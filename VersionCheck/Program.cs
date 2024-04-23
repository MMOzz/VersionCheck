using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace VersionCheck
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://<www.yourdomain.com>/Version.php");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());
            Console.ReadKey();
        }
    }
}
