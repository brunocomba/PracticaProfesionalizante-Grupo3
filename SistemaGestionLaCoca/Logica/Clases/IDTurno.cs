using LogicaClases.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public abstract class IDTurno
    {
        private static int lastID = 0;

        public static int GenerateID()
        {
            lastID++;
            return lastID;
        }
        public static void AdjustIDs(List<Turno> listaTurno)
        {
            int IDmasAlto = listaTurno.Max(item => item.id);

            lastID = IDmasAlto;
        }
    }
}
