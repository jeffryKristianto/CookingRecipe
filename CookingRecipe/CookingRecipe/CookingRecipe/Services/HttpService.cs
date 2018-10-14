using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace CookingRecipe.Services
{
    public abstract class HttpService
    {
        protected async Task<T> SendRequestAsync<T>(Uri url, HttpMethod httpMethod = null, 
            IDictionary<string, string> headers = null, object requestData = null)
        {
            var result = default(T);

            var method = httpMethod ?? HttpMethod.Get;

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var data = requestData == null ? null : JsonConvert.SerializeObject(requestData, settings);
            
            using (var request = new HttpRequestMessage(method, url))
            {
                request.Content = data != null ? new StringContent(data, Encoding.UTF8, "application/json") : null;

                if (headers != null)
                {
                    foreach (var h in headers)
                    {
                        request.Headers.Add(h.Key, h.Value);
                    }
                }

                using (var handler = new HttpClientHandler())
                {
                    using (var client = new HttpClient(handler))
                    {
                        using (var response = await client.SendAsync(request, HttpCompletionOption.ResponseContentRead))
                        {
                            var content = response.Content == null ? null : await response.Content.ReadAsStringAsync();

                            response.EnsureSuccessStatusCode();
                            result = JsonConvert.DeserializeObject<T>(content, settings);
                        }

                        return result;
                    }
                }
            }
        }
    }
}