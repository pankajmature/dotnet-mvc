using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webmvc.Controllers
{
    public class UserController : Controller
    {
        [Route("Admin/[Controller]/[Action]")]
        public string Index()
        {
            return "From user index.";
        }
    }
}
