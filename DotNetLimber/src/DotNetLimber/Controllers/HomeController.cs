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
            ViewData["Message"] = "Your press page.";

            return View();
        }

		public IActionResult Gear()
		{
			ViewData["Message"] = "Your Gear page.";

			return View();
		}

		public IActionResult Error()
        {
            return View();
        }
    }
}
