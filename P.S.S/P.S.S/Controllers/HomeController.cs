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
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Reservation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Reservation(ReservationModel model)
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

            dBContext.Reservations.Add(reservation);
            await dBContext.SaveChangesAsync();
            return Json(new { success = true, message = "Saved successfully" });
        }
    }
}
