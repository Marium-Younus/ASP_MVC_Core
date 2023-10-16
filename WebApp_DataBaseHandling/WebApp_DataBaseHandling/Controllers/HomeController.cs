using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_DataBaseHandling.Models;

namespace WebApp_DataBaseHandling.Controllers
{
    public class HomeController : Controller
    {
        OrganizationDbContext db = new OrganizationDbContext();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.data = db.CategoryTbls.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(CategoryTbl categoryTbl)
        {
            try
            {
                if (ModelState.IsValid)
                {
               // db.Entry(categoryTbl).State = Microsoft.EntityFrameworkCore.EntityState.Added;

             

                    db.CategoryTbls.Add(categoryTbl);   
                    db.SaveChanges();
                ViewBag.msg = "Add Category Success";
                    ViewBag.value = "alert alert-success mt-5";
                    
                }
                
            }
            catch (Exception ex)
            {
                ViewBag.msg =ex.Message;
            }
            ViewBag.data = db.CategoryTbls.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}