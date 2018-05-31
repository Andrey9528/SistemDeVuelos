namespace VuelosUI.VistaUsuario
{
    partial class InsertarVuelos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.cboNumeroVuelo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnRegresar = new MetroFramework.Controls.MetroButton();
            this.gv_datos = new MetroFramework.Controls.MetroGrid();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuracionVuelo = new MetroFramework.Controls.MetroTextBox();
            this.dtp_horaLlegada = new System.Windows.Forms.DateTimePicker();
            this.dtp_horaSalida = new System.Windows.Forms.DateTimePicker();
            this.txtpuertaEmbargue = new MetroFramework.Controls.MetroTextBox();
            this.txtaerolinea = new MetroFramework.Controls.MetroTextBox();
            this.cbo_modeloAvion = new System.Windows.Forms.ComboBox();
            this.cbo_tipovuelo = new System.Windows.Forms.ComboBox();
            this.cbo_nombrePiloto = new System.Windows.Forms.ComboBox();
            this.dtp_fechaVuelo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscarVuelosNroVuelo = new MetroFramework.Controls.MetroButton();
            this.gv_datosBusquedaVuelo = new MetroFramework.Controls.MetroGrid();
            this.txtBusquedaNroVuelo = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MG_listarVuelosDestino = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregarDestino = new MetroFramework.Controls.MetroButton();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.AeroPueroImagen = new System.Windows.Forms.PictureBox();
            this.txtPais = new MetroFramework.Controls.MetroTextBox();
            this.txtCiudad = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreAeropuerto = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_datos)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_datosBusquedaVuelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MG_listarVuelosDestino)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AeroPueroImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(7, 27);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(686, 459);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cboNumeroVuelo);
            this.metroTabPage1.Controls.Add(this.btnAgregar);
            this.metroTabPage1.Controls.Add(this.btnRegresar);
            this.metroTabPage1.Controls.Add(this.gv_datos);
            this.metroTabPage1.Controls.Add(this.label11);
            this.metroTabPage1.Controls.Add(this.label10);
            this.metroTabPage1.Controls.Add(this.label9);
            this.metroTabPage1.Controls.Add(this.label8);
            this.metroTabPage1.Controls.Add(this.label7);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.txtDuracionVuelo);
            this.metroTabPage1.Controls.Add(this.dtp_horaLlegada);
            this.metroTabPage1.Controls.Add(this.dtp_horaSalida);
            this.metroTabPage1.Controls.Add(this.txtpuertaEmbargue);
            this.metroTabPage1.Controls.Add(this.txtaerolinea);
            this.metroTabPage1.Controls.Add(this.cbo_modeloAvion);
            this.metroTabPage1.Controls.Add(this.cbo_tipovuelo);
            this.metroTabPage1.Controls.Add(this.cbo_nombrePiloto);
            this.metroTabPage1.Controls.Add(this.dtp_fechaVuelo);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(678, 417);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Insertar Vuelos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // cboNumeroVuelo
            // 
            this.cboNumeroVuelo.FormattingEnabled = true;
            this.cboNumeroVuelo.Location = new System.Drawing.Point(190, 55);
            this.cboNumeroVuelo.Name = "cboNumeroVuelo";
            this.cboNumeroVuelo.Size = new System.Drawing.Size(111, 21);
            this.cboNumeroVuelo.TabIndex = 28;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(419, 337);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 40);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(526, 337);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 40);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseSelectable = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gv_datos
            // 
            this.gv_datos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gv_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_datos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gv_datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gv_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_datos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_datos.EnableHeadersVisualStyles = false;
            this.gv_datos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_datos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_datos.Location = new System.Drawing.Point(27, 253);
            this.gv_datos.Name = "gv_datos";
            this.gv_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_datos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_datos.Size = new System.Drawing.Size(377, 150);
            this.gv_datos.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(253, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Registro de Vuelos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Hora llegada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Hora Salida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Puerta de Embargue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Aerolinea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tipo de Vuelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Modelo del Avión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Duración del Vuelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha de Vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre del Piloto";
            // 
            // txtDuracionVuelo
            // 
            // 
            // 
            // 
            this.txtDuracionVuelo.CustomButton.Image = null;
            this.txtDuracionVuelo.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtDuracionVuelo.CustomButton.Name = "";
            this.txtDuracionVuelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDuracionVuelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDuracionVuelo.CustomButton.TabIndex = 1;
            this.txtDuracionVuelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDuracionVuelo.CustomButton.UseSelectable = true;
            this.txtDuracionVuelo.CustomButton.Visible = false;
            this.txtDuracionVuelo.Lines = new string[0];
            this.txtDuracionVuelo.Location = new System.Drawing.Point(467, 55);
            this.txtDuracionVuelo.MaxLength = 32767;
            this.txtDuracionVuelo.Name = "txtDuracionVuelo";
            this.txtDuracionVuelo.PasswordChar = '\0';
            this.txtDuracionVuelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDuracionVuelo.SelectedText = "";
            this.txtDuracionVuelo.SelectionLength = 0;
            this.txtDuracionVuelo.SelectionStart = 0;
            this.txtDuracionVuelo.ShortcutsEnabled = true;
            this.txtDuracionVuelo.Size = new System.Drawing.Size(121, 23);
            this.txtDuracionVuelo.TabIndex = 14;
            this.txtDuracionVuelo.UseSelectable = true;
            this.txtDuracionVuelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDuracionVuelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtp_horaLlegada
            // 
            this.dtp_horaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaLlegada.Location = new System.Drawing.Point(467, 161);
            this.dtp_horaLlegada.Name = "dtp_horaLlegada";
            this.dtp_horaLlegada.Size = new System.Drawing.Size(121, 20);
            this.dtp_horaLlegada.TabIndex = 13;
            // 
            // dtp_horaSalida
            // 
            this.dtp_horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horaSalida.Location = new System.Drawing.Point(467, 123);
            this.dtp_horaSalida.Name = "dtp_horaSalida";
            this.dtp_horaSalida.Size = new System.Drawing.Size(121, 20);
            this.dtp_horaSalida.TabIndex = 12;
            // 
            // txtpuertaEmbargue
            // 
            // 
            // 
            // 
            this.txtpuertaEmbargue.CustomButton.Image = null;
            this.txtpuertaEmbargue.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtpuertaEmbargue.CustomButton.Name = "";
            this.txtpuertaEmbargue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpuertaEmbargue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpuertaEmbargue.CustomButton.TabIndex = 1;
            this.txtpuertaEmbargue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpuertaEmbargue.CustomButton.UseSelectable = true;
            this.txtpuertaEmbargue.CustomButton.Visible = false;
            this.txtpuertaEmbargue.Lines = new string[0];
            this.txtpuertaEmbargue.Location = new System.Drawing.Point(467, 200);
            this.txtpuertaEmbargue.MaxLength = 32767;
            this.txtpuertaEmbargue.Name = "txtpuertaEmbargue";
            this.txtpuertaEmbargue.PasswordChar = '\0';
            this.txtpuertaEmbargue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpuertaEmbargue.SelectedText = "";
            this.txtpuertaEmbargue.SelectionLength = 0;
            this.txtpuertaEmbargue.SelectionStart = 0;
            this.txtpuertaEmbargue.ShortcutsEnabled = true;
            this.txtpuertaEmbargue.Size = new System.Drawing.Size(121, 23);
            this.txtpuertaEmbargue.TabIndex = 11;
            this.txtpuertaEmbargue.UseSelectable = true;
            this.txtpuertaEmbargue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpuertaEmbargue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtaerolinea
            // 
            // 
            // 
            // 
            this.txtaerolinea.CustomButton.Image = null;
            this.txtaerolinea.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.txtaerolinea.CustomButton.Name = "";
            this.txtaerolinea.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtaerolinea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtaerolinea.CustomButton.TabIndex = 1;
            this.txtaerolinea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtaerolinea.CustomButton.UseSelectable = true;
            this.txtaerolinea.CustomButton.Visible = false;
            this.txtaerolinea.Lines = new string[0];
            this.txtaerolinea.Location = new System.Drawing.Point(190, 200);
            this.txtaerolinea.MaxLength = 32767;
            this.txtaerolinea.Name = "txtaerolinea";
            this.txtaerolinea.PasswordChar = '\0';
            this.txtaerolinea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtaerolinea.SelectedText = "";
            this.txtaerolinea.SelectionLength = 0;
            this.txtaerolinea.SelectionStart = 0;
            this.txtaerolinea.ShortcutsEnabled = true;
            this.txtaerolinea.Size = new System.Drawing.Size(111, 23);
            this.txtaerolinea.TabIndex = 10;
            this.txtaerolinea.UseSelectable = true;
            this.txtaerolinea.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtaerolinea.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbo_modeloAvion
            // 
            this.cbo_modeloAvion.FormattingEnabled = true;
            this.cbo_modeloAvion.Location = new System.Drawing.Point(190, 161);
            this.cbo_modeloAvion.Name = "cbo_modeloAvion";
            this.cbo_modeloAvion.Size = new System.Drawing.Size(111, 21);
            this.cbo_modeloAvion.TabIndex = 9;
            // 
            // cbo_tipovuelo
            // 
            this.cbo_tipovuelo.FormattingEnabled = true;
            this.cbo_tipovuelo.Location = new System.Drawing.Point(190, 122);
            this.cbo_tipovuelo.Name = "cbo_tipovuelo";
            this.cbo_tipovuelo.Size = new System.Drawing.Size(111, 21);
            this.cbo_tipovuelo.TabIndex = 8;
            // 
            // cbo_nombrePiloto
            // 
            this.cbo_nombrePiloto.FormattingEnabled = true;
            this.cbo_nombrePiloto.Location = new System.Drawing.Point(190, 90);
            this.cbo_nombrePiloto.Name = "cbo_nombrePiloto";
            this.cbo_nombrePiloto.Size = new System.Drawing.Size(111, 21);
            this.cbo_nombrePiloto.TabIndex = 7;
            // 
            // dtp_fechaVuelo
            // 
            this.dtp_fechaVuelo.Location = new System.Drawing.Point(467, 91);
            this.dtp_fechaVuelo.Name = "dtp_fechaVuelo";
            this.dtp_fechaVuelo.Size = new System.Drawing.Size(121, 20);
            this.dtp_fechaVuelo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de Vuelo";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.btnBuscarVuelosNroVuelo);
            this.metroTabPage2.Controls.Add(this.gv_datosBusquedaVuelo);
            this.metroTabPage2.Controls.Add(this.txtBusquedaNroVuelo);
            this.metroTabPage2.Controls.Add(this.label12);
            this.metroTabPage2.Controls.Add(this.MG_listarVuelosDestino);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(678, 417);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Buscar Vuelos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Número de vuelo";
            // 
            // btnBuscarVuelosNroVuelo
            // 
            this.btnBuscarVuelosNroVuelo.Location = new System.Drawing.Point(254, 33);
            this.btnBuscarVuelosNroVuelo.Name = "btnBuscarVuelosNroVuelo";
            this.btnBuscarVuelosNroVuelo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarVuelosNroVuelo.TabIndex = 7;
            this.btnBuscarVuelosNroVuelo.Text = "Buscar";
            this.btnBuscarVuelosNroVuelo.UseSelectable = true;
            this.btnBuscarVuelosNroVuelo.Click += new System.EventHandler(this.btnBuscarVuelosNroVuelo_Click);
            // 
            // gv_datosBusquedaVuelo
            // 
            this.gv_datosBusquedaVuelo.AllowUserToResizeRows = false;
            this.gv_datosBusquedaVuelo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_datosBusquedaVuelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_datosBusquedaVuelo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_datosBusquedaVuelo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_datosBusquedaVuelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_datosBusquedaVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_datosBusquedaVuelo.DefaultCellStyle = dataGridViewCellStyle6;
            this.gv_datosBusquedaVuelo.EnableHeadersVisualStyles = false;
            this.gv_datosBusquedaVuelo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_datosBusquedaVuelo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_datosBusquedaVuelo.Location = new System.Drawing.Point(56, 134);
            this.gv_datosBusquedaVuelo.Name = "gv_datosBusquedaVuelo";
            this.gv_datosBusquedaVuelo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_datosBusquedaVuelo.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gv_datosBusquedaVuelo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_datosBusquedaVuelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_datosBusquedaVuelo.Size = new System.Drawing.Size(566, 150);
            this.gv_datosBusquedaVuelo.TabIndex = 6;
            // 
            // txtBusquedaNroVuelo
            // 
            // 
            // 
            // 
            this.txtBusquedaNroVuelo.CustomButton.Image = null;
            this.txtBusquedaNroVuelo.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtBusquedaNroVuelo.CustomButton.Name = "";
            this.txtBusquedaNroVuelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBusquedaNroVuelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBusquedaNroVuelo.CustomButton.TabIndex = 1;
            this.txtBusquedaNroVuelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBusquedaNroVuelo.CustomButton.UseSelectable = true;
            this.txtBusquedaNroVuelo.CustomButton.Visible = false;
            this.txtBusquedaNroVuelo.Lines = new string[0];
            this.txtBusquedaNroVuelo.Location = new System.Drawing.Point(119, 33);
            this.txtBusquedaNroVuelo.MaxLength = 32767;
            this.txtBusquedaNroVuelo.Name = "txtBusquedaNroVuelo";
            this.txtBusquedaNroVuelo.PasswordChar = '\0';
            this.txtBusquedaNroVuelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBusquedaNroVuelo.SelectedText = "";
            this.txtBusquedaNroVuelo.SelectionLength = 0;
            this.txtBusquedaNroVuelo.SelectionStart = 0;
            this.txtBusquedaNroVuelo.ShortcutsEnabled = true;
            this.txtBusquedaNroVuelo.Size = new System.Drawing.Size(129, 23);
            this.txtBusquedaNroVuelo.TabIndex = 4;
            this.txtBusquedaNroVuelo.UseSelectable = true;
            this.txtBusquedaNroVuelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBusquedaNroVuelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(501, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Lista de numeros vuelos";
            // 
            // MG_listarVuelosDestino
            // 
            this.MG_listarVuelosDestino.AllowUserToResizeRows = false;
            this.MG_listarVuelosDestino.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MG_listarVuelosDestino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MG_listarVuelosDestino.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MG_listarVuelosDestino.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MG_listarVuelosDestino.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.MG_listarVuelosDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MG_listarVuelosDestino.DefaultCellStyle = dataGridViewCellStyle9;
            this.MG_listarVuelosDestino.EnableHeadersVisualStyles = false;
            this.MG_listarVuelosDestino.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MG_listarVuelosDestino.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MG_listarVuelosDestino.Location = new System.Drawing.Point(435, 33);
            this.MG_listarVuelosDestino.Name = "MG_listarVuelosDestino";
            this.MG_listarVuelosDestino.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MG_listarVuelosDestino.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.MG_listarVuelosDestino.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MG_listarVuelosDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MG_listarVuelosDestino.Size = new System.Drawing.Size(240, 95);
            this.MG_listarVuelosDestino.TabIndex = 2;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.label13);
            this.metroTabPage3.Controls.Add(this.btnAgregarDestino);
            this.metroTabPage3.Controls.Add(this.btnBrowse);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.Controls.Add(this.AeroPueroImagen);
            this.metroTabPage3.Controls.Add(this.txtPais);
            this.metroTabPage3.Controls.Add(this.txtCiudad);
            this.metroTabPage3.Controls.Add(this.txtNombreAeropuerto);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(678, 417);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Insertar Destinos";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(255, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "Insertar Destino";
            // 
            // btnAgregarDestino
            // 
            this.btnAgregarDestino.Location = new System.Drawing.Point(58, 290);
            this.btnAgregarDestino.Name = "btnAgregarDestino";
            this.btnAgregarDestino.Size = new System.Drawing.Size(85, 30);
            this.btnAgregarDestino.TabIndex = 11;
            this.btnAgregarDestino.Text = "Agregar";
            this.btnAgregarDestino.UseSelectable = true;
            this.btnAgregarDestino.Click += new System.EventHandler(this.btnAgregarDestino_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(453, 269);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(113, 34);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(25, 231);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "País";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Aeropuerto";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 178);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Ciudad";
            // 
            // AeroPueroImagen
            // 
            this.AeroPueroImagen.BackColor = System.Drawing.Color.White;
            this.AeroPueroImagen.Location = new System.Drawing.Point(331, 73);
            this.AeroPueroImagen.Name = "AeroPueroImagen";
            this.AeroPueroImagen.Size = new System.Drawing.Size(347, 177);
            this.AeroPueroImagen.TabIndex = 5;
            this.AeroPueroImagen.TabStop = false;
            // 
            // txtPais
            // 
            // 
            // 
            // 
            this.txtPais.CustomButton.Image = null;
            this.txtPais.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtPais.CustomButton.Name = "";
            this.txtPais.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPais.CustomButton.TabIndex = 1;
            this.txtPais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPais.CustomButton.UseSelectable = true;
            this.txtPais.CustomButton.Visible = false;
            this.txtPais.Lines = new string[0];
            this.txtPais.Location = new System.Drawing.Point(165, 227);
            this.txtPais.MaxLength = 32767;
            this.txtPais.Name = "txtPais";
            this.txtPais.PasswordChar = '\0';
            this.txtPais.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPais.SelectedText = "";
            this.txtPais.SelectionLength = 0;
            this.txtPais.SelectionStart = 0;
            this.txtPais.ShortcutsEnabled = true;
            this.txtPais.Size = new System.Drawing.Size(116, 23);
            this.txtPais.TabIndex = 4;
            this.txtPais.UseSelectable = true;
            this.txtPais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCiudad
            // 
            // 
            // 
            // 
            this.txtCiudad.CustomButton.Image = null;
            this.txtCiudad.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtCiudad.CustomButton.Name = "";
            this.txtCiudad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCiudad.CustomButton.TabIndex = 1;
            this.txtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCiudad.CustomButton.UseSelectable = true;
            this.txtCiudad.CustomButton.Visible = false;
            this.txtCiudad.Lines = new string[0];
            this.txtCiudad.Location = new System.Drawing.Point(165, 174);
            this.txtCiudad.MaxLength = 32767;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.PasswordChar = '\0';
            this.txtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCiudad.SelectedText = "";
            this.txtCiudad.SelectionLength = 0;
            this.txtCiudad.SelectionStart = 0;
            this.txtCiudad.ShortcutsEnabled = true;
            this.txtCiudad.Size = new System.Drawing.Size(116, 23);
            this.txtCiudad.TabIndex = 3;
            this.txtCiudad.UseSelectable = true;
            this.txtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCiudad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreAeropuerto
            // 
            // 
            // 
            // 
            this.txtNombreAeropuerto.CustomButton.Image = null;
            this.txtNombreAeropuerto.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtNombreAeropuerto.CustomButton.Name = "";
            this.txtNombreAeropuerto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreAeropuerto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreAeropuerto.CustomButton.TabIndex = 1;
            this.txtNombreAeropuerto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreAeropuerto.CustomButton.UseSelectable = true;
            this.txtNombreAeropuerto.CustomButton.Visible = false;
            this.txtNombreAeropuerto.Lines = new string[0];
            this.txtNombreAeropuerto.Location = new System.Drawing.Point(165, 117);
            this.txtNombreAeropuerto.MaxLength = 32767;
            this.txtNombreAeropuerto.Name = "txtNombreAeropuerto";
            this.txtNombreAeropuerto.PasswordChar = '\0';
            this.txtNombreAeropuerto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreAeropuerto.SelectedText = "";
            this.txtNombreAeropuerto.SelectionLength = 0;
            this.txtNombreAeropuerto.SelectionStart = 0;
            this.txtNombreAeropuerto.ShortcutsEnabled = true;
            this.txtNombreAeropuerto.Size = new System.Drawing.Size(116, 23);
            this.txtNombreAeropuerto.TabIndex = 2;
            this.txtNombreAeropuerto.UseSelectable = true;
            this.txtNombreAeropuerto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreAeropuerto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InsertarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 531);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "InsertarVuelos";
            this.Load += new System.EventHandler(this.InsertarVuelos_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_datos)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_datosBusquedaVuelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MG_listarVuelosDestino)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AeroPueroImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtDuracionVuelo;
        private System.Windows.Forms.DateTimePicker dtp_horaLlegada;
        private System.Windows.Forms.DateTimePicker dtp_horaSalida;
        private MetroFramework.Controls.MetroTextBox txtpuertaEmbargue;
        private MetroFramework.Controls.MetroTextBox txtaerolinea;
        private System.Windows.Forms.ComboBox cbo_modeloAvion;
        private System.Windows.Forms.ComboBox cbo_tipovuelo;
        private System.Windows.Forms.ComboBox cbo_nombrePiloto;
        private System.Windows.Forms.DateTimePicker dtp_fechaVuelo;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnRegresar;
        private MetroFramework.Controls.MetroGrid gv_datos;
        private System.Windows.Forms.ComboBox cboNumeroVuelo;
        private MetroFramework.Controls.MetroGrid MG_listarVuelosDestino;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroButton btnBuscarVuelosNroVuelo;
        private MetroFramework.Controls.MetroGrid gv_datosBusquedaVuelo;
        private MetroFramework.Controls.MetroTextBox txtBusquedaNroVuelo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAgregarDestino;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox AeroPueroImagen;
        private MetroFramework.Controls.MetroTextBox txtPais;
        private MetroFramework.Controls.MetroTextBox txtCiudad;
        private MetroFramework.Controls.MetroTextBox txtNombreAeropuerto;
        private System.Windows.Forms.Label label13;
    }
}