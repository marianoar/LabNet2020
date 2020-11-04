using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class CategoryLogic : LogicBase, ILogic<Categories>
    {

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public Categories GetOne(int id)
        {

            return context.Categories.FirstOrDefault(t => t.CategoryID.Equals(id));
        }

        public Categories GetOne(Categories t)
        {
            return context.Categories.Find(t.CategoryID);
        }
        public bool Delete (Categories cat)
        {
            try
            {
                if (context.Customers.Find(cat.CategoryID)!=null)
                {
               // context.Categories.FirstOrDefault(c => c.CategoryID.Equals(cat.CategoryID));
                context.Categories.Remove(cat);
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
