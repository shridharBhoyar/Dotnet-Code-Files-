using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using webapiDataAcees.Models;

namespace webapiDataAcees.Controllers
{
    public class abcController : Controller
    {


        HttpClient Clt = new HttpClient();

        // GET: /abc/


        public ActionResult Index()
        {
            List<student> list=new List<student>();

            Clt.BaseAddress = new Uri("http://localhost:50494/api/newapi");
            var response = Clt.GetAsync("newapi");
            response.Wait();

            var test = response.Result;

            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<student>>();
                display.Wait();
                list = display.Result;
            }
            return View(list);
        }
	}
}