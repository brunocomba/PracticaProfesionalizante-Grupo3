using Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases.Clases
{
    public class Principal
    {
        // ---------------------------------------------
        // ADMINISTRADORES

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


        public void modificarAdmin(Administrador admiMod, string Nombre, string Apellido, int DNI, uint Tel, string User, string Pass)
        {
            admiMod.nombre = Nombre;
            admiMod.apellido = Apellido;
            admiMod.dni = DNI;
            admiMod.telefono = Tel;
            admiMod.usuario = User;
            admiMod.contrasenia = Pass;
        }

        public void removeAdmin(Administrador adminABorrare)
        {
            ObtenerAdministradores().Remove(adminABorrare);
        }

        // --------------------------------------------------------- 
        // CLIENTES

        public static List<Cliente> listaClientes;
        public static List<Cliente> ObtenerClientes()
        {
            if (listaClientes == null)
            {
                listaClientes = new List<Cliente>();

                Cliente clienteBase = new Cliente();

                clienteBase.nombre = "Roman";
                clienteBase.apellido = "Riquelme";
                clienteBase.dni = 28167907;
                clienteBase.telefono = 2299665477;


                listaClientes.Add(clienteBase);
            }
            return listaClientes;
        }
        public void ataCliente(string Nombre, string Apellido, int Dni, uint Tel)
        {
            Cliente newCliente = new Cliente();

            newCliente.nombre = Nombre;
            newCliente.apellido = Apellido;
            newCliente.dni = Dni;
            newCliente.telefono = Tel;


            ObtenerClientes().Add(newCliente);
        }
        public void modificarCliente(Cliente clienteMod, string Nombre, string Apellido, int DNI, uint Tel)
        {
            clienteMod.nombre = Nombre;
            clienteMod.apellido = Apellido;
            clienteMod.dni = DNI;
            clienteMod.telefono = Tel;
        }

        public void removeCliente(Cliente ClienteABorrar)
        {
            ObtenerClientes().Remove(ClienteABorrar);
        }


        // -------------------------------------------------------------------------------------

        // CANCHAS

        public static List<Cancha> listaCanchas;
        public static List<Cancha> ObtenerCanchas()
        {
            if (listaCanchas == null)
            {
                listaCanchas = new List<Cancha>();

                Cancha canchaBase = new Cancha();

                canchaBase.id = IDCancha.GenerateID();
                canchaBase.nombre = "Norte";
                canchaBase.tipo = "BASQUET";
                canchaBase.cantJugadores = 8;
                canchaBase.precio = 4000;


                listaCanchas.Add(canchaBase);

                Cancha canchaBase2 = new Cancha();

                canchaBase2.id = IDCancha.GenerateID();
                canchaBase2.nombre = "Sur";
                canchaBase2.tipo = "FUTBOL";
                canchaBase2.cantJugadores = 10;
                canchaBase2.precio = 4000;


                listaCanchas.Add(canchaBase2);
            }
            return listaCanchas;
        }
        public void altaCancha(string Nombre, string Tipo, int CantJugadores, int Precio)
        {
            Cancha newCancha = new Cancha();

            newCancha.id = IDCancha.GenerateID();
            newCancha.nombre = Nombre;
            newCancha.tipo = Tipo;
            newCancha.cantJugadores = CantJugadores;
            newCancha.precio = Precio;

            ObtenerCanchas().Add(newCancha);
        }

        public void modificarCancha(Cancha canchaMod, string Nombre, string Tipo, int CantJug, int Precio)
        {
            canchaMod.nombre = Nombre;
            canchaMod.tipo = Tipo;
            canchaMod.cantJugadores = CantJug;
            canchaMod.precio = Precio;
        }

        public void removeCancha(Cancha CanchaABorrar)
        {
            ObtenerCanchas().Remove(CanchaABorrar);
        }

        // -------------------------------------------------------------------------------------

        // TURNOS


        public static List<Turno> listaTurnos;
        public static List<Turno> ObtenerTurnos()
        {
            if (listaTurnos == null)
            {
                listaTurnos = new List<Turno>();

                Turno turnoBase = new Turno();

                turnoBase.id = IDTurno.GenerateID();
                turnoBase.fecha = new DateOnly(2023, 8, 8);
                turnoBase.horario = new TimeOnly(15, 30);
                turnoBase.precio = 8000;


                listaTurnos.Add(turnoBase);

                Turno turnoBase2 = new Turno();

                turnoBase2.id = IDTurno.GenerateID();
                turnoBase2.fecha = new DateOnly(2023, 8, 10);
                turnoBase2.horario = new TimeOnly(18, 30);
                turnoBase2.precio = 7000;
                


                listaTurnos.Add(turnoBase2);
            }
            return listaTurnos;
        }
        public void altaTurno(DateOnly Fecha, TimeOnly Hora, int Precio, Cancha CanchaTurno, Cliente cliente)
        {
            {
                Turno newTurno = new Turno();

                newTurno.id = IDTurno.GenerateID();
                newTurno.fecha = Fecha;
                newTurno.horario = Hora;
                newTurno.precio = Precio;
                newTurno.cancha = CanchaTurno;
                newTurno.cliente = cliente;

                ObtenerTurnos().Add(newTurno);
            }

        }
}   }
