using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Vuelos.DATA
{
    public class Piloto
    {
        public int idPiloto { get; set; }
        public string Cedula { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_naci { get; set; }
        public string Lugar_Naci { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Nacionalidad { get; set; }
        public string Imagen { get; set; }
        

    }
}
