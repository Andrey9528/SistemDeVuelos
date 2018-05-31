using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;

namespace Vuelos.DS.Interfaces
{
   public interface IPIlotoLicencia
    {
        List<PilotoLicencia> ListarPilotoLicencia();
        PilotoLicencia BuscarPilotoLicenciaPorPiloID(int idpiloto);
        void insertarPilotoLicencia(PilotoLicencia pilotolicencia);
        void ActualizarPilotoLicencia(PilotoLicencia pilotoLicencia);
        void EliminarPilotoLicencia(int idpilotolicencia);
        PilotoLicencia buscarTipolicencia(int tipolicencia);
    }
}
