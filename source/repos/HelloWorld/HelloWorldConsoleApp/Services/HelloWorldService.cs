using HelloWorldConsoleApp.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace HelloWorldConsoleApp.Service
{
    public class HelloWorldService : IHelloWorld
    {
        private AppSettings _config;
        private ILogger<HelloWorldService> _logger;
        public HelloWorldService(IOptions<AppSettings> config, ILogger<HelloWorldService> logger)
        {
            _config = config.Value;
            _logger = logger;
        }

        public string GetData(string methodName)
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

                string test = client.GetStringAsync(_config.ServiceUrl + methodName).Result;
                return test;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                _logger.LogCritical(e.Message);
                return null;
            }
        }
    }
}
