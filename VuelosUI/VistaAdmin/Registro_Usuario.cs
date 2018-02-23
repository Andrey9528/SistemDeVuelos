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
               
                var rol=Singleton.opRoles.listarRoles().Select(x => x.Nombre).ToList();
                Rol_comboBox.DataSource = rol;
            }
            catch
            {
                
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                RolGlobal = Singleton.opRoles.BuscarRolesPorNombre(Rol_comboBox.Text);
                var idRol = RolGlobal.id_rol.ToString();
                Usuario usu = new Usuario()
                {
                    id_rol = Convert.ToInt32(idRol),
                    Nombre = txtnombre.Text,
                    Apellidos = txtapellidos.Text,
                    Direccion = txtdireccion.Text,
                    Correo = txcorreo.Text,
                    contra = "123"
                    ,Cedula=txtCedula.Text


                };
                Singleton.opUsuarios.insertarUsuarios(usu);
                MessageBox.Show("Usuario Agregado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gv_datos.DataSource = Singleton.opUsuarios.ListarUsuarios();
                txcorreo.Text = string.Empty;
                txtdireccion.Text = string.Empty;
                txtapellidos.Text = string.Empty;
                txtnombre.Text = string.Empty;
                txtCedula.Text = string.Empty;
            }
            catch
            {

            }
        }
    }
}
