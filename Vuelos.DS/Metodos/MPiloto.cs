using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.DATA;
using ServiceStack.OrmLite;
using Oracle.DataAccess.Client;
using Vuelos.DS.Interfaces;
using System.Data;

namespace Vuelos.DS.Metodos
{
    public class MPiloto : IPiloto
     {

        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;
        public MPiloto()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion ,  ServiceStack.OrmLite.Oracle.OracleDialect.Provider);
            _db = _conexion.Open();
        }

        public void ActualizarPilotos(Piloto pilo)
        {
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
                ora.Open();
                OracleCommand comando = new OracleCommand("sp_ACTUALIZARPILOTO", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("IDPILOTO", OracleDbType.Int32).Value = Convert.ToInt32(pilo.idPiloto);
                comando.Parameters.Add("CEDULA", OracleDbType.Varchar2).Value = pilo.Cedula;
                comando.Parameters.Add("APELLIDO", OracleDbType.Varchar2).Value = pilo.Apellido;
                comando.Parameters.Add("NOMBRE", OracleDbType.Varchar2).Value = pilo.Nombre;
                comando.Parameters.Add("FECHA_NACI", OracleDbType.Date).Value = pilo.Fecha_naci;
                comando.Parameters.Add("LUGAR_NACI", OracleDbType.Varchar2).Value = pilo.Lugar_Naci;
                comando.Parameters.Add("TELEFONO", OracleDbType.Int32).Value = Convert.ToInt32(pilo.Telefono);
                comando.Parameters.Add("CORREO", OracleDbType.Varchar2).Value = pilo.Correo;
                comando.Parameters.Add("NACIONALIDAD", OracleDbType.Varchar2).Value = pilo.Nacionalidad;
                comando.Parameters.Add("IMAGEN", OracleDbType.Varchar2).Value = pilo.Imagen;
                comando.ExecuteNonQuery();
                ora.Close();
            }

            catch
            {
            }
           
        }

        public Piloto BuscarPiloto(int id_piloto)
        {
            return _db.Select<Piloto>(x => x.idPiloto== id_piloto).FirstOrDefault();
        }

        public Piloto buscarPilotoCorreo(string correo)
        {
            return _db.Select<Piloto>(x => x.Correo == correo).FirstOrDefault();
        }

        public Piloto buscarPilotoPorNombre(string nombre)
        {
            return _db.Select<Piloto>(X => X.Nombre== nombre).FirstOrDefault();
        }

        public void EliminarPiloto(string cedula)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_BORRARPILOTOS", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("CEDULA", OracleDbType.Varchar2).Value = cedula;
            comando.ExecuteNonQuery();
            ora.Close();
        }

        public bool ExistePiloto(string correo)
        {
            try
            {
                Piloto pilo = _db.Select<Piloto>(x => x.Correo == correo).FirstOrDefault();
                if (pilo.Correo == correo)
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

        public void insertarPilotos(Piloto pilo)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("INSERTARPILOTO", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("CEDULA", OracleDbType.Varchar2).Value = pilo.Cedula;
            comando.Parameters.Add("NOMBRE", OracleDbType.Varchar2).Value = pilo.Nombre;
            comando.Parameters.Add("APELLIDO", OracleDbType.Varchar2).Value = pilo.Apellido;
            comando.Parameters.Add("FECHA_NACI", OracleDbType.Date).Value = Convert.ToDateTime(pilo.Fecha_naci);
            comando.Parameters.Add("LUGAR_NACI", OracleDbType.Varchar2).Value = pilo.Lugar_Naci;
            comando.Parameters.Add("TELEFONO", OracleDbType.Int32).Value = Convert.ToInt32(pilo.Telefono);
            comando.Parameters.Add("CORREO", OracleDbType.Varchar2).Value = pilo.Correo;
            comando.Parameters.Add("NACIONALIDAD", OracleDbType.Varchar2).Value = pilo.Nacionalidad;
            comando.Parameters.Add("IMAGEN", OracleDbType.Varchar2).Value = pilo.Imagen;
            comando.ExecuteNonQuery();
        }

        public List<Piloto> ListarPilotos()
        {
            return _db.Select<Piloto>();
        }
    }
}
