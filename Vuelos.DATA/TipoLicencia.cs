using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Vuelos.DATA
{
   public class TipoLicencia
    {
        public int IDTIPOLICENCIA{ get; set; }
        public int NROLICENCIA { get; set; }
        public DateTime FECHA_VENCIMIENTO { get; set; }
        public DateTime FECHA_EXPEDICION { get; set; }
        public string DESCRIPCION { get; set; }

    }
}
