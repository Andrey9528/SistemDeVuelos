using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;

namespace Vuelos.DS.Interfaces
{
    public interface IPiloto
    {
        List<Piloto> ListarPilotos();
        Piloto BuscarPiloto(int  id_piloto);
        void insertarPilotos(Piloto pilo);
        void ActualizarPilotos(Piloto pilo);
        void EliminarPiloto(string cedula);
        bool ExistePiloto(string correo);
        Piloto buscarPilotoCorreo(string correo );
        Piloto buscarPilotoPorNombre(string nombre);
    }
}
