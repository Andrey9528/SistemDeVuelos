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
    public partial class InsertarVuelosDestino : Form
    {
       public static Destino destinoGlobal = new Destino();
        public InsertarVuelosDestino()
        {
            InitializeComponent();
        }

        private void InsertarVuelosDestino_Load(object sender, EventArgs e)
        {
            cbo_destino.DataSource = Singleton.opDestino.ListarDestino().Select(x => x.CIUDAD).ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                destinoGlobal = Singleton.opDestino.BuscarDestinoNombre(cbo_destino.Text);
                var idDestino = destinoGlobal.id_destino.ToString();
                if (string.IsNullOrEmpty(txtNroVuelo.Text))
                {
                    MessageBox.Show("El campo es requerido", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    
                    VuelosDestino vd = new VuelosDestino()
                    {
                        NroVuelo=txtNroVuelo.Text,
                        id_destino=Convert.ToInt32(idDestino)
                        
                    };
                    Singleton.opVuelosDestino.insertarVuelosDestino(vd);
                     var msj= MessageBox.Show("Vuelo destino insertado correctamente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (msj == DialogResult.OK)
                    {
                        this.Hide();
                        InsertarVuelos v = new InsertarVuelos();
                        v.Show();
                    }
                    
                }
            }
            catch
            {

            }
        }
    }
}
