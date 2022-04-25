using System;
using System.Collections.Generic;
using System.Net.Http;

namespace cron.Services
{
    public class LogDate
    {
        private readonly HttpClient httpClient;

        public LogDate(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public void testc()
        {
            List<string> hpnames = new List<string>() { "WC23_77_10", "WC23_88_05", "WC23_88_15", "WC23_88_20", "WC23_88_30" };
            
            foreach (var hpname in hpnames)
            {

                Uri myUri = new Uri($"http://localhost:5000/api/MonthlyFU/{hpname}", UriKind.Absolute);
                var response = httpClient.GetAsync(myUri);
                Console.WriteLine(response.Result.StatusCode);

            }

            Console.WriteLine($"Job {DateTime.Now.AddHours(4):U}");

        }
    }
}
