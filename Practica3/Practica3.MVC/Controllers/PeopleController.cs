
using Newtonsoft.Json;
using Practica3.MVC.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Practica3.MVC.Controllers
{
    public class PeopleController : Controller
    {
        //Hosted web API REST Service base url  
        string Baseurl = "https://swapi.dev/api/";
        public async Task<ActionResult> Index()
        {
            PeopleView PpInfo = new PeopleView();

            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
 
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
  
                HttpResponseMessage Res = await client.GetAsync("people/1");


                if (Res.IsSuccessStatusCode)
                {
                    var PpResponse = Res.Content.ReadAsStringAsync().Result;

                    PpInfo = JsonConvert.DeserializeObject<PeopleView>(PpResponse);

                }

                return View(PpInfo);
            }
        }
    }
}