using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_ModelValidation.Models;

namespace WebApp_ModelValidation.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
        public IActionResult Index(User user)
        {
			if (ModelState.IsValid)
			{
				ViewBag.msg = "All Ok";
				ViewBag.value = "alert alert-success";
				

            }
            return View();
        }
        public IActionResult Privacy()
		{
			return View();
		}

	}
}