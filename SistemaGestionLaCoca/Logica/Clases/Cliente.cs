using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logica.Clases
{
    public class Cliente
    {
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public uint telefono { get; set; }
        public string nombreYapellido { get; set; }

        public override string ToString()
        {
            return nombre;
        }

    }
}
