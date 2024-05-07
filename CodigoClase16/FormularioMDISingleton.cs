using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase16
{
    public class FormularioMDISingleton
    {
        //Propiedades del formulario de tipo estático
        private static Form formularioMDI;

        private FormularioMDISingleton() { } // Constructor privado para evitar instanciación externa


        //Crear una función estática
        public static Form ObtenerInstancia()
        {
            if (formularioMDI == null || formularioMDI.IsDisposed)
            {
                //Creas tu formulario
                formularioMDI = new MDINuevo();
            }
            return formularioMDI;
        }
    }
}
