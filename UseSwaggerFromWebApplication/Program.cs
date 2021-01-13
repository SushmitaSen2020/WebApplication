using System;
using System.Net.Http;

namespace UseSwaggerFromWebApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseUrl = "http://localhost:5000";
            var httpClient = new HttpClient();
            var apiClient = new WebApplication.WebApplicationClient(baseUrl, httpClient);
            var result = apiClient.GetAsync().Result;

            foreach (var item in result)
            {
                Console.WriteLine($"Weather is {item.Summary} at {item.TemperatureF}");
            }
        }
    }
}
