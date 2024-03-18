using Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

using static Logica.Clases.Turno;
using System.Runtime.CompilerServices;

namespace Logica.Clases
{
    public class Principal
    {
        // ------------------------------
        // Instancia de la base de datos.
        // ------------------------------

        ApplicationDbContex context = new ApplicationDbContex();


        // ----------------------------------
        // Metodos de verificacion generales.
        // ----------------------------------

        public bool SoloLetras(string textBox) // Verificar que la cadena tenga Solo Letras.
        {
            foreach (char caracter in textBox)
            {
                if (char.IsDigit(caracter))
                {
                    return true;

                }
            }
            return false;
        }

        
        public bool SoloNumeros(string textBox) // Verificar que la cadena tenga Solo Numeros.
        {
            foreach (char caracter in textBox)
            {
                if (char.IsLetter(caracter))
                {
                    return true;
                }
            }
            return false;
        }

        
        public bool TelCompleto(string Tel) // Verificar que contenga 10 caracteres lo ingresado en el apartado Telefono
        {
            int minimoDeCaracteres = 10;

            if (Tel.Length < minimoDeCaracteres)
            {
                return true;
            }
            return false;
        }

    
        public bool DniCompleto(string DNI) // Verificar que contenga 8 caracteres lo ingresado en el apartado DNI
        {
            int minimoDeCaracteres = 8;

            if (DNI.Length < minimoDeCaracteres)
            {
                return true;
            }

            return false;
        }



        // -----------------
        // Administradores
        // -----------------

        // Alta
        public void AltaAdmi(string nombre, string apellido, string dni, string tel, string user, string pass, string confirmPass)
        {
            

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(tel)
                || string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrEmpty(confirmPass))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (DniCompleto(dni))
            {
                throw new Exception("El DNI esta incompleto.");
            }
            
            if (TelCompleto(tel))
            {
                throw new Exception("El Numero de Telefeno ingresado esta incomleto.\nEs necesario el codigo de area.");
            }

            if (SoloNumeros(dni) || SoloNumeros(tel))
            {
                throw new Exception("El DNI o Numero de Telefono ingresado no puede letras.");
            }
            
            if (SoloLetras(nombre) || SoloLetras(apellido))
            {
                throw new Exception("El Nombre o Apellido ingresado no puede contener numeros.");
            }
            if (CumpleRequisitos(pass) == false) 
            {
                throw new Exception("La contraseña debe contener al menos una mayuscula y una letra.");
            }
            if (confirmarPass(pass, confirmPass) == false)
            {
                throw new Exception("Las contraseñas ingresadas no coinciden.");
            }


            Administrador newAdmin = new Administrador();

            newAdmin.Nombre = nombre;
            newAdmin.Apellido = apellido;
            newAdmin.DNI = int.Parse(dni);
            newAdmin.Telefono = long.Parse(tel);
            newAdmin.Usuario = user;
            newAdmin.Contrasenia = pass;
            newAdmin.Logueado = Administrador.SioNo.NO;

            var listaAdmisCreados = context.Administradores.ToList();

            foreach (var admi in listaAdmisCreados)
            {
                if (admi.Nombre == newAdmin.Nombre && admi.Apellido == newAdmin.Apellido && admi.DNI == newAdmin.DNI && admi.Telefono == newAdmin.Telefono )
                {
                    throw new Exception("Ya exixste un usuario creado con EXACTAMENTE los mismos datos creados.");
                }

                if (admi.Usuario == newAdmin.Usuario)
                {
                    throw new Exception("El nombre de usuario ya existe.");

                }
            }

            context.Administradores.Add(newAdmin);  
            context.SaveChanges();
        }

        // Modificacion
        public void ModificarAdmin(Administrador admiMod, string nombre, string apellido, string dni, string tel, string user, string pass, string confirmPass)
        { 
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(tel)
                || string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrEmpty(confirmPass))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (DniCompleto(dni))
            {
                throw new Exception("El DNI esta incompleto.");
            }

            if (TelCompleto(tel))
            {
                throw new Exception("El Numero de Telefeno ingresado esta incomleto.\nEs necesario el codigo de area.");
            }

            if (SoloNumeros(dni) || SoloNumeros(tel))
            {
                throw new Exception("El DNI o Numero de Telefono ingresado no puede letras.");
            }

            if (SoloLetras(nombre) || SoloLetras(apellido))
            {
                throw new Exception("El Nombre o Apellido ingresado no puede contener numeros.");
            }
            if (CumpleRequisitos(pass) == false)
            {
                throw new Exception("La contraseña debe contener al menos una mayuscula y una letra.");
            }

            if (confirmarPass(pass, confirmPass) == false)
            {
                throw new Exception("Las contraseñas ingresadas no coinciden.");
            }

            if (admiMod != null)
            {
                admiMod.Nombre = nombre;
                admiMod.Apellido = apellido;
                admiMod.DNI = int.Parse(dni);
                admiMod.Telefono = long.Parse(tel);
                admiMod.Usuario = user;
                admiMod.Contrasenia = pass;
                admiMod.Logueado = Administrador.SioNo.NO;

                var listaAdmisCreados = context.Administradores.ToList();

                foreach (var admi in listaAdmisCreados)
                {
                    if (admi.Nombre == admiMod.Nombre && admi.Apellido == admiMod.Apellido && admi.DNI == admiMod.DNI && admi.Telefono == admiMod.Telefono)
                    {
                        throw new Exception("Ya exixste un usuario creado con EXACTAMENTE los mismos datos creados.");
                    }

                    if (admi.Usuario == admiMod.Usuario)
                    {
                        throw new Exception("El nombre de usuario ya existe.");

                    }
                }

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
            var listaAdmi = context.Administradores.ToList();

            return listaAdmi;
        }

        // --------------------------------------
        // Metodos de verificacion para el LogIn.
        // --------------------------------------


        // Verificar si la confirmacion de la contraseña coincide con la prev ingresada.
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

        // Metodo de logueo.
        public bool LogIn(string user, string pass)
        {
            var listaAdm = context.Administradores.ToList();
            bool resultado = false;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                throw new Exception("Complete los campos por favor.");

            }

            if (listaAdm.Count < 0)
            {
                throw new Exception("No hay ningun administrador registrado en el sistema.");

            }

            foreach (var adm in listaAdm)
            {

                if (adm.Usuario == user && adm.Contrasenia == pass)
                {
                    adm.Logueado = Administrador.SioNo.SI; // al entrar al sist, ponerle que SI a la propiedad Logueado.
                    context.Administradores.Update(adm);
                    context.SaveChanges();
                    resultado = true;
                    
                }
                else
                {
                    resultado = false;
                    
                }
            }
            
            return resultado;
           
        }

        public static ApplicationDbContex GetContext()
        {
            ApplicationDbContex context = new ApplicationDbContex();

            return context;
        }

        // Buscar los administradores que esten actualmente logueados.
        public static Administrador BuscarAdmLogueado(ApplicationDbContex context)
        {
            var admLogueado = context.Administradores.First(adm => adm.Logueado == Administrador.SioNo.SI);

            return admLogueado;
        }







        // ----------
        // CLIENTES. 
        // ----------

        public void AltaCliente(string nombre, string apellido, string dni, string tel)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(tel))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (DniCompleto(dni))
            {
                throw new Exception("El DNI esta incompleto.");
            }

            if (TelCompleto(tel))
            {
                throw new Exception("El Numero de Telefeno ingresado esta incomleto.\nEs necesario el codigo de area.");
            }

            if (SoloNumeros(dni) || SoloNumeros(tel))
            {
                throw new Exception("El DNI o Numero de Telefono ingresado no puede letras.");
            }

            if (SoloLetras(nombre) || SoloLetras(apellido))
            {
                throw new Exception("El Nombre o Apellido ingresado no puede contener numeros.");
            }
            Cliente newCliente = new Cliente();

            newCliente.Nombre = nombre;
            newCliente.Apellido = apellido;
            newCliente.DNI = int.Parse(dni);
            newCliente.Telefono = long.Parse(tel);

            context.Clientes.Add(newCliente);
            context.SaveChanges();
        }
    
        
        public void ModificarCliente(Cliente clienteMod, string nombre, string apellido, string dni, string tel)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(tel))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (DniCompleto(dni))
            {
                throw new Exception("El DNI esta incompleto.");
            }

            if (TelCompleto(tel))
            {
                throw new Exception("El Numero de Telefeno ingresado esta incomleto.\nEs necesario el codigo de area.");
            }

            if (SoloNumeros(dni) || SoloNumeros(tel))
            {
                throw new Exception("El DNI o Numero de Telefono ingresado no puede letras.");
            }

            if (SoloLetras(nombre) || SoloLetras(apellido))
            {
                throw new Exception("El Nombre o Apellido ingresado no puede contener numeros.");
            }
            if (clienteMod != null)
            {
                clienteMod.Nombre = nombre;
                clienteMod.Apellido = apellido;
                clienteMod.DNI = int.Parse(dni);
                clienteMod.Telefono = long.Parse(tel);

                context.Clientes.Update(clienteMod);
                context.SaveChanges();
            }          
        }
         
        public void removeCliente(Cliente clienteABorrar)
        {
            if (clienteABorrar == null)
            {
                throw new Exception("No hay ningun cliente seleccionado");

            }
            context.Clientes.Remove(clienteABorrar);
            context.SaveChanges();
        }


        public  List<Cliente> ObtenerListClientes()
        {
            var listaClientes = context.Clientes.ToList();

            return listaClientes;
        }

        // -------------
        // DEPORTES
        // -------------



        public List<Deporte> ObtenerListaDeportes()
        {
            var listaDeportes = context.Deportes.ToList();

            return listaDeportes;
        }


        public void altaDeporte(string nombre, string cantJugadores)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(cantJugadores))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (SoloNumeros(cantJugadores))
            {
                throw new Exception("La cantidad de jugadores ingresada no puede contener letras.");
            }

            if (SoloNumeros(nombre))
            {
                throw new Exception("El nombre ingresado no puede contener numeros.");

            }

            Deporte deporteNew = new Deporte();
            deporteNew.Name = nombre;
            deporteNew.Cant_Jugadores = cantJugadores;

            context.Deportes.Add(deporteNew);   
            context.SaveChanges();
        }

        public void removeDeporte(Deporte deporteABorrar)
        {
            if (deporteABorrar != null)
            {
                context.Deportes.Remove(deporteABorrar);
                context.SaveChanges();

            }
            else
            {
                throw new Exception("No hay ningun deporte seleccionado.");

            }
        }

        // -------------
        // CANCHAS.
        // -------------

        public void AltaCancha(string nombre,Deporte deporte, string precio)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(precio))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (SoloNumeros(precio))
            {
                throw new Exception("El precio ingresado no puede contener letras.");
            }

            if (SoloNumeros(nombre))
            {
                throw new Exception("El nombre ingresado no puede contener numeros.");

            }


            Cancha newCancha = new Cancha();

            newCancha.nombre = nombre;
            newCancha.Deporte = deporte;;
            newCancha.Precio = decimal.Parse(precio);

            context.Canchas.Add(newCancha);
            context.SaveChanges();
        }

        public void modificarCancha(Cancha canchaMod, string nombre, Deporte deporte, string precio)
        {
            if (string.IsNullOrWhiteSpace(nombre)  || string.IsNullOrWhiteSpace(precio))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (SoloNumeros(precio))
            {
                throw new Exception("El precio ingresado no puede contener letras.");
            }

            if (SoloNumeros(nombre))
            {
                throw new Exception("El nombre ingresado no puede contener numeros.");

            }

            if (canchaMod != null)
            {
                canchaMod.nombre = nombre;
                canchaMod.Deporte = deporte;
                canchaMod.Precio = decimal.Parse(precio);

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
            var listaCanchas = context.Canchas.ToList();

            return listaCanchas;
        }

        public List<string> DeportesSinRepetir()
        {
            var listaDeportes = new List<string>();

            foreach (var cancha in ObtenerListaCanchas())
            {
                if (!listaDeportes.Contains(cancha.Deporte.Name))  // no tiene ese deporte en la lista de deportes que hay
                {
                    listaDeportes.Add(cancha.Deporte.Name);
                }

            }
            return listaDeportes;

        }

        public List<Cancha> CanchasDeSoloUnDeporte(string deporte)
        {
            var canchasFiltraadas = ObtenerListaCanchas().Where(cancha => cancha.Deporte.Name == deporte).ToList();

            return canchasFiltraadas;
        }


        // Obtener listado completo. Ya que tiene propiedades de tipo objeto la clase  Cancha
        public DataTable ListadoCanchas()
        {
            var consulta = from cancha in context.Canchas
                           join deporte in context.Deportes on cancha.Deporte.ID equals deporte.ID

                           select new
                           {
                               cancha.ID,
                               cancha.nombre,
                               deporte.Name,
                               deporte.Cant_Jugadores,
                               cancha.Precio,

                           };

            // convertir en lista la consulta 
            var listaConsulta = consulta.ToList();

            // crear datatable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Cancha", typeof(int));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Deporte", typeof(string));
            dataTable.Columns.Add("Jugadores", typeof(int));
            dataTable.Columns.Add("Precio", typeof(int));
            


            // asiganar los valores de la lista al datatable

            foreach (var resultado in listaConsulta)
            {
                dataTable.Rows.Add(resultado.ID, resultado.nombre, resultado.Name, resultado.Cant_Jugadores, resultado.Precio);
            }

            return dataTable;

        }


        // -----------------
        // TURNOS.
        // -----------------


        // Lista horarios Futbol
        public List<string> ListaHorariosFutbol()
        {
            var horariosFutbol = new List<string>
            {
                    "16:00",
                    "16:30",
                    "17:00",
                    "17:30",
                    "18:00",
                    "18:30",
                    "19:00",
                    "19:30",
                    "20:00",
                    "20:30",
                    "21:00",
                    "21:30"
            };


            return horariosFutbol;
        }



        // Lista horarios Basquet
        public List<string> ListaHorariosBasquet()
        {
            var horariosBasquet = new List<string>
            {
                    "16:00",
                    "17:00",
                    "18:00",
                    "19:00",
                    "20:00",
                    "21:00",
                    "22:00"
            };

          
            return horariosBasquet;
        }

     
        // Alta turno
        public void AltaTurno(Cliente cliente, Cancha cancha, string fecha, string hora)
        {  
            var listaTurnos = context.Turnos.ToList();
            foreach (var turn in listaTurnos)
            {
                if (turn.Horario.Contains(hora) && turn.Fecha.Contains(fecha) && turn.Cancha.Equals(cancha)) // verificar que el turno no este registrado
                {
                    throw new Exception("El turno solicitado ya se encuentra registrado.");
                }
            }

            Turno turno = new Turno();
            turno.Cliente = cliente;
            turno.Cancha = cancha;
            turno.Fecha = fecha;
            turno.Horario = hora;

            context.Turnos.Add(turno);
            context.SaveChanges();

        }
        public void ModificarTurno(Turno turnoMod, Cliente cliente, Cancha cancha, string fecha, string hora)
        {

            var listaTurnos = context.Turnos.ToList();
            foreach (var turn in listaTurnos)
            {
                if (turn.Cliente.Equals(cliente) && turn.Horario.Contains(hora) && turn.Fecha.Contains(fecha) && turn.Cancha.Equals(cancha)) // verificar que el turno no este registrado
                {
                    throw new Exception("El turno solicitado ya se encuentra registrado.");
                }
            }

            //var turnoEncontrado = context.Turnos.Find(IdTurno);
            if (turnoMod != null) // si es distinto de null, quiere decir que encontro el turno
            {
                turnoMod.Cliente = cliente;
                turnoMod.Cancha = cancha;
                turnoMod.Fecha = fecha;
                turnoMod.Horario = hora;


                context.Turnos.Update(turnoMod);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("No se a encotrado el turno.");

            }
        }

        public void EliminarTurno(int IdTurno)
        {
            var turnoEncontrado = context.Turnos.Find(IdTurno);
            if (turnoEncontrado != null)
            {
                context.Turnos.Remove(turnoEncontrado);
                context.SaveChanges(); 
            }
        }

        public List<Turno> GetTurnos()
        {
            var listaTurnos = context.Turnos.ToList();

            return listaTurnos;
        }

        
        // Obtener listado completo. Ya que tiene propiedades de tipo objeto la clase Turno
        public DataTable ListadoTurnos()
        {
            var consulta = from turno in context.Turnos
                           join cliente in context.Clientes on turno.Cliente.ID equals cliente.ID
                           join cancha in context.Canchas on turno.Cancha.ID equals cancha.ID

                           select new
                           {
                               turno.ID,
                               turno.Fecha,
                               turno.Horario,
                               cancha.Deporte,
                               cancha.nombre,
                               cliente.Nombre,
                               cliente.Apellido,
                               cliente.Telefono,
                               

                           };

            // convertir en lista la consulta 
            var listaConsulta = consulta.ToList();

            // crear datatable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Turno", typeof(int));
            dataTable.Columns.Add("Fecha", typeof(string));
            dataTable.Columns.Add("Horario", typeof(string));
            dataTable.Columns.Add("Deporte", typeof(string));
            dataTable.Columns.Add("Cancha", typeof(string));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Apellido", typeof(string));
            dataTable.Columns.Add("Telefono", typeof(long));



            // asiganar los valores de la lista al datatable

            foreach (var resultado in listaConsulta)
            {
                dataTable.Rows.Add(resultado.ID, resultado.Fecha, resultado.Horario, resultado.Deporte, resultado.nombre, resultado.Nombre, resultado.Apellido, resultado.Telefono);
            }
            
            return dataTable;
            
        }


        // Obtener unicamente los turnos del dia actual
        public DataTable turnosDelDia()
        {
            var consulta = from turno in context.Turnos
                           join cliente in context.Clientes on turno.Cliente.ID equals cliente.ID
                           join cancha in context.Canchas on turno.Cancha.ID equals cancha.ID

                           select new
                           {
                               turno.ID,
                               turno.Fecha,
                               turno.Horario,
                               cancha.Deporte,
                               cancha.nombre,
                               cliente.Nombre,
                               cliente.Apellido,
                               cliente.Telefono,

                           };

            // convertir en lista la consulta 
            var listaConsulta = consulta.ToList();

            // crear datatable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Turno", typeof(int));
            dataTable.Columns.Add("Fecha", typeof(string));
            dataTable.Columns.Add("Horario", typeof(string));
            dataTable.Columns.Add("Deporte", typeof(string));
            dataTable.Columns.Add("Cancha", typeof(string));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Apellido", typeof(string));
            dataTable.Columns.Add("Telefono", typeof(long));


            // asiganar los valores de la lista al datatable
            foreach (var resultado in listaConsulta)
            {
                
                DateTime fechaTurno = DateTime.Parse(resultado.Fecha);    // convertir la fecha (que es un string) a tipo datetime para hacer la verificacion  que coincida con el dia actual
                DateTime fechaLarga = DateTime.Now; // fecha en formato largo (fecha y horas)
                DateTime fecha = fechaLarga.Date; // fecha en formato cortoc (anio, mes, dia)

                if (fechaTurno == fecha)
                {
                    dataTable.Rows.Add(resultado.ID, resultado.Fecha, resultado.Horario, resultado.Deporte, resultado.nombre, resultado.Nombre, resultado.Apellido, resultado.Telefono);

                }
            }

            return dataTable;

        }


        // Metodo para filtrar los turnos por un valor ingresado.
        public DataTable FiltrarDatos(DataTable dataTable, string valorBusqueda)
        {
            DataTable resultadoFiltrado = dataTable.Clone(); // Clona la estructura del DataTable original.

            foreach (DataRow fila in dataTable.Rows)
            {
                foreach (DataColumn columna in dataTable.Columns)
                {
                    // Verifica si el valor de la columna contiene el valor de búsqueda.
                    if (fila[columna].ToString().Contains(valorBusqueda))
                    {
                        resultadoFiltrado.ImportRow(fila); // Agrega la fila al resultado filtrado.
                        break; // Sal del bucle interno, ya que se encontró una coincidencia en esta fila.
                    }
                }
            }

            return resultadoFiltrado;
        }



        // ----------
        // ELEMENTOS.
        // ----------

        public void altaElemento(string nombre, string stock)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(stock))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }
            if (SoloNumeros(stock))
            {
                throw new Exception("El stock ingresado no puede contener letras.");
            }

            var elementoExiste = context.Elementos.FirstOrDefault(elemento => elemento.Nombre.ToUpper() == nombre);
            if (elementoExiste != null) // seria que ya existe
            {
                throw new Exception("El elemento que desea crear ya ha sido creado.");
            }

            Elemento elemento = new Elemento();
            elemento.Nombre = nombre;
            elemento.Stock = int.Parse(stock);

            context.Elementos.Add(elemento);
            context.SaveChanges();


        }
        public void ModificarElemento(Elemento elemento, string nombre, string stock)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(stock))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }
            if (SoloNumeros(stock))
            {
                throw new Exception("El stock ingresado no puede contener letras.");
            }

            if (SoloLetras(nombre))
            {
                throw new Exception("El Nombre ingresado no puede contener numeros.");
            }

            if (elemento != null)
            {
                elemento.Nombre = nombre;
                elemento.Stock = int.Parse(stock);
                

                context.Elementos.Update(elemento);
                context.SaveChanges();
            }
        }

        public void AgregarStock(Elemento elemento, string masStock)
        {
            if (string.IsNullOrWhiteSpace(masStock))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }
            if (SoloNumeros(masStock))
            {
                throw new Exception("El stock ingresado no puede contener letras.");
            }

            if (elemento != null)
            {
                elemento.Stock = elemento.Stock + int.Parse(masStock);
                context.Elementos.Update(elemento);
                context.SaveChanges();
            }
        }
        public void RemoveElemento(Elemento elemento)
        {
            if (elemento != null)
            {
                context.Elementos.Remove(elemento);
                context.SaveChanges();
            }
        }

        public List<Elemento> ObtenerElementos()
        {
            var listaElementos = context.Elementos.ToList();

            return listaElementos;
        }

        // ----------------=
        // ELEMENTOS CANCHA.
        // -----------------

        // Crear una nueva asignacion de un elemento a una cancha
        public void AsigElementoCancha(Cancha cancha, Elemento elemento, string cant)
        {
            if (string.IsNullOrWhiteSpace(cant))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (SoloNumeros(cant))
            {
                throw new Exception("La cantidad ingresada no puede contener letras.");
            }


            var asignacionExiste = context.ElementoCancha.FirstOrDefault(asig => asig.Elemento.Nombre == elemento.Nombre);
            var busqueda = context.ElementoCancha.FirstOrDefault(asignacionExiste => asignacionExiste.Cancha.nombre == cancha.nombre);

            if (busqueda != null) // ya existe el elemento en la cancha (elemento y cancha pasados como parametros)
            {
                busqueda.Cantidad += int.Parse(cant);  // entonces solamente le modificamos la cantidad que tiene de ese elemento.
                busqueda.Elemento.Stock -= int.Parse(cant); // y le bajamos el stock a ese elemento

                context.ElementoCancha.Update(busqueda);
                context.SaveChanges();
            }
            if (busqueda == null) // no exite la asignacion de ese elemento con la cancha
            {
                ElementoCancha elementoCancha = new ElementoCancha();
                elementoCancha.Cancha = cancha;
                elementoCancha.Elemento = elemento;
                elementoCancha.Cantidad = int.Parse(cant);

                // bajar la cantidad en el stock
                elementoCancha.Elemento.Stock -= int.Parse(cant);


                context.ElementoCancha.Add(elementoCancha);
                context.SaveChanges();
            }

        }
 

        public void RemoveAsignacionElemento(int idElemento, int idAsig)
        {
            var asigEncontrada = context.ElementoCancha.Find(idAsig); // buscar la asignacion
            
            if (asigEncontrada != null) // encontro la asig que coincide con el idAsig ingresado
            {
                var elemento = context.Elementos.Find(idElemento); // buscar el elemento con el idElemento que esta asociado al idAsig

                if (elemento != null)  // enconto el elemento
                {
                    elemento.Stock += asigEncontrada.Cantidad; // agregarle al stockd del elemento la cantidad que tiene la asignacion encontrada

                    context.Elementos.Update(elemento); // actualizar 
                    context.SaveChanges();
                }


                context.ElementoCancha.Remove(asigEncontrada); // y por ultimo eliminar la asignacion
                context.SaveChanges();


            }
        }


        // Obtener listado completos de las asignaciones registradas. Tambien al igual que Turno, tiene prop de tipo de objeto, por eso se hace asi.
        public DataTable ObtenerAsignacionDeElementos()
        {
            var consulta = from asignacion in context.ElementoCancha
                           join elemento in context.Elementos on asignacion.Elemento.Id equals elemento.Id
                           join cancha in context.Canchas on asignacion.Cancha.ID equals cancha.ID

                           select new
                           {
                               asignacion.ID,
                               cancha.nombre,
                               cancha.Deporte,
                               elemento.Id,
                               elemento.Nombre,
                               asignacion.Cantidad,


                           };

            // convertir en lista la consulta 
            var listaConsulta = consulta.ToList();

            // crear datatable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID-Asignacion", typeof(int));
            dataTable.Columns.Add("Cancha", typeof(string));
            dataTable.Columns.Add("Deporte", typeof(string));
            dataTable.Columns.Add("ID-Elemento", typeof(int));
            dataTable.Columns.Add("Elemento", typeof(string));
            dataTable.Columns.Add("Cantidad", typeof(int));

            // asiganar los valores de la lista al datatable
            foreach (var resultado in listaConsulta)
            {
                dataTable.Rows.Add(resultado.ID, resultado.nombre, resultado.Deporte, resultado.Id, resultado.Nombre, resultado.Cantidad);
            }

            return dataTable;

        }

    }



}