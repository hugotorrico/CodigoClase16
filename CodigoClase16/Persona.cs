using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase16
{
    public class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Nacionalidad Nacionalidad { get; set; }
    }   
    public class Nacionalidad
    {
        public string Pais { get; set; }
        public string Pasaporte { get; set; }
    }


    //public class NacionalidadPasaporte
    //{
    //    public string Nombres { get; set; }
    //    public string Apellidos { get; set; }
    //    public string Pasaporte { get; set; }
    //}



}
