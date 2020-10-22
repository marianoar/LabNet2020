using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Automovil : Transporte
    {
        public Automovil(int pasajeros) : base(pasajeros)
        {
            this.Pasajeros = pasajeros;
        }
        public override string Avanzar()
        {
            return " avanzando";
        }
        public override string Detenerse()
        {
            return " frenando";
        }
        public override string Definir()
        {
            return "Automovil";
        }
    }
}
