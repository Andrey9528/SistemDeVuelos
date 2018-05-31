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

namespace VuelosUI.VistaUsuario
{
    public partial class InsertarPiloto : MetroFramework.Forms.MetroForm
    {
        public InsertarPiloto()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Piloto_img.Image= Image.FromFile(dialog.FileName);
                    Piloto_img.ImageLocation = dialog.FileName;
                    Piloto_img.SizeMode = PictureBoxSizeMode.CenterImage;

                }
            } catch
            {
            }
        }

        private void btnAgregarRegistrarPiloto_Click(object sender, EventArgs e)
        {
            try
            {
                if (Piloto_img.Image == null || string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellido.Text) || string.IsNullOrEmpty(txttelefono.Text) || string.IsNullOrEmpty(txtnacionalidad.Text) || string.IsNullOrEmpty(txtcorreo.Text) || string.IsNullOrEmpty(metroDateFecha.Text) || string.IsNullOrEmpty(txtlugarNaci.Text))
                {
                    MessageBox.Show("Los campos son requeridos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Validaciones.ValidarEmail(txtcorreo.Text))
                    {
                        if (Validaciones.EsNumerico(txttelefono.Text))
                        {


                            Piloto pilo = new Piloto()
                            {
                                Cedula = txtCédula.Text,
                                Nombre = txtnombre.Text,
                                Apellido = txtapellido.Text,
                                Telefono = Convert.ToInt32(txttelefono.Text),
                                Nacionalidad = txtnacionalidad.Text,
                                Correo = txtcorreo.Text,
                                Fecha_naci = metroDateFecha.Value,
                                Lugar_Naci = txtlugarNaci.Text,
                                Imagen = Piloto_img.ImageLocation


                            };
                            Singleton.opPiloto.insertarPilotos(pilo);
                            LimpiarCampos();
                            MessageBox.Show("Piloto Insertado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else

                        {
                            MessageBox.Show("El campo teléfono no es valido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo correo no es valido","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                    }

                }

            }
            catch
            {
               
            }
        }
        public void LimpiarCampos()
        {
            txtCédula.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapellido.Text = string.Empty;
            txttelefono.Text = string.Empty;
            txtnacionalidad.Text = string.Empty;
            txtcorreo.Text = string.Empty;
            metroDateFecha.Text = string.Empty;
            txtlugarNaci.Text = string.Empty;
            Piloto_img.Image = null;

        }

        private void btnAgregarTipoLicencia_Click(object sender, EventArgs e)
        {
            try

            {
                if (string.IsNullOrEmpty(txtNúmeroLicencia.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Campos son requeridos");
                }
                else
                {
                    if (Validaciones.EsNumerico(txtNúmeroLicencia.Text))
                    {
                        TipoLicencia tl = new TipoLicencia()
                        {
                            NROLICENCIA = Convert.ToInt32(txtNúmeroLicencia.Text),
                            FECHA_VENCIMIENTO=Convert.ToDateTime(mdt_fechavencimiento.Value),
                            FECHA_EXPEDICION=Convert.ToDateTime(mdt_fechaExpedicion.Value),
                            DESCRIPCION=txtDescripcion.Text
                        };
                        Singleton.optipolicencia.insertarTipoLicencia(tl);
                        txtNúmeroLicencia.Text = string.Empty;
                        mdt_fechaExpedicion.Text = string.Empty;
                        mdt_fechavencimiento.Text = string.Empty;
                        txtDescripcion.Text = string.Empty;
                        MessageBox.Show("Tipo licencia insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            } catch
            {

            }
        }

        private void InsertarPiloto_Load(object sender, EventArgs e)
        {
            try
            {
                gv_datosPilotoLicencia.DataSource = Singleton.opPilotoLicencia.ListarPilotoLicencia();
                gv_datosTipoLicencia.DataSource = Singleton.optipolicencia.ListarTipolicencia();
                cbonombrePiloto.DataSource = Singleton.opPiloto.ListarPilotos().Select(x => x.Nombre).ToList();
                cboTipoLicencia.DataSource = Singleton.optipolicencia.ListarTipolicencia().Select(x => x.DESCRIPCION).ToList();
            }
            catch
            {

            }
        }

        private void cbonombrePiloto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAgregarPilotoLicencia_Click(object sender, EventArgs e)
        {
            try
            {
                Piloto pilo = new Piloto();
                TipoLicencia tl = new TipoLicencia();

                pilo = Singleton.opPiloto.buscarPilotoPorNombre(cbonombrePiloto.Text);
                var idpilo = pilo.idPiloto.ToString();
                tl = Singleton.optipolicencia.buscarPorDescripcion(cboTipoLicencia.Text);
                var idtl = tl.IDTIPOLICENCIA.ToString();
                PilotoLicencia pl = new PilotoLicencia()
                {
                    IDPILOTO = Convert.ToInt32(idpilo),
                    IDTIPOLICENCIA = Convert.ToInt32(idtl)


                };
                Singleton.opPilotoLicencia.insertarPilotoLicencia(pl);
                MessageBox.Show("Piloto licencia insertado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
               

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaUsuario usu = new VistaUsuario();
            usu.Show();
        }
    }
}
