using Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                clienteBase.nombreYapellido = "Roman" + " Riquelme";
                clienteBase.Turnos = new List<Turno>();

                listaClientes.Add(clienteBase);

                Cliente clienteBase2 = new Cliente();
                clienteBase2.nombre = "Joaquin";
                clienteBase2.apellido = "Lopez";
                clienteBase2.dni = 45414815;
                clienteBase2.telefono = 3493666650;
                clienteBase2.nombreYapellido = "Joaquin" + " Lopez";
                clienteBase2.Turnos = new List<Turno>(); 

                listaClientes.Add(clienteBase2);
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
            newCliente.nombreYapellido = Nombre + " " + Apellido;


            ObtenerClientes().Add(newCliente);
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
                canchaBase.idYnombre = canchaBase.id + " Norte";
                canchaBase.Turnos = new List<Turno>();
                canchaBase.Horarios = new List<Horario>();


                listaCanchas.Add(canchaBase);

                Cancha canchaBase2 = new Cancha();

                canchaBase2.id = IDCancha.GenerateID();
                canchaBase2.nombre = "Sur";
                canchaBase2.tipo = "FUTBOL";
                canchaBase2.cantJugadores = 10;
                canchaBase2.precio = 4000;
                canchaBase2.idYnombre = canchaBase2.id + " Sur";
                canchaBase2.Turnos = new List<Turno>(); 
                canchaBase2.Horarios = new List<Horario>();



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
            newCancha.idYnombre = newCancha.id + " " + Nombre;


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

                // PRIMER TURNO HARCODEADO.
                Turno turnoBase = new Turno();
                turnoBase.id = IDTurno.GenerateID();
                turnoBase.fecha = new DateOnly(2023, 8, 8);
                turnoBase.horario = new TimeOnly(15, 30);
              
                Cancha laCancha = Principal.ObtenerCanchas()[0];
                turnoBase.cancha = laCancha;
                turnoBase.canchaID = laCancha.id;
                turnoBase.tipoCancha = laCancha.tipo;
                turnoBase.precio = laCancha.precio;
                
                Cliente elCliente = Principal.ObtenerClientes()[0];
                turnoBase.cliente = elCliente;
                turnoBase.nombreCliente = elCliente.nombre;
                turnoBase.apellidoCliente = elCliente.apellido;
                turnoBase.telCliente = elCliente.telefono;

                laCancha.Turnos.Add(turnoBase);
                elCliente.Turnos.Add(turnoBase);
                listaTurnos.Add(turnoBase);

                // SEGUNDO TURNO HARCODEADO.
                Turno turnoBase2 = new Turno();
                turnoBase2.id = IDTurno.GenerateID();
                turnoBase2.fecha = new DateOnly(2023, 8, 10);
                turnoBase2.horario = new TimeOnly(15, 30);

                Cancha canchaBase = Principal.ObtenerCanchas()[1];
                turnoBase2.cancha = canchaBase;
                turnoBase2.canchaID = canchaBase.id;
                turnoBase2.tipoCancha = canchaBase.tipo;
                turnoBase2.precio = canchaBase.precio;

                Cliente clienteBase = Principal.ObtenerClientes()[1];
                turnoBase.cliente = clienteBase;
                turnoBase2.nombreCliente = clienteBase.nombre;
                turnoBase2.apellidoCliente = clienteBase.apellido;
                turnoBase2.telCliente = clienteBase.telefono;

                canchaBase.Turnos.Add(turnoBase2);   
                clienteBase.Turnos.Add(turnoBase2); 
                listaTurnos.Add(turnoBase2);
                
            }

            return listaTurnos;
        }
        public void altaTurno(Cancha cancha, Cliente cliente)
        {
            {
                Turno newTurno = new Turno();

                newTurno.id = IDTurno.GenerateID();

                newTurno.precio = cancha.precio;
                newTurno.canchaID = cancha.id;
                newTurno.tipoCancha = cancha.tipo;

                newTurno.cliente = cliente;
                newTurno.nombreCliente = cliente.nombre;
                newTurno.apellidoCliente = cliente.apellido;
                newTurno.telCliente = cliente.telefono;

                cancha.Turnos.Add(newTurno);
                cliente.Turnos.Add(newTurno);

                ObtenerTurnos().Add(newTurno);
            }

        }





        // ------------------------------------ HORARIOS.

        public static List<Horario> listaHorarios;
        public static List<Horario> ObtenerHorarios()
        {
            if (listaHorarios == null)
            {
                listaHorarios = new List<Horario>();

                Horario horarioBase = new Horario();

                horarioBase.hora = "17:00";
                Cancha canchaBase = Principal.ObtenerCanchas()[0];
                horarioBase.cancha = canchaBase;
                horarioBase.nombreCancha = canchaBase.idYnombre;
                listaHorarios.Add(horarioBase);
                canchaBase.Horarios.Add(horarioBase);


                Horario horarioBase2 = new Horario();
                horarioBase2.hora = "18:30";
                Cancha canchaBase2 = Principal.ObtenerCanchas()[1];
                horarioBase2.cancha = canchaBase2;
                horarioBase2.nombreCancha = canchaBase2.idYnombre;
                listaHorarios.Add(horarioBase2);
                canchaBase2.Horarios.Add(horarioBase2);


                Horario horarioBase3 = new Horario();
                horarioBase3.hora = "19:30";
                Cancha canchaBase3 = Principal.ObtenerCanchas()[1];
                horarioBase3.cancha = canchaBase3;
                horarioBase3.nombreCancha = canchaBase3.idYnombre;
                listaHorarios.Add(horarioBase3);
                canchaBase3.Horarios.Add(horarioBase3);


            }
            return listaHorarios;
        }
        public void altaHorario(string Hora, Cancha cancha)
        {
            {
                Horario newHorario = new Horario();

                newHorario.hora = Hora;
                newHorario.cancha = cancha;
                newHorario.nombreCancha = cancha.idYnombre;
                cancha.Horarios.Add(newHorario);
               

                ObtenerHorarios().Add(newHorario);
            }

        }
    }

   
}
