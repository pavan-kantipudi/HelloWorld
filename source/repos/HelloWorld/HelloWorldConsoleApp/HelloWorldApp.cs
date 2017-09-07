using HelloWorldConsoleApp.Interfaces;
using HelloWorldConsoleApp.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HelloWorldConsoleApp
{
    public class HelloWorldApp
    {
        private IHelloWorld _helloWorldService;
        public HelloWorldApp(IHelloWorld helloWorld)
        {
            _helloWorldService = helloWorld;
        }

        public void GetData()
        {
           Console.WriteLine(_helloWorldService.GetData("values"));
        }

    }
}
