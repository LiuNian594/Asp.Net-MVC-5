using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomerView()
        {
            string greeting;
            //获取当前时间
            DateTime dt = DateTime.Now;
            //获取当前小时数
            int hour = dt.Hour;
            //根据小时数判断要返回哪个视图，<12 f返回myview否则返回yourview
            if (hour < 12)
            {
                greeting = ("早上好");
            }
            else
            {
                greeting = ("下午好");
            }
            //ViewData["greeting"] = greeting;
            ViewBag.greeting = greeting;
            Customer emp = new Customer();
            emp.CustomerName = "顾清繁";
            emp.Address = "天水市";
            //viewdata["empkey"] = emp;
            ViewBag.Empkey = emp;
            return View("CustomerView", emp);
        }
    }
    }
