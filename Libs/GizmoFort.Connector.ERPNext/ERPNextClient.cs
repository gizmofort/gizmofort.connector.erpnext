using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using GizmoFort.Connector.ERPNext.InternalTypes;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Utils;
using RestSharp;
using RestSharp.Deserializers;
using RestRequest = RestSharp.RestRequest;

namespace GizmoFort.Connector.ERPNext
{
    public class ERPNextClient : IDisposable
    {
        private RestClient client;

        public ERPNextClient(string domain)
        {
            this.client = new RestClient(domain);
            this.client.CookieContainer = new CookieContainer();
        }

        public void Dispose()
        {
            this.client.ClearHandlers();
            this.client.CookieContainer = null;
        }

        public void Login(string username, string password)
        {
            IRestRequest request = new RestRequest("/api/method/login", Method.POST);
            request.AddParameter("usr", username);
            request.AddParameter("pwd", password);
            var response = this.client.Execute(request);

            assertResponseIsOK(response);
        }

        public string GetActiveUserName()
        {
            IRestRequest request = new RestRequest("/api/method/frappe.auth.get_logged_user", Method.GET);
            var response = this.client.Execute(request);

            assertResponseIsOK(response);

            return parseMessage(response);
        }


        public ERPObject InsertObject(ERPObject obj)
        {
            RestRequest request = new RestRequest($"/api/resource/{obj.ObjectType}", Method.POST);

            var args_text = SerializeUtils.ToString(obj.Data);
            request.AddParameter("data", args_text);

            var response = this.client.Execute(request);

            assertResponseIsOK(response);

            return parseOneObject(obj.ObjectType, response);
        }

        public ERPObject GetObject(DocType docType, string name)
        {
            RestRequest request = new RestRequest($"/api/resource/{docType}/{name}", Method.GET);

            var response = this.client.Execute(request);

            assertResponseIsOK(response);

            return parseOneObject(docType, response);
        }

        public ERPObject UpdateObject(DocType docType, string name, ERPObject doc)
        {
            RestRequest request = new RestRequest($"/api/resource/{docType}/{name}", Method.PUT);
            var args_text = SerializeUtils.ToString(doc.Data);
            request.AddParameter("data", args_text);

            var response = this.client.Execute(request);

            assertResponseIsOK(response);

            return parseOneObject(docType, response);
        }

        public void DeleteObject(DocType docType, string name)
        {
            RestRequest request = new RestRequest($"/api/resource/{docType}/{name}", Method.DELETE);

            var response = this.client.Execute(request);

            assertResponseIsOK(response);
        }

        public List<ERPObject> ListObjects(DocType docType, FetchListOption listOption = null)
        {
            listOption = listOption ?? new FetchListOption();
            RestRequest request = new RestRequest($"/api/resource/{docType}", Method.GET);

            var filters = listOption.Filters ?? new List<ERPFilter>();
            if (filters.Any()) {
                var filter_val = SerializeUtils.ToString(filters.Select(toFilterObject).ToList());
                request.AddParameter("filters", filter_val);
            }

            var included_fields = listOption.IncludedFields ?? new List<string>();
            if (included_fields.Any()) {
                var filter_val = SerializeUtils.ToString(included_fields.ToList());
                request.AddParameter("fields", filter_val);
            }

            if (listOption.PageSize > 0) {
                request.AddParameter("limit_page_length", listOption.PageSize);
            }

            if (listOption.PageStartIndex > 0) {
                request.AddParameter("limit_start", listOption.PageStartIndex);
            }

            var response = this.client.Execute(request);
            assertResponseIsOK(response);

            return parseManyObjects(docType, response);
        }

        private static string parseMessage(IRestResponse response)
        {
            JsonDeserializer des = new JsonDeserializer();
            Dictionary<string, object> result = des.Deserialize<Dictionary<string, object>>(response);

            return (string) result["message"];
        }

        private static ERPObject parseOneObject(DocType docType, IRestResponse response)
        {
            JsonDeserializer des = new JsonDeserializer();
            DocRaw data_json = des.Deserialize<DocRaw>(response);
            return new ERPObject(docType, convertToDynamic(data_json.data));
        }

        private static List<ERPObject> parseManyObjects(DocType docType, IRestResponse response)
        {
            JsonDeserializer des = new JsonDeserializer();
            DocRawList data_json = des.Deserialize<DocRawList>(response);

            return data_json.data.Select(x => new ERPObject(docType, convertToDynamic(x))).ToList();
        }

        private static List<string> toFilterObject(ERPFilter filter)
        {
            List<string> result = new List<string>();
            result.Add(filter.DocType.ToString());
            result.Add(filter.TargetField);
            result.Add(OperatorFilterUtils.ToString(filter.OperatorFilter));
            result.Add(filter.Operand);
            return result;
        }

        private static dynamic convertToDynamic(Dictionary<string, object> vals)
        {
            ExpandoObject result = new ExpandoObject();

            var iface = (IDictionary<string, object>)result;

            foreach (var pair in vals) {
                iface[pair.Key] = pair.Value;
            }

            return result;
        }

        private static void assertResponseIsOK(IRestResponse response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                case HttpStatusCode.Accepted:
                    break;
                default:
                    throw new ArgumentException(response.Content);
            }
        }
    }
}
