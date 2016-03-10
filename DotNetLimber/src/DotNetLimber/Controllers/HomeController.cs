using DotNetLimber.Models;
using Microsoft.AspNet.Mvc;

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
		public IActionResult Volunteer()
		{
			//Need to add conditional statement here if valid, show this message
			if (ModelState.IsValid)
			{
				ViewData["Message"] = "We have received your volunteer information. Thank you!";
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
