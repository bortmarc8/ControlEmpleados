namespace AEV7.Formularios
{
    partial class FormAddUser
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
            this.pnlAgregarEmp = new System.Windows.Forms.Panel();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblRutaImagen = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.mtxtNIF = new System.Windows.Forms.MaskedTextBox();
            this.btnInsertarImagen = new System.Windows.Forms.Button();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnVolverAgregarEmp = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.pnlAgregarEmp.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAgregarEmp
            // 
            this.pnlAgregarEmp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAgregarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(250)))));
            this.pnlAgregarEmp.Controls.Add(this.pnlBackground);
            this.pnlAgregarEmp.Controls.Add(this.btnVolverAgregarEmp);
            this.pnlAgregarEmp.Controls.Add(this.btnInsertar);
            this.pnlAgregarEmp.Controls.Add(this.lblRutaImagen);
            this.pnlAgregarEmp.Controls.Add(this.lblPassword2);
            this.pnlAgregarEmp.Controls.Add(this.lblPassword);
            this.pnlAgregarEmp.Controls.Add(this.lblEdad);
            this.pnlAgregarEmp.Controls.Add(this.lblApellido);
            this.pnlAgregarEmp.Controls.Add(this.lblNombre);
            this.pnlAgregarEmp.Controls.Add(this.lblNIF);
            this.pnlAgregarEmp.Controls.Add(this.mtxtNIF);
            this.pnlAgregarEmp.Controls.Add(this.btnInsertarImagen);
            this.pnlAgregarEmp.Controls.Add(this.txtRutaImagen);
            this.pnlAgregarEmp.Controls.Add(this.txtPassword2);
            this.pnlAgregarEmp.Controls.Add(this.txtPassword);
            this.pnlAgregarEmp.Controls.Add(this.txtEdad);
            this.pnlAgregarEmp.Controls.Add(this.txtApellido);
            this.pnlAgregarEmp.Controls.Add(this.txtNombre);
            this.pnlAgregarEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAgregarEmp.Location = new System.Drawing.Point(0, 0);
            this.pnlAgregarEmp.Name = "pnlAgregarEmp";
            this.pnlAgregarEmp.Size = new System.Drawing.Size(1904, 1041);
            this.pnlAgregarEmp.TabIndex = 9;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(237)))), ((int)(((byte)(108)))));
            this.btnInsertar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.Location = new System.Drawing.Point(293, 861);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(384, 80);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Agregar Empleado";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // lblRutaImagen
            // 
            this.lblRutaImagen.AutoSize = true;
            this.lblRutaImagen.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblRutaImagen.Location = new System.Drawing.Point(858, 137);
            this.lblRutaImagen.Name = "lblRutaImagen";
            this.lblRutaImagen.Size = new System.Drawing.Size(341, 65);
            this.lblRutaImagen.TabIndex = 18;
            this.lblRutaImagen.Text = "Ruta imágen: ";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblPassword2.Location = new System.Drawing.Point(116, 621);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(400, 65);
            this.lblPassword2.TabIndex = 17;
            this.lblPassword2.Text = "Rep contraseña: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(116, 534);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(308, 65);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Contraseña: ";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblEdad.Location = new System.Drawing.Point(116, 439);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(166, 65);
            this.lblEdad.TabIndex = 15;
            this.lblEdad.Text = "Edad: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblApellido.Location = new System.Drawing.Point(116, 335);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(266, 65);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellidos: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(116, 239);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(240, 65);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblNIF.Location = new System.Drawing.Point(116, 137);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(132, 65);
            this.lblNIF.TabIndex = 12;
            this.lblNIF.Text = "NIF: ";
            // 
            // mtxtNIF
            // 
            this.mtxtNIF.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.mtxtNIF.Location = new System.Drawing.Point(520, 136);
            this.mtxtNIF.Mask = "00000000-?";
            this.mtxtNIF.Name = "mtxtNIF";
            this.mtxtNIF.Size = new System.Drawing.Size(307, 70);
            this.mtxtNIF.TabIndex = 11;
            // 
            // btnInsertarImagen
            // 
            this.btnInsertarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnInsertarImagen.Location = new System.Drawing.Point(1605, 136);
            this.btnInsertarImagen.Name = "btnInsertarImagen";
            this.btnInsertarImagen.Size = new System.Drawing.Size(70, 70);
            this.btnInsertarImagen.TabIndex = 9;
            this.btnInsertarImagen.Text = "+";
            this.btnInsertarImagen.UseVisualStyleBackColor = true;
            this.btnInsertarImagen.Click += new System.EventHandler(this.btnInsertarImagen_Click);
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaImagen.Location = new System.Drawing.Point(1205, 136);
            this.txtRutaImagen.Multiline = true;
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.ReadOnly = true;
            this.txtRutaImagen.Size = new System.Drawing.Size(384, 70);
            this.txtRutaImagen.TabIndex = 10;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.txtPassword2.Location = new System.Drawing.Point(519, 626);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(307, 60);
            this.txtPassword2.TabIndex = 7;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.txtPassword.Location = new System.Drawing.Point(520, 539);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(307, 60);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.txtEdad.Location = new System.Drawing.Point(520, 444);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(307, 60);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdad_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.txtApellido.Location = new System.Drawing.Point(519, 340);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(307, 60);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.txtNombre.Location = new System.Drawing.Point(519, 244);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(307, 60);
            this.txtNombre.TabIndex = 3;
            // 
            // btnVolverAgregarEmp
            // 
            this.btnVolverAgregarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(38)))), ((int)(((byte)(68)))));
            this.btnVolverAgregarEmp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnVolverAgregarEmp.ForeColor = System.Drawing.Color.White;
            this.btnVolverAgregarEmp.Image = global::AEV7.Properties.Resources.volver;
            this.btnVolverAgregarEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolverAgregarEmp.Location = new System.Drawing.Point(1205, 861);
            this.btnVolverAgregarEmp.Name = "btnVolverAgregarEmp";
            this.btnVolverAgregarEmp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVolverAgregarEmp.Size = new System.Drawing.Size(384, 80);
            this.btnVolverAgregarEmp.TabIndex = 20;
            this.btnVolverAgregarEmp.Text = "Volver";
            this.btnVolverAgregarEmp.UseVisualStyleBackColor = false;
            this.btnVolverAgregarEmp.Click += new System.EventHandler(this.btnVolverAgregarEmp_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(125)))), ((int)(((byte)(229)))));
            this.pnlBackground.Controls.Add(this.picProfile);
            this.pnlBackground.Location = new System.Drawing.Point(1205, 244);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(384, 384);
            this.pnlBackground.TabIndex = 21;
            // 
            // picProfile
            // 
            this.picProfile.Location = new System.Drawing.Point(40, 40);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(304, 304);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 22;
            this.picProfile.TabStop = false;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlAgregarEmp);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.pnlAgregarEmp.ResumeLayout(false);
            this.pnlAgregarEmp.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgregarEmp;
        private System.Windows.Forms.Button btnInsertarImagen;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mtxtNIF;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label lblRutaImagen;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnVolverAgregarEmp;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.PictureBox picProfile;
    }
}