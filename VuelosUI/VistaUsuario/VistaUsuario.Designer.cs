namespace VuelosUI.VistaUsuario
{
    partial class VistaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaUsuario));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnPaises = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new MetroFramework.Controls.MetroButton();
            this.mtlCambioContraseña = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtlInsertarVuelos = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(13, 20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.BackgroundImage = global::VuelosUI.Properties.Resources.Aeropuerto;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.btnPaises);
            this.splitContainer1.Panel2.Controls.Add(this.btnCerrarSesion);
            this.splitContainer1.Panel2.Controls.Add(this.mtlCambioContraseña);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.mtlInsertarVuelos);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(770, 526);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(198, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vista Usuario";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(216, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 190);
            this.panel1.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "World Map";
            // 
            // btnPaises
            // 
            this.btnPaises.Image = global::VuelosUI.Properties.Resources.paisesMundo;
            this.btnPaises.Location = new System.Drawing.Point(365, 43);
            this.btnPaises.Name = "btnPaises";
            this.btnPaises.Size = new System.Drawing.Size(135, 128);
            this.btnPaises.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPaises.TabIndex = 19;
            this.btnPaises.TabStop = false;
            this.btnPaises.Click += new System.EventHandler(this.btnPaises_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarSesion.Location = new System.Drawing.Point(465, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(42, 22);
            this.btnCerrarSesion.TabIndex = 18;
            this.btnCerrarSesion.UseSelectable = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // mtlCambioContraseña
            // 
            this.mtlCambioContraseña.ActiveControl = null;
            this.mtlCambioContraseña.ForeColor = System.Drawing.Color.Black;
            this.mtlCambioContraseña.Location = new System.Drawing.Point(15, 409);
            this.mtlCambioContraseña.Name = "mtlCambioContraseña";
            this.mtlCambioContraseña.Size = new System.Drawing.Size(185, 100);
            this.mtlCambioContraseña.TabIndex = 4;
            this.mtlCambioContraseña.Text = "Cambio Contraseña";
            this.mtlCambioContraseña.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtlCambioContraseña.TileImage = global::VuelosUI.Properties.Resources.pass3;
            this.mtlCambioContraseña.UseCustomForeColor = true;
            this.mtlCambioContraseña.UseSelectable = true;
            this.mtlCambioContraseña.UseTileImage = true;
            this.mtlCambioContraseña.Click += new System.EventHandler(this.mtlCambioContraseña_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(190, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VuelosUI.Properties.Resources.el_mundo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mtlInsertarVuelos
            // 
            this.mtlInsertarVuelos.ActiveControl = null;
            this.mtlInsertarVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mtlInsertarVuelos.ForeColor = System.Drawing.Color.White;
            this.mtlInsertarVuelos.Location = new System.Drawing.Point(15, 43);
            this.mtlInsertarVuelos.Name = "mtlInsertarVuelos";
            this.mtlInsertarVuelos.Size = new System.Drawing.Size(135, 128);
            this.mtlInsertarVuelos.TabIndex = 0;
            this.mtlInsertarVuelos.Text = "Insertar Vuelos";
            this.mtlInsertarVuelos.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.mtlInsertarVuelos.TileImage = ((System.Drawing.Image)(resources.GetObject("mtlInsertarVuelos.TileImage")));
            this.mtlInsertarVuelos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtlInsertarVuelos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtlInsertarVuelos.UseCustomBackColor = true;
            this.mtlInsertarVuelos.UseCustomForeColor = true;
            this.mtlInsertarVuelos.UseSelectable = true;
            this.mtlInsertarVuelos.UseTileImage = true;
            this.mtlInsertarVuelos.Click += new System.EventHandler(this.mtlInsertarVuelos_Click);
            // 
            // VistaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 552);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "VistaUsuario";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTile mtlInsertarVuelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile mtlCambioContraseña;
        private MetroFramework.Controls.MetroButton btnCerrarSesion;
        private System.Windows.Forms.PictureBox btnPaises;
    }
}