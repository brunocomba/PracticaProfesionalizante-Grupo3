

namespace Logica.Clases
{
    public class Cancha
    {

        public int ID { get; set; }
        public string Deporte { get; set; }
        public int Cantidad_Jugadores { get; set; }
        public string nombre { get; set; }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"{nombre}";
        }



    }
}
