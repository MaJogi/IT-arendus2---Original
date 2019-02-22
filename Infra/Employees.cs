using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra
{
    public static class Employees
    {
        public static List<Employee> Get(SalesDbContext db)
        {
            return db.Employees.ToList();
        }
        public static List<Employee> GetFakeData()
        {
            var employees = new List<Employee>()
            {
                new Employee("John", "Doe", 14000),
                new Employee("Michael", "Jackson", 16000)
            };
            return employees;
        }
    }
}
