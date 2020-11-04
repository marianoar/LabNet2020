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
    public class EmployeeLogic : LogicBase, ILogic<Employees>
    {
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employees GetOne(int id)
        {

            return context.Employees.FirstOrDefault(e => e.EmployeeID.Equals(id));
        }

        public Employees GetOne(Employees e)
        {
            return context.Employees.Find(e.EmployeeID);
        }

        public bool Delete(Employees e)
        {
            try
            {
                if (context.Employees.Find(e.EmployeeID) != null)
                {
                    context.Employees.Remove(e);
                }
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ModifyEmployee(Employees e)
        {
            try
            {
                if (context.Employees.Find(e.EmployeeID) != null)
                {
                    e.FirstName = "Mariano";
                    e.LastName = "Arias";
                    e.Address = "CABA";
                    e.City = "CABA";
                    e.Country = "Argentina";
                }
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
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
