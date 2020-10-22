using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1POO.Clases
{
    public class Avion : Transporte
    {
        public Avion(int cantPasajeros) : base(cantPasajeros) { }

        public override string Avanzar()
        {
            return Encendiendo()+"El avion despego";
        }

        public override string Detenerse()
        {
            return "El avion llego a su destino";
        }

        private string Encendiendo() {
            return "Encendiendo motores....";
        }
    }
}
