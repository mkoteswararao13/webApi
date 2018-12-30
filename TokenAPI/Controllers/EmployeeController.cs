using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public string Get()
        {
            return "get employees list";
        }
    }
}
