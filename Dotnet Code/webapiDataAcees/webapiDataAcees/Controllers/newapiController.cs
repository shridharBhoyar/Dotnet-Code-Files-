using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapiDataAcees.Models;

namespace webapiDataAcees.Controllers
{
    public class newapiController : ApiController
    {
        projectEntities db = new projectEntities();

        [System.Web.Http.HttpGet]
        public IHttpActionResult Action()
        {
            List<student> std = db.students.ToList();
            return Ok(std);
        }
    }
}
