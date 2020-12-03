using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P.S.S.Controllers
{
    public class AdminMainController : Controller
    {
        public ActionResult IndexAdmin()
        {
            return View();
        }
    }
}
