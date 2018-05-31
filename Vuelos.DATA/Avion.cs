using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
namespace Vuelos.DATA
{
    public class Avion
    {
        public int IDAVION { get; set; }
        public string NRO_PLACA { get; set; }
        public string MODELO { get; set; }
        public DateTime TIEMPO_VUELO { get; set; }
        public string IMAGEN { get; set; }

    }
}
