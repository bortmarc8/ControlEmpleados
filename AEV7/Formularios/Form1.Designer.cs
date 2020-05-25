namespace AEV7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblProfileNIFNoEdit = new System.Windows.Forms.Label();
            this.lblFichaSalida = new System.Windows.Forms.Label();
            this.lblFichaEntrada = new System.Windows.Forms.Label();
            this.lblFichaSalidaNoEdit = new System.Windows.Forms.Label();
            this.lblFichaEntradaNoEdit = new System.Windows.Forms.Label();
            this.lblEdadNoEdit = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblProfileNIF = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.lblReloj = new System.Windows.Forms.Label();
            this.mtxtDNI = new System.Windows.Forms.MaskedTextBox();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnFicharSalida = new System.Windows.Forms.Button();
            this.btnFicharEntrada = new System.Windows.Forms.Button();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnSalirResumen = new System.Windows.Forms.Button();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btnPermanencia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnPermanencia.ForeColor = System.Drawing.Color.White;
            this.btnPermanencia.Image = global::AEV7.Properties.Resources.permanencia;
            this.btnPermanencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermanencia.Location = new System.Drawing.Point(700, 425);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPermanencia.Size = new System.Drawing.Size(370, 80);
            this.btnPermanencia.TabIndex = 4;
            this.btnPermanencia.Text = "    Ver Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = false;
            this.btnPermanencia.Click += new System.EventHandler(this.BtnPermanencia_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(391, 562);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 45);
            this.dtpInicio.TabIndex = 6;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(700, 562);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 45);
            this.dtpFin.TabIndex = 7;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btnMantenimiento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnMantenimiento.Location = new System.Drawing.Point(480, 663);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(370, 80);
            this.btnMantenimiento.TabIndex = 5;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.BtnMantenimiento_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.lblInformacion);
            this.pnlContent.Controls.Add(this.lblProfileNIFNoEdit);
            this.pnlContent.Controls.Add(this.lblFichaSalida);
            this.pnlContent.Controls.Add(this.lblFichaEntrada);
            this.pnlContent.Controls.Add(this.lblFichaSalidaNoEdit);
            this.pnlContent.Controls.Add(this.lblFichaEntradaNoEdit);
            this.pnlContent.Controls.Add(this.lblEdadNoEdit);
            this.pnlContent.Controls.Add(this.lblEdad);
            this.pnlContent.Controls.Add(this.lblProfileNIF);
            this.pnlContent.Controls.Add(this.lblProfileName);
            this.pnlContent.Controls.Add(this.picProfile);
            this.pnlContent.Location = new System.Drawing.Point(1300, 150);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(595, 900);
            this.pnlContent.TabIndex = 8;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblInformacion.ForeColor = System.Drawing.Color.Black;
            this.lblInformacion.Location = new System.Drawing.Point(142, 729);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 46);
            this.lblInformacion.TabIndex = 10;
            // 
            // lblProfileNIFNoEdit
            // 
            this.lblProfileNIFNoEdit.AutoSize = true;
            this.lblProfileNIFNoEdit.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblProfileNIFNoEdit.ForeColor = System.Drawing.Color.Black;
            this.lblProfileNIFNoEdit.Location = new System.Drawing.Point(29, 315);
            this.lblProfileNIFNoEdit.Name = "lblProfileNIFNoEdit";
            this.lblProfileNIFNoEdit.Size = new System.Drawing.Size(92, 46);
            this.lblProfileNIFNoEdit.TabIndex = 9;
            this.lblProfileNIFNoEdit.Text = "DNI:";
            // 
            // lblFichaSalida
            // 
            this.lblFichaSalida.AutoSize = true;
            this.lblFichaSalida.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblFichaSalida.ForeColor = System.Drawing.Color.White;
            this.lblFichaSalida.Location = new System.Drawing.Point(368, 534);
            this.lblFichaSalida.Name = "lblFichaSalida";
            this.lblFichaSalida.Size = new System.Drawing.Size(122, 46);
            this.lblFichaSalida.TabIndex = 8;
            this.lblFichaSalida.Text = "--:--:--";
            // 
            // lblFichaEntrada
            // 
            this.lblFichaEntrada.AutoSize = true;
            this.lblFichaEntrada.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblFichaEntrada.ForeColor = System.Drawing.Color.White;
            this.lblFichaEntrada.Location = new System.Drawing.Point(368, 459);
            this.lblFichaEntrada.Name = "lblFichaEntrada";
            this.lblFichaEntrada.Size = new System.Drawing.Size(122, 46);
            this.lblFichaEntrada.TabIndex = 7;
            this.lblFichaEntrada.Text = "--:--:--";
            // 
            // lblFichaSalidaNoEdit
            // 
            this.lblFichaSalidaNoEdit.AutoSize = true;
            this.lblFichaSalidaNoEdit.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblFichaSalidaNoEdit.ForeColor = System.Drawing.Color.Black;
            this.lblFichaSalidaNoEdit.Location = new System.Drawing.Point(29, 534);
            this.lblFichaSalidaNoEdit.Name = "lblFichaSalidaNoEdit";
            this.lblFichaSalidaNoEdit.Size = new System.Drawing.Size(306, 46);
            this.lblFichaSalidaNoEdit.TabIndex = 6;
            this.lblFichaSalidaNoEdit.Text = "Fichado de Salida:";
            // 
            // lblFichaEntradaNoEdit
            // 
            this.lblFichaEntradaNoEdit.AutoSize = true;
            this.lblFichaEntradaNoEdit.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblFichaEntradaNoEdit.ForeColor = System.Drawing.Color.Black;
            this.lblFichaEntradaNoEdit.Location = new System.Drawing.Point(29, 459);
            this.lblFichaEntradaNoEdit.Name = "lblFichaEntradaNoEdit";
            this.lblFichaEntradaNoEdit.Size = new System.Drawing.Size(333, 46);
            this.lblFichaEntradaNoEdit.TabIndex = 5;
            this.lblFichaEntradaNoEdit.Text = "Fichado de Entrada:";
            // 
            // lblEdadNoEdit
            // 
            this.lblEdadNoEdit.AutoSize = true;
            this.lblEdadNoEdit.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblEdadNoEdit.ForeColor = System.Drawing.Color.Black;
            this.lblEdadNoEdit.Location = new System.Drawing.Point(29, 385);
            this.lblEdadNoEdit.Name = "lblEdadNoEdit";
            this.lblEdadNoEdit.Size = new System.Drawing.Size(107, 46);
            this.lblEdadNoEdit.TabIndex = 4;
            this.lblEdadNoEdit.Text = "Edad:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblEdad.ForeColor = System.Drawing.Color.White;
            this.lblEdad.Location = new System.Drawing.Point(142, 385);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(60, 46);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "21";
            // 
            // lblProfileNIF
            // 
            this.lblProfileNIF.AutoSize = true;
            this.lblProfileNIF.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblProfileNIF.ForeColor = System.Drawing.Color.White;
            this.lblProfileNIF.Location = new System.Drawing.Point(142, 315);
            this.lblProfileNIF.Name = "lblProfileNIF";
            this.lblProfileNIF.Size = new System.Drawing.Size(217, 46);
            this.lblProfileNIF.TabIndex = 2;
            this.lblProfileNIF.Text = "03153156-V";
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.lblProfileName.ForeColor = System.Drawing.Color.White;
            this.lblProfileName.Location = new System.Drawing.Point(26, 34);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(310, 62);
            this.lblProfileName.TabIndex = 1;
            this.lblProfileName.Text = "José Lacueva";
            // 
            // picProfile
            // 
            this.picProfile.Location = new System.Drawing.Point(365, 30);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(200, 200);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            // 
            // tmrReloj
            // 
            this.tmrReloj.Tick += new System.EventHandler(this.TmrReloj_Tick);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblReloj.Location = new System.Drawing.Point(12, 21);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(246, 72);
            this.lblReloj.TabIndex = 9;
            this.lblReloj.Text = "00:00:00";
            // 
            // mtxtDNI
            // 
            this.mtxtDNI.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Bold);
            this.mtxtDNI.Location = new System.Drawing.Point(450, 150);
            this.mtxtDNI.Mask = "00000000-?";
            this.mtxtDNI.Name = "mtxtDNI";
            this.mtxtDNI.Size = new System.Drawing.Size(400, 96);
            this.mtxtDNI.TabIndex = 0;
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btnPresencia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnPresencia.ForeColor = System.Drawing.Color.White;
            this.btnPresencia.Image = global::AEV7.Properties.Resources.presencia;
            this.btnPresencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPresencia.Location = new System.Drawing.Point(230, 425);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPresencia.Size = new System.Drawing.Size(370, 80);
            this.btnPresencia.TabIndex = 3;
            this.btnPresencia.Text = "    Empleados Presentes";
            this.btnPresencia.UseVisualStyleBackColor = false;
            this.btnPresencia.Click += new System.EventHandler(this.BtnPresencia_Click);
            // 
            // btnFicharSalida
            // 
            this.btnFicharSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btnFicharSalida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnFicharSalida.ForeColor = System.Drawing.Color.White;
            this.btnFicharSalida.Image = global::AEV7.Properties.Resources.salir;
            this.btnFicharSalida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFicharSalida.Location = new System.Drawing.Point(700, 300);
            this.btnFicharSalida.Name = "btnFicharSalida";
            this.btnFicharSalida.Size = new System.Drawing.Size(370, 80);
            this.btnFicharSalida.TabIndex = 2;
            this.btnFicharSalida.Text = "Fichar Salida";
            this.btnFicharSalida.UseVisualStyleBackColor = false;
            this.btnFicharSalida.Click += new System.EventHandler(this.BtnFicharSalida_Click);
            // 
            // btnFicharEntrada
            // 
            this.btnFicharEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btnFicharEntrada.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnFicharEntrada.ForeColor = System.Drawing.Color.White;
            this.btnFicharEntrada.Image = global::AEV7.Properties.Resources.entrar;
            this.btnFicharEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFicharEntrada.Location = new System.Drawing.Point(230, 300);
            this.btnFicharEntrada.Name = "btnFicharEntrada";
            this.btnFicharEntrada.Size = new System.Drawing.Size(370, 80);
            this.btnFicharEntrada.TabIndex = 1;
            this.btnFicharEntrada.Text = "Fichar Entrada";
            this.btnFicharEntrada.UseVisualStyleBackColor = false;
            this.btnFicharEntrada.Click += new System.EventHandler(this.BtnFicharEntrada_Click);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 21;
            this.lstEmpleados.Location = new System.Drawing.Point(230, 776);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(840, 256);
            this.lstEmpleados.TabIndex = 10;
            this.lstEmpleados.DoubleClick += new System.EventHandler(this.LstEmpleados_DoubleClick);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLog.Location = new System.Drawing.Point(1300, 32);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(595, 112);
            this.txtLog.TabIndex = 11;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlBackground.Location = new System.Drawing.Point(1300, 150);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(595, 900);
            this.pnlBackground.TabIndex = 12;
            // 
            // btnSalirResumen
            // 
            this.btnSalirResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btnSalirResumen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnSalirResumen.ForeColor = System.Drawing.Color.White;
            this.btnSalirResumen.Location = new System.Drawing.Point(480, 425);
            this.btnSalirResumen.Name = "btnSalirResumen";
            this.btnSalirResumen.Size = new System.Drawing.Size(370, 80);
            this.btnSalirResumen.TabIndex = 13;
            this.btnSalirResumen.Text = "Salir del Resumen";
            this.btnSalirResumen.UseVisualStyleBackColor = false;
            this.btnSalirResumen.Visible = false;
            this.btnSalirResumen.Click += new System.EventHandler(this.BtnSalirResumen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnSalirResumen);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.mtxtDNI);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnFicharSalida);
            this.Controls.Add(this.btnFicharEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFicharEntrada;
        private System.Windows.Forms.Button btnFicharSalida;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.MaskedTextBox mtxtDNI;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblFichaSalida;
        private System.Windows.Forms.Label lblFichaEntrada;
        private System.Windows.Forms.Label lblFichaSalidaNoEdit;
        private System.Windows.Forms.Label lblFichaEntradaNoEdit;
        private System.Windows.Forms.Label lblEdadNoEdit;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblProfileNIF;
        private System.Windows.Forms.Label lblProfileNIFNoEdit;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnSalirResumen;
    }
}

