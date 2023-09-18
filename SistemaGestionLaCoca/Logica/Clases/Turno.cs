using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Turno
    {
        public int ID { get; set; }
        public string Fecha { get; set; }
        public string Horario { get; set; }

        //  Precio de la cancha dividido por la cant de jugadores de la misma
        public bool Reservado { get; set; } // hacer la condicion

        public Cancha Cancha_Turno { get; set; }
        public Cliente Cliente_Turno { get; set; }
        


       
    }
    //{Fecha.Day}/{Fecha.Month}
}
