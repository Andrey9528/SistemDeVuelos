using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using Vuelos.DATA;
using Oracle.DataAccess.Client;
using System.Data;
using Vuelos.DS.Interfaces;

namespace Vuelos.DS.Metodos
{
    public class MTipoLicencia : ITipoLicencia
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MTipoLicencia()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion, ServiceStack.OrmLite.Oracle.OracleDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarTipoLicencia(TipoLicencia tl)
        {
            _db.Update(tl);
        }

        public TipoLicencia buscarPorDescripcion(string descripcion)
        {
            return _db.Select<TipoLicencia>(x => x.DESCRIPCION == descripcion).FirstOrDefault();
        }

        public TipoLicencia buscarTipoLicencia(int nrolicencia)
        {
            return _db.Select<TipoLicencia>(x => x.NROLICENCIA == nrolicencia).FirstOrDefault();
        }

        public TipoLicencia BuscarTipolicencia(int IDTIPOLICENCIA)
        {
            return _db.Select<TipoLicencia>(x => x.IDTIPOLICENCIA == IDTIPOLICENCIA).FirstOrDefault();
        }

        public void EliminarTipoLicencia(int IDTIPOLICENCIA)
        {
            _db.Delete<TipoLicencia>(x => x.IDTIPOLICENCIA == IDTIPOLICENCIA);
        }

        public void insertarTipoLicencia(TipoLicencia tl)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("INSERTARTIPOLICENCIA", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("NROLICENCIA", OracleDbType.Int32).Value = tl.NROLICENCIA;
            comando.Parameters.Add("FECHA_VENCIMIENTO", OracleDbType.Date).Value = tl.FECHA_VENCIMIENTO;
            comando.Parameters.Add("FECHA_EXPEDICION", OracleDbType.Date).Value =tl.FECHA_EXPEDICION;
             comando.Parameters.Add("DESCRIPCION", OracleDbType.Varchar2).Value = tl.DESCRIPCION;
            comando.ExecuteNonQuery();
        }

        public List<TipoLicencia> ListarTipolicencia()
        {
          return  _db.Select<TipoLicencia>();
        }
    }
}
