using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class CategoryLogic
    {
        private readonly NorthwindContext context;
        public CategoryLogic()
        {
            this.context = new NorthwindContext();
        }
        public List<Categories> Categories()
        {
            return context.Categories.ToList();
        }

        public Categories Categories(int id)
        {
            return context.Categories.FirstOrDefault(c => c .CategoryID.Equals(id));
        }
        public bool DeleteCategory (Categories cat)
        {
            try
            {
               // context.Categories.FirstOrDefault(c => c.CategoryID.Equals(cat.CategoryID));
                context.Categories.Remove(cat);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}
