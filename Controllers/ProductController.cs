using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webmvc.Controllers
{
    public class ProductController : Controller
    {
        public List<string> Index()
        {
            return new List<string>()
            {
                "Item1",
                "Item2",
                "Item3"
            };
        }
    }
}
