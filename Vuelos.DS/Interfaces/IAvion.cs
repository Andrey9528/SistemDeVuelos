using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;

namespace Vuelos.DS.Interfaces
{
  public  interface IAvion
    {
        List<Avion> ListarAviones();
        Avion BuscarAvion(int  idavion);
        void insertarAvion(Avion av);
        void ActualizarAvion(Avion av);
        void EliminarAvion(int idavion);
        Avion buscarAvionModelo(string modelo);
        Avion BuscarAvionPorModelo(string MODELO);
    }
}
