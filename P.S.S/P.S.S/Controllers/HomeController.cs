using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using P.S.S.Models;

namespace P.S.S.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        public IActionResult Some()
        {
            return View();
        }
       // [HttpPost]
        public async Task<IActionResult> Reservation(ReservationModel model)
        {
            return View();
        }
    }
}
