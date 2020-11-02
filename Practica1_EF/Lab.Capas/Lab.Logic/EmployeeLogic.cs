using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class EmployeeLogic
    {
        private readonly NorthwindContext context;
        public EmployeeLogic()
        {
            this.context = new NorthwindContext();
        }
        public List<Employees> Employees()
        {
            return context.Employees.ToList();
        }
        public Employees DeleteEmployee(Employees e)
        {
            /* if(context.Employees.Find(e.EmployeeID)!=null)
             {
                 context.Employees.Remove(e);
             }
             context.SaveChanges();*/
            return e;


        }
        public bool ModifyEmployee(Employees e)
        {
            if (context.Employees.Find(e.EmployeeID) != null)
            {
                e.FirstName = "Mariano";
                e.LastName = "Arias";
                e.Address = "San Telmo";
                e.City = "CABA";
                e.Country = "Argentina";
            }
            context.SaveChanges();
            return true;
        }

        public bool AddEmployee(string name, string lastName, string adress, string city, string country)
        {
            try
            {
                Employees newEmployee = new Employees();
                newEmployee.FirstName = name;
                newEmployee.LastName = lastName;
                newEmployee.Address = adress;
                newEmployee.City = city;
                newEmployee.Country = country;

                context.Employees.Add(newEmployee);

                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
