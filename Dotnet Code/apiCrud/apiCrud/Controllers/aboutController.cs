using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using apiCrud.Models;
using System.Net.Http;
namespace apiCrud.Controllers
{
    public class aboutController : Controller
    {
        HttpClient client = new HttpClient();
        // GET: /about/
        public ActionResult Index()
        {
            List<studentData> li = new List<studentData>();
            client.BaseAddress = new Uri("http://localhost:51094/api/newapi");
            var respon=client.GetAsync ("newapi");
            respon.Wait();
            var test=respon.Result;

            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<studentData>>();
                display.Wait();
                li=display.Result;
            }
            
            return View(li);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(studentData s)
        {
            client.BaseAddress = new Uri("http://localhost:51094/api/newapi");
            var rspon = client.PostAsJsonAsync("newapi",s);
            rspon.Wait();
            var tst = rspon.Result;
            if(tst.IsSuccessStatusCode)
            {
                RedirectToAction("Index");
            }
            return View("Create");
        }

        [HttpGet]
        public ActionResult Details( int id)
        {
           studentData a = null;
            client.BaseAddress = new Uri("http://localhost:51094/api/newapi");
            var rspon = client.GetAsync("newapi?id="+id.ToString());
            rspon.Wait();
            var txt=rspon.Result;
            if(txt.IsSuccessStatusCode)
            {
                var display = txt.Content.ReadAsAsync<studentData>();
                    display.Wait();
                a=display.Result;
              
            }
            return View(a);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            studentData a = null;
            client.BaseAddress = new Uri("http://localhost:51094/api/newapi");
            var rspon = client.GetAsync("newapi?id="+id.ToString());
            rspon.Wait();
            var txt = rspon.Result;

            if(txt.IsSuccessStatusCode)
            {
                var isplay = txt.Content.ReadAsAsync<studentData>();
                isplay.Wait();
                a = isplay.Result;
            }
            return View(a);
        }

        public ActionResult Edit(studentData s)
        {
            client.BaseAddress = new Uri("http://localhost:51094/api/newapi");
            var rslt = client.PutAsJsonAsync("newapi",s);
            rslt.Wait();
            var txt=rslt.Result;
            
            if(txt.IsSuccessStatusCode)
            {
                RedirectToAction("Index");
            }
            return View("Edit");
        }


        public ActionResult Delete(int id)
        {
            studentData a = null;
            client.BaseAddress = new Uri("http://localhost:51094/api/newapi");
            var rslt = client.GetAsync("newapi?id=" + id.ToString());
            rslt.Wait();
            var txt=rslt.Result;

            if(txt.IsSuccessStatusCode)
            {
              var  isplay = txt.Content.ReadAsAsync<studentData>();
              isplay.Wait();
              a = isplay.Result;
            }
            return View(a);
        }

        [HttpPost]
         public ActionResult Delete(int id)
        {
            client.BaseAddress = new Uri("http://localhost:51094/api/newapi");
            var rspon = client.DeleteAsync("newapi",s);
            rspon.Wait();
            var txt= rspon.Result;
            
            if(txt.IsSuccessStatusCode)
            {
                RedirectToAction("Index");
            }
            return View("Delete");
        }
	}
}