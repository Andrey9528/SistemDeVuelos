using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;
using Vuelos.DS.Interfaces;
using ServiceStack.OrmLite;
using System.Data;
using Oracle.DataAccess.Client;

namespace Vuelos.DS.Metodos
{
    public class MRol : IRol
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MRol()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion, ServiceStack.OrmLite.Oracle.OracleDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarRoles(Rol roles)
        {
            _db.Update(roles);
        }

        public Rol BuscarRoles(int id_rol)
        {
            return _db.Select<Rol>(x => x.id_rol == id_rol).FirstOrDefault();

        }

        public Rol BuscarRolesPorNombre(string Nombre)
        {
            return _db.Select<Rol>(x => x.Nombre == Nombre).FirstOrDefault();

        }

        public void EliminarRoles(int id_rol)
        {
            _db.Delete<Rol>(x => x.id_rol == id_rol);
        }

        public void InsertarRoles(Rol roles)
        {
            _db.Insert(roles);
        }

        public List<Rol> listarRoles()
        {
            return _db.Select<Rol>();
        }
    }
}
