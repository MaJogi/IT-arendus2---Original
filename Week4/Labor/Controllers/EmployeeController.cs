﻿using System.Collections.Generic;
using Core;
using Facade;
using Infra;
using Microsoft.AspNetCore.Mvc;

namespace Labor.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly SalesDbContext db;

        public EmployeeController(SalesDbContext db) {this.db = db; }
        public ActionResult Index()
        {
            var model = new EmployeeListViewModel();
            var employees = Employees.Get(db);
            var list = new List<EmployeeViewModel>();
            foreach (var e in employees)
            {
                var employee = new EmployeeViewModel(e);
                list.Add(employee);
            }

            model.Employees = list;
            
           
            return View("Index", model);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }
    }
}