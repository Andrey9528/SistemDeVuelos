using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;


namespace Vuelos.DS.Interfaces
{
   public interface IUsuario
    {
        List<Usuario> ListarUsuarios();
        Usuario BuscarUsuario(string Cedula);
        void insertarUsuarios(Usuario usu);
        void ActualizarUsuarios(Usuario usu);
        void EliminarUsuario(string cedula);
        bool ExisteUsuario(string correo);
        Usuario buscarUsuarioCorreo(string correo);
    }
}
