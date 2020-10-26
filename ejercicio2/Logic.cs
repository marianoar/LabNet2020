using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    public class Logic
    {
        public static void LanzarExcepcion()
        {
            throw new Exception();
        }

        public static void LanzarExcepcionPersonalizada()
        {
            throw new CustomException("Lanzo mi Exception");
        }
    }
}
