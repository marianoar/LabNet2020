using Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class RegionsLogic : LogicBase
    {
        public List<Region> GetAll()
        {
            return context.Region.ToList();
        }
    }
}
