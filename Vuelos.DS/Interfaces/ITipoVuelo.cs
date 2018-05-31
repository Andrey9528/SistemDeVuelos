using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;

namespace Vuelos.DS.Interfaces
{
  public   interface ITipoVuelo
    {
        List<TipoVuelo> ListarTipoVuelos();
        TipoVuelo BuscarTipoVueloDescripcion(string descripcion);
        void insertarTipoVuelo(TipoVuelo tp);
        void ActualizarTipoVuelo(TipoVuelo tp);
        void EliminarTipoVuelo(int  idtipovuelo);
        TipoVuelo buscarTipoVuelo(int  idtipovuelo);

    }
}
