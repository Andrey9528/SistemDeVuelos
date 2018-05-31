namespace VuelosUI.VistaUsuario
{
    partial class Paises
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbo_paises = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnReproducirHimno = new MetroFramework.Controls.MetroButton();
            this.btnRegresar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_paises
            // 
            this.cbo_paises.FormattingEnabled = true;
            this.cbo_paises.ItemHeight = 23;
            this.cbo_paises.Location = new System.Drawing.Point(36, 86);
            this.cbo_paises.Name = "cbo_paises";
            this.cbo_paises.Size = new System.Drawing.Size(121, 29);
            this.cbo_paises.TabIndex = 0;
            this.cbo_paises.UseSelectable = true;
            this.cbo_paises.SelectedIndexChanged += new System.EventHandler(this.cbo_paises_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 209);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.LightGray;
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(241, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(409, 221);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnReproducirHimno
            // 
            this.btnReproducirHimno.Location = new System.Drawing.Point(54, 167);
            this.btnReproducirHimno.Name = "btnReproducirHimno";
            this.btnReproducirHimno.Size = new System.Drawing.Size(103, 23);
            this.btnReproducirHimno.TabIndex = 4;
            this.btnReproducirHimno.Text = "Reproducir Himno";
            this.btnReproducirHimno.UseSelectable = true;
            this.btnReproducirHimno.Click += new System.EventHandler(this.btnReproducirHimno_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(54, 223);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(103, 23);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseSelectable = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Paises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 310);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnReproducirHimno);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.cbo_paises);
            this.Name = "Paises";
            this.Text = "Paises";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.LightSteelBlue;
            this.Load += new System.EventHandler(this.Paises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbo_paises;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnReproducirHimno;
        private MetroFramework.Controls.MetroButton btnRegresar;
    }
}