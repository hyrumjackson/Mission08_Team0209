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
                return RedirectToAction("CreateTask");
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
            var uncompletedTasks = _repo.Tasks.Where(t => t.Completed == false).ToList();
            return View(uncompletedTasks);
		}

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var task = _repo.Tasks
				.Single(x => x.TaskId == id);

            ViewBag.Categories = _repo.Categories.ToList();
            return View("CreateTask", task);
        }

        [HttpPost]
        public IActionResult Edit(Mission08_Team0209.Models.Task task)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateTask(task);
                return RedirectToAction("Quadrants");
            }

            ViewBag.Categories = _repo.Categories.ToList();
            return View("CreateTask", task);
        }

        [HttpPost]
        public IActionResult Complete(int id)
        {
            _repo.CompleteTask(id);
            return RedirectToAction("Quadrants"); // Refresh the Quadrants view
        }
    }
}
