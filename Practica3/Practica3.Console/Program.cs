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

            TerritoriesLogic territoriesLogic = new TerritoriesLogic();
            EmployeesLogic employeeLogic = new EmployeesLogic(); 
            Console.WriteLine("Territorios:");
            territoriesLogic.AllTerritories();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Empleado:");
            employeeLogic.Employees(1);
                
            
            Console.ReadKey();
        }
    }
}
//98104
