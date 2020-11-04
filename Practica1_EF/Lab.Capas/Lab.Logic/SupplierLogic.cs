using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class SupplierLogic : LogicBase, ILogic<Suppliers>
    {
        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public Suppliers GetOne(int id)
        {

            return context.Suppliers.FirstOrDefault(s => s.SupplierID.Equals(id));
        }

        public Suppliers GetOne(Suppliers s)
        {
            return context.Suppliers.Find(s.SupplierID);
        }
        public bool Delete(Suppliers s)
        {
            return false;
        }
    }
}
