using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class CustomerLogic
    {
        private readonly NorthwindContext context;
        public CustomerLogic()
        {
            this.context = new NorthwindContext();
        }
        public List<Customers> Customers()
        {

            return context.Customers.ToList();
        }

        public Customers Customers(int id)
        {
            return context.Customers.FirstOrDefault(c => c.CustomerID.Equals(id));
        }
        public bool DeleteCustomer(Customers c)
        {
            if(context.Customers.Find(c.CustomerID)!= null)
            {
                context.Customers.Remove(c);
                //context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

