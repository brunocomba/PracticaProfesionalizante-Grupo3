

namespace Logica.Clases
{
    public class Cancha
    {

        public int ID { get; set; }
        public string Tipo { get; set; }
        public int Cantidad_Jugadores { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public override string ToString()
        {
            return $"{Nombre}";
        }



    }
}
