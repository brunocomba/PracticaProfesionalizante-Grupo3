
using Logica.Clases;
using Microsoft.EntityFrameworkCore;

namespace Logica
{
    internal class ApplicationDbContex : DbContext
    {
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BR-PC;database=LaCocaDB;trusted_connection=true;Encrypt=False");
        }
    }
}
