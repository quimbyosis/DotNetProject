using DotNetLimber.Models;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using System;

namespace DotNetLimber.Controllers
{
	public class HomeController : Controller
    {

        public IActionResult Index()
        {
			ViewData["Message"] = "Meow is the time!";

			

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
			ViewData["Message"] = "Click on pictures to reveal full size images.";

			return View();
		}

		// POST /HOME/VOLUNTEER
		[HttpPost]
		public IActionResult Volunteer(Person personIn)
		{
			var db = new PersonContext();
			db.Persons.Add(personIn);
			db.SaveChanges();

			return View(personIn);
		}

		// GET /HOME/VOLUNTEER
		[HttpGet]
		public IActionResult Volunteer(string submit)
		{
			//Need to add conditional statement here, this doesn't work yet. womp womp.
			if (!string.IsNullOrEmpty(submit))
			{
				ViewData["Message"] = "Please fill out all fields.";
			}
			else
			{
				ViewData["Mesage"] = "Thank you for submitting your information! We will be in contact soon.";
			}

			var p = new Person()
			{
				Email = "isaacw@manual.com",
				FirstName = "Isaac",
				LastName = "Weiss",
				ZipCode = 40208
			};

			return View(p);
		}


		public IActionResult Error()
        {
            return View();
        }
    }
}
