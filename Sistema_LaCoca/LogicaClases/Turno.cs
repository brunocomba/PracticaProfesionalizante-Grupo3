using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Turno
    {
        public DateOnly  fecha { get; set; }
        public TimeOnly horario { get; set; }
        public  int  precio { get; set; }
        public bool condicionReservado { get; set; }
    }
}
