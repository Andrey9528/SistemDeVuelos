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
    public partial class VerPerfil : MetroFramework.Forms.MetroForm
    {
        public VerPerfil()
        {
            InitializeComponent();
        }

        private void VerPerfil_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre:" + MenuLogin.UsuarioGlobal.Nombre;
            lblApellidos.Text = "Apellidos:" + MenuLogin.UsuarioGlobal.Apellidos;
            lblCorreo.Text = "Correo:" + MenuLogin.UsuarioGlobal.Correo;
            lblRol.Text = "Rol" + Singleton.opRoles.BuscarRoles(MenuLogin.UsuarioGlobal.id_rol).Nombre;
            lblCédula.Text = "Cédula:" + MenuLogin.UsuarioGlobal.Cedula;
            lblDireccion.Text = "Direccion:" + MenuLogin.UsuarioGlobal.Direccion;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaAdmin ad = new VistaAdmin();
            ad.Show();
        }
    }
}
