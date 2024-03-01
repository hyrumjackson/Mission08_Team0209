using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission08_Team0209.Models;

namespace Mission08_Team0209.Controllers
{
	public class HomeController : Controller
	{
		private ITaskRepository _repo;

		public HomeController(ITaskRepository temp)
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
		public IActionResult CreateTask()
		{
			//ViewBag.Categories = _repo.Categories
			//	.OrderBy(x => x.CategoryName)
			//	.ToList();

			return View();
		}

		[HttpGet]
		public IActionResult Quadrant()
		{
			return View();
		}
	}
}
