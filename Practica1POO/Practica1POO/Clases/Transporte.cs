using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Practica1POO.Clases
{
    public abstract class Transporte
    {
        private int cantPasajeros;
       
        #region Constructor
        public Transporte(int cantPasajeros)
        {
            this.cantPasajeros = cantPasajeros;
        }
        #endregion


        #region Clases Publicas
        public int CantPasajeros
        {
            get { return this.cantPasajeros; }
        }
        public abstract string Avanzar();

        public abstract string Detenerse();
        #endregion




    }
}
