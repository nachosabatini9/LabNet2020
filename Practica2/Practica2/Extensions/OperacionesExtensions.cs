using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Extensions
{
    public static class OperacionesExtensions
    {
        public static void DivCero(this int numero)
        {
            try
            {
                Console.WriteLine(numero / 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Mensaje de la excepcion: {ex.Message}");
            }
            finally {
                Console.WriteLine();
                Console.WriteLine("Ejecucion Terminada");
            }

        }

        public static void RealizarOperacion(){
            try
            {
                string input;
                int valorPrimario, valorSecundario;
                bool esDiv;

                Console.WriteLine("Ingrese primer valor:");
                input = Console.ReadLine();
                valorPrimario = int.Parse(input);
                
                Console.WriteLine("Ingrese el segundo valor:");
                input = Console.ReadLine();
                valorSecundario = int.Parse(input);
                
                Console.WriteLine("Es division?? S/N");
                input = Console.ReadLine();
                
                if (input.ToLower() == "s") esDiv = true; else esDiv = false;

                if (esDiv)
                {
                    int division = valorPrimario / valorSecundario;
                    Console.WriteLine("El resultado es " + division);
                }
                else {
                    int multiplicacion = valorPrimario * valorSecundario;
                    Console.WriteLine("El resultado es " + multiplicacion);
                }
            }catch (DivideByZeroException ex){
                Console.WriteLine();
                Console.WriteLine("Solo Chuck Norris tiene este poder.");
                Console.WriteLine();
            }
            catch (Exception ex) {
                Console.WriteLine();
                Console.WriteLine("Ingresa un numero picaron");
                Console.WriteLine();

            }
            finally{
                Console.WriteLine("Ejecucion terminada");
                Console.WriteLine();
            }
        }
    }
}

