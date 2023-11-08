using Microsoft.AspNetCore.Mvc;
using ShopApplication.Models;
using System.Diagnostics;

namespace ShopApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShopDBContext database;

        public HomeController(ILogger<HomeController> logger,ShopDBContext database)
        {
            _logger = logger;
            this.database = database;
        }

        public IActionResult Add_Cat()
        {
            return View();
        }
        public IActionResult Show_Cat()
        {
           ViewBag.list_cat =database.Categories.ToList();
            return View();
        }

        //======================================================================Product Work
        [HttpGet]
        public IActionResult Add_Pro()
        {

           ViewBag.catdata = database.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Add_Pro(Product product,IFormFile pro_img)
        {
            ViewBag.catdata = database.Categories.ToList();
            if (ModelState.IsValid)
            {
                //--------------------------------------------------------------------- file uploading
                if (pro_img != null)
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                    string filepath = Path.Combine(path, pro_img.FileName);
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var stream = new FileStream(filepath, FileMode.Create);
                    pro_img.CopyTo(stream);
                }
                //------------------------------------------------------------------------------------
                string? filename = pro_img.FileName;
                product.PImage = filename;
                database.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                database.SaveChanges();


                }
            return RedirectToAction("Show_Pro");
        }


        public IActionResult Show_Pro()
        {
            ViewBag.list_pro = database.ViewPcs.ToList();
            return View();
        }

    }
}