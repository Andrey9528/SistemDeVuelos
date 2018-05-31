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
    public partial class ActualizarPerfil : MetroFramework.Forms.MetroForm
    {
        public ActualizarPerfil()
        {
            InitializeComponent();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                txtnombre.Text = MenuLogin.UsuarioGlobal.Nombre;
                txtapellidos.Text = MenuLogin.UsuarioGlobal.Apellidos;
                txtcorreo.Text = MenuLogin.UsuarioGlobal.Correo;
                txtcedula.Text = MenuLogin.UsuarioGlobal.Cedula;
                txtdireccion.Text = MenuLogin.UsuarioGlobal.Direccion;


            }
            catch
            {
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones.ValidarEmail(txtcorreo.Text))
                {
                    Usuario usu = new Usuario()
                    {
                        Nombre = txtnombre.Text,
                        Apellidos = txtapellidos.Text,
                        Cedula = txtcedula.Text,
                        Correo = txtcorreo.Text,
                        Direccion = txtdireccion.Text,
                        id_rol = MenuLogin.UsuarioGlobal.id_rol,
                        contra = MenuLogin.UsuarioGlobal.contra,
                        id_user = MenuLogin.UsuarioGlobal.id_user
                    };
                    Singleton.opUsuarios.ActualizarUsuarios(usu);
                    var msj = MessageBox.Show("Se ha actualizado los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (msj == DialogResult.OK)
                    {
                        this.Hide();
                        VistaAdmin ad = new VistaAdmin();
                        ad.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Correo invalido");
                }
            }
            catch
            {
            }
        }

        
    }
}
