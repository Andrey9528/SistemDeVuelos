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

namespace VuelosUI.VistaAdmin
{
    public partial class ActualizarPiloto :MetroFramework.Forms.MetroForm
    {
        public ActualizarPiloto()
        {
            InitializeComponent();
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {
           

        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarPiloto_Load(object sender, EventArgs e)
        {

            btnActualizar.Enabled = false;
            Piloto_img.Enabled = false;
        }

        private void btnBuscarCedula_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCedula.Text))
                {
                    MessageBox.Show("Cédula es requerida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    List<Piloto> ListaPilotos = Singleton.opPiloto.ListarPilotos();
                    var piloto = ListaPilotos.FirstOrDefault(x => x.Cedula == txtCedula.Text);
                    var fecha = piloto.Fecha_naci.ToString();
                   
                    if (piloto != null)
                    {
                        //byte imageBuffer = (byte)piloto.Imagen;
                    //System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);

                        btnActualizar.Enabled = true;
                        txtidPiloto.ReadOnly = true;
                        txtCedula.ReadOnly = true;
                        txtnombre.Text = piloto.Nombre;
                        txtapellido.Text = piloto.Apellido;
                        txtFechaNacimiento.Value = piloto.Fecha_naci;
                        txtlugarNaci.Text = piloto.Lugar_Naci;
                        txtcorreo.Text = piloto.Correo;
                        txtnacionalidad.Text = piloto.Nacionalidad;
                        txttelefono.Text = piloto.Telefono.ToString(); 
                        txtidPiloto.Text = piloto.idPiloto.ToString();
                        //Piloto_img.Image = Image.FromStream(ms);
                        Piloto_img.Load(piloto.Imagen);

                    }
                    else
                    {
                        MessageBox.Show("Piloto no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //System.IO.MemoryStream ms = new System.IO.MemoryStream();

                //Piloto_img.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                OpenFileDialog dialog = new OpenFileDialog();
                Piloto pilo = new Piloto()
                {
                    Nombre = txtnombre.Text,
                    Apellido = txtapellido.Text,
                    Fecha_naci = txtFechaNacimiento.Value,
                    Lugar_Naci = txtlugarNaci.Text,
                    Telefono = Convert.ToInt32(txttelefono.Text),
                    Correo = txtcorreo.Text,
                    Nacionalidad = txtnacionalidad.Text,
                    idPiloto = Convert.ToInt32(txtidPiloto.Text),
                    Cedula = txtCedula.Text,
                    //Imagen = Convert.ToByte(ms.GetBuffer())
                    Imagen = Piloto_img.ImageLocation                   
                    
                    
                };
                Singleton.opPiloto.ActualizarPilotos(pilo);
                limpiarcampos();
                MessageBox.Show("Piloto Actualizado", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCedula.Focus();
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        public void limpiarcampos()
        {
            txtCedula.Text = string.Empty;
            txtidPiloto.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapellido.Text = string.Empty;
            txtlugarNaci.Text = string.Empty;
            txtnacionalidad.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            txtcorreo.Text = string.Empty;
            txttelefono.Text = string.Empty;
            Piloto_img.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
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
                    Piloto_img.Image = Image.FromFile(dialog.FileName);
                    Piloto_img.ImageLocation = dialog.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Parece que hubo un error");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdmin ad = new VistaAdmin();
            ad.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                var msj = MessageBox.Show("Esta seguro de borrar el vuelo", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (msj == DialogResult.Yes)
                {
                    Singleton.opPiloto.EliminarPiloto(txtCedula.Text);
                    MessageBox.Show("El vuelo se ha eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarcampos();

                }
                else
                {
                    MessageBox.Show("Ha cancelado la operacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch
            {
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
