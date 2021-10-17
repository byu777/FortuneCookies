using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FortuneCookies.Models;

namespace FortuneCookies.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.cookie = Models.FortuneCookies.getCookie();
            return View();
        }
    }
}
