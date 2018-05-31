using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;

namespace Vuelos.DS.Interfaces
{
   public interface IDestino
    {
        void InsertarDestino(Destino destino);
        void ActualizarDestino(Destino destino);
        List<Destino> ListarDestino();
        Destino BuscarDestino(int id_destino);
        void EliminarDestino(int id_destino);
        Destino BuscarDestinoNombre(string CIUDAD);

    }
}
