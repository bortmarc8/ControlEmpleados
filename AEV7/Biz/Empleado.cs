using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AEV7.Common;
using MySql.Data.MySqlClient;

namespace AEV7
{
    class Empleado
    {        
        private string nif, nombre, apellido, password;
        private int edad;
        private Image image;
        private bool activo;

        public string Nif { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apelido { get { return apellido; } set { apellido = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public Image Image { get { return image; } set { image = value; } }
        public bool Activo { get { return activo; } set { activo = value; } }
        public string Password { get { return password; } set { password = value; } }

        public Empleado(string nif, string nombre, string apellido, int edad, Image image, bool activo, string password)
        {
            this.nif = nif;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.image = image;
            this.activo = activo;
            this.password = password;
        }
        public Empleado() { }

        public static byte FicharEntrada(string nif)
        {   //Comprobar que la letra coincide con los números.
            if (Validar.ValidarLetra(nif))
            {   //Si el DNI es real, comprobar si existe en la BBDD.
                if (BBDD.Leer($"SELECT NIF from empleado WHERE NIF = '{nif}' AND Activo=1;").Count > 0)
                {   //Si existe, comprobar que no haya un Fichaje de Entrada por cerrar.
                    if (BBDD.Leer($"SELECT * FROM fichaje WHERE NIF = '{nif}' AND Ficha_Entrada = 1 AND Ficha_Salida = 0;").Count == 0)
                    {   //Si no hay Fichajes de Entrada por cerrar, se inserta un nuevo Fichaje de Entrada.
                        if (BBDD.Escribir("INSERT INTO fichaje (NIF, Fecha, Hora_Entrada, Hora_Salida, Ficha_Entrada, Ficha_Salida) " +
                                $"VALUES ('{nif}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{DateTime.Now.ToString("HH:mm:ss")}', NULL, 1, 0)"))
                        {   //Si se ha insertado correctamente se consultan los datos Empleado/Fichaje para mostarlos gráficamente.
                            List<ArrayList> dataRows = BBDD.Leer("SELECT empleado.NIF, Nombre, Apellido, Edad, Imagen, Hora_Entrada, Hora_Salida FROM empleado " +
                                $"INNER JOIN fichaje ON empleado.NIF=fichaje.NIF WHERE empleado.NIF='{nif}' AND Ficha_Salida=0;");

                            CargarDatosEmpleado(dataRows[0]);
                            return 0;
                        }
                    }
                    return 3;
                }
                else if (BBDD.ConnectionWorking)
                    return 2;
                else
                    return 4;
            }
            return 1;
        }
        public static byte FicharSalida(string nif)
        {
            if (Validar.ValidarLetra(nif))
            {
                if (BBDD.Leer($"SELECT NIF from empleado WHERE NIF = '{nif}' AND Activo=1;").Count > 0)
                {
                    if (BBDD.Leer("SELECT * FROM fichaje " +
                        $"WHERE '{nif}' = NIF AND '{DateTime.Now.ToString("yyyy-MM-dd")}' = Fecha AND Ficha_Entrada = 1 AND Ficha_Salida = 0;").Count > 0)
                    {
                        if (BBDD.Escribir($"UPDATE fichaje SET Ficha_Salida = 1, Hora_Salida = '{DateTime.Now.ToString("HH:mm:ss")}' " +
                                $"WHERE NIF = '{nif}' AND Ficha_Salida = 0;"))//
                        {
                            List<ArrayList> dataRows = BBDD.Leer("SELECT empleado.NIF, Nombre, Apellido, Edad, Imagen, Hora_Entrada, Hora_Salida FROM empleado " +
                                $"INNER JOIN fichaje ON empleado.NIF=fichaje.NIF WHERE empleado.NIF='{nif}' AND Ficha_Salida=1 AND Fecha = '{DateTime.Now.ToString("yyyy-MM-dd")}' ORDER BY ID DESC;");

                            CargarDatosEmpleado(dataRows[0]);
                            return 0;
                        }
                        return 4;
                    }
                    return 3;
                }
                else if (BBDD.ConnectionWorking)
                    return 2;
                else
                    return 4;
            }
            return 1;
        }

        public static byte Presencia()
        {
            BBDD.Leer("SELECT empleado.NIF, Nombre, Apellido, Hora_Entrada FROM empleado INNER JOIN fichaje ON empleado.NIF=fichaje.NIF " +
                $"WHERE Ficha_Entrada=1 AND Ficha_Salida=0 AND Fecha = '{DateTime.Now.ToString("yyyy-MM-dd")}';");

            if (BBDD.DataRows.Count > 0)
                return 0;
            else if (BBDD.ConnectionWorking)
                return 1;
            else
                return 2;
        }

        public static byte Permanencia(string nif, DateTime fechaInicial, DateTime fechaFinal)
        {
            TimeSpan diferenciaTiempo;
            TimeSpan tiempoTotal = TimeSpan.Zero;
            if (Validar.ValidarLetra(nif))
            {
                if (BBDD.Leer($"SELECT NIF from empleado WHERE NIF = '{nif}' AND Activo=1;").Count > 0)
                {
                    if (BBDD.Leer($"SELECT Fecha, Hora_Entrada, Hora_Salida FROM fichaje WHERE NIF='{nif}' AND Ficha_Entrada=1 AND Ficha_Salida=1 " +
                    $"AND Fecha BETWEEN '{fechaInicial.ToString("yyyy-MM-dd")}' AND '{fechaFinal.ToString("yyyy-MM-dd")}';").Count > 0)
                    {
                        ArrayList permanenciaTotal = new ArrayList();

                        foreach (var item in BBDD.DataRows)
                        {
                            diferenciaTiempo = TimeSpan.Parse(item[1].ToString()).Subtract(TimeSpan.Parse(item[2].ToString()));
                            tiempoTotal += diferenciaTiempo;
                        }
                        permanenciaTotal.Add(tiempoTotal);
                        BBDD.DataRows.Add(permanenciaTotal);

                        return 0; //Se han recibido datos para mostrar en el formulario.
                    }
                    else
                        return 3; //No hay permanencia de ese empleado.
                }
                else if (BBDD.ConnectionWorking)
                    return 2; //El DNI no existe en el sistema.
                else
                    return 4; //No hay conexión con la Base de Datos.
            }
            return 1; //Letra no correspondiente al DNI (DNI incorrecto).
        }

        public static byte Mentenimiento(string nif)
        {
            if (Validar.ValidarLetra(nif))
            {
                if (BBDD.Leer($"SELECT NIF from empleado WHERE NIF = '{nif}' AND Activo=1;").Count > 0)   
                {
                    if (BBDD.Leer($"SELECT * FROM empleado WHERE NIF = '{nif}' AND `Password` IS NOT NULL AND `Password` != ''").Count > 0)
                        return 0; //El empleado existe y es administrador (pedir la contraseña posteriormente).
                    else
                        return 3; //No es administrador, no tiene permisos.
                }
                else if (BBDD.ConnectionWorking)
                    return 2; //El DNI no existe en el sistema.
                else
                    return 4; //No hay conexión con la BBDD.
            }
            return 1; //Letra incorrecta.
        }

        public static bool ShowListBoxInfo(string nif)
        {
            List<ArrayList> dataRows = BBDD.Leer("SELECT empleado.NIF, Nombre, Apellido, Edad, Imagen, Hora_Entrada, Hora_Salida FROM empleado INNER JOIN fichaje ON empleado.NIF=fichaje.NIF "
                + $"WHERE empleado.NIF = '{nif}' AND Ficha_Salida=0;");

            if (BBDD.ConnectionWorking)
                return CargarDatosEmpleado(dataRows[0]);
            return false;
        }

        private static bool CargarDatosEmpleado(ArrayList data)
        {
            if (data.Count > 0)
            {
                GlobalData.Empleado = new Empleado();
                GlobalData.Empleado.Nif = data[0].ToString();
                GlobalData.Empleado.Nombre = data[1].ToString();
                GlobalData.Empleado.Apelido = data[2].ToString();
                GlobalData.Empleado.Edad = Convert.ToInt32(data[3]);

                if (data[4].ToString().Length > 0)
                    GlobalData.Empleado.Image = Image.FromStream(ImgByteConverter.ByteToImage((byte[])data[4]));
                else
                    GlobalData.Empleado.Image = AEV7.Properties.Resources.user;

                GlobalData.Fichaje = new Fichaje();
                GlobalData.Fichaje.Hora_Entrada = TimeSpan.Parse(data[5].ToString());
                if (data[6].ToString().Length > 0)
                    GlobalData.Fichaje.Hora_Salida = TimeSpan.Parse(data[6].ToString());
                return true;
            }
            return false;
        }

        public static bool CerrarFichajesAbiertos()
        {
            if (BBDD.Escribir($"UPDATE fichaje SET Ficha_Salida = 1, Hora_Salida = '23:59:59' " +
                $"WHERE Fecha < '{DateTime.Now.ToString("yyyy-MM-dd")}' AND Ficha_Salida = 0;"))
                return true;
            else
                return false;
        }

        public static bool CheckDataBasePassword(string nif, string password)
        {
            if (BBDD.Leer($"SELECT * FROM empleado WHERE NIF = '{nif}' AND `Password` = '{password}'").Count > 0)
                return true;
            return false;
        }
    }
}