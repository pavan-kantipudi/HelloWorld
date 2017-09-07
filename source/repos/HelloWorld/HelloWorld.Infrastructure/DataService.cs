using HelloWorld.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Infrastructure
{
    public class DataService : IDataProvider
    {

        public string GetData()
        {
            return "Hello World";
        }

    }
}
