using Case_Study2.Models;
using Case_Study2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case_Study2.Controllers
{
    public class RegisterController : Controller
    {
        AirlineContext _airlineContext;
        public RegisterController(AirlineContext airlineContext)
        {
            _airlineContext = airlineContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SubmitData(Register register)
        {
            TblUser tblUser = new TblUser();
            tblUser.UserName = register.Name;
            _airlineContext.TblUsers.Add(tblUser);
            _airlineContext.SaveChanges();
            return View();
        }
    }
}
