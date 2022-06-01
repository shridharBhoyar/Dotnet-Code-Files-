using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDataConsue.Models;
using System.Data;

namespace WebApiDataConsue.Controllers
{
   
    public class webapiController : ApiController
    {
        practiceEntities db = new practiceEntities();

        public IHttpActionResult Getdata()
        {
            var list = db.studentDatas.ToList();
            return Ok(list);
        }






        [HttpGet]
        public IHttpActionResult Details(int id)
        {
            var list = db.studentDatas.Where(model => model.id == id).FirstOrDefault();
            return Ok(list);
        }


        [System.Web.Http.HttpPost]
        public IHttpActionResult Create(studentData s)
        {
            db.studentDatas.Add(s);
            db.SaveChanges();
            return Ok();
        }



        [System.Web.Http.HttpPut]
        public IHttpActionResult Edit(studentData s)
        {

            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
          var data= db.studentDatas.Where(model => model.id == id).FirstOrDefault();
          db.Entry(data).State = EntityState.Deleted;
          db.SaveChanges();
            return Ok();
        }


    }
}
