using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebApiDataConsue.Models;

namespace WebApiDataConsue.Controllers
{
    public class AboutController : Controller
    {
        HttpClient client = new HttpClient();
        //
        // GET: /About/
     

        public ActionResult Getdata()
        {
            List<studentData> li = new List<studentData>();
            client.BaseAddress = new Uri("http://localhost:51020/api/webapi");
            var respon = client.GetAsync("webapi");
            respon.Wait();
            var txt=respon.Result;

            if(txt.IsSuccessStatusCode)
            {
                var display = txt.Content.ReadAsAsync<List<studentData>>();
                display.Wait();
                li=display.Result;
            }
            return View(li);
        }
        
        [System.Web.Http.HttpGet]
        public ActionResult Details(int id)
        {
            studentData s = null;
            client.BaseAddress = new Uri("http://localhost:51020/api/webapi");
            var respon = client.GetAsync("webapi?id="+id.ToString());
            respon.Wait();
            var txt=respon.Result;

            if(txt.IsSuccessStatusCode)
            {
                var display = txt.Content.ReadAsAsync<studentData>();
                display.Wait();
                s = display.Result;
            }
            return View(s);
        }



        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(studentData s)
        {
            client.BaseAddress = new Uri("http://localhost:51020/api/webapi");
            var respon = client.PostAsJsonAsync("webapi",s);
            respon.Wait();
            var txt = respon.Result;

            if(txt.IsSuccessStatusCode)
            {
                RedirectToAction("Getdata");
            }
            return View("Create");
        }



        public ActionResult Edit(int id)
        {
            studentData s = null;
            client.BaseAddress = new Uri("http://localhost:51020/api/webapi");
            var respon = client.GetAsync("webapi?id="+id.ToString());
            respon.Wait();
            var txt = respon.Result;

            if(txt.IsSuccessStatusCode)
            {
                var display=txt.Content.ReadAsAsync<studentData>();
                display.Wait();
                s = display.Result;

            }
            return View(s);
        }

        [HttpPost]
         public ActionResult Edit(studentData s)
        {
            client.BaseAddress = new Uri("http://localhost:51020/api/webapi");
            var respon = client.PutAsJsonAsync("webapi",s);
            respon.Wait();
            var txt = respon.Result;

             if(txt.IsSuccessStatusCode)
             {
                 RedirectToAction("Getdata");
             }
            return View("Edit");
        }


        public ActionResult Delete(int id)
        {
            studentData s = null;
            client.BaseAddress=new Uri("http://localhost:51020/api/webapi");
            var respon = client.GetAsync("webapi?id="+id.ToString());
            respon.Wait();
           var txt=respon.Result;

            if(txt.IsSuccessStatusCode)
            {
                var display=txt.Content.ReadAsAsync<studentData>();
                display.Wait();
                s = display.Result;
            }
            return View(s);
        }

        [HttpPost , ActionName("Delete")]
        public ActionResult DeleteConform(int id)
        {
            client.BaseAddress = new Uri("http://localhost:51020/api/webapi");
            var respon = client.DeleteAsync("webapi?id="+id.ToString());
            respon.Wait();
            var txt=respon.Result;

            if(txt.IsSuccessStatusCode)
            {
                RedirectToAction("Index");
            }
            return View("Getdata");
        }
	}
}