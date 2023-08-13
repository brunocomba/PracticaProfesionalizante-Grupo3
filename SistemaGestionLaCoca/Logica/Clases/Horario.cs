using LogicaClases.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Horario
    {
        public TimeOnly hora { get; set; }
        public string nombreCancha { get; set; }
        public Cancha cancha { get; set; }
    }
}
