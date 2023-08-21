using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Turno
    {
        public int id { get; set; }
        public DateOnly fecha { get; set; }
        public TimeOnly horario { get; set; }

        //  Precio de la cancha dividido por la cant de jugadores de la misma
        public bool condicionReservado { get; set; } // hacer la condicion

        public Cancha cancha { get; set; }
        public Cliente cliente { get; set; }


        private static int lastID = 0;
        public static int GenerateID()
        {
            lastID++;
            return lastID;
        }
        public string MostrarInfo()
        {
            return $"{id} ; {fecha} ; {horario} ; {cliente.nombre} ; {cliente.apellido} ; {cliente.telefono} ; {cancha.id} ; {cancha.tipo} ; {cancha.precio}";
        }
    }

}
