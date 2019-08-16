using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Password = new PasswordGen().GetPassword(14);
            System.Console.WriteLine(ViewBag.Password);
            ViewBag.Count = PasswordGen.GetCount();
            return View();
        }

        [HttpGet("/password")]
        public JsonResult Password()
        {
            return Json(new PasswordGen().GetPassword(14));
        }
    }
}
