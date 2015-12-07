using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;

namespace ChurchCommunityBuilder.Api {
    public class BaseApiSet<T> where T : new() {
        private readonly string _baseUrl;
        private readonly string _username;
        private readonly string _password;
        private readonly ContentType _contentType;
        private IDictionary<string, string> _parameters;

        public string BaseUrl { get { return _baseUrl; } }

        public BaseApiSet(string baseUrl, string username, string password) {
            _baseUrl = baseUrl;
            _username = username;
            _password = password;
        }

        public T Execute(string serviceName) {
            this._parameters = new Dictionary<string, string>();
            this._parameters.Add("srv", serviceName);
            var request = CreateRestRequest(Method.GET, _baseUrl);

            var results = ExecuteRequest(request);
            return results.Data;
        }

        public T Execute(string serviceName, Dictionary<string, string> parameters) {
            this._parameters = new Dictionary<string, string>();
            this._parameters.Add("srv", serviceName);

            foreach (var current in parameters) {
                this._parameters.Add(current.Key, current.Value);
            }

            var request = CreateRestRequest(Method.GET, _baseUrl);

            var results = ExecuteRequest(request);
            return results.Data;
        }

        public T Execute(string serviceName, QueryObject qo) {
            this._parameters = new Dictionary<string, string>();
            this._parameters.Add("srv", serviceName);
            var request = CreateRestRequest(Method.GET, _baseUrl);

            foreach (var pair in qo.ToDictionary()) {
                request.AddParameter(pair.Key, pair.Value);
            }

            var results = ExecuteRequest(request);
            return results.Data;
        }

        public S Execute<S>(string serviceName, Dictionary<string, string> parameters) where S : new() {
            this._parameters = new Dictionary<string, string>();
            this._parameters.Add("srv", serviceName);

            foreach (var current in parameters) {
                this._parameters.Add(current.Key, current.Value);
            }

            var request = CreateRestRequest(Method.GET, _baseUrl);

            var results = ExecuteGenericRequest<S>(request);
            return results.Data;
        }

        internal T Update(string serviceName, string formValues, Dictionary<string, string> parameters) {
            var updateUrl = _baseUrl + "?srv=" + serviceName;

            foreach (var pair in parameters) {
                updateUrl += "&" + pair.Key + "=" + pair.Value;
            }

            this._parameters = new Dictionary<string, string>();
            var request = CreateRestRequest(Method.POST, updateUrl);

            request.AddParameter("application/x-www-form-urlencoded", formValues, ParameterType.RequestBody);
            var results = ExecuteRequest(request);
            return results.Data;
        }

        internal T Create(string serviceName, string formValues, string file = null) {
            var createUrl = _baseUrl + "?srv=" + serviceName;
            this._parameters = new Dictionary<string, string>();
            var request = CreateRestRequest(Method.POST, createUrl);

            if (!string.IsNullOrEmpty(file)) {
                var bytes = Encoding.ASCII.GetBytes(file);
                request.AddFile("file", bytes, "file", "text/xml");
            }

            request.AddParameter("application/x-www-form-urlencoded", formValues, ParameterType.RequestBody);
            var results = ExecuteRequest(request);
            return results.Data;
        }
        protected IRestResponse<T> ExecuteRequest(IRestRequest request) {
            var client = new RestClient(_baseUrl);
            client.Authenticator = new HttpBasicAuthenticator(this._username, this._password);
            var response = client.Execute<T>(request);

            if ((int)response.StatusCode > 300) {
                throw new Exception(response.StatusDescription);
            }
            else if (!string.IsNullOrEmpty(response.ErrorMessage)) {
                throw new Exception(response.ErrorMessage);
            }

            return response;
        }

        protected IRestResponse<S> ExecuteGenericRequest<S>(IRestRequest request) where S : new() {
            var client = new RestClient(_baseUrl);
            client.Authenticator = new HttpBasicAuthenticator(this._username, this._password);
            var response = client.Execute<S>(request);

            if ((int)response.StatusCode > 300) {
                throw new Exception(response.StatusDescription);
            }
            else if (!string.IsNullOrEmpty(response.ErrorMessage)) {
                throw new Exception(response.ErrorMessage);
            }

            return response;
        }

        private RestRequest CreateRestRequest(Method method, string url, string contentType = null) {
            var request = new RestRequest(method) {
                Resource = url
            };

            if (method == Method.POST && string.IsNullOrEmpty(contentType)) {
                contentType = "application/x-www-form-urlencoded";
            }
            else {
                request.RequestFormat = _contentType == ContentType.JSON ? DataFormat.Json : DataFormat.Xml;
            }
            request.AddHeader("Accept-Encoding", "gzip,deflate");
            request.AddHeader("Content-Type", !string.IsNullOrEmpty(contentType) ? contentType : _contentType == ContentType.XML ? "application/xml" : "application/json");

            if (_parameters != null && _parameters.Count > 0) {
                foreach (var current in _parameters) {
                    request.AddParameter(current.Key, current.Value);
                }
            }

            return request;
        }
    }
}
