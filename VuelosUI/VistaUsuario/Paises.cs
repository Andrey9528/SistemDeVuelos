using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace VuelosUI.VistaUsuario
{
    public partial class Paises :MetroFramework.Forms.MetroForm
    {
        SoundPlayer himno;
        public Paises()
        {
            InitializeComponent();
        }

        private void Paises_Load(object sender, EventArgs e)
        {
            var paises= Singleton.opDestino.ListarDestino().Select(x => x.Pais).ToList();
            cbo_paises.DataSource = paises;
            
        }
        

        private void cbo_paises_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_paises.Text == "Russia")
                {
                    var request = System.Net.WebRequest.Create("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWE9MQZGxCYkF_jJmPHIJmmYhTzeIrdPwXN6lQir2qHpqQmb3o7Q ");

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }



                }
                else if (cbo_paises.Text == "Arabia Saudita")
                {
                    var request = System.Net.WebRequest.Create("https://i.ytimg.com/vi/lTF-G3RXALA/maxresdefault.jpg");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "Egipto")
                {
                    var request = System.Net.WebRequest.Create("http://www.banderas-mundo.es/data/flags/big/eg.png");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Uruguay")
                {
                    var request = System.Net.WebRequest.Create("  https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTmf_Uc4Ohn4Wl743x5PvSznebi92tlBrVz060J6Ms8Y2DJFFR_");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "Portugal")
                {
                    var request = System.Net.WebRequest.Create(" http://www.banderas-mundo.es/data/flags/ultra/pt.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "España")
                {
                    var request = System.Net.WebRequest.Create(" https://www.worldflags.es/imagenes/productos/972p_ESPANA.jpg ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "Marruecos")
                {
                    var request = System.Net.WebRequest.Create("http://simbologiadelmundo.com/wp-content/uploads/2016/06/r-Marruecos.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "Iran")
                {
                    var request = System.Net.WebRequest.Create(" https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTLocCbbb0V01o9tamcl3_e__IP5Xvji1QdIIwX2EtbH3Lp0PjuQ ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "Francia")
                {
                    var request = System.Net.WebRequest.Create(" https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQciWLCQvlJD5n7ItcQbkphfYEJvAO7tZy-9yojMGvfXM0HPe9 ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Australia")
                {
                    var request = System.Net.WebRequest.Create(" http://flags.fmcdn.net/data/flags/w580/au.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Peru")
                {
                    var request = System.Net.WebRequest.Create("https://upload.wikimedia.org/wikipedia/commons/c/c1/Bandera_Flag_Per%C3%BA_03a.png"); using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Dinamarca")
                {
                    var request = System.Net.WebRequest.Create(" http://flags.fmcdn.net/data/flags/w580/dk.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Argentina")
                {
                    var request = System.Net.WebRequest.Create("https://i.ytimg.com/vi/IcQqT2U0zXM/maxresdefault.jpg ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Iceland")
                {
                    var request = System.Net.WebRequest.Create("http://flags.fmcdn.net/data/flags/w580/is.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Croatia")
                {
                    var request = System.Net.WebRequest.Create("https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Croatia.svg/2000px-Flag_of_Croatia.svg.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Nigeria")
                {
                    var request = System.Net.WebRequest.Create("https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/Flag_of_Nigeria.svg/2000px-Flag_of_Nigeria.svg.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Brasil")
                {
                    var request = System.Net.WebRequest.Create("http://flags.fmcdn.net/data/flags/w580/br.png");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Switzerland")
                {
                    var request = System.Net.WebRequest.Create("http://capitalradio.es/wp-content/uploads/2014/11/Suiza_Flag_Bandera.jpg ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Serbia")
                {
                    var request = System.Net.WebRequest.Create("http://www.banderas-mundo.es/data/flags/big/rs.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "Costa Rica")
                {
                    var request = System.Net.WebRequest.Create("https://images.visitarcostarica.com/bandera-de-costa-rica.jpg ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Germany")
                {
                    var request = System.Net.WebRequest.Create("https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/Flag_of_Germany.svg/1280px-Flag_of_Germany.svg.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "México")
                {
                    var request = System.Net.WebRequest.Create("https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/Flag_of_Mexico_%281934-1968%29.svg/1280px-Flag_of_Mexico_%281934-1968%29.svg.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "South korea")
                {
                    var request = System.Net.WebRequest.Create("https://i.pinimg.com/originals/19/7b/aa/197baa9dbe7daf69f2530417b59fb376.jpg");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Suecia")
                {
                    var request = System.Net.WebRequest.Create("http://flags.fmcdn.net/data/flags/w580/se.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Belgica")
                {
                    var request = System.Net.WebRequest.Create("http://www.banderas.club/imagenes/1/original/8201459166423-bandera-de-belgica.jpg ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "Panama")
                {
                    var request = System.Net.WebRequest.Create("  http://flags.fmcdn.net/data/flags/w580/pa.png");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Tunez")
                {
                    var request = System.Net.WebRequest.Create("https://www.viajejet.com/wp-content/viajes/bandera-de-tunez.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "England")
                {
                    var request = System.Net.WebRequest.Create("https://www.viajejet.com/wp-content/viajes/bandera-de-inglaterra-400x240.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "Poland")
                {
                    var request = System.Net.WebRequest.Create("http://flags.fmcdn.net/data/flags/w580/pl.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else if (cbo_paises.Text == "Senegal")
                {
                    var request = System.Net.WebRequest.Create("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxyMz8Rl8EPTWdaf1mAtFvO_eiw1CbEpuiRVAUB2fcOR7iZ6X3NA ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "Colombia")
                {
                    var request = System.Net.WebRequest.Create("http://flags.fmcdn.net/data/flags/w580/co.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (cbo_paises.Text == "Japón")
                {

                    var request = System.Net.WebRequest.Create("http://flags.fmcdn.net/data/flags/w580/jp.png ");
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        pictureBox1.Image = Bitmap.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Hubo un error");
            }
        }

     
        private void btnReproducirHimno_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_paises.Text == "Russia")
                {

                    //himno = new SoundPlayer(Application.StartupPath + @"\son\Russia.wav");
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Russia.wav");
                    himno.Play();

                }
                else if (cbo_paises.Text == "Arabia Saudita")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\ArabiaSaudita.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Uruguay")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Uruguay.wav");

                    himno.Play();

                }
                else if (cbo_paises.Text == "Egipto")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Egipto.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Portugal")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Portugal.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "España")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\España.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Marruecos")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Morocco.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Iran")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Iran.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Francia")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Francia.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Australia")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Australia.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Peru")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Peru.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Dinamarca")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Dinamarca.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Argentina")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Argentina.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Iceland")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Islandia.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Croatia")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Croacia.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Nigeria")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Nigeria.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Brasil")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Brasil.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Switzerland")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Suiza.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Costa Rica")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\CostaRica.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Serbia")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Serbia.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Germany")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Alemania.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "México")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Mexico.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Suecia")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Sweden.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "South korea")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\CoreaSur.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Belgica")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Belgica.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Panama")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Panama.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Tunez")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Tunez.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "England")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\England.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Poland")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Polonia.wav");

                    himno.Play();

                }
                else if (cbo_paises.Text == "Senegal")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Senegal.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Colombia")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Colombia.wav");

                    himno.Play();
                }
                else if (cbo_paises.Text == "Japón")
                {
                    himno = new SoundPlayer(@"C:\Users\Toshiba\Pictures\SistemaVuelos\himnos\Japon.wav");

                    himno.Play();

                }
            }
            catch
            {
                MessageBox.Show("Hubo un error");
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            VistaUsuario usu = new VistaUsuario();
            usu.Show();
        }
    }
}
