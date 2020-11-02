using Lab.Capas.Entities;
using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class TerritoriesLogic
    {
        private readonly NorthwindContext context;
        public TerritoriesLogic()
        {
            this.context = new NorthwindContext();
        }
        public List<Territories> Territories()
        {

            return context.Territories.ToList();
        }

        public Territories Territories(int id) { 
        
            return context.Territories.FirstOrDefault(t => t.TerritoryID.Equals(id));
        }
    }
}
