using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldAPI.Controllers
{
    public class DemoController : ApiController
    {
        public string Get(string name)
        {
            return "Hello " + name;
        }
    }
}
