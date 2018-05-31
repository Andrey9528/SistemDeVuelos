using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;

namespace Vuelos.DS.Interfaces
{
   public interface ITipoLicencia
    {
        List<TipoLicencia> ListarTipolicencia();
        TipoLicencia BuscarTipolicencia(int IDTIPOLICENCIA);
        void insertarTipoLicencia(TipoLicencia  tl);
        void ActualizarTipoLicencia(TipoLicencia tl);
        void EliminarTipoLicencia(int IDTIPOLICENCIA);
        TipoLicencia buscarTipoLicencia(int nrolicencia);
        TipoLicencia buscarPorDescripcion(string descripcion);

    }
}
