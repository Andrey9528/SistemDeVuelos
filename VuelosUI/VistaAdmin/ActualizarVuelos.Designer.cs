namespace VuelosUI.VistaAdmin
{
    partial class ActualizarVuelos
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
            this.dtp_horasalida = new System.Windows.Forms.DateTimePicker();
            this.dtp_horallegada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_nroVuelo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.txtaerolinea = new System.Windows.Forms.TextBox();
            this.dtp_fechaVuelo = new System.Windows.Forms.DateTimePicker();
            this.txtPuerta = new System.Windows.Forms.TextBox();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.gv_datos = new MetroFramework.Controls.MetroGrid();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_tipoVuelo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbonombrepiloto = new System.Windows.Forms.ComboBox();
            this.cbomodeloavion = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gv_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_horasalida
            // 
            this.dtp_horasalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horasalida.Location = new System.Drawing.Point(525, 156);
            this.dtp_horasalida.Name = "dtp_horasalida";
            this.dtp_horasalida.Size = new System.Drawing.Size(100, 20);
            this.dtp_horasalida.TabIndex = 11;
            // 
            // dtp_horallegada
            // 
            this.dtp_horallegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_horallegada.Location = new System.Drawing.Point(525, 208);
            this.dtp_horallegada.Name = "dtp_horallegada";
            this.dtp_horallegada.Size = new System.Drawing.Size(100, 20);
            this.dtp_horallegada.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(287, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Actualizar Vuelos";
            // 
            // cbo_nroVuelo
            // 
            this.cbo_nroVuelo.FormattingEnabled = true;
            this.cbo_nroVuelo.Location = new System.Drawing.Point(105, 52);
            this.cbo_nroVuelo.Name = "cbo_nroVuelo";
            this.cbo_nroVuelo.Size = new System.Drawing.Size(121, 21);
            this.cbo_nroVuelo.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(24, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(323, 156);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(131, 20);
            this.txttiempo.TabIndex = 20;
            this.txttiempo.Text = "       : hora/s";
            // 
            // txtaerolinea
            // 
            this.txtaerolinea.Location = new System.Drawing.Point(323, 208);
            this.txtaerolinea.Name = "txtaerolinea";
            this.txtaerolinea.Size = new System.Drawing.Size(131, 20);
            this.txtaerolinea.TabIndex = 21;
            // 
            // dtp_fechaVuelo
            // 
            this.dtp_fechaVuelo.Location = new System.Drawing.Point(323, 250);
            this.dtp_fechaVuelo.Name = "dtp_fechaVuelo";
            this.dtp_fechaVuelo.Size = new System.Drawing.Size(131, 20);
            this.dtp_fechaVuelo.TabIndex = 22;
            // 
            // txtPuerta
            // 
            this.txtPuerta.Location = new System.Drawing.Point(525, 250);
            this.txtPuerta.Name = "txtPuerta";
            this.txtPuerta.Size = new System.Drawing.Size(100, 20);
            this.txtPuerta.TabIndex = 24;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(654, 156);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(654, 250);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gv_datos
            // 
            this.gv_datos.AllowUserToResizeRows = false;
            this.gv_datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_datos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_datos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_datos.EnableHeadersVisualStyles = false;
            this.gv_datos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_datos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_datos.Location = new System.Drawing.Point(13, 297);
            this.gv_datos.Name = "gv_datos";
            this.gv_datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_datos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_datos.Size = new System.Drawing.Size(728, 267);
            this.gv_datos.Style = MetroFramework.MetroColorStyle.Green;
            this.gv_datos.TabIndex = 27;
            this.gv_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_datos_CellContentClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 159);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 13);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre del Piloto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tipo de  Vuelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Modelo del avión";
            // 
            // cbo_tipoVuelo
            // 
            this.cbo_tipoVuelo.FormattingEnabled = true;
            this.cbo_tipoVuelo.Location = new System.Drawing.Point(105, 202);
            this.cbo_tipoVuelo.Name = "cbo_tipoVuelo";
            this.cbo_tipoVuelo.Size = new System.Drawing.Size(134, 21);
            this.cbo_tipoVuelo.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Duración";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Aerolinea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Hora Salida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Hora llegada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Puerta ";
            // 
            // cbonombrepiloto
            // 
            this.cbonombrepiloto.FormattingEnabled = true;
            this.cbonombrepiloto.Location = new System.Drawing.Point(105, 156);
            this.cbonombrepiloto.Name = "cbonombrepiloto";
            this.cbonombrepiloto.Size = new System.Drawing.Size(134, 21);
            this.cbonombrepiloto.TabIndex = 38;
            // 
            // cbomodeloavion
            // 
            this.cbomodeloavion.FormattingEnabled = true;
            this.cbomodeloavion.Location = new System.Drawing.Point(104, 242);
            this.cbomodeloavion.Name = "cbomodeloavion";
            this.cbomodeloavion.Size = new System.Drawing.Size(135, 21);
            this.cbomodeloavion.TabIndex = 39;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(654, 204);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 40;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseSelectable = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // ActualizarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 584);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.cbomodeloavion);
            this.Controls.Add(this.cbonombrepiloto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_tipoVuelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gv_datos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtPuerta);
            this.Controls.Add(this.dtp_fechaVuelo);
            this.Controls.Add(this.txtaerolinea);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbo_nroVuelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_horallegada);
            this.Controls.Add(this.dtp_horasalida);
            this.Name = "ActualizarVuelos";
            this.Load += new System.EventHandler(this.ActualizarVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_horasalida;
        private System.Windows.Forms.DateTimePicker dtp_horallegada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_nroVuelo;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.TextBox txtaerolinea;
        private System.Windows.Forms.DateTimePicker dtp_fechaVuelo;
        private System.Windows.Forms.TextBox txtPuerta;
        private MetroFramework.Controls.MetroButton btnActualizar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroGrid gv_datos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_tipoVuelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
       
       
       
        private System.Windows.Forms.DataGridViewTextBoxColumn nROVUELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPILOTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPOVUELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAVIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dURACIONVUELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aEROLINEADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAVUELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORASALIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORALLEGADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUERTAEMBARGEDataGridViewTextBoxColumn;
        
       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbonombrepiloto;
        private System.Windows.Forms.ComboBox cbomodeloavion;
        private MetroFramework.Controls.MetroButton btnBorrar;
    }
}