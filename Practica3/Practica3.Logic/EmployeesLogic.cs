using Practica.Entities;
using Practica.ResourceAccess;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
        public class EmployeesLogic
        {

            private readonly NorthwindContext context;

            public EmployeesLogic()
            {
                this.context = new NorthwindContext();
            }

            public void Employees(int ID)
            {
            try
            {
                var employee = RetrieveEmployee(ID);
                Console.WriteLine($"ID Empleado:{employee.EmployeeID}, Nombre Completo: {employee.FirstName} {employee.LastName}, Ciudad:{employee.City}");

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            }
        
            private Employees RetrieveEmployee(int ID) {

                    try
                    {
                        return context.Employees.First(r => r.EmployeeID.Equals(ID));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Empleado inexistente");
                    }
            }
    

      }
}

