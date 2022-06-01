using Crudapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Crudapi.Controllers
{
    public class xyzController : Controller
    {
        HttpClient client = new HttpClient();
        // GET: /xyz/
        public ActionResult Index()
        {
            List<student> li = new List<student>();
            client.BaseAddress = new Uri("http://localhost:50636/api/abc");
            var respon = client.GetAsync("abc");
            respon.Wait();

            var test = respon.Result;
           
            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<student>>();
                display.Wait();
                 li = display.Result;
            }

            return View(li);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            student s = null;
            client.BaseAddress = new Uri("http://localhost:50636/api/abc");
            var respon = client.GetAsync("abc?id="+id.ToString());
            respon.Wait();

            var test = respon.Result;

            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<student>();
                display.Wait();
                s = display.Result;
            }

            return View(s);
        }


        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(student s)
        {
            client.BaseAddress = new Uri("http://localhost:50636/api/abc");
          var respon=client.PostAsJsonAsync<student>("abc",s);
          respon.Wait();
          var test = respon.Result;

            if(test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View("Create");
        }


        
        public ActionResult Edit(int id)
        {
            student a = null;
            client.BaseAddress = new Uri("http://localhost:50636/api/abc");
            var respon = client.GetAsync("abc?id="+id.ToString());
            respon.Wait();
            var test = respon.Result;

            if (test.IsSuccessStatusCode)
            {
                var displat = test.Content.ReadAsAsync<student>();
                displat.Wait();
                a = displat.Result;

            }
            return View(a);
        }



        [HttpPost]
        public ActionResult Edit(student s)
        {
            student a = null;
            client.BaseAddress = new Uri("http://localhost:50636/api/abc");
            var respon = client.PutAsJsonAsync<student>("abc",s);
            respon.Wait();
            var test = respon.Result;

            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View("Edit");
        }


        
        public ActionResult Delete(int id)
        {
            
            client.BaseAddress = new Uri("http://localhost:50636/api/abc");
            var respon = client.DeleteAsync("abc?id="+id.ToString());
            respon.Wait();
            var test = respon.Result;

            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View("Edit");
        }

     

        [HttpPost]
        public ActionResult Delete(student s)
        {
            student a = null;
            client.BaseAddress = new Uri("http://localhost:50636/api/abc");
            var respon = client.PutAsJsonAsync<student>("abc", s);
            respon.Wait();
            var test = respon.Result;

            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }
            return View("Edit");
        }


        
	}
}