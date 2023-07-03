using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Externals.Requests
{
    public class Client : IClient
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task GetAsync<T>(string url)
        {
            using HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsByteArrayAsync();

            // TODO: Use an extension method to HttpContent to bind the result to the T object

            // TODO: return result
        }
    }
}
