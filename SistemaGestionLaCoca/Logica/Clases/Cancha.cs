

namespace Logica.Clases
{
    public class Cancha
    {

        public int ID { get; set; }
        public Deporte Deporte { get; set; }
        public string nombre { get; set; }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"{nombre}";
        }



    }
}
