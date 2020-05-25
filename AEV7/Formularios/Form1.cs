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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            tmrReloj.Enabled = true;
            tmrReloj.Interval = 1000;

            btnFicharEntrada.Image = AEV7.Properties.Resources.entrar;
            btnFicharSalida.Image = AEV7.Properties.Resources.salir;

            //btnFicharEntrada.BackgroundImageLayout = ImageLayout.Center;


            btnSalirResumen.Visible = false;

            Empleado.CerrarFichajesAbiertos();
        }

        private void BtnFicharEntrada_Click(object sender, EventArgs e)
        {
            if (Validar.ValidarExpresion(mtxtDNI.Text))
            {
                int valor = Empleado.FicharEntrada(mtxtDNI.Text.ToUpper());

                switch (valor)
                {
                    case 0:
                        ShowProfileData();
                        SwapMainButtons(!mtxtDNI.Visible);
                        txtLog.AppendText(Environment.NewLine +
                            $"[{GlobalData.Fichaje.Hora_Entrada}]: {GlobalData.Empleado.Nombre} {GlobalData.Empleado.Apelido} '{GlobalData.Empleado.Nif}' ha fichado de entrada.");
                        //MessageBox.Show("Has fichado la entrada.", "Fichaje completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        MessageBox.Show("El DNI introducido no es correcto.", "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("El DNI introducido no existe en el sistema.", "DNI no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        MessageBox.Show("Hay un fichaje de entrada abierto (no se ha realizado fichaje de salida).", "Fichaje de entrada no cerrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 4:
                        MessageBox.Show("No se ha podido establecer conexión con la Base de Datos.");
                        break;
                }
            }
            else
                MessageBox.Show("El DNI introducido no es correcto.", "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnFicharSalida_Click(object sender, EventArgs e)
        {
            if (Validar.ValidarExpresion(mtxtDNI.Text))
            {
                byte valor = Empleado.FicharSalida(mtxtDNI.Text.ToUpper());

                switch (valor)
                {
                    case 0:
                        lstEmpleados.Items.Clear();
                        ShowProfileData();
                        SwapMainButtons(!mtxtDNI.Visible);
                        txtLog.AppendText(Environment.NewLine +
                            $"[{GlobalData.Fichaje.Hora_Salida}]: {GlobalData.Empleado.Nombre} {GlobalData.Empleado.Apelido} '{GlobalData.Empleado.Nif}' ha fichado de salida.");
                        //MessageBox.Show("Has fichado la salida.", "Fichaje completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        MessageBox.Show("El DNI introducido no es correcto.", "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("El DNI introducido no existe en el sistema.", "DNI no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        MessageBox.Show("No se ha realizado el fichaje de entrada o ya se ha realizado el fichaje de salida con este DNI.", "Error fichaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 4:
                        MessageBox.Show("No se ha podido establecer conexión con la Base de Datos.");
                        break;
                }
            }
            else
                MessageBox.Show("El DNI introducido no es correcto.", "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnPresencia_Click(object sender, EventArgs e)
        {
            switch (Empleado.Presencia())
            {//NIF = [{BBDD.DataRows[i][0].ToString()}]
                case 0:
                    lstEmpleados.Items.Clear();
                    lstEmpleados.SelectionMode = SelectionMode.One;
                    for (int i = 0; i < BBDD.DataRows.Count; i++)
                    {
                        string tiempoTotal = DateTime.Now.Subtract(TimeSpan.Parse(BBDD.DataRows[i][3].ToString())).ToString("HH:mm:ss");
                        string h = tiempoTotal.Substring(0, 2);
                        string min = tiempoTotal.Substring(3, 2);
                        string sec = tiempoTotal.Substring(6, 2);
                        lstEmpleados.Items.Add($"[{BBDD.DataRows[i][3].ToString()}]: {BBDD.DataRows[i][1].ToString()} {BBDD.DataRows[i][2].ToString()}" +
                            $"\tTiempo Presente: {h} horas, {min} minutos, {sec} segundos.");
                    }
                    break;
                case 1:
                    lstEmpleados.Items.Clear();
                    MessageBox.Show("No se han encontrado empleados presentes en la empresa.", "Empleados no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("No se ha podido establecer conexión con la Base de Datos.");
                    break;
            }
        }

        private void LstEmpleados_DoubleClick(object sender, EventArgs e)
        {
            try //TryCatch salvavidas
            {
                if (lstEmpleados.SelectedIndex != -1)
                {
                    if (Empleado.ShowListBoxInfo(BBDD.DataRows[lstEmpleados.SelectedIndex][0].ToString().ToUpper()))
                    {
                        ShowProfileData();
                        SwapMainButtons(false);
                        lstEmpleados.SelectionMode = SelectionMode.None;
                    }
                    else
                        MessageBox.Show("No se ha podido establecer conexión con la Base de Datos.");

                }
            }
            catch { }
        }

        private void BtnPermanencia_Click(object sender, EventArgs e) //GESTIÓN DE ERRORES, DNI, ETC. //ELEGIR INTERVALO DE FECHAS //ERROR SI NO DEVUELVE NADA
        {
            if (Validar.ValidarExpresion(mtxtDNI.Text))
            {
                CheckDate(); //Comprueba que la fecha de inicio no sea superior a la de fin.
                byte valor = Empleado.Permanencia(mtxtDNI.Text.ToUpper(), dtpInicio.Value, dtpFin.Value);

                switch (valor)
                {
                    case 0:
                        lstEmpleados.SelectionMode = SelectionMode.None; //Desactivar la seleccón para que no de problemas por querer mostrar la información.
                        lstEmpleados.Items.Clear();
                        for (int i = 0; i < BBDD.DataRows.Count - 1; i++)
                        {
                            lstEmpleados.Items.Add($"[{mtxtDNI.Text}]\tFecha: {Convert.ToDateTime(BBDD.DataRows[i][0]).ToString("dd/MM/yyyy")}\tHora de Entrada: {BBDD.DataRows[i][1]}\tHora de Salida: {BBDD.DataRows[i][2]}");
                        }
                        if (lstEmpleados.Items.Count > 0)
                        {
                            lstEmpleados.Items.Add("");
                            //lstEmpleados.Items.Add($"[{mtxtDNI.Text}]\tTiempo total: {TimeSpan.Parse(BBDD.DataRows[BBDD.DataRows.Count - 1][0].ToString()).TotalHours}");
                            TimeSpan totalTime = TimeSpan.Parse(BBDD.DataRows[BBDD.DataRows.Count - 1][0].ToString());

                            string[] items = String.Format("{0}horas, {1}minutos, {2}segundos.", totalTime.Hours, totalTime.Minutes, totalTime.Seconds).Split('-');
                            string total = "";
                            foreach (var item in items)
                            {
                                total += item;
                            }

                            lstEmpleados.Items.Add($"[{mtxtDNI.Text}]\tTiempo total: {total}");
                        }
                        break;
                    case 1:
                        MessageBox.Show("El DNI introducido no es correcto.", "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("El DNI introducido no existe en el sistema.", "DNI no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        MessageBox.Show("No se ha encontrado una permanencia del empleado entre las fechas dadas.", "Permanencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 4:
                        MessageBox.Show("No se ha podido establecer conexión con la Base de Datos.");
                        break;
                }
            }
            else
                MessageBox.Show("El DNI introducido no es correcto.", "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnMantenimiento_Click(object sender, EventArgs e)
        {
            if (Validar.ValidarExpresion(mtxtDNI.Text)) //Revisar si esta comprobación está implementada en todas las funciones donde se pone DNI.
            {
                byte valor = Empleado.Mentenimiento(mtxtDNI.Text.ToUpper());

                switch (valor)
                {
                    case 0:
                        FrmPassword password = new FrmPassword();
                        DialogResult result = password.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            if (Empleado.CheckDataBasePassword(mtxtDNI.Text.ToUpper(), password.Password))
                            {
                                //MessageBox.Show("Accediendo a mantenimiento.");
                                Formularios.FormAdmin formAdmin = new Formularios.FormAdmin();
                                formAdmin.ShowDialog();
                            }
                            else
                                MessageBox.Show("Contraseña incorrecta.");
                        }
                        break;
                    case 1:
                        MessageBox.Show("El DNI introducido no es correcto.", "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("El DNI introducido no existe en el sistema.", "DNI no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        MessageBox.Show("No se tienen permisos de administrador.", "No se tienen permisos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 4:
                        MessageBox.Show("No se ha podido establecer conexión con la Base de Datos.");
                        break;
                }
            }
            else
                MessageBox.Show("El DNI introducido no es correcto.", "DNI incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            if (lblReloj.Text == "00:00:01")
                Empleado.CerrarFichajesAbiertos();
        }


        private void SwapMainButtons(bool value)
        {
            if (value == true)
                lstEmpleados.Items.Clear();

            mtxtDNI.Visible = value;
            btnFicharEntrada.Visible = value;
            btnFicharSalida.Visible = value;
            btnPresencia.Visible = value;
            btnPermanencia.Visible = value;
            dtpInicio.Visible = value;
            dtpFin.Visible = value;
            btnMantenimiento.Visible = value;
            pnlBackground.Visible = value;

            btnSalirResumen.Visible = !value;
        }

        private void ShowProfileData()
        {
            lblProfileName.Text = $"{GlobalData.Empleado.Nombre}\n{GlobalData.Empleado.Apelido}";
            lblProfileNIF.Text = GlobalData.Empleado.Nif;
            lblEdad.Text = GlobalData.Empleado.Edad.ToString();
            lblFichaEntrada.Text = GlobalData.Fichaje.Hora_Entrada.ToString();

            if (GlobalData.Fichaje.Hora_Salida.ToString() == "00:00:00" && DateTime.Now.ToString("HH:mm:ss") != "00:00:00")
                lblFichaSalida.Text = "--:--:--";
            else
                lblFichaSalida.Text = GlobalData.Fichaje.Hora_Salida.ToString();

            picProfile.Image = GlobalData.Empleado.Image;
        }

        private void BtnSalirResumen_Click(object sender, EventArgs e)
        {
            SwapMainButtons(!mtxtDNI.Visible);
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            mtxtDNI.Clear();
        }

        private void CheckDate()
        {
            if (dtpInicio.Value > dtpFin.Value)
            {
                DateTime fecha = dtpFin.Value;
                dtpFin.Value = dtpInicio.Value;
                dtpInicio.Value = fecha;
            }
        }
    }
}
