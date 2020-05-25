using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AEV7
{
    static class Validar
    {
        private static Regex regex = new Regex("[0-9]{8}-[A-Za-z]");

        public static bool ValidarExpresion(string nif) => regex.IsMatch(nif);

        /// <summary>Recibe un string con formato DNI y comprueba si la letra es correcta.</summary>
        /// <param name="nif">NIF pasado por parámetro, el parámetro debe tener formato "00000000-X"</param>
        /// <returns>True si la letra es correcta</returns>
        public static bool ValidarLetra(string nif)
        {
            char[] letras = new char[] { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            int dni = Convert.ToInt32(nif.Substring(0, 8));

            if (letras[dni % 23] == Convert.ToChar(nif.Substring(9, 1)))
                return true;
            else
                return false;
        }
    }
}