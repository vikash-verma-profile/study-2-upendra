using Case_Study2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_Study2.Controllers
{
    public class HomeController : Controller
    {
        AirlineContext _airlineContext;
        public HomeController(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
