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
using System.Threading;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;

namespace VuelosUI
{
    public partial class OlvideContraseña : MetroFramework.Forms.MetroForm
    {
        Usuario UsuarioGlobal = new Usuario();
        public static string contrasena;
        public OlvideContraseña()
        {
            InitializeComponent();
        }

        private void OlvideContraseña_Load(object sender, EventArgs e)
        {
            try
            {
                btnCambiar.Enabled = false;
                txtconfirmarcontraseña.ReadOnly = true;
                txtnuevacontraseña.ReadOnly = true;
                btnConfirmar.Enabled = false;
                txtpasswordgenerico.ReadOnly = true;
            }
            catch { }
        }

        private void CodigoPin()
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            contrasena = rd.Next(100000, 999999).ToString();
        }

        private void btnValidarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("Correo es requerido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    if (Singleton.opUsuarios.ExisteUsuario(txtCorreo.Text))
                    {
                        UsuarioGlobal = Singleton.opUsuarios.buscarUsuarioCorreo(txtCorreo.Text);
                        CodigoPin();
                        Usuario usu = new Usuario()
                        {
                            id_user = Convert.ToInt32(UsuarioGlobal.id_user),
                            id_rol = Convert.ToInt32(UsuarioGlobal.id_rol),
                            Nombre = UsuarioGlobal.Nombre,
                            Apellidos = UsuarioGlobal.Apellidos,
                            Correo = UsuarioGlobal.Correo,
                            Direccion = UsuarioGlobal.Direccion,
                            contra = Encriptacion.Encriptar(contrasena, Encriptacion.Llave),
                            Cedula = UsuarioGlobal.Cedula


                        };
                        Singleton.opUsuarios.ActualizarUsuarios(usu);
                        ThreadStart InicioHilo = new ThreadStart(EnvioCorreo);
                        Thread hilo = new Thread(InicioHilo);
                        hilo.Start();
                        btnConfirmar.Enabled = true;
                        txtCorreo.ReadOnly = true;
                        txtpasswordgenerico.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Correo invalido", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch
            {
                
               MessageBox.Show("Hubo un error");
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnuevacontraseña.Text) || string.IsNullOrEmpty(txtconfirmarcontraseña.Text))
                {
                    MessageBox.Show("Los campo de contraseña son requeridas");
                }
                else if (txtnuevacontraseña.Text==txtconfirmarcontraseña.Text)
                {
                    Singleton.opUsuarios.buscarUsuarioCorreo(txtCorreo.Text);
                    Usuario usu = new Usuario()
                    {
                        id_user = UsuarioGlobal.id_user,
                        Nombre = UsuarioGlobal.Nombre,
                        Apellidos = UsuarioGlobal.Apellidos,
                        Direccion = UsuarioGlobal.Direccion,
                        Cedula = UsuarioGlobal.Cedula,
                        id_rol = UsuarioGlobal.id_rol,
                        Correo = UsuarioGlobal.Correo,
                        contra = Encriptacion.Encriptar(txtnuevacontraseña.Text, Encriptacion.Llave)
                    };
                    Singleton.opUsuarios.ActualizarUsuarios(usu);
                    MessageBox.Show("Contraseña actualizada", "Cambio de contraseña con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCorreo.Text = string.Empty;
                    txtconfirmarcontraseña.Text = string.Empty;
                    txtpasswordgenerico.Text = string.Empty;
                    txtnuevacontraseña.Text = string.Empty;
                    
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnvioCorreo()
        {
            try
            {

                using (SmtpClient cliente = new SmtpClient("smtp.live.com", 25))
                {
                    cliente.EnableSsl = true;
                    cliente.Credentials = new NetworkCredential("sistemavuelos@hotmail.com", "vuelos123");
                    MailMessage msj = new MailMessage("sistemavuelos@hotmail.com", txtCorreo.Text, "Restauración de contraseña", "Has recibido una nueva contraseña:  " + contrasena + ":" + "Para tu usuario: " + txtCorreo.Text);
                    cliente.Send(msj);
                    MessageBox.Show("Correo enviado ", "Olvidé contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
            }
            catch
            {
                MessageBox.Show("Hubo un error a la hora de enviar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtpasswordgenerico.Text))
                {
                    MessageBox.Show("Password generico es requerido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    UsuarioGlobal = Singleton.opUsuarios.buscarUsuarioCorreo(txtCorreo.Text);
                    var pass = Encriptacion.Decriptar(UsuarioGlobal.contra, Encriptacion.Llave);
                    var pin = txtpasswordgenerico.Text; 
                    if (pin == pass)
                    {
                       
                        var msj = MessageBox.Show("Pin correcto ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (msj == DialogResult.OK)
                        {
                            txtconfirmarcontraseña.ReadOnly = false;
                            txtnuevacontraseña.ReadOnly = false;
                            btnCambiar.Enabled = true;
                            txtpasswordgenerico.Text = string.Empty;
                            btnConfirmar.Enabled = false;
                            txtpasswordgenerico.ReadOnly = true;
                            

                        }

                    }
                    else
                    {
                        MessageBox.Show("pin incorrecto","mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                  
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuLogin me = new MenuLogin();
            me.Show();
        }
    }
}
