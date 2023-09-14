using Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace Logica.Clases
{
    public class Principal
    {
        // Instancia de la base de datos.
        ApplicationDbContex context = new ApplicationDbContex();


        // ------------------------------------ LISTAS -------------------------------

        public  List<Administrador> ListaAdministradores = new List<Administrador>();

        public  List<Cliente> ListaClientes = new List<Cliente>();

        public List<Cancha> ListaCanchas = new List<Cancha>();

        public List<Turno> ListaTurnos = new List<Turno>();
     

        public static List<Cancha> listaCanchas;

        public static List<Turno> listaTurnos;

        
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


        // -------------------------------------------- ADMINISTRADORES ----------------------------------------------------------------

       
        // Alta
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

        // Modificacion
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

        // Baja
        public void RemoveAdmin(Administrador admiABorrar)
        {
            if (admiABorrar != null)
            {
                context.Administradores.Remove(admiABorrar);
                context.SaveChanges();
            }
        }

        // Devolver lista
        public  List<Administrador> ObtenerListaAdmi()
        {
            ListaAdministradores = context.Administradores.ToList();

            return ListaAdministradores;
        }


        // ------------------------------------------------------ METODOS DE VALIDACION Front Administradores.

        // Verificar que los textbox no esten vacios.

        public bool VerificarTextBoxAdmi(string Nombre, string Apellido, string Dni, string Tel, string User, string Pass, string ConfirPass)
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


        // Inicio de sesion (LogIn)
        public string  InicioDeSesion(string usuario, string pass)
        {
            ListaAdministradores = context.Administradores.ToList();


            if (ListaAdministradores.Count > 0)
            {
                foreach (var admiGuardado in ListaAdministradores)
                {
                    if (admiGuardado.Usuario == usuario && admiGuardado.Contrasenia == pass)
                    {
                        return $"Inicio de sesion exitoso.\n!Bienvenido, {usuario}! ";
                    }
                    else
                    {
                        return "Nombre de usuario o contraseña incorrectos.\nPor favor, inténtalo de nuevo.";
                    }
                }
            }
            return "No hay ningun administrador registrado en el sistema.";
           
        }


























        // ----------------------------------------------CLIENTES. 
 
        
        public void AltaCliente(string nombre, string apellido, int dni, decimal tel)
        {
            Cliente newCliente = new Cliente();

            newCliente.Nombre = nombre;
            newCliente.Apellido = apellido;
            newCliente.DNI = dni;
            newCliente.Telefono = tel;

            context.Clientes.Add(newCliente);
            context.SaveChanges();
        }
    
        
        public void modificarCliente(Cliente clienteMod, string nombre, string apellido, int dni, decimal tel)
        {
            if (clienteMod != null)
            {
                clienteMod.Nombre = nombre;
                clienteMod.Apellido = apellido;
                clienteMod.DNI = dni;
                clienteMod.Telefono = tel;

                context.Clientes.Update(clienteMod);
                context.SaveChanges();
            }          
        }
         
        public void removeCliente(Cliente clienteABorrar)
        {
            if (clienteABorrar != null)
            {
                context.Clientes.Remove(clienteABorrar);
                context.SaveChanges();
            }
        }

        public  List<Cliente> ObtenerListClientes()
        {
            ListaClientes = context.Clientes.ToList();

            return ListaClientes;
        }

        // Verificar que los textbox no esten vacios.
        public bool VerificarTextBoxCliente(string Nombre, string Apellido, string Dni, string Tel)
        {
            if (!string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Apellido) && !string.IsNullOrEmpty(Dni.ToString()) &&
                !string.IsNullOrEmpty(Tel.ToString()))
            {
                return true;

            }
            return false;

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

           

                listaTurnos.Add(turnoBase);

                // SEGUNDO TURNO HARCODEADO.
                Turno turnoBase2 = new Turno();
                turnoBase2.Id = Turno.GenerateID();
                turnoBase2.Fecha = ("27/08/2023");
                turnoBase2.Horario = ("18:00");
                turnoBase2.condicionReservado = true;

                Cancha canchaBase = Principal.ObtenerCanchas()[1];
                turnoBase2.canchaTurno = canchaBase;




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
