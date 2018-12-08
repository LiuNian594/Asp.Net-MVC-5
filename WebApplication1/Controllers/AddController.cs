using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AddController : Controller
    {
 

        public ActionResult AddIndex()
        {
            Customer add = new Customer();
            Employee emp = new Employee();

            add.CustomerName = "顾清繁";
            add.Address = "天水市";
            ViewBag.Customer = add;

            emp.Name = "刘志涵";
            emp.Salary = 80000;
            ViewData["Employee"] = emp;
            return View("AddIndex", add);
        }
    }
}