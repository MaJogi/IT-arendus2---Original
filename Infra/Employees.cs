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
    }
}
