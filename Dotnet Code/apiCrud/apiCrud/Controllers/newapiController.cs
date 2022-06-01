using apiCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Data;

namespace apiCrud.Controllers
{
    public class newapiController : ApiController
    {
        practiceEntities db = new practiceEntities();
        public IHttpActionResult getdata()
        {
            var li = db.studentDatas.ToList();
            return Ok(li);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult getdata(int id)
        {
            var li = db.studentDatas.Where(model => model.id == id).FirstOrDefault();
            return Ok(li);
        }


        public IHttpActionResult Create(studentData s)
        {
            db.studentDatas.Add(s);
            db.SaveChanges();
            return Ok();
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Details(int id)
        {
            var li = db.studentDatas.Where(model => model.id ==id).FirstOrDefault();

            return Ok(li);
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult Edit(studentData s)
        {
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(studentData s)
        {
            db.Entry(s).State = EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}
