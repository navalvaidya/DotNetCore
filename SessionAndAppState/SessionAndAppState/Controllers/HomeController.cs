using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SessionAndAppState.Models;

namespace SessionAndAppState.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var sessionId = HttpContext.Session.Id;
            HttpContext.Session.SetString("AppName", "SessionDemo");
            var AppName = HttpContext.Session.GetString("AppName");
            var sessionCookie = HttpContext.Request.Cookies["mySessionCookies"];
            ViewBag.Id = sessionId;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
