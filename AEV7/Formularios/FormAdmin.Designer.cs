using System.Windows.Forms;

namespace AEV7.Formularios
{
    partial class FormAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tituloAdmin = new System.Windows.Forms.Label();
            this.BtnCerrarApp = new System.Windows.Forms.Button();
            this.BtnSalirMant = new System.Windows.Forms.Button();
            this.BtnInformes = new System.Windows.Forms.Button();
            this.BtnElimEmp = new System.Windows.Forms.Button();
            this.btnAgregarEmp = new System.Windows.Forms.Button();
            this.pnlAdmin1 = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvFichajes = new System.Windows.Forms.DataGridView();
            this.btnInsertarImagen = new System.Windows.Forms.Button();
            this.tbRutaImagen = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbNIF = new System.Windows.Forms.TextBox();
            this.btnVolverAgregarEmp = new System.Windows.Forms.Button();
            this.pnlAdmin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloAdmin
            // 
            this.tituloAdmin.AutoSize = true;
            this.tituloAdmin.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.tituloAdmin.ForeColor = System.Drawing.Color.White;
            this.tituloAdmin.Location = new System.Drawing.Point(2, 16);
            this.tituloAdmin.Name = "tituloAdmin";
            this.tituloAdmin.Size = new System.Drawing.Size(797, 65);
            this.tituloAdmin.TabIndex = 6;
            this.tituloAdmin.Text = "Panel de control de administrador";
            this.tituloAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCerrarApp
            // 
            this.BtnCerrarApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.BtnCerrarApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCerrarApp.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarApp.Location = new System.Drawing.Point(1470, 895);
            this.BtnCerrarApp.Name = "BtnCerrarApp";
            this.BtnCerrarApp.Size = new System.Drawing.Size(370, 80);
            this.BtnCerrarApp.TabIndex = 5;
            this.BtnCerrarApp.Text = "Salir de la aplicación";
            this.BtnCerrarApp.UseVisualStyleBackColor = false;
            this.BtnCerrarApp.Click += new System.EventHandler(this.BtnCerrarApp_Click);
            // 
            // BtnSalirMant
            // 
            this.BtnSalirMant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.BtnSalirMant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSalirMant.ForeColor = System.Drawing.Color.White;
            this.BtnSalirMant.Location = new System.Drawing.Point(1470, 790);
            this.BtnSalirMant.Name = "BtnSalirMant";
            this.BtnSalirMant.Size = new System.Drawing.Size(370, 80);
            this.BtnSalirMant.TabIndex = 4;
            this.BtnSalirMant.Text = "Salir de mantenimiento";
            this.BtnSalirMant.UseVisualStyleBackColor = false;
            this.BtnSalirMant.Click += new System.EventHandler(this.BtnSalirMant_Click);
            // 
            // BtnInformes
            // 
            this.BtnInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.BtnInformes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnInformes.ForeColor = System.Drawing.Color.White;
            this.BtnInformes.Location = new System.Drawing.Point(1470, 319);
            this.BtnInformes.Name = "BtnInformes";
            this.BtnInformes.Size = new System.Drawing.Size(370, 80);
            this.BtnInformes.TabIndex = 2;
            this.BtnInformes.Text = "Generar informes";
            this.BtnInformes.UseVisualStyleBackColor = false;
            this.BtnInformes.Click += new System.EventHandler(this.BtnInformes_Click);
            // 
            // BtnElimEmp
            // 
            this.BtnElimEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.BtnElimEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnElimEmp.ForeColor = System.Drawing.Color.White;
            this.BtnElimEmp.Location = new System.Drawing.Point(1470, 211);
            this.BtnElimEmp.Name = "BtnElimEmp";
            this.BtnElimEmp.Size = new System.Drawing.Size(370, 80);
            this.BtnElimEmp.TabIndex = 1;
            this.BtnElimEmp.Text = "Modificar empleado";
            this.BtnElimEmp.UseVisualStyleBackColor = false;
            this.BtnElimEmp.Click += new System.EventHandler(this.BtnElimEmp_Click);
            // 
            // btnAgregarEmp
            // 
            this.btnAgregarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.btnAgregarEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarEmp.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEmp.Location = new System.Drawing.Point(1470, 105);
            this.btnAgregarEmp.Name = "btnAgregarEmp";
            this.btnAgregarEmp.Size = new System.Drawing.Size(370, 80);
            this.btnAgregarEmp.TabIndex = 0;
            this.btnAgregarEmp.Text = "Agregar empleado";
            this.btnAgregarEmp.UseVisualStyleBackColor = false;
            this.btnAgregarEmp.Click += new System.EventHandler(this.btnAgregarEmp_Click);
            // 
            // pnlAdmin1
            // 
            this.pnlAdmin1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdmin1.Controls.Add(this.dgvEmpleados);
            this.pnlAdmin1.Controls.Add(this.dgvFichajes);
            this.pnlAdmin1.Controls.Add(this.tituloAdmin);
            this.pnlAdmin1.Controls.Add(this.BtnCerrarApp);
            this.pnlAdmin1.Controls.Add(this.BtnSalirMant);
            this.pnlAdmin1.Controls.Add(this.BtnInformes);
            this.pnlAdmin1.Controls.Add(this.BtnElimEmp);
            this.pnlAdmin1.Controls.Add(this.btnAgregarEmp);
            this.pnlAdmin1.Location = new System.Drawing.Point(12, 12);
            this.pnlAdmin1.Name = "pnlAdmin1";
            this.pnlAdmin1.Size = new System.Drawing.Size(1880, 1017);
            this.pnlAdmin1.TabIndex = 7;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeColumns = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.dgvEmpleados.Location = new System.Drawing.Point(13, 84);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(1303, 405);
            this.dgvEmpleados.TabIndex = 9;
            // 
            // dgvFichajes
            // 
            this.dgvFichajes.AllowUserToAddRows = false;
            this.dgvFichajes.AllowUserToDeleteRows = false;
            this.dgvFichajes.AllowUserToResizeColumns = false;
            this.dgvFichajes.AllowUserToResizeRows = false;
            this.dgvFichajes.BackgroundColor = System.Drawing.Color.White;
            this.dgvFichajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFichajes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFichajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichajes.EnableHeadersVisualStyles = false;
            this.dgvFichajes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.dgvFichajes.Location = new System.Drawing.Point(13, 555);
            this.dgvFichajes.Name = "dgvFichajes";
            this.dgvFichajes.ReadOnly = true;
            this.dgvFichajes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFichajes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFichajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFichajes.Size = new System.Drawing.Size(1303, 405);
            this.dgvFichajes.TabIndex = 8;
            // 
            // btnInsertarImagen
            // 
            this.btnInsertarImagen.Location = new System.Drawing.Point(0, 0);
            this.btnInsertarImagen.Name = "btnInsertarImagen";
            this.btnInsertarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarImagen.TabIndex = 0;
            // 
            // tbRutaImagen
            // 
            this.tbRutaImagen.Location = new System.Drawing.Point(0, 0);
            this.tbRutaImagen.Name = "tbRutaImagen";
            this.tbRutaImagen.Size = new System.Drawing.Size(100, 20);
            this.tbRutaImagen.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(0, 0);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 0;
            // 
            // tbPassword2
            // 
            this.tbPassword2.Location = new System.Drawing.Point(68, 331);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.Size = new System.Drawing.Size(226, 20);
            this.tbPassword2.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(68, 269);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(226, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(68, 207);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(226, 20);
            this.tbEdad.TabIndex = 5;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(68, 150);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(226, 20);
            this.tbApellido.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(68, 90);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(226, 20);
            this.tbNombre.TabIndex = 3;
            // 
            // tbNIF
            // 
            this.tbNIF.Location = new System.Drawing.Point(68, 35);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(226, 20);
            this.tbNIF.TabIndex = 2;
            // 
            // btnVolverAgregarEmp
            // 
            this.btnVolverAgregarEmp.Location = new System.Drawing.Point(0, 0);
            this.btnVolverAgregarEmp.Name = "btnVolverAgregarEmp";
            this.btnVolverAgregarEmp.Size = new System.Drawing.Size(75, 23);
            this.btnVolverAgregarEmp.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlAdmin1);
            this.Name = "FormAdmin";
            this.Text = "Form1";
            this.pnlAdmin1.ResumeLayout(false);
            this.pnlAdmin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnInformes;
        private Button BtnElimEmp;
        private Button btnAgregarEmp;
        private Button BtnCerrarApp;
        private Button BtnSalirMant;
        private Label tituloAdmin;
        private Panel pnlAdmin1;
        private Button btnVolverAgregarEmp;
        private TextBox tbNombre;
        private TextBox tbNIF;
        private Button btnInsertarImagen;
        private Button btnInsertar;
        private TextBox tbPassword2;
        private TextBox tbPassword;
        private TextBox tbEdad;
        private TextBox tbApellido;
        private TextBox tbRutaImagen;
        private DataGridView dgvFichajes;
        private DataGridView dgvEmpleados;
    }
}