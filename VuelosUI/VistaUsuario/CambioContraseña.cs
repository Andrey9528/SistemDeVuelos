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
    public partial class CambioContraseña : MetroFramework.Forms.MetroForm
    {
        public CambioContraseña()
        {
            InitializeComponent();
        }
        public static bool FormatoContraseña(string contrasena)
        {
            try
            {
                if (MenuLogin.UsuarioGlobal.contra == Encriptacion.Encriptar(contrasena, Encriptacion.Llave))

                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw;
                    
            }
        }


        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormatoContraseña(txtContraseñaActual.Text.ToString()))
                {
                    txtNuevaContraseña.ReadOnly = false;
                    txtconfirmarContraseña.ReadOnly = false;
                    btnActualizar.Enabled = true;
                    btnValidar.Enabled = false;
                    txtContraseñaActual.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch
            {

                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtconfirmarContraseña.Text) || string.IsNullOrEmpty(txtNuevaContraseña.Text))
                {
                    MessageBox.Show("Los campos son requeridos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (txtconfirmarContraseña.Text != txtNuevaContraseña.Text)
                {
                    MessageBox.Show("Los campos deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtconfirmarContraseña.Text == txtNuevaContraseña.Text)
                {


                    Usuario usu = new Usuario()
                    {
                        id_user = MenuLogin.UsuarioGlobal.id_user,
                        id_rol = MenuLogin.UsuarioGlobal.id_rol,
                        Nombre = MenuLogin.UsuarioGlobal.Nombre,
                        Apellidos = MenuLogin.UsuarioGlobal.Apellidos,
                        Correo = MenuLogin.UsuarioGlobal.Correo,
                        Direccion = MenuLogin.UsuarioGlobal.Direccion,
                        contra = Encriptacion.Encriptar(txtNuevaContraseña.Text, Encriptacion.Llave)
                         ,
                        Cedula = MenuLogin.UsuarioGlobal.Cedula
                    };
                    //Debug.WriteLine("This is my password: " + usu.contra);
                    //Debug.WriteLine("This is ID: " + usu.id_user);

                    Singleton.opUsuarios.ActualizarUsuarios(usu);
                   var msj= MessageBox.Show("La contraseña ha sido modificada favor volver a logearse","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    if (msj == DialogResult.OK)
                    {
                        this.Hide();
                        MenuLogin m = new MenuLogin();
                        m.Show();
                    }
                    else
                    {

                    }


                }
            }
            catch
            {

                MessageBox.Show("Hubo un error");

            }
        }

        private void CambioContraseña_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            txtNuevaContraseña.ReadOnly = true;
            txtconfirmarContraseña.ReadOnly = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaUsuario usu = new VistaUsuario();
            usu.Show();
        }
    }
}
