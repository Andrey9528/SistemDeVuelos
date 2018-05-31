using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;

namespace Vuelos.DS.Interfaces
{
   public interface IVuelosDestino
    {
        List<VuelosDestino> ListarVuelosDestino();
        VuelosDestino BuscarVuelosDestinoPorID(int id_destino);
        void insertarVuelosDestino(VuelosDestino vuelosDestino);
        void ActualizarVuelosDestino(VuelosDestino vuelosdestino);
        void EliminarVuelosDestino(string nro_vuelo);
   
        VuelosDestino buscarVuelosDestinoporVuelo(string nrVuelo);
    }
}
