using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project1.Models;
using Project1.Models.ViewModels;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        
        private TaskListContext context { get; set; }

        //constructor
        public HomeController(TaskListContext con)
        {
            context = con;
        }

        public IActionResult Index()
        {
            return View(new QuadrantsViewModel
            {
                QuadrantI = context.Tasks
                    .Where(x => x.Urgent == true && x.Important == true),

                QuadrantII = context.Tasks
                    .Where(x => x.Urgent == false && x.Important == true),

                QuadrantIII = context.Tasks
                    .Where(x => x.Urgent == true && x.Important == false),

                QuadrantIV = context.Tasks
                    .Where(x => x.Urgent == false && x.Important == false)

            });
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
        [HttpGet]
        public IActionResult EnterTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterTask(TaskItem t)
        {
            if (ModelState.IsValid)
            {
                context.Tasks.Add(t);
                context.SaveChanges();
            }
            return View();
        }
    }
}
