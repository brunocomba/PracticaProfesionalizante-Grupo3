using Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

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
            
            // si los strings ingresados son nulos, devuelve ese mensaje en un messagebox
            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(pass))
            {
                return "Complete los campos por favor.";
            }

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
    
        
        public void ModificarCliente(Cliente clienteMod, string nombre, string apellido, int dni, decimal tel)
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
      
       
        public void AltaCancha(string nombre, string tipo, int cantJugadores, int precio)
        {
            Cancha newCancha = new Cancha();

            newCancha.Nombre = nombre;
            newCancha.Tipo = tipo;
            newCancha.Cantidad_Jugadores = cantJugadores;
            newCancha.Precio = precio;

            context.Canchas.Add(newCancha);
            context.SaveChanges();
        }

        public void modificarCancha(Cancha canchaMod, string nombre, string tipo, int cantJug, int precio)
        {
            if (canchaMod != null)
            {
                canchaMod.Nombre = nombre;
                canchaMod.Tipo = tipo;
                canchaMod.Cantidad_Jugadores = cantJug;
                canchaMod.Precio = precio;

                context.Canchas.Update(canchaMod);
                context.SaveChanges();
            }
           
        }

        public void removeCancha(Cancha CanchaABorrar)
        {
            if (CanchaABorrar != null)
            {
                context.Canchas.Remove(CanchaABorrar);
                context.SaveChanges();  

            }
        }

        public List<Cancha> ObtenerListaCanchas()
        {
            ListaCanchas = context.Canchas.ToList();

            return ListaCanchas;
        }


        // ------------------------------------ TURNOS.

        public static List<Turno> ObtenerTurnos()

        {
            if (listaTurnos == null)
            {
                listaTurnos = new List<Turno>();

                // PRIMER TURNO HARCODEADO.
                Turno turnoBase = new Turno();
                turnoBase.Fecha = ("28/08/2023");
                turnoBase.Horario = ("16:30");



           

                listaTurnos.Add(turnoBase);

                // SEGUNDO TURNO HARCODEADO.
                Turno turnoBase2 = new Turno();
                turnoBase2.Fecha = ("27/08/2023");
                turnoBase2.Horario = ("18:00");





                listaTurnos.Add(turnoBase2);
                
            }

            return listaTurnos;

        }
        
        public void altaTurno(Cancha cancha, Cliente cliente, string fecha, string hora)
        {
            {
                
                Turno newTurno = new Turno();


                newTurno.Cancha_Turno = cancha;
                newTurno.Cliente_Turno = cliente;
                newTurno.Fecha = fecha;
                newTurno.Horario = hora;
                newTurno.Reservado = true;

                listaTurnos.Add(newTurno);

            }

        }




       
    }

   
}
