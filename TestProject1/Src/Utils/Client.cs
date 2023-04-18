using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework.Constraints;

namespace TestProject1.Src.Utils
{
    public class Client
    {
        public async Task GetRequest(String request, Dictionary<string, string> parameters )
        {
            using (HttpClient client = new HttpClient())
            {
                string url = request;

                var content = new FormUrlEncodedContent(parameters);
                HttpResponseMessage response = await client.PostAsync(url, content);


                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Error al enviar la solicitud");
                }
                Assert.True(response.IsSuccessStatusCode);
            }
        }
    }

}
