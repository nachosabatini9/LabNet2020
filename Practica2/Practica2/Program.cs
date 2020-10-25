using Practica2.Clases;
using Practica2.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            string op;

            while (menu) {
                Console.Clear();
                Console.WriteLine("------ Practica 2 ------");
                Console.WriteLine("1- Prueba division por 0");
                Console.WriteLine("2- Division o Multiplicacion");
                Console.WriteLine("3- Prueba de Excepcion");
                Console.WriteLine("4- Prueba Excepcion Custom");
                Console.WriteLine("5-Terminar Prueba");
                Console.WriteLine("Ingrese una opcion:");
                op = Console.ReadLine();
                
                switch (op) {
                    
                    case "1":
                        
                        Console.Clear();
                        Console.WriteLine("Esto es solo una prueba de la divison por 0");
                        Console.WriteLine();
                        int numero = 10;
                        numero.DivCero();
                        Console.WriteLine("Aprete una tecla para continuar..");
                        Console.ReadKey();
                        break;
                    
                    case "2":
                        
                        Console.Clear();
                        OperacionesExtensions.RealizarOperacion();
                        Console.WriteLine("Aprete una tecla para continuar..");
                        Console.ReadKey();
                        break;

                    case "3":
                        
                        Console.Clear();
                        Logic log = new Logic();
                        
                        try
                        {
                            log.ThrowException();
                        }
                        catch(Exception ex) {
                            
                            Console.WriteLine($"Mensaje: {ex.Message}");
                            Console.WriteLine();
                            Console.WriteLine($"StackTrace: {ex.StackTrace}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Aprete una tecla para continuar..");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Clear();
                        ExceptionsCustom.ThrowExceptionCustom();
                        break;

                    case "5":
                        menu = false;
                        break;
                }

            }
        }
    }
}
