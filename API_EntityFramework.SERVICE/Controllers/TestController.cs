using API_EntityFramework.SERVICE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API_EntityFramework.SERVICE.Controllers
{
    public class TestController : ApiController
    {
      private  NorthwindEntities context = new NorthwindEntities();
       // [EnableCors(origins:"*",headers:"*",methods:"*")]
        [EnableCors("https://localhost:44388", "*","*")]
      public IHttpActionResult Get()
        {
            context.Configuration.ProxyCreationEnabled = false;
            var catList = context.Categories.ToList();
            return Json(catList);
        }
    }
}
