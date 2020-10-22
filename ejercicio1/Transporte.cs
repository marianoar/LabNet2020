using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    public abstract class Transporte : IDefinicion
    {
        #region Atributos
        private int pasajeros;
        #endregion
        #region Propiedades
        public int Pasajeros
        {
            get
            {
                return this.pasajeros;
            }
            set
            {
                this.pasajeros = value;
            }
        }
        #endregion
        #region Constructor
        public Transporte(int pasajeros)
        {
            this.Pasajeros = pasajeros;
        }
        #endregion
        #region Metodos
        public abstract string Avanzar();

        public abstract string Detenerse();
        public abstract string Definir();
        #endregion
    }
}
