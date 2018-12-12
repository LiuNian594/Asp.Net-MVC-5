using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {

        public List<Employee> Getemployeelist()
        {
            var list=new List<Employee>();
            Employee emp = new Employee();
            emp.Name = "zhangsan";
            emp.Salary = 15000;
            list.Add(emp);
            emp = new Employee();
            emp.Name = "lisi";
            emp.Salary = 50000;
            list.Add(emp);
            emp = new Employee();
            emp.Name = "wangwu";
            emp.Salary = 2000;
            list.Add(emp);
            return list;


        }
    }
}