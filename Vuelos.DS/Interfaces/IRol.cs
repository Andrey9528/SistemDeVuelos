using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;


namespace Vuelos.DS.Interfaces
{
   public interface IRol
    {
        List<Rol> listarRoles();
        Rol BuscarRoles(int id_rol);
        void InsertarRoles(Rol roles);
        Rol BuscarRolesPorNombre(string Nombre);
        void ActualizarRoles(Rol roles);
        void EliminarRoles(int id_rol);
    }
}
