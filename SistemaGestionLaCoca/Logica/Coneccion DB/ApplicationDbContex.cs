
using Logica.Clases;
using Microsoft.EntityFrameworkCore;
using static System.Formats.Asn1.AsnWriter;

namespace Logica
{
    public class ApplicationDbContex : DbContext
    {
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cancha> Canchas { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Elemento> Elementos { get; set; }
        public DbSet<ElementoCancha> ElementoCancha { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BR-PC;database=LaCocaBD;trusted_connection=true;Encrypt=False");
        }




    }
}
