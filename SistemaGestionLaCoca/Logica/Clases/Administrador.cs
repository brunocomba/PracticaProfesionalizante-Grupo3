
namespace Logica.Clases
{
    public class Administrador
    {
        public int Id { get; set; }
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

        // Propiedad estatica para almacenar el Adm que este logueado actualmente
        public static Administrador admLogueado { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }

    }
}
