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
    public partial class ActualizarAvion : MetroFramework.Forms.MetroForm
    {
        public ActualizarAvion()
        {
            InitializeComponent();
        }

        private void txtnumeroavion_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pb_avion == null || string.IsNullOrEmpty(txtnumeroavion.Text) || string.IsNullOrEmpty(txtmodelo.Text) || string.IsNullOrEmpty(dtptiempovuelo.Text))
                {
                    MessageBox.Show("Campos son requeridos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Avion av = new Avion()
                    {
                        NRO_PLACA=txtnumeroavion.Text,
                        MODELO=txtmodelo.Text,
                        TIEMPO_VUELO=Convert.ToDateTime(dtptiempovuelo.Value),
                        IMAGEN=pb_avion.ImageLocation
                    };
                    Singleton.opavion.insertarAvion(av);
                    MessageBox.Show("El avion se insetó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnumeroavion.Text = string.Empty;
                    txtmodelo.Text = string.Empty;
                    dtptiempovuelo.Text = string.Empty;
                    pb_avion.Image = null;
                    mostradatos();
                    
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pb_avion.Image = Image.FromFile(dialog.FileName);
                    pb_avion.ImageLocation = dialog.FileName;
                    pb_avion.SizeMode = PictureBoxSizeMode.CenterImage;


                }

            }

            catch
            {
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ActualizarAvion_Load(object sender, EventArgs e)
        {
            try
            {
                mostradatos();
                txtidavion.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void mostradatos()
        {
            try
            {
                gv_datos.DataSource = Singleton.opavion.ListarAviones();
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
      
        

        private void gv_datos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtidavion.Text = gv_datos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtnumeroavion.Text = gv_datos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtmodelo.Text = gv_datos.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtptiempovuelo.Value = Convert.ToDateTime(gv_datos.Rows[e.RowIndex].Cells[3].Value.ToString());
                pb_avion.ImageLocation = gv_datos.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pb_avion == null || string.IsNullOrEmpty(txtnumeroavion.Text) || string.IsNullOrEmpty(txtmodelo.Text) || string.IsNullOrEmpty(dtptiempovuelo.Text))
                {
                    MessageBox.Show("Campos son requeridos ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var msj = MessageBox.Show("¿Desea actualizar los datos?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msj == DialogResult.Yes)
                    {
                        Avion av = new Avion()
                        {
                            IDAVION = Convert.ToInt32(txtidavion.Text),
                            MODELO = txtmodelo.Text,
                            IMAGEN = pb_avion.ImageLocation,
                            NRO_PLACA = txtnumeroavion.Text,
                            TIEMPO_VUELO = dtptiempovuelo.Value

                        };
                        Singleton.opavion.ActualizarAvion(av);
                        MessageBox.Show("Se ha actualizado los datos ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnumeroavion.Text = string.Empty;
                        txtmodelo.Text = string.Empty;
                        dtptiempovuelo.Text = string.Empty;
                        pb_avion.Image = null;
                        txtidavion.Text = string.Empty;
                        mostradatos();
                    }
                    else
                    {
                        MessageBox.Show("Ha cancelado la operacion!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                var msj = MessageBox.Show("¿Esta seguro de borrar los datos?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msj == DialogResult.Yes)
                {
                    Singleton.opavion.EliminarAvion(Convert.ToInt32(txtidavion.Text));
                    MessageBox.Show("Se ha borrado los datos correctamente!", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostradatos();
                }
                else
                {
                    MessageBox.Show("Ha cancelado la operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            catch
            {
                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdmin ad = new VistaAdmin();
            ad.Show();
        }
    }
}
