using Errores;
using Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class EmployeesLogic : LogicBase, ILogic<Employees>
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
            catch (Exception ex)
            {
                throw new SaveLogsException("Error al intentar eliminar Employee", ex);
            }
        }
        public bool Update(Employees e)
        {
            try
            {
                if (context.Employees.Find(e.EmployeeID) != null)
                {
                    context.SaveChanges(); ;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new SaveLogsException("Error al modificar datos Employee", ex);
            }
        }

        public bool Create(Employees e)
        {
            try
            {
                context.Employees.Add(e);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new SaveLogsException("Error al crear new Employee", ex);
            }
        }

        public bool Create(string name, string lastName, string title, string city, string country)
        {
            try
            {
                Employees newEmployee = new Employees();
                newEmployee.FirstName = name;
                newEmployee.LastName = lastName;
                newEmployee.Title = title;
                newEmployee.City = city;
                newEmployee.Country = country;

                context.Employees.Add(newEmployee);

                context.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                throw new SaveLogsException("Error al crear new Employee", ex);
            }
        }
    }
}

