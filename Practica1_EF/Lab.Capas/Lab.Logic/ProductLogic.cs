using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class ProductLogic : LogicBase, ILogic<Products>
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public Products GetOne(int id)
        {

            return context.Products.FirstOrDefault(p => p.ProductID.Equals(id));
        }

        public Products GetOne(Products t)
        {
            return context.Products.Find(t.ProductID);
        }

        public bool Delete(Products p)
        {
            return false;
        }

    }
}
