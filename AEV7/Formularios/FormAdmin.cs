using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7.Formularios
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            CrearColumnasDGV();
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e) => new FormAddUser().ShowDialog();

        private void BtnElimEmp_Click(object sender, EventArgs e) => new ModificarEmpleado().ShowDialog();

        private void BtnInformes_Click(object sender, EventArgs e)
        {
            //Borrado de datos
            dgvEmpleados.Rows.Clear();
            dgvFichajes.Rows.Clear();

            //Empleados
            List<ArrayList> datos = BBDD.Leer("SELECT NIF, Nombre, Apellido, Edad, Activo FROM empleado;");

            foreach (ArrayList item in datos)
            {
                if (item[4].ToString() == "True")
                    item[4] = "Si";
                else
                    item[4] = "No";

                dgvEmpleados.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
            }
            datos = null;
            //Fichajes
            List<ArrayList> datosdatos = BBDD.Leer("SELECT NIF, Fecha, Hora_Entrada, Hora_Salida, Ficha_Entrada, Ficha_Salida FROM fichaje;");

            foreach (ArrayList item in datosdatos)
            {
                if (item[4].ToString() == "True")
                    item[4] = "Si";
                else
                    item[4] = "No";

                if (item[5].ToString() == "True")
                    item[5] = "Si";
                else
                    item[5] = "No";

                dgvFichajes.Rows.Add(item[0], Convert.ToDateTime(item[1]).ToString("dd/MM/yyyy"), item[2], item[3], item[4], item[5]);
            }
        }

        private void CrearColumnasDGV()
        {
            dgvEmpleados.Columns.Add("Columna0", "NIF");
            dgvEmpleados.Columns.Add("Columna1", "Nombre");
            dgvEmpleados.Columns.Add("Columna2", "Apellidos");
            dgvEmpleados.Columns.Add("Columna3", "Edad");
            dgvEmpleados.Columns.Add("Columna4", "Activo");

            dgvFichajes.Columns.Add("Columna0", "NIF");
            dgvFichajes.Columns.Add("Columna1", "Fecha");
            dgvFichajes.Columns.Add("Columna2", "Hora de Entrada");
            dgvFichajes.Columns.Add("Columna3", "Hora de Salida");
            dgvFichajes.Columns.Add("Columna4", "Entrada Fichada");
            dgvFichajes.Columns.Add("Columna5", "Salida Fichada");

            for (int i = 0; i < dgvEmpleados.Columns.Count; i++)
            {
                dgvEmpleados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            for (int i = 0; i < dgvFichajes.Columns.Count; i++)
            {
                dgvFichajes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void BtnSalirMant_Click(object sender, EventArgs e) => this.Close();

        private void BtnCerrarApp_Click(object sender, EventArgs e) => Application.Exit();
    }
}
