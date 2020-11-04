using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class CustomerLogic : LogicBase, ILogic<Customers>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers GetOne(int id)
        {

            return context.Customers.FirstOrDefault(t => t.CustomerID.Equals(id));
        }

        public Customers GetOne(Customers t)
        {
            return context.Customers.Find(t.CustomerID);
        }
        public bool Delete(Customers c)
        {
            try
            {

                if (context.Customers.Find(c.CustomerID) != null)
                {
                    context.Customers.Remove(c);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
    }
}

