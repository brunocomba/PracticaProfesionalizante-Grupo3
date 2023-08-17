using Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases.Clases
{
    public class Turno
    {
        public int id { get; set; }
        public DateOnly fecha { get; set; }
        public TimeOnly horario { get; set; }
        public int precio { get; set; } //  Precio de la cancha dividido por la cant de jugadores de la misma
        public bool condicionReservado { get; set; } // hacer la condicion
        public  int canchaID { get; set; }
        public string tipoCancha { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public uint telCliente { get; set; }


        public Cancha cancha { get; set; }
        public  Cliente cliente { get; set; }


        private static int lastID = 0;
        public static int GenerateID()
        {
            lastID++;
            return lastID;
        }

    }

}
