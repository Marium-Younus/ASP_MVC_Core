using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Whole_Lecture.Models;

namespace Whole_Lecture.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult VB_Action()
        {
            ViewBag.intro = "Introduction to Viewbag";
            ViewBag.body = "The ViewBag in ASP.NET MVC is used to transfer temporary data (which is not included in the model) from the controller to the view.";
            return View();
        }

        public IActionResult VD_Action()
        {
            ViewData["intro"] = "Introduction to ViewData";
            ViewData["body"] = "In ASP.NET MVC, ViewData is similar to ViewBag, which transfers data from Controller to View. ViewData is of Dictionary type, whereas ViewBag is of dynamic type. However, both store data in the same dictionary internally.";
            return View();
        }
        public IActionResult TD_Action()
        {
            TempData["name"] = "Introduction to TempData";
            TempData["def"] = "TempData is used to transfer data from view to controller, controller to view, or from one action method to another action method of the same or a different controller.";

            //TempData.Keep("def"); // Marks the specified key in the TempData for retention.

            TempData.Keep(); // Marks all keys in the TempData for retention
            return View();
        }

        public IActionResult NP_Action()
        {


            return View();
        }
        [HttpGet]
        public IActionResult FD_Action()
        {

            return View();


        }
        [HttpPost]
        
        public IActionResult FD_Action(string fname, string lname,string pwd,string email,string comment,string gender)
        {
            ViewBag.fullname = fname + " " + lname;
            ViewBag.password = pwd;
            ViewBag.gender = gender;
            ViewBag.email = email;
            ViewBag.message = comment;
            ViewBag.tar = "#exampleModal";
            ViewBag.tog = "modal";
            return View();
        
        
        }
    }
}