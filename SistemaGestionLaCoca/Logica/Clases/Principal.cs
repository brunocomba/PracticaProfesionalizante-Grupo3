using Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logica.Clases
{
    public class Principal
    {
        // ------------------------------------ LISTAS.

        public static List<Administrador> listaAdministradores;

        public static List<Cliente> listaClientes;

        public static List<Cancha> listaCanchas;

        public static List<Turno> listaTurnos;




        // ------------------------------------ ADMINISTRADORES.
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

        public void altaAdmin(string Nombre, string Apellido, int Dni, uint Tel, string User, string Pass)
        {
            Administrador newAdmin = new Administrador();

            newAdmin.nombre = Nombre;
            newAdmin.apellido = Apellido;
            newAdmin.dni = Dni;
            newAdmin.telefono = Tel;
            newAdmin.usuario = User;
            newAdmin.contrasenia = Pass;

            listaAdministradores.Add(newAdmin);
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
            listaAdministradores.Remove(adminABorrare);
        }



        // ------------------------------------ CLIENTES. 
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
                clienteBase.nombreYapellido = "Roman" + " Riquelme";

                listaClientes.Add(clienteBase);

                Cliente clienteBase2 = new Cliente();
                clienteBase2.nombre = "Joaquin";
                clienteBase2.apellido = "Lopez";
                clienteBase2.dni = 45414815;
                clienteBase2.telefono = 3493666650;
                clienteBase2.nombreYapellido = "Joaquin" + " Lopez";


                listaClientes.Add(clienteBase2);
            }
            return listaClientes;
        }
        public void altaCliente(string Nombre, string Apellido, int Dni, uint Tel)
        {
            Cliente newCliente = new Cliente();

            newCliente.nombre = Nombre;
            newCliente.apellido = Apellido;
            newCliente.dni = Dni;
            newCliente.telefono = Tel;
            newCliente.nombreYapellido = Nombre + " " + Apellido;


            listaClientes.Add(newCliente);
        }
        public void modificarCliente(Cliente clienteMod, string Nombre, string Apellido, int DNI, uint Tel)
        {
            clienteMod.nombre = Nombre;
            clienteMod.apellido = Apellido;
            clienteMod.dni = DNI;
            clienteMod.telefono = Tel;
            clienteMod.nombreYapellido = Nombre + " " + Apellido;
        }

        public void removeCliente(Cliente ClienteABorrar)
        {
            listaClientes.Remove(ClienteABorrar);
        }



        // ------------------------------------ CANCHAS.
        public static List<Cancha> ObtenerCanchas()
        {
            if (listaCanchas == null)
            {
                listaCanchas = new List<Cancha>();

                Cancha canchaBase = new Cancha();

                canchaBase.id = Cancha.GenerateID();
                canchaBase.nombre = "Norte";
                canchaBase.tipo = "BASQUET";
                canchaBase.cantJugadores = 8;
                canchaBase.precio = 4000;
                canchaBase.idYnombre = canchaBase.id + " Norte";



                listaCanchas.Add(canchaBase);

                Cancha canchaBase2 = new Cancha();

                canchaBase2.id = Cancha.GenerateID();
                canchaBase2.nombre = "Sur";
                canchaBase2.tipo = "FUTBOL";
                canchaBase2.cantJugadores = 10;
                canchaBase2.precio = 4000;
                canchaBase2.idYnombre = canchaBase2.id + " Sur";




                listaCanchas.Add(canchaBase2);
            }
            return listaCanchas;
        }
        public void altaCancha(string Nombre, string Tipo, int CantJugadores, int Precio)
        {
            Cancha newCancha = new Cancha();

            newCancha.id = Cancha.GenerateID();
            newCancha.nombre = Nombre;
            newCancha.tipo = Tipo;
            newCancha.cantJugadores = CantJugadores;
            newCancha.precio = Precio;
            newCancha.idYnombre = newCancha.id + " " + Nombre;


            listaCanchas.Add(newCancha);
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
            listaCanchas.Remove(CanchaABorrar);
        }


        // ------------------------------------ TURNOS.
        public static List<Turno> ObtenerTurnos()

        {
            if (listaTurnos == null)
            {
                listaTurnos = new List<Turno>();

                // PRIMER TURNO HARCODEADO.
                Turno turnoBase = new Turno();
                turnoBase.Id = Turno.GenerateID();
                turnoBase.Fecha = new DateTime(2023, 8, 27);
                turnoBase.Horario = ("16:30");
                turnoBase.condicionReservado = true;


                Cancha laCancha = Principal.ObtenerCanchas()[0];
                turnoBase.canchaTurno = laCancha;

                Cliente elCliente = Principal.ObtenerClientes()[0];
                turnoBase.clienteTurno = elCliente;
           

                listaTurnos.Add(turnoBase);

                // SEGUNDO TURNO HARCODEADO.
                Turno turnoBase2 = new Turno();
                turnoBase2.Id = Turno.GenerateID();
                turnoBase2.Fecha = new DateTime(2023, 8, 25);
                turnoBase2.Horario = ("18:00");
                turnoBase2.condicionReservado = true;

                Cancha canchaBase = Principal.ObtenerCanchas()[1];
                turnoBase2.canchaTurno = canchaBase;

                Cliente clienteBase = Principal.ObtenerClientes()[1];
                turnoBase2.clienteTurno = clienteBase;



                listaTurnos.Add(turnoBase2);
                
            }

            return listaTurnos;

        }
        
        public void altaTurno(Cancha cancha, Cliente cliente, DateTime fecha, string hora)
        {
            {
                
                Turno newTurno = new Turno();

                newTurno.Id = Turno.GenerateID();

                newTurno.canchaTurno = cancha;
                newTurno.clienteTurno = cliente;
                newTurno.Fecha = fecha;
                newTurno.Horario = hora;
                newTurno.condicionReservado = true;

            }

        }




       
    }

   
}
