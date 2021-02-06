using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Reservation_2(int id)
        {
            ViewBag.Hours = WorkingHours.GetHours();
            

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Reservation_2(ReservationModel model)
        {
            ViewBag.Error = "";
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

                int compareDates = DateTime.Compare(DateTime.Today, reservation.Date);
                if (compareDates > 0)
                {
                    //return RedirectToAction("Error");
                    //return new JavaScriptResult("<script language='javascript' type='text/javascript'>$(function () { alert('Some error occured!')});</script>");
                    //return Content("<script language='javascript' type='text/javascript'>alert('Hello world!');</script>");
                    //return new JavaScriptResult("swal({text: 'Make sure that dates are correct!',icon: 'error',}); ");
                    //return Json(new { message = "Some error occured!", succes = true});
                    //return new JavaScriptResult("alert('Some error')");
                    return new JavaScriptResult("<script language='javascript' type='text/javascript'>$(function(){Swal.fire({title: 'Delete this reservation?',text: 'You won't be able to revert this!',icon: 'question',showCancelButton: true,showConfirmButton: true,}))</script>");
                }
                else
                {
                    dBContext.Reservations.Add(reservation);
                    await dBContext.SaveChangesAsync();
                }

                //return Json(new {success = true, message = "Added!"});
                //return new JavaScriptResult("swal({text: 'Make sure that dates are correct!',icon: 'error',}); ");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Reservation()
        {
            ViewBag.Hours = WorkingHours.GetHours();
            return View();
            
        }
        [HttpPost]
        public async Task<IActionResult> Reservation(ReservationModel model)
        {
            ViewBag.Error = "";
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

                int compareDates = DateTime.Compare(DateTime.Today, reservation.Date);
                if(compareDates > 0)
                {
                    //return RedirectToAction("Error");
                    //return new JavaScriptResult("<script language='javascript' type='text/javascript'>$(function () { alert('Some error occured!')});</script>");
                    //return Content("<script language='javascript' type='text/javascript'>alert('Hello world!');</script>");
                    //return new JavaScriptResult("swal({text: 'Make sure that dates are correct!',icon: 'error',}); ");
                    //return Json(new { message = "Some error occured!", succes = true});
                    //return new JavaScriptResult("alert('Some error')");
                    return new JavaScriptResult("<script language='javascript' type='text/javascript'>$(function(){Swal.fire({title: 'Delete this reservation?',text: 'You won't be able to revert this!',icon: 'question',showCancelButton: true,showConfirmButton: true,}))</script>");
                }
                else
                {
                    dBContext.Reservations.Add(reservation);
                    await dBContext.SaveChangesAsync();
                }
                
                //return Json(new {success = true, message = "Added!"});
                //return new JavaScriptResult("swal({text: 'Make sure that dates are correct!',icon: 'error',}); ");
            }
            return RedirectToAction("Index");
        }
        public IActionResult Error()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var reservation = await dBContext.Reservations.Where(i => i.Id == id).FirstOrDefaultAsync();
            dBContext.Reservations.Remove(reservation);
            await dBContext.SaveChangesAsync();
            return Json(new { success = true, message = "Deleted successfully" });
        }
   
    }
}
