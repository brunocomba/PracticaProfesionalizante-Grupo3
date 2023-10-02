
namespace Logica.Clases
{
    public class Elemento
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }


        public void AltaElemento(string nombre, int stock)
        {
            Elemento elemento = new Elemento(); 
            elemento.Nombre = nombre;
            elemento.Stock = stock;

            // guardarlo en la base de datos
        }
    }
}
