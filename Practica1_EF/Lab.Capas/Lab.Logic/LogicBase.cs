using Lab.ResourseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class LogicBase
    {
        protected readonly NorthwindContext context;
        public LogicBase()
        {
            this.context = new NorthwindContext();
        }
    }
}
