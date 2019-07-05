using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Web;
using System.Net.Http;
using Sitecore.HabitatHome.Foundation.DependencyInjection;

namespace MCH.Feature.Brands.Services
{
    [Service(typeof(IRequestService))]
    public class RequestService : IRequestService
    {
        //readonly JsonSerializerSettings m_serializerSettings;

        public RequestService()
        {
            //m_serializerSettings = new JsonSerializerSettings
            //{
            //    ContractResolver = new CamelCaseProper
            //}
        }

        public async Task<T> GetAsync<T>(Uri uri)
        {
            var httpClient = CreateHttpClient();
            var response = await httpClient.GetAsync(uri);
            var stringValue = await response.Content.ReadAsStringAsync();
            //var result = await Task.Run(() => JsonConvert.DeserializeObject<T>(stringValue));

            return await Task.Run(() => JsonConvert.DeserializeObject<T>(stringValue)); ;
        }

        private HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }
    }
}