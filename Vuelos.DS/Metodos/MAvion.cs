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
    public class MAvion : IAvion
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MAvion()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion, ServiceStack.OrmLite.Oracle.OracleDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarAvion(Avion av)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
                ora.Open();
                OracleCommand comando = new OracleCommand(" sp_ACTUALIZARAVION", ora);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("IDAVION", OracleDbType.Int32).Value = Convert.ToInt32(av.IDAVION);
                comando.Parameters.Add("NRO_PLACA", OracleDbType.Varchar2).Value = av.NRO_PLACA;
                comando.Parameters.Add("MODELO", OracleDbType.Varchar2).Value = av.MODELO;
                comando.Parameters.Add("TIEMPO_VUELO", OracleDbType.TimeStamp).Value = Convert.ToDateTime(av.TIEMPO_VUELO);
                comando.Parameters.Add("IMAGEN", OracleDbType.Long).Value = av.IMAGEN;
                comando.ExecuteNonQuery();
                ora.Close();
            }
            catch
            {

            }
        }

        public Avion BuscarAvion(int idavion)
        {
           return _db.Select<Avion>(x => x.IDAVION == idavion).FirstOrDefault();
        }

        public Avion buscarAvionModelo(string modelo)
        {
            return _db.Select<Avion>(x => x.MODELO == modelo).FirstOrDefault();
        }

        public Avion BuscarAvionPorModelo(string MODELO)
        {
         return _db.Select<Avion>(x => x.MODELO == MODELO).FirstOrDefault();
            
            

            }

        public void EliminarAvion(int idavion)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BORRARAVION", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("IDAVION", OracleDbType.Int32).Value = idavion;
                comando.ExecuteNonQuery();
                ora.Close();
            }
            catch
            {

            }
        }

        public void insertarAvion(Avion av)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
                ora.Open();
                OracleCommand comando = new OracleCommand(" INSERTARAVION", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("NRO_PLACA", OracleDbType.Varchar2).Value = av.NRO_PLACA;
                comando.Parameters.Add("MODELO", OracleDbType.Varchar2).Value = av.MODELO;
                comando.Parameters.Add("TIEMPO_VUELO", OracleDbType.TimeStamp).Value = Convert.ToDateTime(av.TIEMPO_VUELO);
                comando.Parameters.Add("IMAGEN", OracleDbType.Long).Value = av.IMAGEN;
                comando.ExecuteNonQuery();
                ora.Close();
            }
            catch
            {
            }
        }

        public List<Avion> ListarAviones()
        {
          return  _db.Select<Avion>();
        }
    }
}
