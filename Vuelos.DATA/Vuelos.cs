using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Vuelos.DATA
{
    public class Vuelos
    {
        public string NroVuelo { get; set; }
        public int idPiloto { get; set; }
        public int idTipoVuelo { get; set; }
        public int idAvion { get; set; }
        public string Duracion_Vuelo { get; set; }
        public string Aerolinea { get; set; }
        public DateTime Fecha_Vuelo { get; set; }
        public DateTime Hora_Salida { get; set; }
        public DateTime Hora_llegada { get; set; }
        public string Puerta_embarge { get; set; }




    }
}
