using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Practica1POO.Clases
{
    public class Automovil : Transporte
    {
        public Automovil(int cantPasajeros) : base(cantPasajeros) { }

        public override string Avanzar()
        {
            return Arranque() + "El auto esta avanzando";
        }

        public override string Detenerse()
        {
            return "El auto llego a su destino.."+ Apagar();
        }

        private string Arranque() {
            return "Encendiendo auto....";
        }

        private string Apagar() {
            return "Apagando auto...";
        }
    }
}
