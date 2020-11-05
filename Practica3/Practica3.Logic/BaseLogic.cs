using Practica.ResourceAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
    public abstract class BaseLogic
    {
        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            this.context = new NorthwindContext();
        }



    }
}
