


namespace Logica.Clases
{
    public class Cliente
    {
        public int ID {  get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Telefono { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }


    }
}
