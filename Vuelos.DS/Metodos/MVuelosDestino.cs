using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DS.Interfaces;
using ServiceStack.OrmLite;
using Vuelos.DATA;
using System.Data;
using Oracle.DataAccess.Client;


namespace Vuelos.DS.Metodos
{
    public class MVuelosDestino : IVuelosDestino
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MVuelosDestino()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion, ServiceStack.OrmLite.Oracle.OracleDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarVuelosDestino(VuelosDestino vuelosdestino)
        {
            throw new NotImplementedException();
        }

        public VuelosDestino BuscarVuelosDestinoPorID(int id_destino)
        {
            return _db.Select<VuelosDestino>(x => x.id_destino == id_destino).FirstOrDefault();
        }

        public VuelosDestino buscarVuelosDestinoporVuelo(string nrVuelo)
        {
           return  _db.Select<VuelosDestino>(x => x.NroVuelo == nrVuelo).FirstOrDefault();
        }

        public void EliminarVuelosDestino(string nro_vuelo)
        {
            _db.Delete<VuelosDestino>(x => x.NroVuelo == nro_vuelo);
        }

        public void insertarVuelosDestino(VuelosDestino vuelosDestino)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("INSERTARVUELOSDESTINO", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("NROVUELO", OracleDbType.Varchar2).Value = vuelosDestino.NroVuelo;
            comando.Parameters.Add("ID_DESTINO", OracleDbType.Int32).Value = Convert.ToInt32(vuelosDestino.id_destino);
            comando.ExecuteNonQuery();
        }

        public List<VuelosDestino> ListarVuelosDestino()
        {
            return _db.Select<VuelosDestino>();
        }
    }
}
