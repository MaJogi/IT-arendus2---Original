using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labor.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello world!";
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;

            ViewData["Employee"] = emp;
            return View("MyView");
        }
    }
}