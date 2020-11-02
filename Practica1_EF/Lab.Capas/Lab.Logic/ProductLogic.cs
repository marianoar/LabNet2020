using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class ProductLogic
    {
        private readonly NorthwindContext context;
        public ProductLogic()
        {
            this.context = new NorthwindContext();
        }
        public List<Products> Products()
        {
                return context.Products.ToList();
        }

        public Products Delete(Products p)
        {
            Products a= context.Products.Find(p.CategoryID);
            context.Products.Remove(p);
            context.SaveChanges();
            return a;
            //context.SaveChanges();
        }

    }
}
