using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webmvc.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Contact()
        {
            return View();
        }
    }
}
