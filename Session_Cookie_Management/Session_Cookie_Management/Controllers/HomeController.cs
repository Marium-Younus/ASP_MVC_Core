using Microsoft.AspNetCore.Mvc;
using Session_Cookie_Management.Models;
using System.Diagnostics;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
namespace Session_Cookie_Management.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email,string pwd)
        {
            try
            {
                if (email.Equals("admin@gmail.com") && pwd.Equals("aptech"))
                {
                    //login

                    HttpContext.Session.SetString("email_session", email);

                    TempData["SessionId"] = HttpContext.Session.Id;


                    return RedirectToAction("Dashboard");

                }
                else
                {
                    //invalid login
                    ViewBag.msg = "Invalid username and password";
                    ViewBag.value = "alert alert-danger mb-3";
                }

            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
                ViewBag.value = "alert alert-danger mb-3";
            }
            return View();
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("email_session") == null)
            {
                return RedirectToAction("Login");
            }

            ViewBag.Email = HttpContext.Session.GetString("email_session");
            return View();
        }

        public IActionResult About()
        {
            if (HttpContext.Session.GetString("email_session") == null)
            {
                return RedirectToAction("Login");
            }


            ViewBag.Email = HttpContext.Session.GetString("email_session");
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("email_session") !=null)
            {
                HttpContext.Session.Remove("email_session");
            }
            return RedirectToAction("Login");
        }

    }
}