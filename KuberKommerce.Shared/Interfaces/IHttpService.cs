using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace KuberKommerce.Shared.Interfaces
{
    public interface IHttpService
    {
        Uri BaseUri { get; }

        Task<HttpResponseMessage> GetAsync(string endpoint);

        Task<HttpResponseMessage> PostAsync(string endpoint, JObject obj);

        Task<HttpResponseMessage> PutAsync(string endpoint, JObject obj);

        Task<HttpResponseMessage> DeleteAsync(string endpoint);
    }
}