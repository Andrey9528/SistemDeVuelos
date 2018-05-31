using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;
using ServiceStack.OrmLite;
using Oracle.DataAccess.Client;
using System.Data;
using Vuelos.DS.Interfaces;

namespace Vuelos.DS.Metodos
{
    public class MDestino : IDestino
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;


        public MDestino()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion, ServiceStack.OrmLite.Oracle.OracleDialect.Provider);
            _db = _conexion.Open();

        }
        public void ActualizarDestino(Destino destino)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("sp_ACTUALIZARDESTINO", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("ID_DESTINO", OracleDbType.Int32).Value = Convert.ToInt32(destino.id_destino);
            comando.Parameters.Add("NOMBRE_AEROPUERTO", OracleDbType.Varchar2).Value = destino.NOMBRE_AEROPUERTO;
            comando.Parameters.Add("CIUDAD", OracleDbType.Varchar2).Value = destino.CIUDAD;
            comando.Parameters.Add("PAIS", OracleDbType.Varchar2).Value =destino.Pais;
            comando.Parameters.Add("IMAGEN", OracleDbType.Varchar2).Value = destino.IMAGEN;
            comando.ExecuteNonQuery();
            ora.Close();
        }

        public Destino BuscarDestino(int id_destino)
        {
            return _db.Select<Destino>(x => x.id_destino == id_destino).FirstOrDefault();
        }

        public Destino BuscarDestinoNombre(string CIUDAD)
        {
            return _db.Select<Destino>(x => x.CIUDAD == CIUDAD).FirstOrDefault();
        }

        public void EliminarDestino(int id_destino)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
                ora.Open();
                OracleCommand comando = new OracleCommand(" sp_borrardestino", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("ID_DESTINO", OracleDbType.Int32).Value = id_destino;
                comando.ExecuteNonQuery();
                ora.Close();
            }
            catch
            {
            }
        }

        public void InsertarDestino(Destino destino)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("INSERTARDESTINO", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("NOMBRE_AEROPUERTO", OracleDbType.Varchar2).Value = destino.NOMBRE_AEROPUERTO;
            comando.Parameters.Add("CIUDAD", OracleDbType.Varchar2).Value = destino.CIUDAD;
            comando.Parameters.Add("PAIS", OracleDbType.Varchar2).Value = destino.Pais;
            comando.Parameters.Add("IMAGEN", OracleDbType.Varchar2).Value = destino.IMAGEN;
            comando.ExecuteNonQuery();
            ora.Close();
        }

        public List<Destino> ListarDestino()
        {
            return _db.Select<Destino>();
        }
    }
}
