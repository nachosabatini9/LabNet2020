using Practica.Entities;
using Practica3.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAll() {
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();
            var lst = territoriesLogic.GetAll();
            
            return Ok(lst);
        }
    }
}
