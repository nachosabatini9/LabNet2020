using Practica.Entities;
using Practica.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
    public class TerritoriesLogic : BaseLogic, ILogic<Territories>
    {
        public void Delete(int id)
        {
            try
            {
                Territories territorioAEliminar = GetOne(id);
                context.Territories.Remove(territorioAEliminar);
                context.SaveChanges();
            }
            catch
            {
                throw new CustomException("Error al eliminar Empleado");
            }

        }
    

        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }

        public Territories GetOne(int id)
        {
            return context.Territories.First(r => r.TerritoryID.Equals(id));
        }

        public void Insert(Territories entity)
        {
            try
            {
                Territories nuevoTerritorio = context.Territories.Add(entity);
                context.SaveChanges();
            }
            catch
            {
                throw new CustomException("Error al Crear nuevo Empleado");
            }
        }

        public void Update(Territories entity)
        {
            try
            {
                Territories territoriooAEditar = GetOne(int.Parse(entity.TerritoryID));
                territoriooAEditar.TerritoryDescription = entity.TerritoryDescription;
                territoriooAEditar.RegionID = entity.RegionID;
                context.SaveChanges();
            }
            catch
            {
                throw new CustomException("Error al actualizar Empleado");
            }

        }
    }
}
