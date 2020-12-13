﻿using System;
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
        public readonly ApplicationDBContext dBContext;
       
        public HomeController(ApplicationDBContext context)
        {
            dBContext = context;
        }
        public JsonResult GetData()
        {
            var result = dBContext.Reservations.ToList();
            return Json(result);
        }
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult Reservation()
        {
            List<string> hours = WorkingHours.GetHours();
            ViewBag.Hours = hours;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Reservation(ReservationModel model)
        {
            if (model != null)
            {
                ReservationModel reservation = new ReservationModel();
                reservation.Id = model.Id;
                reservation.Date = model.Date;
                reservation.Email = model.Email;
                reservation.Gender = model.Gender;
                reservation.Name = model.Name;
                reservation.Specialist = model.Specialist;
                reservation.Surname = model.Surname;
                reservation.TelNumber = model.TelNumber;
                reservation.Time = model.Time;

                dBContext.Reservations.Add(reservation);
                await dBContext.SaveChangesAsync();
                return Json(new {success = true, message = "Added!"});
                //return new JavaScriptResult("swal({text: 'Make sure that dates are correct!',icon: 'error',}); ");
            }
            return RedirectToAction("Index");
        }
   
    }
}
