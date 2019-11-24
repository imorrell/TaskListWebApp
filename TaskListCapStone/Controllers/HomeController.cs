using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaskListCapStone.Models;




namespace TaskListCapStone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TaskDbContext _context;
        public HomeController(ILogger<HomeController> logger, TaskDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListTask()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return View(_context.Tasks.Where(t => t.UserId == id).ToList());
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(Tasks newTask)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(newTask);
                _context.SaveChanges();
                return RedirectToAction("ListTask");

            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateTask(int id)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewBag.Id = userId;
            return View(_context.Tasks.Find(id));
        }

        [HttpPost]
        public IActionResult UpdateTask(Tasks newTask)
        {
            if (ModelState.IsValid)
            {
                //locate the task that the user wants to update
                Tasks oldTask = _context.Tasks.Find(newTask.Id);

                //set the old task to new task attributes
                oldTask.TaskDescription = newTask.TaskDescription;
                oldTask.DueDate = newTask.DueDate;
                oldTask.Completed = newTask.Completed;

                _context.Entry(oldTask).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(oldTask);
                _context.SaveChanges();
                return RedirectToAction("ListTask");

            }
            return View();
        }

        public IActionResult DeleteTask(int id)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            ViewBag.Id = userId;
            var foundTask = _context.Tasks.Find(id);

            if (foundTask != null)
            {
                _context.Tasks.Remove(foundTask);
                _context.SaveChanges();
            }

            return RedirectToAction("ListTask");
        }

        public IActionResult FilterListByCompletion()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return View(_context.Tasks.Where(t => t.UserId == id).ToList());
        }

        public IActionResult FilterListByInCompletion()
        {
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return View(_context.Tasks.Where(t => t.UserId == id).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
