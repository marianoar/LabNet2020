using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Lab.Capas.API.Models;
using Newtonsoft;
using Newtonsoft.Json;

namespace Lab.Capas.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Get(Photo r)
        {
            try
            {
                ViewBag.Title = "Astronomy Picture of the Day";
                HttpClient clienteHttp = new HttpClient();
                clienteHttp.BaseAddress = new Uri("https://api.nasa.gov/planetary/apod");
                HttpResponseMessage request;

                if (r.date == null)
                {
                    request = clienteHttp.GetAsync("?api_key=6u3ZEO3Pafy6aiIbCctFScwnFsXbK7vP6KcvMN95").Result;
                }
                else
                {
                    request = clienteHttp.GetAsync("?api_key=6u3ZEO3Pafy6aiIbCctFScwnFsXbK7vP6KcvMN95&date=" + r.date + "").Result;
                }
                if (request.IsSuccessStatusCode) //identifica si es un 200
                {
                    var resultString = request.Content.ReadAsStringAsync().Result;

                    var getView = JsonConvert.DeserializeObject<Photo>(resultString);

                    string aux = getView.url;
                    return View(getView);
                }
            }
            catch(Exception)
            {
                RedirectToAction("Get");
            }
            return View();
        }
    }
}
