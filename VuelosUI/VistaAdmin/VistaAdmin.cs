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
    }
}
