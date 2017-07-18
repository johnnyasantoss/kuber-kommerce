using System;
using System.Net.Http;
using System.Threading.Tasks;
using KuberKommerce.Shared.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KuberKommerce.Shared.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient _client;

        public HttpService()
        {
            _client = new HttpClient();
        }

        public Uri BaseUri { get; protected set; }

        public Task<HttpResponseMessage> GetAsync(string endpoint)
        {
            return _client.GetAsync(endpoint);
        }

        public Task<HttpResponseMessage> PostAsync(string endpoint, JObject obj)
        {
            return _client.PostAsync(endpoint, ToJson(obj));
        }

        public Task<HttpResponseMessage> PutAsync(string endpoint, JObject obj)
        {
            return _client.PutAsync(endpoint, ToJson(obj));
        }

        public Task<HttpResponseMessage> DeleteAsync(string endpoint)
        {
            return _client.DeleteAsync(endpoint);
        }

        private static HttpContent ToJson(JToken obj)
            => new StringContent(obj.ToString(Formatting.None));
    }
}