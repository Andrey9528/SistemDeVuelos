namespace VuelosUI.VistaUsuario
{
    partial class InsertarVuelosDestino
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
            this.txtNroVuelo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbo_destino = new MetroFramework.Controls.MetroComboBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNroVuelo
            // 
            // 
            // 
            // 
            this.txtNroVuelo.CustomButton.Image = null;
            this.txtNroVuelo.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtNroVuelo.CustomButton.Name = "";
            this.txtNroVuelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNroVuelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroVuelo.CustomButton.TabIndex = 1;
            this.txtNroVuelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroVuelo.CustomButton.UseSelectable = true;
            this.txtNroVuelo.CustomButton.Visible = false;
            this.txtNroVuelo.Lines = new string[0];
            this.txtNroVuelo.Location = new System.Drawing.Point(146, 55);
            this.txtNroVuelo.MaxLength = 32767;
            this.txtNroVuelo.Name = "txtNroVuelo";
            this.txtNroVuelo.PasswordChar = '\0';
            this.txtNroVuelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroVuelo.SelectedText = "";
            this.txtNroVuelo.SelectionLength = 0;
            this.txtNroVuelo.SelectionStart = 0;
            this.txtNroVuelo.ShortcutsEnabled = true;
            this.txtNroVuelo.Size = new System.Drawing.Size(119, 23);
            this.txtNroVuelo.TabIndex = 0;
            this.txtNroVuelo.UseSelectable = true;
            this.txtNroVuelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroVuelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(26, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Número de Vuelo";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.Location = new System.Drawing.Point(36, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Destino";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // cbo_destino
            // 
            this.cbo_destino.FormattingEnabled = true;
            this.cbo_destino.ItemHeight = 23;
            this.cbo_destino.Location = new System.Drawing.Point(144, 114);
            this.cbo_destino.Name = "cbo_destino";
            this.cbo_destino.Size = new System.Drawing.Size(121, 29);
            this.cbo_destino.TabIndex = 5;
            this.cbo_destino.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(26, 203);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 27);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insertar Vuelos Destino";
            // 
            // InsertarVuelosDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbo_destino);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNroVuelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertarVuelosDestino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InsertarVuelosDestino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNroVuelo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbo_destino;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.Label label1;
    }
}