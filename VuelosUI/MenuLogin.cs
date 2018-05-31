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
        //Mi contraseña sara admin y para oracle ORACLE01
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
                        var data = Encriptacion.Encriptar(txtcontra.Text, Encriptacion.Llave);
                        if (UsuarioGlobal.contra == data && UsuarioGlobal.id_rol == 1)
                        {

                        VistaAdmin.VistaAdmin admi = new VistaAdmin.VistaAdmin();
                           admi.Show();
                           this.Hide();
                               
                            Usuario usu = new Usuario()
                            {
                                id_user = UsuarioGlobal.id_user,
                                Correo = UsuarioGlobal.Correo,
                                id_rol = UsuarioGlobal.id_rol,
                                Nombre = UsuarioGlobal.Nombre,
                                Apellidos = UsuarioGlobal.Apellidos,
                                Direccion = UsuarioGlobal.Direccion,
                                //contra=txtcontra.Text,
                                contra = Encriptacion.Encriptar(txtcontra.Text, Encriptacion.Llave),
                                Cedula=UsuarioGlobal.Cedula

                             
                            };
                            //Singleton.opUsuarios.ActualizarUsuarios(usu);
                           
                       

                      

                        }
                        
                        else if (UsuarioGlobal.contra == data && UsuarioGlobal.id_rol == 2)
                        {
                            Encriptacion.Decriptar(UsuarioGlobal.contra, Encriptacion.Llave);
                            Usuario usu = new Usuario()
                            {
                                id_user = UsuarioGlobal.id_user,
                                Correo = UsuarioGlobal.Correo,
                                id_rol = UsuarioGlobal.id_rol,
                                Nombre = UsuarioGlobal.Nombre,
                                Apellidos = UsuarioGlobal.Apellidos,
                                Direccion = UsuarioGlobal.Direccion,
                                contra = Encriptacion.Encriptar(txtcontra.Text, Encriptacion.Llave),
                                Cedula = UsuarioGlobal.Cedula


                            };
                            //Singleton.opUsuarios.ActualizarUsuarios(usu);
                            VistaUsuario.VistaUsuario us = new VistaUsuario.VistaUsuario();
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

        private void lkb_olvide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OlvideContraseña olv = new OlvideContraseña();
            olv.Show();
        }
    }
}
