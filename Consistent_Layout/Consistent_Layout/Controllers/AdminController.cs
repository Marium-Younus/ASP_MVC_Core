using Microsoft.AspNetCore.Mvc;

namespace Consistent_Layout.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
