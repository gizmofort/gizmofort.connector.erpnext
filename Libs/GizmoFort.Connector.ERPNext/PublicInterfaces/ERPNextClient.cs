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

namespace GizmoFort.Connector.ERPNext.PublicInterfaces
{
    public class ERPNextClient : IDisposable
    {
        private string _domain;
        private string _username;
        private string _password;
        private RestClient client;

        #region Constructor

        public ERPNextClient(string domain)
        {
            _domain = domain;
            this.client = new RestClient(domain);
            this.client.CookieContainer = new CookieContainer();
        }

        public ERPNextClient(string domain, string username, string password) : this(domain)
        {
            this.Login(username, password);
        }

        #endregion

        #region Dispose

        public void Dispose()
        {
            this._domain = this._username = this._password = null;
            this.client.ClearHandlers();
            this.client.CookieContainer = null;
        }

        #endregion

        public void Login(string username, string password)
        {
            this._username = username;
            this._password = password;
            this.client.CookieContainer = new CookieContainer();

            loginIfNeeded();
        }

        public bool IsLoggedIn
        {
            get {
                CookieCollection collection = this.client.CookieContainer.GetCookies(new Uri(this._domain));
                Cookie session_cookie = collection["sid"];
                if (session_cookie != null) {
                    bool is_cookie_active = DateTime.Now < session_cookie.Expires;
                    return is_cookie_active;
                }
                return false;
            }
        }

        public string GetActiveUserName()
        {
            loginIfNeeded();

            IRestRequest request = new RestRequest("/api/method/frappe.auth.get_logged_user", Method.GET);
            var response = this.client.Execute(request);

            assertResponseIsOK(response);

            return parseMessage(response);
        }


        public ERPObject InsertObject(ERPObject obj)
        {
            loginIfNeeded();

            RestRequest request = new RestRequest($"/api/resource/{obj.ObjectType}", Method.POST);

            var args_text = SerializeUtils.ToString(obj.Data);
            request.AddParameter("data", args_text);

            var response = this.client.Execute(request);

            assertResponseIsOK(response);

            return parseOneObject(obj.ObjectType, response);
        }

        public ERPObject GetObject(DocType docType, string name)
        {
            loginIfNeeded();

            RestRequest request = new RestRequest($"/api/resource/{docType}/{name}", Method.GET);

            var response = this.client.Execute(request);

            if (response.StatusCode == HttpStatusCode.NotFound) {
                return null;
            }

            assertResponseIsOK(response);

            return parseOneObject(docType, response);
        }

        public ERPObject UpdateObject(ERPObject obj)
        {
            return UpdateObject(obj.ObjectType, obj.Name, obj);
        }

        public ERPObject UpdateObject(DocType docType, string name, ERPObject obj)
        {
            loginIfNeeded();

            RestRequest request = new RestRequest($"/api/resource/{docType}/{name}", Method.PUT);
            var args_text = SerializeUtils.ToString(obj.Data);
            request.AddParameter("data", args_text);

            var response = this.client.Execute(request);

            assertResponseIsOK(response);

            return parseOneObject(docType, response);
        }

        public void DeleteObject(DocType docType, string name)
        {
            loginIfNeeded();

            RestRequest request = new RestRequest($"/api/resource/{docType}/{name}", Method.DELETE);

            var response = this.client.Execute(request);

            assertResponseIsOK(response);
        }

        public List<ERPObject> ListObjects(DocType docType, FetchListOption listOption = null)
        {
            loginIfNeeded();

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

        #region Helper Methods

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
            return new ERPObject(docType, convertToData(data_json.data));
        }

        private static List<ERPObject> parseManyObjects(DocType docType, IRestResponse response)
        {
            JsonDeserializer des = new JsonDeserializer();
            DocRawList data_json = des.Deserialize<DocRawList>(response);

            return data_json.data.Select(x => new ERPObject(docType, convertToData(x))).ToList();
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

        private static ExpandoObject convertToData(Dictionary<string, object> vals)
        {
            ExpandoObject result = new ExpandoObject();

            var iface = (IDictionary<string, object>) result;

            foreach (var pair in vals)
            {
                iface[pair.Key] = pair.Value;
            }

            return result;
        }

        #region Login specific

        private void loginIfNeeded()
        {
            if (!IsLoggedIn)
            {
                doLogin();
            }
        }

        private void doLogin()
        {
            if (string.IsNullOrEmpty(_username)) return;
            if (string.IsNullOrEmpty(_password)) return;

            IRestRequest request = new RestRequest("/api/method/login", Method.POST);
            request.AddParameter("usr", _username);
            request.AddParameter("pwd", _password);
            var response = this.client.Execute(request);

            assertResponseIsOK(response);

            bool result = IsLoggedIn;
        }

        #endregion

        private static void assertResponseIsOK(IRestResponse response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                case HttpStatusCode.Accepted:
                    break;
                default:
                    throw new ERPException($"ErrorCode: {response.StatusCode.ToString()}\r\n\r\nDescription:\r\n{response.StatusDescription}\r\n\r\nReason:\r\n" + response.Content + "\r\n");
            }
        }

        #endregion
    }
}
