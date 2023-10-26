using Logica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

using static Logica.Clases.Turno;


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


        // metodo para verificar que la cadena tenga Solo Letras.
        public bool SoloLetras(string textBox)
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


        // metodo para verificar que la cadena tenga Solo Numeros.
        public bool SoloNumeros(string textBox)
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


        // -------------------------------------------- ADMINISTRADORES ----------------------------------------------------------------

       
        // --------------------------------------------------------------------------Alta
        public void AltaAdmi(string nombre, string apellido, string dni, string tel, string user, string pass, string confirmPass)
        {
           // EXCEPCIONES
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(tel)
                || string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrEmpty(confirmPass))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (dni.Length <= 7)
            {
                throw new Exception("El DNI esta incompleto.");
            }
            
            if (tel.Length <= 9)
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

            context.Administradores.Add(newAdmin);  
            context.SaveChanges();
        }

        // -------------------------------------------------------------------------------------------------------------Modificacion
        public void ModificarAdmin(Administrador admiMod, string nombre, string apellido, string dni, string tel, string user, string pass, string confirmPass)
        { 
            // EXCEPCIONES
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(tel)
                || string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrEmpty(confirmPass))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (dni.Length <= 7)
            {
                throw new Exception("El DNI esta incompleto.");
            }

            if (tel.Length <= 9)
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

        public bool LogIn(string user, string pass)
        {
            var listaAdm = context.Administradores.ToList();
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                throw new Exception("Complete los campos por favor.");
                
            }
            if (listaAdm.Count > 0)
            {
                foreach (var admiGuardado in listaAdm)
                {
                    if (admiGuardado.Usuario != user || admiGuardado.Contrasenia != pass)
                    {
                        throw new Exception($"Nombre de usuario o contraseña incorrectos.\nPor favor, inténtalo de nuevo.");
                    }
                    else
                    {
                        return true;
                    }

                }
            }
            else
            {
                throw new Exception("No hay ningun administrador registrado en el sistema.");
            }
            return false;
        }



 

























        // ----------------------------------------------CLIENTES. 
 
        
        public void AltaCliente(string nombre, string apellido, string dni, string tel)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(tel))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (dni.Length <= 7)
            {
                throw new Exception("El DNI esta incompleto.");
            }

            if (tel.Length <= 9)
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

            if (dni.Length <= 7)
            {
                throw new Exception("El DNI esta incompleto.");
            }

            if (tel.Length <= 9)
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
      

        public void AltaCancha(string nombre, string deporte, string cantJugadores, string precio)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(deporte) || string.IsNullOrWhiteSpace(cantJugadores) || string.IsNullOrWhiteSpace(precio))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (SoloNumeros(cantJugadores) || SoloNumeros(precio))
            {
                throw new Exception("La cantidad de jugadores o el precio ingresado no puede letras.");
            }

            if (SoloLetras(nombre))
            {
                throw new Exception("El Nombre ingresado no puede contener numeros.");
            }
            Cancha newCancha = new Cancha();

            newCancha.nombre = nombre;
            newCancha.Deporte = deporte;
            newCancha.Cantidad_Jugadores = int.Parse(cantJugadores);
            newCancha.Precio = decimal.Parse(precio);

            context.Canchas.Add(newCancha);
            context.SaveChanges();
        }

        public void modificarCancha(Cancha canchaMod, string nombre, string deporte, string cantJug, string precio)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(deporte) || string.IsNullOrWhiteSpace(cantJug) || string.IsNullOrWhiteSpace(precio))
            {
                throw new Exception("Por favor, complete todos los campos del formulario.");
            }

            if (SoloNumeros(cantJug) || SoloNumeros(precio))
            {
                throw new Exception("La cantidad de jugadores o el precio ingresado no puede contener letras.");
            }

            if (SoloLetras(nombre))
            {
                throw new Exception("El Nombre ingresado no puede contener numeros.");
            }
            if (canchaMod != null)
            {
                canchaMod.nombre = nombre;
                canchaMod.Deporte = deporte;
                canchaMod.Cantidad_Jugadores = int.Parse(cantJug);
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
            ListaCanchas = context.Canchas.ToList();

            return ListaCanchas;
        }

        public List<string> DeportesSinRepetir()
        {
            var listaDeportes = new List<string>();

            foreach (var cancha in ObtenerListaCanchas())
            {
                if (!listaDeportes.Contains(cancha.Deporte))  // no tiene ese deporte en la lista de deportes que hay
                {
                    listaDeportes.Add(cancha.Deporte);
                }

            }
            return listaDeportes;

        }

        public List<Cancha> CanchasDeSoloUnDeporte(string deporte)
        {
            var canchasFiltraadas = ObtenerListaCanchas().Where(cancha => cancha.Deporte == deporte).ToList();

            return canchasFiltraadas;
        }


        // ------------------------------------ TURNOS.

        public static List<string> HorariosFutbol;
        public static List<string> ListaHorariosFutbol()
        {
            if (HorariosFutbol == null)
            {
                HorariosFutbol = new List<string>
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

            }
            return HorariosFutbol;
        }

        public static List<string> HorariosBasquet;
        public static List<string> ListaHorariosBasquet()
        {
            if (HorariosBasquet == null)
            {
                HorariosBasquet = new List<string>
                {
                    "16:00",
                    "17:00",
                    "18:00",
                    "19:00",
                    "20:00",
                    "21:00",
                    "22:00"
                };

            }
            return HorariosBasquet;
        }
        public static bool EsFormatoValido(string hora)
        {
            // Patrón de expresión regular para el formato "xx:xx".
            string patron = @"^\d{2}:\d{2}$";

            // Verifica si el input coincide con el patrón.
            return Regex.IsMatch(hora, patron);
        }


        public static void AgregarHorario(string horario, string deporte)
        {
            if (horario.Length < 5)
            {
                throw new Exception("El horario ingresado no contiene los caracteres solicitados.");
            }
            if (EsFormatoValido(horario) ==  false)
            {
                throw new Exception("El horario ingresado no coincide con el patron solicitado\nPATRON SOLICITADO\nxx:xx\n(donde x es cualquier digito).");
            }

            if (deporte == "BASQUET")
            {
                HorariosBasquet.Add(horario);
            }
            if (deporte == "FUTBOL")
            {
                HorariosFutbol.Add(horario);
            }

        }
        public void AltaTurno(Cliente cliente, Cancha cancha, string fecha, string hora)
        {
            // verificaciones;
             
            var listaTurnos = context.Turnos.ToList();
            foreach (var turn in listaTurnos)
            {
                if (turn.Horario.Contains(hora) && turn.Fecha.Contains(fecha) && turn.Cancha.Equals(cancha))
                {
                    throw new Exception("El turno solicitado ya se encuentra registrado.");

                }
            }




            Turno turno = new Turno();
            turno.Cliente = cliente;
            turno.Cancha = cancha;
            turno.Fecha = fecha;
            turno.Horario = hora;
            turno.Condicion = Reservado.Si;


           

            context.Turnos.Add(turno);
            context.SaveChanges();



        }
        public void ModificarTurno(Turno turno, Cliente cliente, Cancha cancha, string fecha, string hora)
        {
            if (turno != null)
            {
                turno.Cliente = cliente;
                turno.Cancha = cancha;
                turno.Fecha = fecha;
                turno.Horario = hora;
                turno.Condicion = Reservado.Si;


                context.Turnos.Update(turno);
                context.SaveChanges();
            }
        }

        
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




        // ------------------------------------ ELEMENTOS.

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

            if (SoloLetras(nombre))
            {
                throw new Exception("El Nombre ingresado no puede contener numeros.");
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


        // ----------------------------------- ELEMENTOS CANCHA.
        public void AsigElementoCancha(Cancha cancha, Elemento elemento, int cant)
        {
            ElementoCancha elementoCancha = new ElementoCancha();
            elementoCancha.Cancha = cancha;
            elementoCancha.Elemento = elemento;
            elementoCancha.Cantidad = cant;

            // bajar la cantidad en el stock
            elementoCancha.Elemento.Stock -= cant;
            // ver ejemplo de buscar por ID y desp mpodificar

            context.ElementoCancha.Add(elementoCancha);
            context.SaveChanges();


            // guardarlo en la BD
        }
        public DataTable ObtenerAsignacionDeElementos()
        {
            var consulta = from asignacion in context.ElementoCancha
                           join elemento in context.Elementos on asignacion.Elemento.ID equals elemento.ID
                           join cancha in context.Canchas on asignacion.Cancha.ID equals cancha.ID
        
                           select new
                           {
                               asignacion.ID,
                               cancha.nombre,
                               cancha.Deporte,
                               elemento.Nombre,
                               asignacion.Cantidad,
                               

                           };

            // convertir en lista la consulta 
            var listaConsulta = consulta.ToList();

            // crear datatable
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Cancha", typeof(string));
            dataTable.Columns.Add("Deporte", typeof(string));
            dataTable.Columns.Add("Elemento", typeof(string));
            dataTable.Columns.Add("Cantidad", typeof(int));            

            // asiganar los valores de la lista al datatable
            foreach (var resultado in listaConsulta)
            {
                dataTable.Rows.Add(resultado.ID, resultado.nombre, resultado.Deporte, resultado.Nombre, resultado.Cantidad);
            }

            return dataTable;

        }
 
  

        public void ModificarAsignacionElemento(ElementoCancha elementoCancha, Cancha cancha, Elemento elemento, int cantidad)
        {
            if (elementoCancha != null)
            {
                elementoCancha.Cancha = cancha;
                elementoCancha.Elemento = elemento;
                elementoCancha.Cantidad = cantidad;


                context.ElementoCancha.Update(elementoCancha);
                context.SaveChanges();
            }
        }

        public void RemoveAsignacionElemento(ElementoCancha elementoCancha)
        {
            if (elementoCancha != null)
            {
                context.ElementoCancha.Remove(elementoCancha);
                context.SaveChanges();
            }
        }

    }


}
