using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CatAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Press Enter for cat images!!!");
                Console.ReadLine();
                await CallingAPI();
            }
        }

        static HttpClient client = new HttpClient();

        static async Task CallingAPI()
        {
            var stringTask = client.GetStringAsync("https://api.thecatapi.com/v1/images/search");
            List<RequestedData> catUrl = JsonConvert.DeserializeObject<List<RequestedData>>(await stringTask);
            System.Diagnostics.Process.Start(catUrl[0].url);
        }
    }
}
