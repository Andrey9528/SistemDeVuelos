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
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace VuelosUI.VistaAdmin
{
    public partial class Registro_Usuario : MetroFramework.Forms.MetroForm
    {
        public static string contrasena;

        public static Rol RolGlobal = new Rol();
        public Registro_Usuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registro_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> listar = Singleton.opUsuarios.ListarUsuarios();
                var listarUsu = listar.Select(y => new { y.id_rol, y.Nombre, y.Apellidos, y.Correo, y.Direccion, y.Cedula, y.contra });
                gv_datos.DataSource = Singleton.opUsuarios.ListarUsuarios();
                gv_datos.Columns[0].HeaderText = "Número de usuario";
                gv_datos.Columns[1].HeaderText = "Número de rol";
                gv_datos.Columns[2].HeaderText = "Nombre";
                gv_datos.Columns[3].HeaderText = "Apellidos";
                gv_datos.Columns[4].HeaderText = "Correo";
                gv_datos.Columns[5].HeaderText = "Direccion";
                gv_datos.Columns[6].HeaderText = "Contraseña";
                gv_datos.Columns[7].HeaderText = "Cédula";
                var rol=Singleton.opRoles.listarRoles().Select(x => x.Nombre).ToList();
                Rol_comboBox.DataSource = rol;
            }
            catch
            {
                MessageBox.Show("Hubo un error ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
        }
      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtdireccion.Text) || string.IsNullOrEmpty(txtapellidos.Text) || string.IsNullOrEmpty(txcorreo.Text) || string.IsNullOrEmpty(Rol_comboBox.Text))
                {
                    MessageBox.Show("Los campos son requeridos");
                }
                else
                {

                    RolGlobal = Singleton.opRoles.BuscarRolesPorNombre(Rol_comboBox.Text);
                    var idRol = RolGlobal.id_rol.ToString();
                    CodigoPin();
                    Usuario usu = new Usuario()
                    {
                        id_rol = Convert.ToInt32(idRol),
                        Nombre = txtnombre.Text,
                        Apellidos = txtapellidos.Text,
                        Direccion = txtdireccion.Text,
                        Correo = txcorreo.Text,
                        contra = Encriptacion.Encriptar(contrasena, Encriptacion.Llave),
                        Cedula = txtCedula.Text


                    };
                    Singleton.opUsuarios.insertarUsuarios(usu);
                    ThreadStart delegado = new ThreadStart(EnvioCorreo);
                    Thread hilo = new Thread(delegado);
                    hilo.Start();
                    MessageBox.Show("Usuario Agregado con exito y correo enviado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gv_datos.DataSource = Singleton.opUsuarios.ListarUsuarios();
                    txcorreo.Text = string.Empty;
                    txtdireccion.Text = string.Empty;
                    txtapellidos.Text = string.Empty;
                    txtnombre.Text = string.Empty;
                    txtCedula.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

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
                    MailMessage msj = new MailMessage("sistemavuelos@hotmail.com", txcorreo.Text, "Creación de cuenta", "Se ha creado una nueva cuenta para tu usuario:     "+""+txcorreo.Text+"   "+"con la contraseña: "+contrasena+""+"por motivos de seguridad, te recomendamos  cambiar la contraseña una vez que ingrese al sistema");
                    cliente.Send(msj);
                    MessageBox.Show("Correo enviado", "Confirmacion ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void CodigoPin()
        {
            Random rd = new Random(DateTime.Now.Millisecond);
            contrasena = rd.Next(100000, 999999).ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdmin ad = new VistaAdmin();
            ad.Show();
        }
    }
}
