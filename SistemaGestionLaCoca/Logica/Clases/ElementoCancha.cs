
namespace Logica.Clases
{
    public class ElementoCancha
    {
        public int ID { get; set; }
        public Cancha Cancha { get; set; }
        public Elemento Elemento { get; set; }
        public  int  Cantidad { get; set; }

        public void AsigElementoCancha(Cancha cancha, Elemento elemento, int cant)
        {
            ElementoCancha elementoCancha = new ElementoCancha();
            elementoCancha.Cancha = cancha;
            elementoCancha.Elemento = elemento;
            elementoCancha.Cantidad = cant;

            // bajar la cantidad en el stock
            elementoCancha.Elemento.Stock =-cant;
            // ver ejemplo de buscar por ID y desp mpodificar



            // guardarlo en la BD
        }
    }
}
