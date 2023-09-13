using Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;




namespace Logica.Clases
{
    public class Principal
    {
        // Instancia de la base de datos.
        ApplicationDbContex context = new ApplicationDbContex();


        // ------------------------------------ LISTAS.

        public List<Administrador> ListaAdministradores = new List<Administrador>();

     

        public static List<Cancha> listaCanchas;

        public static List<Turno> listaTurnos;

        public List<Administrador> ObtenerListaAdmi()
        {
            ListaAdministradores = context.Administradores.ToList();

            return ListaAdministradores;
        }
        
        
        // ------------------------------------ VERIFICAR CARACTERES INGRESADOS.
        public bool SoloLetras(string textBox)
        {
            foreach (char caracter in textBox)
            {
                if (!char.IsLetter(caracter))
                {
                    return false;

                }
            }
            return true;
        }

        public bool SoloNumeros(string textBox)
        {
            foreach (char caracter in textBox)
            {
                if (!char.IsDigit(caracter))
                {
                    return false;
                }
            }
            return true;
        }


        // ------------------------------------ ADMINISTRADORES.

       
        // ALTA
        public void AltaAdmi(string nombre, string apellido, int dni, decimal tel, string user, string pass)
        {
            Administrador newAdmin = new Administrador();

            newAdmin.Nombre = nombre;
            newAdmin.Apellido = apellido;
            newAdmin.DNI = dni;
            newAdmin.Telefono = tel;
            newAdmin.Usuario = user;
            newAdmin.Contrasenia = pass;

            context.Administradores.Add(newAdmin);  
            context.SaveChanges();
        }

        // MODIFICACION
        public void ModificarAdmin(Administrador admiMod, string nombre, string apellido, int dni, decimal tel, string user, string pass)
        {
            if (admiMod != null)
            {
                admiMod.Nombre = nombre;
                admiMod.Apellido = apellido;
                admiMod.DNI = dni;
                admiMod.Telefono = tel;
                admiMod.Usuario = user;
                admiMod.Contrasenia = pass;

                context.Administradores.Update(admiMod);
                context.SaveChanges();
            }
        }

        // BAJA
        public void RemoveAdmin(Administrador admiABorrar)
        {
            if (admiABorrar != null)
            {
                context.Administradores.Remove(admiABorrar);
                context.SaveChanges();
            }
        }
            // ------------------------------------------------------ METODOS DE VALIDACION.

            // Verificar que los textbox no esten vacios.

        public bool VerificarTextBoxesDatosPersonales(string Nombre, string Apellido, string Dni, string Tel)
        {
            if (!string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Apellido) && !string.IsNullOrEmpty(Dni.ToString()) &&
                !string.IsNullOrEmpty(Tel.ToString()))
            {
                return true;

            }
            return false;

        }
        public bool VerificarTextBoxes(string Nombre, string Apellido, string Dni, string Tel, string User, string Pass, string ConfirPass)
        {
            if(!string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Apellido) && !string.IsNullOrEmpty(Dni.ToString()) &&
                !string.IsNullOrEmpty(Tel.ToString()) && !string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(Pass) && !string.IsNullOrEmpty(ConfirPass))
            {
                return true;

            }
            return false;

        }


        // Confirmar si la confirmacion de la contraseña coincide con la prev ingresada.
        public bool confirmarPass(string Pass, string ConfirPass)
        {
            if (Pass == ConfirPass)
            {
                return true;

            }
            return false;

        }

        // Verificar que la contraseña ingresada contiene al menos una letra MAYUSCULA y un numero.
        public bool CumpleRequisitos(string Contra)
        {
            bool tieneMayuscula = Regex.IsMatch(Contra, @"[A-Z]");
            bool tieneNumero = Regex.IsMatch(Contra, @"\d");

            if (tieneMayuscula && tieneNumero)
            {
                return true;
            }
            return false; 
        }

        // Verificar que contenga si o si 10 caracteres lo ingresado en el apartado Telefono
        public bool TelCompleto(string Tel)
        {
            int minimoDeCaracteres = 10;

            if (Tel.Length < minimoDeCaracteres)
            {
                return false;
            }
            return true;
        }
        // Verificar que contenga si o si 8 caracteres lo ingresado en el apartado DNI
        public bool DniCompleto(string DNI)
        {
            int minimoDeCaracteres = 8;

            if (DNI.Length < minimoDeCaracteres)
            {
                return false;
            }
            return true;
        }


        public static List<Cliente> listaClientes;
        // ----------------------------------------------CLIENTES. 
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
                turnoBase.Fecha = ("28/08/2023");
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
                turnoBase2.Fecha = ("27/08/2023");
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
        
        public void altaTurno(Cancha cancha, Cliente cliente, string fecha, string hora)
        {
            {
                
                Turno newTurno = new Turno();

                newTurno.Id = Turno.GenerateID();

                newTurno.canchaTurno = cancha;
                newTurno.clienteTurno = cliente;
                newTurno.Fecha = fecha;
                newTurno.Horario = hora;
                newTurno.condicionReservado = true;

                listaTurnos.Add(newTurno);

            }

        }




       
    }

   
}
