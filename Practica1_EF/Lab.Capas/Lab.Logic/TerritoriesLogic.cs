using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class TerritoriesLogic : LogicBase, ILogic<Territories>
    {
        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }

        public Territories GetOne(int id) { 
        
            return context.Territories.FirstOrDefault(t => t.TerritoryID.Equals(id));
        }

        public Territories GetOne(Territories t)
        {
            return context.Territories.Find(t.TerritoryID);
        }

        public bool Delete(Territories t)
        {
            return false;
        }
    }
}
