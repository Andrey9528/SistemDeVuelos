using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ServiceStack.DataAnnotations;

namespace Vuelos.DATA
{
  public  class Destino
    {
        public int id_destino { get; set; }
        public string NOMBRE_AEROPUERTO { get; set; }
        public string CIUDAD { get; set; }
        public string Pais { get; set; }
        public string IMAGEN { get; set; }
      

    }
}
