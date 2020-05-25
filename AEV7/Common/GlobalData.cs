using AEV7.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7
{
    static class GlobalData
    {
        private static Empleado empleado;
        private static Fichaje fichaje;
        private static List<Empleado> empleados;
        private static List<Fichaje> fichajes;

        public static Empleado Empleado { get { return empleado; } set { empleado = value; } }
        public static Fichaje Fichaje { get { return fichaje; } set { fichaje = value; } }
        public static List<Empleado> Empleados { get { return empleados; } set { empleados = value; } }
        public static List<Fichaje> Fichajes { get { return fichajes; } set { fichajes = value; } }

        public static bool CargarDatosSoloEmpleado(ArrayList data)
        {//`NIF`, `Nombre`, `Apellido`, `Edad`, `Password`, `Activo`, `Imagen`
            if (data.Count > 0)
            {
                GlobalData.Empleado = new Empleado();
                GlobalData.Empleado.Nif = data[0].ToString();
                GlobalData.Empleado.Nombre = data[1].ToString();
                GlobalData.Empleado.Apelido = data[2].ToString();
                GlobalData.Empleado.Edad = Convert.ToInt32(data[3]);
                GlobalData.Empleado.Password = data[4].ToString();

                if (data[5].ToString() == "True")
                    GlobalData.Empleado.Activo = true;
                else
                    GlobalData.Empleado.Activo = false;

                if (data[6].ToString().Length > 0)
                    GlobalData.Empleado.Image = Image.FromStream(ImgByteConverter.ByteToImage((byte[])data[6]));

                return true;
            }
            return false;
        }
    }
}
