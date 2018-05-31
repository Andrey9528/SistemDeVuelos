using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Vuelos.DATA;

namespace VuelosUI.VistaUsuario
{
    public partial class InsertarVuelos : MetroFramework.Forms.MetroForm
    {
        public static Piloto piloGlobal = new Piloto();
        public static TipoVuelo TipovueloGlobal = new TipoVuelo();
        public static VuelosDestino vuelosDestino = new VuelosDestino();
        public static Avion avionGlobal = new Avion();
        public InsertarVuelos()
        {
            InitializeComponent();
        }
        private void ListarVuelosDestino()
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE =xe;  PASSWORD=ORACLE01; USER ID=DESARROLLO");
            OracleDataAdapter adapt;
            ora.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select * from listarVUELOSDESTINO;", ora);
            adapt.Fill(dt);
            MG_listarVuelosDestino.DataSource= dt;
            

            ora.Close();
        }

        private void DisplayData()
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE =xe;  PASSWORD=ORACLE01; USER ID=DESARROLLO");
            OracleDataAdapter adapt;
            ora.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select *  from LISTARVUELOS;", ora);
            adapt.Fill(dt);
            gv_datos.DataSource = dt;
            gv_datos.Columns[0].HeaderText = "Destino";
            gv_datos.Columns[1].HeaderText = "Nombre del Aeropuerto";
            gv_datos.Columns[2].HeaderText = "Tipo de viaje";
            gv_datos.Columns[3].HeaderText = "Número de placa";
            gv_datos.Columns[4].HeaderText = "Hora de llegada";
            gv_datos.Columns[5].HeaderText = "Hora de salida";
            gv_datos.Columns[6].HeaderText = "Aerolinea";
            gv_datos.Columns[7].HeaderText = "Fecha del vuelo";
            gv_datos.Columns[8].HeaderText = "Duracion del vuelo";
            gv_datos.Columns[9].HeaderText = "Puerta de embargue";
           

            ora.Close();
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cboNumeroVuelo.Text) || string.IsNullOrEmpty(txtaerolinea.Text) || string.IsNullOrEmpty(txtDuracionVuelo.Text) || string.IsNullOrEmpty(txtpuertaEmbargue.Text))
                {
                    MessageBox.Show("Los campos deben de estar lleno", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    piloGlobal = Singleton.opPiloto.buscarPilotoPorNombre(cbo_nombrePiloto.Text);
                    var idpiloto = piloGlobal.idPiloto.ToString();
                    TipovueloGlobal = Singleton.optipovuelo.BuscarTipoVueloDescripcion(cbo_tipovuelo.Text);
                    var idtipovuelo = TipovueloGlobal.IDTIPOVUELO.ToString();
                    avionGlobal = Singleton.opavion.BuscarAvionPorModelo(cbo_modeloAvion.Text);
                    var idavion = avionGlobal.IDAVION.ToString();
                    
                    
        
                    Vuelos.DATA.Vuelos vuelos = new Vuelos.DATA.Vuelos
                    {
                        NroVuelo=cboNumeroVuelo.Text,
                        idPiloto=Convert.ToInt32(idpiloto),
                        idTipoVuelo=Convert.ToInt32(idtipovuelo),
                        idAvion=Convert.ToInt32(idavion),
                        Duracion_Vuelo=txtDuracionVuelo.Text,
                        Aerolinea=txtaerolinea.Text,
                        Fecha_Vuelo=Convert.ToDateTime(dtp_fechaVuelo.Value),
                        Hora_Salida=Convert.ToDateTime(dtp_horaSalida.Value),
                        Hora_llegada=Convert.ToDateTime(dtp_horaLlegada.Value),
                        Puerta_embarge=txtpuertaEmbargue.Text

                        

                    };
                    Singleton.opVuelos.insertarVuelos(vuelos);
                    MessageBox.Show("Vuelo insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DisplayData();

                }
                  
            }
            catch
            {
               
                MessageBox.Show("Hubo un error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarVuelos_Load(object sender, EventArgs e)
        {
            try
            {
                ListarVuelosDestino();
                DisplayData();
                cbo_nombrePiloto.DataSource = Singleton.opPiloto.ListarPilotos().Select(x => x.Nombre).ToList();
                cbo_modeloAvion.DataSource = Singleton.opavion.ListarAviones().Select(x => x.MODELO).ToList();
                cbo_tipovuelo.DataSource = Singleton.optipovuelo.ListarTipoVuelos().Select(x => x.DESCRIPCION).ToList();
                cboNumeroVuelo.DataSource = Singleton.opVuelosDestino.ListarVuelosDestino().Select(x => x.NroVuelo).ToList();
            }
            catch
            {

            }
        }

        public void LimpiarCampos()
        {
            cboNumeroVuelo.Text = string.Empty;
            cbo_nombrePiloto.Text = string.Empty;
            cbo_tipovuelo.Text = string.Empty;
            cbo_modeloAvion.Text = string.Empty;
            txtaerolinea.Text = string.Empty;
            txtDuracionVuelo.Text = string.Empty;
            dtp_fechaVuelo.Text = string.Empty;
            dtp_horaSalida.Text = string.Empty;
            dtp_horaLlegada.Text = string.Empty;
            txtpuertaEmbargue.Text = string.Empty;

        }

        private void btnBuscarVuelosNroVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                Vuelos.DATA.Vuelos vue = new Vuelos.DATA.Vuelos();
                vue = Singleton.opVuelos.buscarVueloNumero(txtBusquedaNroVuelo.Text);
                if (Singleton.opVuelos.ExisteVuelo(txtBusquedaNroVuelo.Text))
                {
                    if (vue != null)
                    {
                        OracleConnection ora = new OracleConnection("DATA SOURCE =xe;  PASSWORD=ORACLE01; USER ID=DESARROLLO");
                        OracleDataAdapter adapt;
                        ora.Open();
                        DataTable dt = new DataTable();
                        adapt = new OracleDataAdapter("select v.NROVUELO,p.NOMBRE as ,av.MODELO ,v.AEROLINEA ,v.FECHA_VUELO ,v.HORA_SALIDA ,v.HORA_LLEGADA ,v.PUERTA_EMBARGE ,d.CIUDAD from VUELOS v , Piloto p, AVION av, Destino d, VUELOSDESTINO vd where v.IDPILOTO = p.IDPILOTO and v.IDAVION = av.IDAVION and d.ID_DESTINO = vd.ID_DESTINO and v.NROVUELO = vd.NROVUELO and   v.NROVUELO='" + txtBusquedaNroVuelo.Text + "'", ora);
                        adapt.Fill(dt);
                        gv_datosBusquedaVuelo.DataSource = dt;
                        gv_datosBusquedaVuelo.Columns[0].HeaderText = "Número de Vuelo";
                        gv_datosBusquedaVuelo.Columns[1].HeaderText = "Nombre del Piloto";
                        gv_datosBusquedaVuelo.Columns[2].HeaderText = "Modelo avion";
                        gv_datosBusquedaVuelo.Columns[3].HeaderText = "Aerolinea";
                        gv_datosBusquedaVuelo.Columns[4].HeaderText = "Fecha del vuelo";
                        gv_datosBusquedaVuelo.Columns[5].HeaderText = "Hora de salida";
                        gv_datosBusquedaVuelo.Columns[6].HeaderText = "Hora de llegada";
                        gv_datosBusquedaVuelo.Columns[7].HeaderText = "Puerta de embargue";
                        gv_datosBusquedaVuelo.Columns[8].HeaderText = "Destino";
                       
                        ora.Close();
                       

                    }
                    else
                    {
                        MessageBox.Show("Vuelo no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
               
            }

            }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
               AeroPueroImagen.Image = Image.FromFile(dialog.FileName);
               AeroPueroImagen.ImageLocation = dialog.FileName;
            }
        }

        private void btnAgregarDestino_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreAeropuerto.Text) || string.IsNullOrEmpty(txtCiudad.Text) || string.IsNullOrEmpty(txtPais.Text) || AeroPueroImagen.ImageLocation == null)
                {
                    MessageBox.Show("Debe llenar los campos requeridos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Destino desti = new Destino()
                    {
                        NOMBRE_AEROPUERTO=txtNombreAeropuerto.Text,
                        CIUDAD=txtCiudad.Text,
                        Pais=txtPais.Text,
                        IMAGEN=AeroPueroImagen.ImageLocation
                        
                    };
                    Singleton.opDestino.InsertarDestino(desti);
                    var msj = MessageBox.Show("Destino Insertado proceda a insertar el número de vuelo", "Atencion", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    if (msj == DialogResult.OK)
                    {
                        this.Hide();
                        InsertarVuelosDestino insertar = new InsertarVuelosDestino();
                        insertar.Show();
                    }
                }

            }
            catch
            {

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaUsuario usu = new VistaUsuario();
            usu.Show();
        }
    }
}
