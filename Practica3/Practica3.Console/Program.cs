using Practica.Entities;
using Practica3.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EmployeesLogic employeeLogic = new EmployeesLogic();



                employeeLogic.Insert(new Employees
                {
                    FirstName = "Jon",
                    LastName = "Snow",
                    City = "Rosario",
                    PostalCode = "2000",
                    Country = "Argentina"

                });

                var allEmployees = employeeLogic.GetAll();
                foreach (var e in allEmployees)
                {
                    Console.WriteLine($"Nombre: {e.FirstName} {e.LastName}, Ciudad: {e.City}, ID:{e.EmployeeID}");
                }

                Console.WriteLine("----------------------------");

                employeeLogic.Delete(14);
                allEmployees = employeeLogic.GetAll();
                foreach (var e in allEmployees)
                {
                    Console.WriteLine($"Nombre: {e.FirstName} {e.LastName}, Ciudad: {e.City}, ID:{e.EmployeeID}");
                }



            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

