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

		[HttpPost]
		public IActionResult CreateTask(Mission08_Team0209.Models.Task t)
		{
			if (ModelState.IsValid)
			{
				_repo.AddTask(t);
				return RedirectToAction("Index");
			}

			ViewBag.Categories = _repo.Categories.ToList();
            return View(t);
        }


		[HttpGet]
		public IActionResult CreateTask()
		{
			ViewBag.Categories = _repo.Categories.ToList();

			return View(new Mission08_Team0209.Models.Task());
		}

		[HttpGet]
		public IActionResult Quadrants()
		{
			return View();
		}
	}
}
