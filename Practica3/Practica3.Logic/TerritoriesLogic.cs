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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Update(Territories entity)
        {
            throw new NotImplementedException();
        }
    }
}
