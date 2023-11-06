using Database_FirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Database_FirstApproach.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly DB_FirstApproachContext context;

        public HomeController(ILogger<HomeController> logger,DB_FirstApproachContext context)
        {
            _logger = logger;
            this.context = context;
        }
        [HttpGet]
        public IActionResult Add_Student()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Add_Student(Student std )
        {
            if (ModelState.IsValid)
            {
               
                    context.Entry(std).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                    //context.Students.Add(std);
               
                context.SaveChanges();
               return RedirectToAction("Show_Student");
            }
            return View();
        }

      
        public ActionResult Std_del(string stdId)
        {
            Student std = new Student();
            std.SId = Convert.ToInt32(stdId);
            context.Entry(std).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            context.SaveChanges();
            return RedirectToAction("Show_Student");
         
            
        }

        public IActionResult Edit(string? SId)
        {
            Student std = new Student();
            
                int my_editid = Convert.ToInt32(SId);
                std = context.Students.Find(my_editid);
                ViewBag.value = "Update Record";
                ViewBag.color = "btn  btn-primary";

                return View(std); 
            
        }
        [HttpPost]
        public IActionResult Edit(Student model)
        {
            var student = new Student()
            {   
                SId =     model.SId,
                SName =   model.SName,
                SEmail =  model.SEmail,
                SGender = model.SGender,
                SPhone =  model.SPhone,
                SCity =   model.SCity,
                SAge =    model.SAge,

            };
           
            context.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Show_Student");

        }
        [HttpGet]
        public IActionResult Show_Student()
        {
            ViewData["std_data"] = context.Students.ToList();
            return View();
        }


        public IActionResult Add_Employee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add_Employee(Employee emp, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");
                    string fileNameWithPath = Path.Combine(path, image.FileName);
                    if (!Directory.Exists(path))

                        Directory.CreateDirectory(path);
                    var stream = new FileStream(fileNameWithPath, FileMode.Create);
                    image.CopyTo(stream);
                    emp.EImage = image.FileName;
                    context.Entry(emp).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                    context.SaveChanges();

                }
                catch (Exception ex)
                {

                    ViewBag.Message = ex.Message;
                }
            }

                return View();
        }

        public IActionResult Show_Employee()
        {
            ViewBag.employee = context.Employees.ToList();
            return View();
        }
    }
}