using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Types_Of_Views.Models;

namespace Types_Of_Views.Controllers
{
    public class HomeController : Controller
    {
   

        public IActionResult Index()
        {
            ViewBag.Heading = "Standard View"; 
            return View();
        }
        [HttpGet]
        public IActionResult STV()
        {
            return View();
        }

        [HttpPost]
        public IActionResult STV(LoginModel login)
        {

            if (login.Username == "admin" && login.Password == "admin")
            {

                ViewBag.message = "Login Successfull";
                ViewBag.bs_class = "alert alert-success d-grid mb-3";

            }
            else
            {
                ViewBag.message = "Invalid Username and password";
                ViewBag.bs_class = "alert alert-danger d-grid mb-3";
            }
            return View();
        }
        public IActionResult PV()
        {
            return View();
        }
    }
}