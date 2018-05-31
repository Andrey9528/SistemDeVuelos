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
    public partial class ActualizarDestino :MetroFramework.Forms.MetroForm
    {
        public ActualizarDestino()
        {
            InitializeComponent();
        }

        private void ActualizarDestino_Load(object sender, EventArgs e)
        {
            try
            {
                gv_datos.DataSource = Singleton.opDestino.ListarDestino();
                gv_datos.Columns[0].HeaderText = "Número de destino";
                gv_datos.Columns[1].HeaderText = "Aeropuerto";
                gv_datos.Columns[2].HeaderText = "Ciudad";
                gv_datos.Columns[3].HeaderText = "País";
                gv_datos.Columns[4].HeaderText = "Ubicación de la imagen";
                gv_datos.ForeColor = System.Drawing.Color.Black;
                idDestinoCombobox.DataSource = Singleton.opDestino.ListarDestino().Select(x => x.id_destino).ToList();
                btnActualizar.Enabled = false;
                
            }
            catch
            {
            }                
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Destino> listaDestino = Singleton.opDestino.ListarDestino();
                var destino = listaDestino.FirstOrDefault(x => x.id_destino ==  Convert.ToInt32(idDestinoCombobox.Text));
                if (destino != null)
                {
                    txtAeropuerto.Text = destino.NOMBRE_AEROPUERTO;
                    txtProvincia.Text = destino.CIUDAD;
                    txtPais.Text = destino.Pais;
                    btnActualizar.Enabled = true;
                    PB_imagen.Load(destino.IMAGEN);
                    PB_imagen.SizeMode = PictureBoxSizeMode.CenterImage;

                }
                else
                {
                }
            }
            catch
            {
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Destino destino = new Destino()
                {
                    id_destino=Convert.ToInt32(idDestinoCombobox.Text),
                    NOMBRE_AEROPUERTO=txtAeropuerto.Text,
                    CIUDAD=txtProvincia.Text,
                    Pais=txtPais.Text,
                    IMAGEN=PB_imagen.ImageLocation


                };
                var mensaje = MessageBox.Show("Desea actualizar los datos? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (mensaje == DialogResult.Yes)
                {
                    Singleton.opDestino.ActualizarDestino(destino);
                    MessageBox.Show("Destino actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   gv_datos.DataSource= Singleton.opDestino.ListarDestino();
                    txtAeropuerto.Text = string.Empty;
                    txtProvincia.Text = string.Empty;
                    txtPais.Text = string.Empty;
                    PB_imagen.Image = null;
                }
                

            }
            catch
            {
                
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void gv_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PB_imagen.Image = Image.FromFile(dialog.FileName);
                PB_imagen.ImageLocation = dialog.FileName;
            }
            

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdmin admin = new VistaAdmin();
            admin.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                var msj = MessageBox.Show("Esta seguro de borrar el vuelo", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (msj == DialogResult.Yes)
                {
                    Singleton.opDestino.EliminarDestino(Convert.ToInt32(idDestinoCombobox.Text));
                    MessageBox.Show("El vuelo se ha eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAeropuerto.Text = string.Empty;
                    txtProvincia.Text = string.Empty;
                    txtPais.Text = string.Empty;
                    PB_imagen.Image = null;
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
