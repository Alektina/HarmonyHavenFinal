using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HarmonyHaven.Controllers
{
    public class RetreatsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}