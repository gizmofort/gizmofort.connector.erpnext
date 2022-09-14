using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using GizmoFort.Connector.ERPNext.InternalTypes;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Utils;
using RestSharp;
using RestRequest = RestSharp.RestRequest;

namespace GizmoFort.Connector.ERPNext.PublicInterfaces
{
    public class ERPNextClient : IDisposable
    {
        private readonly string _domain;
        private string? _username;
        private string? _password;
        private bool _disposedValue;
        private readonly RestClient _client;

        #region Constructor

        public ERPNextClient(string domain)
        {
            this._domain = domain;
            this._client = new RestClient(domain);
        }

        public ERPNextClient(string domain, string username, string password) : this(domain)
        {
            this.Login(username, password);
        }

        #endregion

        #region Dispose

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)

                    this._username = null;
                    this._password = null;
                    this._client.Dispose();

                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                _disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~ERPNextClient()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion

        public dynamic? RPC(string targetMethod, Method method, dynamic? args = null, bool ensureLoggedIn = true)
        {
            if (ensureLoggedIn) {
                LoginIfNeeded();
            }

            var request = new RestRequest($"/api/method/{targetMethod}", method);

            args ??= new { };
            Type args_type = args.GetType();
            var valid_props = args_type.GetProperties();

            foreach (PropertyInfo prop in valid_props) {
                var val = prop.GetValue(args);
                //request.AddParameter(prop.Name, val);
                RestRequestExtensions.AddParameter(request, prop.Name, val);
            }

            var response = this._client.Execute(request);
            AssertResponseIsOK(response);

            return ParseDynamic(response);
        }

        public void Login(string username, string password)
        {
            this._username = username;
            this._password = password;

            LoginIfNeeded();
        }

        public bool IsLoggedIn
        {
            get {
                CookieCollection collection = this._client.CookieContainer.GetCookies(new Uri(this._domain));
                Cookie? session_cookie = collection["sid"];
                if (session_cookie is not null) {
                    bool is_cookie_active = DateTime.Now < session_cookie.Expires;
                    return is_cookie_active;
                }
                return false;
            }
        }


        public string? GetActiveUserName()
        {
            dynamic? data = RPC("frappe.auth.get_logged_user", Method.Get);
            if (data is null)
                return null;

            return data.message;
        }


        public ERPObject? InsertObject(ERPObject obj)
        {
            LoginIfNeeded();

            var request = new RestRequest($"/api/resource/{obj.ObjectType}", Method.Post);

            string args_text = JsonSerializer.Serialize(obj.Data);
            //request.AddParameter("data", args_text);
            RestRequestExtensions.AddParameter(request, "data", args_text);


            var response = this._client.Execute(request);

            AssertResponseIsOK(response);

            return ParseOneObject(obj.ObjectType, response);
        }

        public ERPObject? GetObject(DocType docType, string name)
        {
            LoginIfNeeded();

            var request = new RestRequest($"/api/resource/{docType}/{name}", Method.Get);

            var response = this._client.Execute(request);

            if (response.StatusCode == HttpStatusCode.NotFound) {
                return null;
            }

            AssertResponseIsOK(response);

            return ParseOneObject(docType, response);
        }

        public ERPObject? UpdateObject(ERPObject obj)
        {
            return UpdateObject(obj.ObjectType, obj.Name, obj);
        }

        public ERPObject? UpdateObject(DocType docType, string name, ERPObject obj)
        {
            LoginIfNeeded();

            var request = new RestRequest($"/api/resource/{docType}/{name}", Method.Put);
            string args_text = JsonSerializer.Serialize(obj.Data);
            //request.AddParameter("data", args_text);
            RestRequestExtensions.AddParameter(request, "data", args_text);


            var response = this._client.Execute(request);

            AssertResponseIsOK(response);

            return ParseOneObject(docType, response);
        }

        public void DeleteObject(DocType docType, string name)
        {
            LoginIfNeeded();

            var request = new RestRequest($"/api/resource/{docType}/{name}", Method.Delete);

            var response = this._client.Execute(request);

            AssertResponseIsOK(response);
        }

        public List<ERPObject>? ListObjects(DocType docType, FetchListOption? listOption = null)
        {
            LoginIfNeeded();

            listOption ??= new FetchListOption();
            var request = new RestRequest($"/api/resource/{docType}", Method.Get);

            var filters = listOption.Filters ?? new List<ERPFilter>();
            if (filters.Any()) {
                string filter_val = JsonSerializer.Serialize(filters.Select(ToFilterObject).ToList());
                request.AddParameter("filters", filter_val);
            }

            var included_fields = listOption.IncludedFields ?? new List<string>();
            if (included_fields.Any()) {
                string filter_val = JsonSerializer.Serialize(included_fields.ToList());
                request.AddParameter("fields", filter_val);
            }

            if (listOption.PageSize > 0) {
                request.AddParameter("limit_page_length", listOption.PageSize);
            }

            if (listOption.PageStartIndex > 0) {
                request.AddParameter("limit_start", listOption.PageStartIndex);
            }

            var response = this._client.Execute(request);
            AssertResponseIsOK(response);

            return ParseManyObjects(docType, response);
        }

        #region Helper Methods

        private static ExpandoObject? ParseDynamic(RestResponse response)
        {
            var content = response.Content;
            if (string.IsNullOrEmpty(content))
                return null;

            Dictionary<string, object?>? result = JsonSerializer.Deserialize<Dictionary<string, object?>>(content);
            if (result is null)
                return null;

            return ConvertToData(result);
        }

        private static ERPObject? ParseOneObject(DocType docType, RestResponse response)
        {
            var content = response.Content;
            if (string.IsNullOrEmpty(content))
                return null;

            DocRaw? data_json = JsonSerializer.Deserialize<DocRaw>(content);
            if (data_json is null)
                return null;
            if (data_json.data is null)
                return null;

            return new ERPObject(docType, ConvertToData(data_json.data));
        }

        private static List<ERPObject>? ParseManyObjects(DocType docType, RestResponse response)
        {
            var content = response.Content;
            if (string.IsNullOrEmpty(content))
                return null;

            DocRawList? data_json = JsonSerializer.Deserialize<DocRawList>(content);
            if (data_json is null)
                return null;
            if (data_json.data is null)
                return null;

            return data_json.data.Select(x => new ERPObject(docType, ConvertToData(x))).ToList();
        }

        private static List<string> ToFilterObject(ERPFilter filter)
        {
            var result = new List<string>
            {
                filter.DocType.ToString(),
                filter.TargetField,
                OperatorFilterUtils.ToString(filter.OperatorFilter),
                filter.Operand
            };
            return result;
        }

        private static ExpandoObject ConvertToData(IDictionary<string, object?> vals)
        {
            var result = new ExpandoObject();

            var resultViaIDictionary = (IDictionary<string, object?>) result;

            foreach (var pair in vals)
            {
                object? value;

                if (pair.Value is JsonElement)
                    value = JsonElementValue((JsonElement)pair.Value);
                else
                    value = pair.Value;
                    
                if (value is IDictionary<string, object?>)
                    value = ConvertToData((IDictionary<string, object?>)value);

                resultViaIDictionary[pair.Key] = value;
            }

            return result;
        }

        //
        // reference: https://stackoverflow.com/a/58679930/2758185
        //
        public static object? JsonElementValue(JsonElement element)
        {
            object? result;
            switch (element.ValueKind)
            {
                case JsonValueKind.Null:
                    result = null;
                    break;
                case JsonValueKind.Number:
                    String? srcDataString = element.GetRawText();
                    if (srcDataString is null)
                        result = null;
                    else if (int.TryParse(srcDataString, out _))
                        result = element.GetInt32();
                    else if (long.TryParse(srcDataString, out _))
                        result = element.GetInt64();
                    else if (decimal.TryParse(srcDataString, out _))
                        result = element.GetDecimal();
                    else
                        result = element; //TODO
                    break;
                case JsonValueKind.False:
                    result = false;
                    break;
                case JsonValueKind.True:
                    result = true;
                    break;
                case JsonValueKind.Undefined:
                    result = element; //TODO
                    break;
                case JsonValueKind.String:
                    result = element.GetString();
                    break;
                case JsonValueKind.Object:
                    result = element; //TODO
                    break;
                case JsonValueKind.Array:
                    result = element.EnumerateArray()
                        .Select(o => JsonElementValue(o))
                        .ToArray();
                    break;
                default:
                    result = element; //TODO
                    break;
            }
            return result;
        }

        #region Login specific

        private void LoginIfNeeded()
        {
            if (!IsLoggedIn)
            {
                DoLogin();
            }
        }

        private void DoLogin()
        {
            if (string.IsNullOrEmpty(_username)) return;
            if (string.IsNullOrEmpty(_password)) return;

            RPC("login", Method.Post, new { usr = _username, pwd = _password }, false);
        }

        #endregion

        private static void AssertResponseIsOK(RestResponse response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                case HttpStatusCode.Accepted:
                    break;
                default:
                    throw new ERPException($"ErrorCode: {response.StatusCode}\r\n\r\nDescription:\r\n{response.StatusDescription}\r\n\r\nReason:\r\n" + response.Content + "\r\n");
            }
        }

        #endregion
    }
}
