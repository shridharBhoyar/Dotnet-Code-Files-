using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapi.Controllers
{
    public class newapiController : ApiController
    {
        public string[] obj = { "ram", "shyam", "shri" };
        

        [HttpGet]
        public string[] getdata()
        {
          
            return obj;
        }
    }
}
