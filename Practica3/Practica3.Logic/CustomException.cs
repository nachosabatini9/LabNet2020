using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
    public class CustomException : Exception
    {
        public CustomException(string msg) : base(msg) { }
    }
}
