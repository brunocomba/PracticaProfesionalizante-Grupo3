using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.Clases;
using Microsoft.EntityFrameworkCore;

namespace Logica
{
    internal class ApplicationDbContex : DbContext
    {
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Cancha> Canchas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Turno> Turnos { get; set; }
    }
}
