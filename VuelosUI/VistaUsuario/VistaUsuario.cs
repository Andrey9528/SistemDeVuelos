using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuelosUI.VistaUsuario
{
    public partial class VistaUsuario : MetroFramework.Forms.MetroForm
    {
        // contraseña david
        public VistaUsuario()
        {
            InitializeComponent();
        }

        private void mtlInsertarVuelos_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertarVuelos vuelo = new InsertarVuelos();
            vuelo.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertarPiloto pilo = new InsertarPiloto();
            pilo.Show();


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var msj = MessageBox.Show("Seguro que quieres cerrar sesion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msj == DialogResult.Yes)
            {
                this.Hide();
                MenuLogin ml = new MenuLogin();
                ml.Show();
            }
            else
            {

            }
        }

        private void mtlCambioContraseña_Click(object sender, EventArgs e)
        {
            this.Hide();
            CambioContraseña cambioUsu = new CambioContraseña();
            cambioUsu.Show();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paises p = new Paises();
            p.Show();
        }
    }
}
