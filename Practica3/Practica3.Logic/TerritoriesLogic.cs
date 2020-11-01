using Practica.Entities;
using Practica.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
    public class TerritoriesLogic
    {
        private readonly NorthwindContext context;

        public TerritoriesLogic(){

            this.context = new NorthwindContext();
        }
        public void AllTerritories() {

            var territories = getAllTerritories();
            foreach (var t in territories)
            {
                Console.WriteLine($"ID Territorio: {t.TerritoryID} , Descripcion: {t.TerritoryDescription}");
            }
        }


        private List<Territories> getAllTerritories() {
            return context.Territories.ToList();
        }
    }
}
