using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class EmployeesLogic
    {
        private readonly NorthwindContext context;
        public EmployeesLogic()
        {
            this.context = new NorthwindContext();
        }
        public List<Employees> Employees()
        {
            return context.Employees.ToList();
        }
    }
}
