using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeListViewModel empListModel = new EmployeeListViewModel();
            //将处理过的数据列表送给强视图类型对象
            empListModel.EmployeeViewList = getEmpVmList();
            empListModel.Greeting = getGreeting();
            empListModel.UserName = getUserName();
            return View(empListModel);
        }

        [NonAction]
        List<EmployeeViewModel> getEmpVmList()
        {
            //实例化员工信息业务层
            EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();
            var listEmp = empBL.Getemployeelist();

            var listEmpVm = new List<EmployeeViewModel>();
            foreach (var key in listEmp)
            {
                EmployeeViewModel empVmOdj = new EmployeeViewModel();
                empVmOdj.EmployeeName = key.Name;
                empVmOdj.EmployeeSalary = key.Salary.ToString("C");
                if (key.Salary > 1000)
                {
                    empVmOdj.EmployeeGrade = "土豪";
                }
                else
                {
                    empVmOdj.EmployeeGrade = "屌丝";
                }
                listEmpVm.Add(empVmOdj);
            }
            return listEmpVm;
        }
        [NonAction]
        string getGreeting()
        {
            string greeting;
            //获取当前时间
            DateTime h = DateTime.Now;
            //获取当前小时数
            int hour = h.Hour;
            //根据小时数判断要返回哪个视图，<12MyView否则返回YouView
            if (hour < 12)
            {
                greeting = "上午好";
            }
            else
            {
                greeting = "下午好";
            }
            return greeting;
        }
        [NonAction]
        string getUserName()
        {
            return "Admin";
        }
    }
}