using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Cancha
    {

        public int id { get; set; }
        public string tipo { get; set; }
        public int cantJugadores { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public string idYnombre { get; set; }


        private static int lastID = 0;

        public static int GenerateID()
        {
            lastID++;
            return lastID;
        }

        public override string ToString()
        {
            return $"{id} {tipo} ";
        }



    }
}
