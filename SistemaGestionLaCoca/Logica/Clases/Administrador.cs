using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Clases
{
    public class Administrador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public long Telefono { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }

        public SioNo Logueado {  get; set; } 
        public enum SioNo
        {
            NO = 0,
            SI = 1
        }

        
    }
}
