using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace DotNetLimber.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Platforms()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Press()
        {
            ViewData["Message"] = "Limberbutt McCubbins is a candidate we can all get behind! Meow is the time!";

            return View();
        }

		public IActionResult Gear()
		{
			ViewData["Message"] = "Click on pictures to purchase to reveal full size images.";

			return View();
		}

		public IActionResult Error()
        {
            return View();
        }
    }
}
