using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Turno
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Horario { get; set; }

        //  Precio de la cancha dividido por la cant de jugadores de la misma
        public bool condicionReservado { get; set; } // hacer la condicion

        public Cancha canchaTurno { get; set; }
        public Cliente clienteTurno { get; set; }
        


        private static int lastID = 0;
        public static int GenerateID()
        {
            lastID++;
            return lastID;
        }
       
    }
    //{Fecha.Day}/{Fecha.Month}
}
