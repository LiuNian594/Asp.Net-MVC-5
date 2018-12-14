using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;
namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Default
        public string GetString()
        {
            return "你好,MVC！";
        }

        public Customer getCustomer()
        {
            Customer yt = new Customer();
            yt.CustomerName = "safas";
            yt.Address = "55";
            return yt;
        }
        public ActionResult GetView()
        {

            Employee emp = new Employee();
            emp.Name = "刘志涵";
            emp.Salary = 80000;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.Name;
            vmEmp.EmployeeSalary = emp.Salary.ToString("C");
            if (emp.Salary > 1000)
            {
                vmEmp.EmployeeGrade = "土豪";
            }
            else
            {
                vmEmp.EmployeeGrade = "屌丝";
            }
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
            //vmEmp.Greeting = greeting;
            //vmEmp.UserName = "超级管理员";

            //viewdata["empkey"] = emp;
            //ViewBag.Empkey = emp;
            return View("MyView", vmEmp);
        }

        }
    }