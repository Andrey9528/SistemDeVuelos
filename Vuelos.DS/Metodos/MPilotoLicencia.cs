using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using Oracle.DataAccess.Client;
using System.Data;
using Vuelos.DS.Interfaces;
using Vuelos.DATA;

namespace Vuelos.DS.Metodos
{
    public class MPilotoLicencia : IPIlotoLicencia
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MPilotoLicencia()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion, ServiceStack.OrmLite.Oracle.OracleDialect.Provider);
            _db = _conexion.Open();

        }
        public void ActualizarPilotoLicencia(PilotoLicencia pilotoLicencia)
        {
            _db.Update();
        }

        public PilotoLicencia BuscarPilotoLicenciaPorPiloID(int idpiloto)
        {
           return  _db.Select<PilotoLicencia>(x => x.IDPILOTO == idpiloto).FirstOrDefault();

        }

        public PilotoLicencia buscarTipolicencia(int tipolicencia)
        {
            return _db.Select<PilotoLicencia>(x => x.IDTIPOLICENCIA == tipolicencia).FirstOrDefault();
        }

        public void EliminarPilotoLicencia(int idpilotolicencia)
        {
            _db.Delete<PilotoLicencia>(X => X.IDPILOTOLICENCIA == idpilotolicencia);
        }

        public void insertarPilotoLicencia(PilotoLicencia pilotolicencia)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("INSERTARPILOTOLICENCIA", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("IDPILOTO", OracleDbType.Int32).Value = pilotolicencia.IDPILOTO;
            comando.Parameters.Add("IDTIPOLICENCIA", OracleDbType.Int32).Value = pilotolicencia.IDTIPOLICENCIA;
            comando.ExecuteNonQuery();
        }

        public List<PilotoLicencia> ListarPilotoLicencia()
        {
           return  _db.Select<PilotoLicencia>();
        }
    }
}
