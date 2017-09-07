using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.API.Extensions.ExceptionHandle
{
    public class ApiError
    {
        public string message { get; set; }
        public bool isError { get; set; }
        public string detail { get; set; }
        public List<string> errors { get; set; }

        public ApiError(string message)
        {
            this.message = message;
            isError = true;
        }
    }
}
