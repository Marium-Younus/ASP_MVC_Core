
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Shpping_Cart.Models;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Xml.Schema;
using WebApp_Add_Cart.Models;

namespace WebApp_Add_Cart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AddCart_DBContext database;

        public HomeController(ILogger<HomeController> logger,AddCart_DBContext database)
        {
            _logger = logger;
            this.database = database;
        }

        public IActionResult Index()
        {
            return View();
        }

   

     
        public IActionResult Shop(string catid)
        {   
            ViewBag.Cata = database.Categories.ToList();
            if (catid == null)
            {
                ViewBag.pro = database.Products.ToList();
            }
            else 
            { 
                ViewBag.pro = database.Products.Where(a => a.CatIdFk ==Convert.ToInt32(catid)).ToList();
                      
            }
            
                
            return View();
        }

     
        public IActionResult Singlepro(int id)
        {          
            ViewBag.pro = database.Products.Where(x => x.Proid == id).ToList();
            return View();
        }
        //===============Checkout work start=================
        [HttpGet]
        public ActionResult Checkout()
        {
            ViewBag.Cata = database.Categories.ToList();
            ViewBag.pro = database.Products.ToList();
            ViewBag.c = ok.c;
            return View();
        }

        [HttpPost]
        public ActionResult Checkout(string pid, string pqty)
        {
            ViewBag.Cata = database.Categories.ToList();
            ViewBag.pro = database.Products.ToList();        
            foreach (var item in ok.c)
            {
                if (item.Id == Convert.ToInt32(pid))
                {
                    item.Quantity += Convert.ToInt32(pqty);
                    ViewBag.c = ok.c;
                    return View();
                }
            }

            Cart ca = new Cart() { Id = Convert.ToInt32(pid), Quantity = Convert.ToInt32(pqty) };
            ok.c.Add(ca);
            ViewBag.c = ok.c;

            return View();
        }
        //===============Checkout work end=================
     
        public IActionResult RemoveFromCart(int productId)
        {
           
            var itemToRemove = ok.c.Single(r => r.Id == productId);
            ok.c.Remove(itemToRemove);

            return RedirectToAction("Checkout");

        }
        //-------------------------------
        [HttpGet]
        public IActionResult CSignup()
        {
            return View();
        
        }

        [HttpPost]
        public IActionResult CSignup(Customer customer)
        {

            database.Entry(customer).State = EntityState.Added;
            database.SaveChanges();
          return View();

        }
        [HttpGet]
        public IActionResult CSignin()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CSignin(Customer customer)
        {
            var query = from myquery in database.Customers select myquery;
            ViewBag.sign = query.ToList();

            foreach (var item in ViewBag.sign)
            {
                if (customer.CustEmail.Equals(item.CustEmail) && customer.CustPassword.Equals(item.CustPassword))
                {
                    string Username = item.CustName;
                    HttpContext.Session.SetString("name_session", Username);
                    return RedirectToAction("CustomerInfo");
                }
                else
                {
                    ViewBag.color = "alert alert-danger";
                    ViewBag.message = "Invalid Username and Password";
                }

            }
            return View();

        }

        public IActionResult CustomerInfo()
        {
            HttpContext.Session.GetString("name_session");
          
            if (HttpContext.Session.GetString("name_session") == null)
            {
                return RedirectToAction("CSignin");
            }

            return View();
        }

       [HttpPost]
        public IActionResult CustomerInfo(OrderTable od, string gttotal)
        {

            if (gttotal != null)
            {
                HttpContext.Session.SetString("total_session", gttotal);
            }
             var pro = from prod in ok.c
                          join ord in database.Products on prod.Id equals ord.Proid
                          select new
                          {
                              pid = ord.Proid,
                              pp = ord.Proprice,
                              pq = prod.Quantity
                          };
            if (Request.Form["btn"] != default(Nullable))
            {



                OrderTable obj = new OrderTable();
                obj.Fullname = od.Fullname;
                obj.Phone = od.Phone;
                obj.Address = od.Address;
                obj.OrderDate = DateTime.Now.ToString();
                obj.TotalAmount = od.TotalAmount;
                foreach (var item in pro)
                {
                    obj.PIdFk = item.pid;
                    obj.Quantity = item.pq;
                }
                database.Entry(obj).State = EntityState.Added;
                database.SaveChanges();
            }

            return RedirectToAction("Csignin");


        }

        //-----------------------------
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("name_session") != null)
            {
                HttpContext.Session.Remove("name_session");
            }
            return RedirectToAction("Index");
        }

    }
}