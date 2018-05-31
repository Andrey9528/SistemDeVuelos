using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DS.Interfaces;
using ServiceStack.OrmLite;
using Oracle.DataAccess.Client;
using System.Data;
using Vuelos.DATA;

namespace Vuelos.DS.Metodos
{
    public class MTipoVuelo : ITipoVuelo
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MTipoVuelo()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion, ServiceStack.OrmLite.Oracle.OracleDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarTipoVuelo(TipoVuelo tp)
        {
            _db.Update(tp);
        }

        public TipoVuelo buscarTipoVuelo(int idtipovuelo)
        {
            return _db.Select<TipoVuelo>(x => x.IDTIPOVUELO == idtipovuelo).FirstOrDefault();
        }

        public TipoVuelo BuscarTipoVueloDescripcion(string descripcion)
        {
            return _db.Select<TipoVuelo>(x => x.DESCRIPCION == descripcion).FirstOrDefault();
        }

        public void EliminarTipoVuelo(int idtipovuelo)
        {
            _db.Delete<TipoVuelo>(x => x.IDTIPOVUELO == idtipovuelo);
        }

        public void insertarTipoVuelo(TipoVuelo tp)
        {
            _db.Insert(tp);
        }

        public List<TipoVuelo> ListarTipoVuelos()
        {
            return _db.Select<TipoVuelo>();
        }
    }
}
