using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7
{
    class Fichaje
    {
        private int id;
        private string nif;
        private DateTime fecha;
        private TimeSpan hora_entrada, hora_salida;
        private bool ficha_entrada, ficha_salida;

        public int Id { get { return id; } set { id = value; } }
        public string Nif { get { return nif; } set { nif = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public TimeSpan Hora_Entrada { get { return hora_entrada; } set { hora_entrada = value; } }
        public TimeSpan Hora_Salida { get { return hora_salida; }set { hora_salida = value; } }
        public bool Ficha_Entrada { get { return ficha_entrada; } set { ficha_entrada = value; } }
        public bool Ficha_Salida { get { return ficha_salida; } set { ficha_salida = value; } }

        public Fichaje(int id, string nif, DateTime fecha, TimeSpan hora_entrada, TimeSpan hora_salida, bool ficha_entrada, bool ficha_salida)
        {
            this.id = id;
            this.nif = nif;
            this.fecha = fecha;
            this.hora_entrada = hora_entrada;
            this.hora_salida = hora_salida;
            this.ficha_entrada = ficha_entrada;
            this.ficha_salida = ficha_salida;
        }

        public Fichaje() { }
    }
}