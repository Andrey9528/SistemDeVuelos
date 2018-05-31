using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Vuelos.DATA
{
   public class Usuario
    {
        public int id_user { get; set; }
        public int id_rol { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string contra { get; set; }
        public string Cedula { get; set; }
    }
}
