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
        public class EmployeesLogic : BaseLogic,ILogic<Employees>
        {

            public List<Employees> GetAll()
            {
                return context.Employees.ToList();
            }

            public Employees GetOne(int id)
            {
                try
                {
                    return context.Employees.First(r => r.EmployeeID.Equals(id));
                }
                catch {
                    throw new CustomException("Empleado Inexistente");
                }

            }

            public void Insert(Employees entity)
            {
                try
                {
                    int ultimoId = (from emp in context.Employees
                                    orderby emp.EmployeeID descending
                                    select emp.EmployeeID).FirstOrDefault();

                    //entity.EmployeeID = ++ultimoId;

                    Employees nuevoEmpleado = context.Employees.Add(entity);
                    context.SaveChanges();
                }
                catch {
                    throw new CustomException("Error al Crear nuevo Empleado");
                }


            }

            public void Update(Employees entity)
            {
                try
                {
                    Employees empleadoAEditar = GetOne(entity.EmployeeID);
                    empleadoAEditar.FirstName = entity.FirstName;
                    empleadoAEditar.LastName = entity.LastName;
                    empleadoAEditar.City = entity.City;
                    empleadoAEditar.Country = entity.Country;
                    //empleadoAEditar.PostalCode = entity.PostalCode;
                    context.SaveChanges();
                }
                catch {
                    throw new CustomException("Error al actualizar Empleado");
                }

            }
            public void Delete(int id)
            {
                try
                {
                    Employees empleadoAEliminar = GetOne(id);
                    context.Employees.Remove(empleadoAEliminar);
                    context.SaveChanges();
                }
                catch {
                throw new CustomException("Error al eliminar Empleado");
            }

            }

        }
}

