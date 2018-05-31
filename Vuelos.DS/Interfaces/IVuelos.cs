using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Vuelos.DATA;

namespace Vuelos.DS.Interfaces
{
    public interface IVuelos
    {
        List<Vuelos.DATA.Vuelos> ListarVuelos();
        Vuelos.DATA.Vuelos BuscarVuelo(string nro_vuelo);
        void insertarVuelos(DATA.Vuelos vuelos);
        void ActualizarVuelos(DATA.Vuelos vuelos);
        void EliminarVuelo(string vuelo);
        bool ExisteVuelo(string nro_vuelo);
        DATA.Vuelos buscarVueloNumero(string nro_vuelo);
    }
}
