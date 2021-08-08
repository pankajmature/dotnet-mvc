using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webmvc.Controllers
{
    //[Route("Color")]
    public class HomeController : Controller
    {
        //[Route("Blue")]
        public string Index()
        {
            return "Hello from home controller.";
        }
    }
}
