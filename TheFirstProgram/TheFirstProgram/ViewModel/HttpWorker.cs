using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TheFirstProgram.ViewModel
{
    public static class HttpWorker
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<string> GET(string url)
        {
            try
            {
                using HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                
                return responseBody;
                                
            }
            catch (HttpRequestException e)
            {
               return string.Empty;
            }
        }
    }
}
