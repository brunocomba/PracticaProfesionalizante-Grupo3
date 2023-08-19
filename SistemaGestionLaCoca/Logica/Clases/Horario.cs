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
        public string hora { get; set; }
        public string nombreCancha { get; set; }
        public Cancha cancha { get; set; }
    }
}
