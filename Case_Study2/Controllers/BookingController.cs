using Case_Study2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_Study2.Controllers
{
    public class BookingController : Controller
    {
        AirlineContext _airlineContext;
        public BookingController(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
        }
        public IActionResult case_study()
        {
            return View();
        }
    }
}
