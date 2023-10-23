using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HomePRO.Controllers
{
    public class CourseController : Controller
    {
        [HttpGet]
        public IActionResult CreateCourse()
        {
            List<string> feedback = new List<string>()
            { 
               "yes","no"
            };
            ViewData["Feedback"]=new SelectList(feedback);
            return View();
        }
        [HttpPost]
        public IActionResult CreateCourse(IFormCollection form,ICollection<string>course)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Interest = form["Feedback"];
            ViewBag.Course=course;
            return View("DisplayCourse");
        }

    }
}
