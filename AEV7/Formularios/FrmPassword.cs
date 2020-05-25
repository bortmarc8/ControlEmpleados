using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7
{
    public partial class FrmPassword : Form
    {
        private string password;
        public string Password => password;
        public FrmPassword()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.Text = String.Empty;
            //this.BackColor = Color.FromArgb(197, 211, 250);

            //btnEnviar.TabStop = false;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnEnviar.FlatAppearance.MouseDownBackColor = Color.FromArgb(197, 211, 250);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(197, 211, 250);
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            password = txtPassword.Text;
            this.Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e) => this.Dispose();
    }
}
