﻿using System;
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
    public class MUsuario : IUsuario
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MUsuario()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.Conexion, ServiceStack.OrmLite.Oracle.OracleDialect.Provider);
            _db = _conexion.Open();
        }
        public void ActualizarUsuarios(Usuario usu)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("SP_ACTUALIZARUSUARIO",ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("ID_USER", OracleDbType.Int32).Value = Convert.ToInt32(usu.id_user);
            comando.Parameters.Add("ID_ROL", OracleDbType.Int32).Value = Convert.ToInt32(usu.id_rol);
            comando.Parameters.Add("NOMBRE", OracleDbType.Varchar2).Value = usu.Nombre;
            comando.Parameters.Add("APELLIDOS", OracleDbType.Varchar2).Value = usu.Apellidos;
            comando.Parameters.Add("CORREO", OracleDbType.Varchar2).Value = usu.Correo;
            comando.Parameters.Add("DIRECCION", OracleDbType.Varchar2).Value = usu.Direccion;
            comando.Parameters.Add("CONTRA", OracleDbType.Varchar2).Value = usu.contra;
            comando.Parameters.Add("CEDULA", OracleDbType.Varchar2).Value = usu.Cedula;
            comando.ExecuteNonQuery();
            ora.Close();

        }

        public Usuario BuscarUsuario(string Cedula)
        {
            return _db.Select<Usuario>(x => x.Cedula == Cedula).FirstOrDefault();

        }

        public Usuario buscarUsuarioCorreo(string correo)
        {
            return _db.Select<Usuario>(x => x.Correo == correo).FirstOrDefault();

        }

        public void EliminarUsuario(string cedula)
        {
            _db.Delete<Usuario>(x => x.Cedula == cedula);
        }

        public bool ExisteUsuario(string correo)
        {
            try
            {
                Usuario usu = _db.Select<Usuario>(x => x.Correo == correo).FirstOrDefault();
                if (usu.Correo == correo)
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

        public void insertarUsuarios(Usuario usu)
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");
            ora.Open();
            OracleCommand comando = new OracleCommand("insertarUsuario", ora);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("id_rol", OracleDbType.Int32).Value = Convert.ToInt32(usu.id_rol);
            comando.Parameters.Add("nombre", OracleDbType.Varchar2).Value = usu.Nombre;
            comando.Parameters.Add("apellidos", OracleDbType.Varchar2).Value = usu.Apellidos;
            comando.Parameters.Add("correo", OracleDbType.Varchar2).Value = usu.Correo;
            comando.Parameters.Add("direccion", OracleDbType.Varchar2).Value = usu.Direccion;
            comando.Parameters.Add("contra", OracleDbType.Varchar2).Value = usu.contra;
            comando.Parameters.Add("Cedula", OracleDbType.Varchar2).Value = usu.Cedula;
            comando.ExecuteNonQuery();
        }

        public List<Usuario> ListarUsuarios()
        {
            //OracleConnection ora = new OracleConnection("DATA SOURCE=TOSHIBA-PC:1521/XE;PASSWORD=ORACLE01;USER ID=DESARROLLO");

            //string sql = "select * from view_ListarVuelos   ";
            //OracleCommand cmd = new OracleCommand();
            //cmd.CommandType = CommandType.Text;
            //ora.Open();
            //IDataReader reader = cmd.ExecuteReader();
            //List<Usuario> lista = new List<Usuario>();
            //while (reader.Read())
            //{





            //}
            //return lista;




            return _db.Select<Usuario>();



            //return _db.Select<Usuario>("select d.ciudad ,d.nombre_aeropuerto,t.Descripcion , av.nro_placa, vue.HORA_LLEGADA, vue.HORA_SALIDA, vue.AEROLINEA, vue.FECHA_VUELO, vue.DURACION_VUELO, vue.PUERTA_EMBARGE from Destino d, Piloto p, TIPOVUELO t, AVION av, PILOTOLICENCIA pl, TIPOLICENCIA tl, vuelos vue, VUELOSDESTINO vd where vd.NROVUELO = vue.NROVUELO and vd.id_Destino = d.ID_DESTINO and vue.idPiloto = p.IDPILOTO and  vue.idTipoVuelo = t.IDTIPOVUELO and vue.idAvion = av.IDAVION group by d.CIUDAD, d.NOMBRE_AEROPUERTO, t.DESCRIPCION, av.NRO_PLACA, vue.HORA_LLEGADA, vue.HORA_SALIDA, vue.AEROLINEA, vue.FECHA_VUELO, vue.DURACION_VUELO, vue.PUERTA_EMBARGE;");
        }
    }
}
