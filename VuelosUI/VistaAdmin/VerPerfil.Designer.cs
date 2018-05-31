namespace VuelosUI.VistaAdmin
{
    partial class VerPerfil
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
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblApellidos = new MetroFramework.Controls.MetroLabel();
            this.lblCorreo = new MetroFramework.Controls.MetroLabel();
            this.lblRol = new MetroFramework.Controls.MetroLabel();
            this.lblCédula = new MetroFramework.Controls.MetroLabel();
            this.lblDireccion = new MetroFramework.Controls.MetroLabel();
            this.btnRegresar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "metroLabel1";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(23, 109);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(83, 19);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "metroLabel2";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(179, 79);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(83, 19);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "metroLabel3";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(179, 109);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(83, 19);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "metroLabel4";
            // 
            // lblCédula
            // 
            this.lblCédula.AutoSize = true;
            this.lblCédula.Location = new System.Drawing.Point(337, 79);
            this.lblCédula.Name = "lblCédula";
            this.lblCédula.Size = new System.Drawing.Size(83, 19);
            this.lblCédula.TabIndex = 4;
            this.lblCédula.Text = "metroLabel5";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(337, 109);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 19);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "metroLabel6";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(47, 230);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseSelectable = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // VerPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 276);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCédula);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Name = "VerPerfil";
            this.Text = "VerPerfil";
            this.Load += new System.EventHandler(this.VerPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroLabel lblApellidos;
        private MetroFramework.Controls.MetroLabel lblCorreo;
        private MetroFramework.Controls.MetroLabel lblRol;
        private MetroFramework.Controls.MetroLabel lblCédula;
        private MetroFramework.Controls.MetroLabel lblDireccion;
        private MetroFramework.Controls.MetroButton btnRegresar;
    }
}