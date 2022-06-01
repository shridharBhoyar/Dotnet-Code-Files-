using Crudapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Data;

namespace Crudapi.Controllers
{
    public class abcController : ApiController
    {
        projectEntities db = new projectEntities();

        [HttpGet]
        public IHttpActionResult Action()
        {
            List<student> list = db.students.ToList();

            return Ok(list);
        }


        [System.Web.Http.HttpGet]
        public IHttpActionResult Details(int id)
        {
            var li = db.students.Where(model => model.id == id).FirstOrDefault();

            return Ok(li);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult insert(student s)
        {
            db.Entry(s).State = EntityState.Added;
            db.SaveChanges();
            return Ok();
        }


        [System.Web.Http.HttpPut]
        public  IHttpActionResult edit(student s)
        
        {
            var a = db.students.Where(model=>model.id==s.id).FirstOrDefault();
            //db.Entry(s).State = EntityState.Modified;

            if(a!=null)
            {
                a.id = s.id;
                a.name = s.name;
                a.age = s.age;
                db.SaveChanges();
            }
            else
            {
                return NotFound();
            }
         
            return Ok();
        }


        [System.Web.Http.HttpDelete]

        public IHttpActionResult delete(int id)
        {
            var a = db.students.Where(model => model.id == id).FirstOrDefault();
            db.Entry(a).State = EntityState.Deleted;
            db.SaveChanges();

            return Ok();
        }

    }
}
