using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission08_Team0209.Models;

namespace Mission08_Team0209.Controllers
{
	public class HomeController : Controller
	{
		private ITaskRespository _repo;

		public HomeController(ITaskRespository temp)
		{
			_repo = temp;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		//[HttpPost]
		//public IActionResult Index()
		//{
		//	return View();
		//}

		[HttpGet]
		public IActionResult Tasks()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Quadrant()
		{
			return View();
		}
	}
}
