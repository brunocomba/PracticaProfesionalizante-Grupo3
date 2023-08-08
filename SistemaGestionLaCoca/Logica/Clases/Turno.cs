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

        public Cancha cancha{ get; set; }

        public  Cliente cliente { get; set; }
    }
}
