using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7.Formularios
{
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void btnInsertarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventana = new OpenFileDialog();
            ventana.Filter = "Imágenes jpg (*.jpg)|*.jpg|Imágenes png (*.png)|*.png|Todos los arhcivos (*.*)|*.*";

            if (ventana.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtRutaImagen.Text = ventana.FileName;
                picProfile.Image = Bitmap.FromFile(txtRutaImagen.Text);
            }
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar.ValidarExpresion(mtxtNIF.Text.ToUpper()) && Validar.ValidarLetra(mtxtNIF.Text.ToUpper()))
            {
                if (txtApellido.Text != "" && txtNombre.Text != "" && txtEdad.Text != "" && txtPassword.Text == txtPassword2.Text)
                {
                    if (BBDD.Leer($"SELECT * FROM empleado WHERE NIF = '{mtxtNIF.Text}' AND Activo=0;").Count == 0)
                    {
                        if (txtRutaImagen.Text == "" || txtRutaImagen.Text == null)
                        {
                            string consulta = $"INSERT INTO `empleado` (`NIF`, `Nombre`, `Apellido`, `Edad`, `Password`, `Activo`) VALUES ('{mtxtNIF.Text}', '{txtNombre.Text}', '{txtApellido.Text}', {txtEdad.Text}, '{txtPassword.Text}', 1)";
                            if (BBDD.Escribir(consulta))
                            {
                                ClearControls();
                                MessageBox.Show("Usuario añadido correctamente");
                            }
                            else
                                MessageBox.Show("Ha sucedido un error, intentalo de nuevo más tarde");
                        }
                        else
                        {
                            string consulta = $"INSERT INTO `empleado` (`NIF`, `Nombre`, `Apellido`, `Edad`, `Password`, `Activo`, `Imagen`) VALUES ('{mtxtNIF.Text}', '{txtNombre.Text}', '{txtApellido.Text}', {txtEdad.Text}, '{txtPassword.Text}', 1, @Imagen)";

                            if (BBDD.Escribir(consulta, picProfile.Image))
                            {
                                ClearControls();
                                MessageBox.Show("Usuario añadido correctamente");
                            }
                            else
                                MessageBox.Show("Ha sucedido un error, intentalo de nuevo más tarde");
                        }
                    }
                    else
                    {
                        if (BBDD.Escribir($"UPDATE `empleado` SET `Activo` = 1 WHERE `NIF` = '{mtxtNIF.Text}' AND `Activo` = 0;"))
                        {
                            ClearControls();
                            MessageBox.Show("Usuario añadido correctamente");
                        }
                        else
                            MessageBox.Show("Ha sucedido un error.");
                    }
                }
                else
                    MessageBox.Show("No has rellenado correctamente el formulario, revisa los datos");
            }
            else
                MessageBox.Show("La estructura o la letra del NIF son incorrectas");
        }

        private void btnVolverAgregarEmp_Click(object sender, EventArgs e) => this.Close();

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ClearControls()
        {
            mtxtNIF.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
            txtRutaImagen.Text = "";
            picProfile.Image = null;
        }
    }
}
