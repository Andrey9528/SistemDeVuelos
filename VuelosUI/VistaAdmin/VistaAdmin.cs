using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuelosUI.VistaAdmin
{
    public partial class VistaAdmin : MetroFramework.Forms.MetroForm
    { 
        //sara
        public VistaAdmin()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Registro_Usuario use = new Registro_Usuario();
            use.Show();
            this.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ActualizarPerfil perfil = new ActualizarPerfil();
                perfil.Show();

            }
            catch
            {

            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            ActualizarDestino destino = new ActualizarDestino();
            destino.Show();
            this.Hide();
        }

        private void mtl_registrarPiloto_Click(object sender, EventArgs e)
        {
            ActualizarPiloto pilo = new ActualizarPiloto();
            pilo.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CambioContraseña cambio = new CambioContraseña();
            cambio.Show();
            
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActualizarAvion av = new ActualizarAvion();
            av.Show();
        }

        private void mtl_borrarVuelos_Click(object sender, EventArgs e)
        {
            
            VerPerfil p = new VerPerfil();
            p.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var msj = MessageBox.Show(" ¿Quieres cerrar sesión?", "Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msj == DialogResult.Yes)
                {
                    this.Hide();
                    MenuLogin me = new MenuLogin();
                    me.Show();
                }
                else
                {

                }
            }
            catch
            {

            }
        }

        private void mtl_actualizarVuelos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActualizarVuelos ac = new ActualizarVuelos();
            ac.Show();
        }
    }
}
