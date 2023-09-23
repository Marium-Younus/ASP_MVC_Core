using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;
using Whole_Lecture.Models;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

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
        
        public IActionResult FD_Action(string fname, string lname,string pwd,string email,string country,string comment,string gender)
        {
            ViewBag.fullname = fname + " " + lname;
            ViewBag.password = pwd;
            ViewBag.gender = gender;
            ViewBag.email = email;
            ViewBag.country = country;
            ViewBag.message = comment;
            ViewBag.value = "container-fluid d-grid bg-danger";
          
            return View();
        
        
        }
        [HttpGet]
        public IActionResult FU_Action()
        {
            return View();        
        }
        [HttpPost]
        public IActionResult FU_Action(IFormFile image)
        {
          
            try
            {
                if (image.Length>0)
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");
                    string fileNameWithPath = Path.Combine(path, image.FileName);
                    //create folder if not exist
                    if (!Directory.Exists(path))
                    
                        Directory.CreateDirectory(path);

                    if (!(System.IO.File.Exists(fileNameWithPath)))
                    {
                        using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                        {

                            image.CopyTo(stream);
                            ViewBag.color = "text-success";
                            ViewBag.Message = "File upload successfully";
                        }
                    }
                    else
                    {
                        ViewBag.color = "text-primary";
                        ViewBag.Message = "File Already Exist";
                    }

                  
                }
                else
                {
                    ViewBag.color = "text-danger";
                    ViewBag.Message = "Please select file";
                }

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
            }
          

            return View();
        }

        public IActionResult MFU_Action()
        {

            return View();


        }
        [HttpPost]
        public IActionResult MFU_Action(List<IFormFile> files)
        {

            try
            {
                foreach (var item in files)
                {
                if (item.Length > 0)
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");
                    string fileNameWithPath = Path.Combine(path, item.FileName);
                    //create folder if not exist
                    if (!Directory.Exists(path))

                        Directory.CreateDirectory(path);

                    if (!(System.IO.File.Exists(fileNameWithPath)))
                    {
                        using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                        {

                            item.CopyTo(stream);
                            ViewBag.color = "text-success";
                            ViewBag.Message = "File upload successfully";
                        }
                    }
                    else
                    {
                        ViewBag.color = "text-primary";
                        ViewBag.Message = "File Already Exist";
                    }


                }
                else
                {
                    ViewBag.color = "text-danger";
                    ViewBag.Message = "Please select file";
                }
                }
                

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex.Message;
            }


            return View();
        }

    }
}