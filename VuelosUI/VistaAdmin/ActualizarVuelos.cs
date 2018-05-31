using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vuelos.DATA;
using Oracle.DataAccess.Client;
using Vuelos.DS.Interfaces;
using Vuelos.DS.Metodos;

namespace VuelosUI.VistaAdmin
{
    public partial class ActualizarVuelos : MetroFramework.Forms.MetroForm
    {
        Piloto PilotoGlobal = new Piloto();
        TipoVuelo TipoVueloGlobal = new TipoVuelo();
        Avion AvionGlobal = new Avion();
       
        public ActualizarVuelos()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
         OracleConnection ora = new OracleConnection("DATA SOURCE =xe;  PASSWORD=ORACLE01; USER ID=DESARROLLO");
        OracleDataAdapter adapt;
            ora.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select * from LISTAACTUALIZARVUELOS", ora);
            adapt.Fill(dt);
            gv_datos.DataSource = dt;
            gv_datos.Columns[0].HeaderText = "Número de Vuelo";
            gv_datos.Columns[1].HeaderText = "Nombre del Piloto";
            gv_datos.Columns[2].HeaderText = "Apellido del piloto";
            gv_datos.Columns[3].HeaderText = "Tipo de Vuelo";
            gv_datos.Columns[4].HeaderText = "Modelo del Avión";
            gv_datos.Columns[5].HeaderText = "Duración del vuelo";
            gv_datos.Columns[6].HeaderText = "Aerolinea";
            gv_datos.Columns[7].HeaderText = "Fecha del Vuelo";
            gv_datos.Columns[8].HeaderText = "Hora de salida";
            gv_datos.Columns[9].HeaderText = "Hora de llegada";
            gv_datos.Columns[10].HeaderText = "Puerta de embargue";
            gv_datos.Columns[11].HeaderText = "Destino";

            ora.Close();
        }

        private void ActualizarVuelos_Load(object sender, EventArgs e)
        {
            
            try
            {

                DisplayData();
 
       
                cbo_nroVuelo.DataSource = Singleton.opVuelos.ListarVuelos().Select(x=>x.NroVuelo).ToList();

            }
            catch
            {
                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Vuelos.DATA.Vuelos> listarVuelo = Singleton.opVuelos.ListarVuelos();
                var vuelo = listarVuelo.FirstOrDefault(x => x.NroVuelo == cbo_nroVuelo.Text);
                //El nombrepiloto va a agarrar el nombre correspondiente al numero de piloto
                var nombrePiloto = Singleton.opPiloto.BuscarPiloto(Convert.ToInt32(vuelo.idPiloto)).Nombre.ToString();
                var tipovuelo = Singleton.optipovuelo.buscarTipoVuelo(Convert.ToInt32(vuelo.idTipoVuelo)).DESCRIPCION.ToString();
                var modeloAvion = Singleton.opavion.BuscarAvion(Convert.ToInt32(vuelo.idAvion)).MODELO.ToString();
                if (vuelo != null)
                {
                    cbo_tipoVuelo.DataSource = Singleton.optipovuelo.ListarTipoVuelos().Select(x => x.DESCRIPCION).ToList();
                    cbomodeloavion.DataSource = Singleton.opavion.ListarAviones().Select(x => x.MODELO).ToList();
                    cbonombrepiloto.DataSource = Singleton.opPiloto.ListarPilotos().Select(x => x.Nombre).ToList();
                 
                    cbonombrepiloto.Text = nombrePiloto;
                    cbomodeloavion.Text = modeloAvion;
                    cbo_tipoVuelo.Text = tipovuelo;
                 
                    txttiempo.Text = vuelo.Duracion_Vuelo;
                    txtaerolinea.Text = vuelo.Aerolinea;
                    dtp_fechaVuelo.Value = Convert.ToDateTime(vuelo.Fecha_Vuelo);
                    dtp_horasalida.Value = Convert.ToDateTime(vuelo.Hora_Salida);
                    dtp_horallegada.Value = Convert.ToDateTime(vuelo.Hora_llegada);
                    txtPuerta.Text = vuelo.Puerta_embarge;

                    
                    

                }


            }
            catch
            {

                MessageBox.Show("Hubo un error");
            }
        }

        private void gv_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdmin ad = new VistaAdmin();
            ad.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                PilotoGlobal = Singleton.opPiloto.buscarPilotoPorNombre(cbonombrepiloto.Text);//Esta linea agarra el nombre del piloto y lo guarda en la variable
                var numeropiloto = PilotoGlobal.idPiloto.ToString(); //esta linea convierte la variable con el nombre y lo convierte en el id correspondiente

                TipoVueloGlobal = Singleton.optipovuelo.BuscarTipoVueloDescripcion(cbo_tipoVuelo.Text);
                var numerotipoVuelo = TipoVueloGlobal.IDTIPOVUELO.ToString();
                
                AvionGlobal = Singleton.opavion.BuscarAvionPorModelo(cbomodeloavion.Text);
                var numeroavion = AvionGlobal.IDAVION.ToString();

                Vuelos.DATA.Vuelos vuelo = new Vuelos.DATA.Vuelos()
                {
                    idPiloto = Convert.ToInt32(numeropiloto),
                    idTipoVuelo = Convert.ToInt32(numerotipoVuelo),
                    idAvion = Convert.ToInt32(numeroavion),
                    Duracion_Vuelo = txttiempo.Text,
                    Aerolinea = txtaerolinea.Text,
                    Fecha_Vuelo=dtp_fechaVuelo.Value,
                    Hora_Salida=dtp_horasalida.Value,
                    Hora_llegada=dtp_horasalida.Value,
                    Puerta_embarge=txtPuerta.Text,
                    NroVuelo=cbo_nroVuelo.Text


                };
                var mensaje = MessageBox.Show("Desea actualizar los datos? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mensaje == DialogResult.Yes)
                {
                    Singleton.opVuelos.ActualizarVuelos(vuelo);
                    MessageBox.Show("Vuelo actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                    limpiar();
                }


            }
            catch
            {
                MessageBox.Show("hubo un error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void limpiar()
        {
            cbonombrepiloto.Text = string.Empty;
            cbo_tipoVuelo.Text = string.Empty;
            cbomodeloavion.Text = string.Empty;
            txttiempo.Text = string.Empty;
            txtaerolinea.Text = string.Empty;
            dtp_fechaVuelo.Text = string.Empty;
            dtp_horasalida.Text = string.Empty;
            dtp_horallegada.Text = string.Empty;
            txtPuerta.Text = string.Empty;
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                var msj = MessageBox.Show("Esta seguro de borrar el vuelo", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (msj == DialogResult.Yes)
                {
                    Singleton.opVuelos.EliminarVuelo(cbo_nroVuelo.Text);
                    MessageBox.Show("El vuelo se ha eliminado correctamente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limpiar();
                    DisplayData();
                    cbo_nroVuelo.DataSource = Singleton.opVuelos.ListarVuelos().Select(x => x.NroVuelo).ToList();

                }
                else
                {
                    MessageBox.Show("Ha cancelado la operacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch
            {
                MessageBox.Show("Hubo un error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
