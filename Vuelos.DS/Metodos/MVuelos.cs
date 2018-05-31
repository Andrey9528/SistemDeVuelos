using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;
using Vuelos.DS.Interfaces;
using ServiceStack.OrmLite;
using Oracle.DataAccess.Client;
using System.Data;

namespace Vuelos.DS.Metodos
{
    public class MVuelos : IVuelos
    {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MVuelos()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion, ServiceStack.OrmLite.Oracle.OracleDialect.Provider);
            _db = _conexion.Open();

        }

        public void ActualizarVuelos(DATA.Vuelos vuelos)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("sp_ACTUALIZARVUELOS", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("NROVUELO", OracleDbType.Varchar2).Value = vuelos.NroVuelo;
            comando.Parameters.Add("IDPILOTO", OracleDbType.Int32).Value = Convert.ToInt32(vuelos.idPiloto);
            comando.Parameters.Add("IDTIPOVUELO", OracleDbType.Int32).Value =Convert.ToInt32(vuelos.idTipoVuelo);
            comando.Parameters.Add("IDAVION", OracleDbType.Int32).Value = Convert.ToInt32(vuelos.idAvion);
            comando.Parameters.Add("DURACION_VUELO", OracleDbType.Varchar2).Value =vuelos.Duracion_Vuelo;
            comando.Parameters.Add("AEROLINEA", OracleDbType.Varchar2).Value = vuelos.Aerolinea;
            comando.Parameters.Add("FECHA_VUELO", OracleDbType.Date).Value = Convert.ToDateTime(vuelos.Fecha_Vuelo);
            comando.Parameters.Add("HORA_SALIDA", OracleDbType.TimeStamp).Value = Convert.ToDateTime(vuelos.Hora_Salida);
            comando.Parameters.Add("HORA_LLEGADA", OracleDbType.TimeStamp).Value =Convert.ToDateTime(vuelos.Hora_llegada);
            comando.Parameters.Add("PUERTA_EMBARGE", OracleDbType.Varchar2).Value = vuelos.Puerta_embarge;
            comando.ExecuteNonQuery();
            ora.Close();
        }

        public DATA.Vuelos BuscarVuelo(string nro_vuelo)
        {
            return _db.Select<DATA.Vuelos>(x => x.NroVuelo == nro_vuelo).FirstOrDefault();

        }

        public DATA.Vuelos buscarVueloNumero(string nro_vuelo)
        {
            return _db.Select<DATA.Vuelos>(x => x.NroVuelo == nro_vuelo).FirstOrDefault();

        }

        public void EliminarVuelo(string vuelo)
        {
            try
            {


                OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BORRARVUELOS", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("NROVUELO", OracleDbType.Varchar2).Value = vuelo;
                comando.ExecuteNonQuery();
                ora.Close();
                //_db.Delete<DATA.Vuelos>(x => x.NroVuelo == vuelo);
            }
            catch

            {

            }

        }

        public bool ExisteVuelo(string nro_vuelo)
        {
            try
            {
                DATA.Vuelos vuelo = _db.Select<DATA.Vuelos>(x => x.NroVuelo == nro_vuelo).FirstOrDefault();
                if (vuelo.NroVuelo == nro_vuelo)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {


                if (ex.Message == "Referencia a objeto no establecida como una instancia de un objeto")
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public void insertarVuelos(DATA.Vuelos vuelos)
        {
            //_db.Insert(vuelos);

            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("INSERTARVUELOS", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("NROVUELO", OracleDbType.Varchar2).Value = vuelos.NroVuelo;
            comando.Parameters.Add("IDPILOTO", OracleDbType.Int32).Value = Convert.ToInt32(vuelos.idPiloto);
            comando.Parameters.Add("IDAVION", OracleDbType.Int32).Value = Convert.ToInt32(vuelos.idAvion);
            comando.Parameters.Add("IDTIPOVUELO", OracleDbType.Int32).Value = Convert.ToInt32(vuelos.idTipoVuelo);
            comando.Parameters.Add("DURACION_VUELO", OracleDbType.Varchar2).Value = vuelos.Duracion_Vuelo;
            comando.Parameters.Add("AEROLINEA", OracleDbType.Varchar2).Value = vuelos.Aerolinea;
            comando.Parameters.Add("FECHA_VUELO", OracleDbType.Date).Value = Convert.ToDateTime(vuelos.Fecha_Vuelo);
            comando.Parameters.Add("HORA_SALIDA", OracleDbType.TimeStamp).Value = Convert.ToDateTime(vuelos.Hora_Salida);
            comando.Parameters.Add("HORA_LLEGADA", OracleDbType.TimeStamp).Value =Convert.ToDateTime( vuelos.Hora_llegada);
            comando.Parameters.Add("PUERTA_EMBARGE", OracleDbType.Varchar2).Value = vuelos.Puerta_embarge;
            comando.ExecuteNonQuery();
            ora.Close();

        }

        public List<DATA.Vuelos> ListarVuelos()
        {
            return _db.Select<DATA.Vuelos>();
        }
    }
}
