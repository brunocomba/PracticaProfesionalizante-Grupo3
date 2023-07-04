using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases.Clases
{
    public class Principal
    {
        public static List<Administrador> listaAdministradores;
        public static List<Cancha> listaCanchas;


        public static List<Administrador> ObtenerAdministradores()
        {
            if (listaAdministradores == null)
            {
                listaAdministradores = new List<Administrador>();

                Administrador adminBase = new Administrador();
                adminBase.id = 1;
                adminBase.nombre = "Bruno";
                adminBase.apellido = "Comba";
                adminBase.dni = 45414815;
                adminBase.telefono = 15662312;
                adminBase.usuario = "brunocomba";
                adminBase.contrasenia = "contrasenia123";

                listaAdministradores.Add(adminBase);    
            }
            return listaAdministradores;
        }
        public void agregarAdmin(Administrador admin)
        {
            listaAdministradores.Add(admin);
        }
        public void altaAdmin(string Nombre, string Apellido, int Dni, int Tel, string User, string Pass)
        {
            Administrador newAdmin = new Administrador();

            newAdmin.nombre = Nombre;
            newAdmin.apellido = Apellido;
            newAdmin.dni = Dni;
            newAdmin.telefono = Tel;
            newAdmin.usuario = User;
            newAdmin.contrasenia = Pass;

            agregarAdmin(newAdmin);
        }

        public void altaCancha(int Id, string Tipo, int CantJugadores)
        {
            Cancha newCancha = new Cancha();

            newCancha.id = Id;
            newCancha.tipo = Tipo;
            newCancha.cantJugadores = CantJugadores;

            listaCanchas.Add(newCancha);
        }

    }

}
