using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class SupplierLogic
    {
        private readonly NorthwindContext context;
        public SupplierLogic()
        {
            this.context = new NorthwindContext();
        }
        public List<Suppliers> Suppliers()
        {
            return context.Suppliers.ToList();
        }

    }
}
