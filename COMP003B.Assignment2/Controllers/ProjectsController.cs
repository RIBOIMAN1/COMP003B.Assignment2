using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers
{
	public class ProjectsController : Controller
	{
		[HttpGet]
		public IActionResult Completed()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Current()
		{
			return View();
		}
		[HttpGet]
		public IActionResult Ideas()
		{
			return View();
		}
	}
}