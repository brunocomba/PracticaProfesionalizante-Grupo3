using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases.Clases
{
    public class Principal
    {
        public void addAdmi(Administrador administrador)
        {
            listaAdministradores.Add(administrador);
        }

        public void altaAdmin(string Nombre, string Apellido, int Dni, uint Tel, string User, string Pass)
        {
            Administrador newAdmin = new Administrador();

            newAdmin.nombre = Nombre;
            newAdmin.apellido = Apellido;
            newAdmin.dni = Dni;
            newAdmin.telefono = Tel;
            newAdmin.usuario = User;
            newAdmin.contrasenia = Pass;

            ObtenerAdministradores().Add(newAdmin); 
        }
        public static List<Administrador> listaAdministradores;
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
                adminBase.telefono = 3493662312;
                adminBase.usuario = "boot";
                adminBase.contrasenia = "123";

                listaAdministradores.Add(adminBase);    
            }
            return listaAdministradores;
        }

        // PROBAR HACER LO MISMO PERO SIN LISTAS ESTATICAS




        public static List<Cancha> listaCanchas;
        public void altaCancha(string Nombre, string Tipo, int CantJugadores)
        {
            Cancha newCancha = new Cancha();

            newCancha.nombre = Nombre;
            newCancha.tipo = Tipo;
            newCancha.cantJugadores = CantJugadores;

            listaCanchas.Add(newCancha);
        }

        
    }

}
