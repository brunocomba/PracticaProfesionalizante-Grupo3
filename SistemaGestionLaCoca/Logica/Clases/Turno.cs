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

        public Cancha Cancha { get; set; }
        public Cliente Cliente { get; set; }
        public Reservado Condicion { get; set; } // hacer la condicion


        public enum Reservado
        {
            No = 0,
            Si = 1
        }

       
    }
    //{Fecha.Day}/{Fecha.Month}
}
