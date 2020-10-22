using Practica1POO.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practica1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Avion> pasajerosAvion = new List<Avion>();
            List<Automovil> pasajerosAutos = new List<Automovil>();
            int count = 1;
            Random rnd = new Random();


            for (int i = 0; i < 5; i++) {
                Automovil auto = new Automovil(rnd.Next(0,6));
                Avion avion = new Avion(rnd.Next(0, 101));
                pasajerosAutos.Add(auto);
                pasajerosAvion.Add(avion);

            }
            
            foreach (Avion av in pasajerosAvion) {
                Console.WriteLine($"Avion{count}: {av.CantPasajeros} Pasajeros");
                count++;
            }
            
            count = 1;
            Console.WriteLine();
            foreach (Automovil au in pasajerosAutos) {
                Console.WriteLine($"Auto{count}: {au.CantPasajeros} Pasajeros");
                count++;
            }

            Console.ReadKey();
        }
    }
}
