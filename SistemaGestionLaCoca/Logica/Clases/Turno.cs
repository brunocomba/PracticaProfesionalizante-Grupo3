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

        public Cancha Cancha { get; set; }
        public Cliente Cliente { get; set; }


       
    }
}
