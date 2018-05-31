using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace Vuelos.DATA
{
   public  class TipoVuelo
    {
        public int IDTIPOVUELO { get; set; }
        public string DESCRIPCION { get; set; }
    }
}
