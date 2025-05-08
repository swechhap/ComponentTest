using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCXComponentTest.Utils
{
    public static class ApiHelper
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await client.GetAsync(url);
        }

        public static async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            return await client.PostAsync(url, content);
        }
    }
}
