using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Clases
{
    public class ExceptionsCustom : Exception
    {
        public ExceptionsCustom() : base("Esto es una excepcion personalizada") { }

        public override string Message => $"Mensaje: {base.Message} con sobreescritura de metodo";

        public static void ThrowExceptionCustom() {
            try
            {
                throw new ExceptionsCustom();
            }
            catch (ExceptionsCustom ex) {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
