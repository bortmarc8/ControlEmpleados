using System;
using System.Collections;
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
    public partial class ModificarEmpleado : Form
    {
        Image defaultImg;
        public ModificarEmpleado()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            defaultImg = picFotoPerfil.Image;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (Validar.ValidarExpresion(txtBuscarEmpleado.Text.ToUpper()) && Validar.ValidarLetra(txtBuscarEmpleado.Text.ToUpper()))
            {
                string consulta = $"SELECT `NIF`, `Nombre`, `Apellido`, `Edad`, `Password`, `Activo`, `Imagen` FROM `empleado` WHERE NIF = '{txtBuscarEmpleado.Text}';";

                List<ArrayList> data = BBDD.Leer(consulta);
                if (BBDD.ConnectionWorking)
                {
                    try
                    {
                        if (GlobalData.CargarDatosSoloEmpleado(data[0]))
                        {
                            mtxtDNI.Text = GlobalData.Empleado.Nif;
                            txtNombre.Text = GlobalData.Empleado.Nombre;
                            txtApellidos.Text = GlobalData.Empleado.Apelido;
                            txtEdad.Text = GlobalData.Empleado.Edad.ToString();
                            txtPassword.Text = GlobalData.Empleado.Password;
                            if (txtPassword.Text != "")
                            {
                                chkAdmin.Checked = true;
                                txtPassword.ReadOnly = false;
                            }
                            else
                                chkAdmin.Checked = false;
                            chkActivo.Checked = GlobalData.Empleado.Activo;
                            if (GlobalData.Empleado.Image != null)
                                picFotoPerfil.Image = GlobalData.Empleado.Image;
                        }
                        else
                            MessageBox.Show("No se ha encontrado ningún usuario con ese DNI en la BBDD.");
                    }
                    catch
                    {
                        MessageBox.Show("No se ha encontrado ningún usuario con ese DNI en la BBDD.");
                    }
                }
                else
                    MessageBox.Show("Error con la conexión con la base de datos, comprueba tu conexión.");
            }
            else
                MessageBox.Show("La estructura o la letra del NIF son incorrectas.");
        }

        private void cbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
                txtPassword.ReadOnly = false;
            else
            {
                txtPassword.Text = "";
                txtPassword.ReadOnly = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (mtxtDNI.Text != "")
            {
                if (txtNombre.Text != "" && txtEdad.Text != "" && txtApellidos.Text != "")
                {
                    byte activo = 0;
                    if (chkActivo.Checked)
                        activo = 1;

                    string consulta = "";
                    bool operacion;
                    if (picFotoPerfil.Image == defaultImg)
                    {
                        consulta = $"UPDATE `empleado` SET `Nombre` = '{txtNombre.Text}', `Apellido` = '{txtApellidos.Text}', `Edad` = {txtEdad.Text}, " +
                            $"`Password` = '{txtPassword.Text}', `Activo` = {activo} WHERE `empleado`.`NIF` = '{mtxtDNI.Text}';";
                        operacion = BBDD.Escribir(consulta);
                    }
                    else
                    {
                        consulta = $"UPDATE `empleado` SET `Nombre` = '{txtNombre.Text}', `Apellido` = '{txtApellidos.Text}', `Edad` = {txtEdad.Text}, " +
                                                    $"`Password` = '{txtPassword.Text}', `Activo` = {activo}, `Imagen` = @Imagen WHERE `empleado`.`NIF` = '{mtxtDNI.Text}';";
                        operacion = BBDD.Escribir(consulta, picFotoPerfil.Image);
                    }
                    if (operacion)
                        MessageBox.Show("Empleado modificado correctamente");
                    else
                        MessageBox.Show("Ha ocurrido un error durante la subida, intentalo más tarde");
                }
                else
                    MessageBox.Show("No puedes dejar campos vacios");
            }
            else
                MessageBox.Show("Antes de modificar debes buscar al empleado en cuestión.");
        }

        private void pbFotoPerfil_Click(object sender, EventArgs e)
        {
            if (mtxtDNI.Text != "")
            {
                OpenFileDialog ventana = new OpenFileDialog();
                ventana.Filter = "Imágenes jpg (*.jpg)|*.jpg|Imágenes png (*.png)|*.png|Todos los arhcivos (*.*)|*.*";

                if (ventana.ShowDialog() == DialogResult.OK)
                    picFotoPerfil.Image = Bitmap.FromFile(ventana.FileName);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (mtxtDNI.Text != "")
            {
                if (MessageBox.Show("El usuario se deshabilitará y no se podrá operar con él hasta habilitarlo, ¿quieres continar?", "Deshabilitar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (BBDD.Escribir($"UPDATE `empleado` SET `Activo` = 0 WHERE `NIF` = '{mtxtDNI.Text}' AND `Activo` = 1;"))
                        MessageBox.Show("Usuario eliminado correctamente");
                    else
                        MessageBox.Show("Ha sucedido un error, intentalo más tarde");

                    ClearControls();
                }
            }
            else
                MessageBox.Show("Antes de eliminar un usuario debes de buscarlo");
        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();

        private void ClearControls()
        {
            mtxtDNI.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
            txtPassword.Text = "";
            chkActivo.Checked = false;
            chkAdmin.Checked = false;
            txtBuscarEmpleado.Text = "";
            picFotoPerfil.Image = Properties.Resources.user;
        }
    }
}
