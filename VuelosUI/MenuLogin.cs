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

namespace VuelosUI
{
    public partial class MenuLogin  : MetroFramework.Forms.MetroForm
    {
        public static Usuario UsuarioGlobal = new Usuario();
        public static string Correo;
        public MenuLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                validarVacios();
                if (txtcorreo.Text != null && txtcontra.Text != null)
                {


                    if (Singleton.opUsuarios.ExisteUsuario(txtcorreo.Text))
                    {
                        UsuarioGlobal = Singleton.opUsuarios.buscarUsuarioCorreo(txtcorreo.Text);
                        Correo = UsuarioGlobal.Correo;
                        if (UsuarioGlobal.contra == txtcontra.Text && UsuarioGlobal.id_rol == 1)
                        {




                            VistaAdmin.VistaAdmin ad = new VistaAdmin.VistaAdmin();
                            ad.Show();
                            this.Hide();


                        }
                        else if (UsuarioGlobal.contra == txtcontra.Text && UsuarioGlobal.id_rol == 2)
                        {
                            VistaUsuario.frm_user us = new VistaUsuario.frm_user();
                            us.Show();
                            this.Hide();


                        }
                        else if (UsuarioGlobal.Correo == txtcorreo.Text && UsuarioGlobal.contra != txtcontra.Text)
                        {
                            lblmensaje.Text = "Contraseña o Usuario Incorrecta";
                            Vaciar();

                        }
                        else if (UsuarioGlobal.Correo == txtcorreo.Text && string.IsNullOrEmpty(txtcontra.Text))
                        {
                            lblmensaje.Text = "Debe de llenar la contraseña";
                            Vaciar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no existe ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Vaciar();
                    }
                }

            }
            catch
            {
                
            }

        }
        public void Vaciar()
        {
            txtcontra.Text = string.Empty;
            txtcorreo.Text = string.Empty;
        }
        public void validarVacios()

        {
            if (string.IsNullOrEmpty(txtcontra.Text) || string.IsNullOrEmpty(txtcorreo.Text))
            {
                lblmensaje.Text = "Debe llenar los dos campos";
            }
        }

    }
}
