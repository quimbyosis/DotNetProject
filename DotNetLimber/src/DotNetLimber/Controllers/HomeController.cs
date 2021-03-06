﻿using DotNetLimber.Models;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using System;

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
            return View();
        }

        public IActionResult Press()
        {

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

			return View("_Confirm");
		}

		// GET /HOME/VOLUNTEER
		[HttpGet]
		public IActionResult Volunteer()
		{
			var p = new Person()
			{
				Email = "isaacw@manual.com",
				FirstName = "Isaac",
				LastName = "Weiss",
				ZipCode = 40208
			};

			return View();
		}


		public IActionResult Error()
        {
            return View();
        }
    }
}
