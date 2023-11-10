using FrontEnd;
using Logica;
using Logica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Turnos
{
    public partial class ModificarTurno : Form
    {
        public ModificarTurno()
        {
            InitializeComponent();
        }

        private Turno turnoQueEdito;

        Principal principal = new Principal();
        private void ModificarTurno_Load(object sender, EventArgs e)
        {
            cmboxTurnos.Items.AddRange(principal.GetTurnos().ToArray());
            cmboxTurnos.DisplayMember = "ID";

            cmboxCliente.Items.AddRange(principal.ObtenerListClientes().ToArray());


            cmboxDeporte.Items.AddRange(principal.DeportesSinRepetir().ToArray());
            cmboxDeporte.DisplayMember = "Deporte";   // Establecer la propiedad a mostrar en el ComboBox

            FechaTurno.Value = DateTime.Now; // Establecer el dia de la fecha al ejecutarse.
            FechaTurno.CustomFormat = "dd/MM/yyyy";


            //  MOSTRAR UN MENSAJE AL PASAR EL MOUSE POR ARRIBA DEL BOTON.
            toolTip1.SetToolTip(btnAgregarClientes, "Agregar un nuevo cliente.");
            toolTip1.SetToolTip(btnAddCanchas, "Agregar nuevas canchas.");

        }

        private void btnModificarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmboxCliente.SelectedItem == null || cmboxDeporte.SelectedItem == null || cmboxCancha.SelectedItem == null || cmboxHorarios.SelectedItem == null)
                {
                    throw new Exception("No se ha seleccionado ningún elemento en el ComboBox."); // si los combos estan incompletos tira esta excepcion  
                }
                else // si estan los combos completos pasa a este try.
                {
                    try
                    {
                        Cliente clienteElegido = (Cliente)cmboxCliente.SelectedItem;
                        Cancha canchaElegida = (Cancha)cmboxCancha.SelectedItem;

                        string horario = cmboxHorarios.SelectedItem.ToString();  // obtener el horario seleccionado
                        string fecha = FechaTurno.Value.ToString("yyyy-MM-dd"); // obtener la fecha del timePicker y convertirla a string con el formato de fecha solamente


                        var respuesta = MessageBox.Show($"DATOS DE LA MODIFICAION\nCliente: {turnoQueEdito.Cliente} por {clienteElegido}\n" +
                        $"Fecha: {turnoQueEdito.Fecha} por {fecha}\nHora: {turnoQueEdito.Horario} por {horario}\nCancha: {turnoQueEdito.Cancha} por {canchaElegida}\nDeporte: {turnoQueEdito.Cancha.Deporte} por {canchaElegida.Deporte}\nPrecio del turno: ${turnoQueEdito.Cancha.Precio} por {canchaElegida.Precio}\n" +
                        $"Precio por jugador ${turnoQueEdito.Cancha.Precio / turnoQueEdito.Cancha.Cantidad_Jugadores} por {canchaElegida.Precio / canchaElegida.Cantidad_Jugadores}", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (respuesta == DialogResult.OK)
                        {
                            principal.ModificarTurno(turnoQueEdito, clienteElegido, canchaElegida, fecha, horario);
                            MessageBox.Show($"El turno fue modificado con exito!\nCancha: {canchaElegida.nombre} de: {canchaElegida.Deporte} el dia: {fecha} a las {horario} al cliente {clienteElegido}", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            HistorialTurnos historialTurnos = new HistorialTurnos();
                            historialTurnos.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception turnoYaRegistrado)
                    {
                        MessageBox.Show("Error: " + turnoYaRegistrado.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception cmboxIncompletos)
            {
                MessageBox.Show("Error: " + cmboxIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmboxDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // guardar el deporte elegido como string y pasarselo al metodo que muestra las canchas registradas con ese deporte.
            string deporteElegido = cmboxDeporte.SelectedItem.ToString();

            cmboxCancha.DataSource = principal.CanchasDeSoloUnDeporte(deporteElegido);


            // si el deporte elegido es futbol, mostrar la lista harcodeadea de horarios para Futbol. 
            if (deporteElegido == "FUTBOL")
            {
                cmboxHorarios.DataSource = principal.ListaHorariosFutbol();
            }

            // lo mismo, si el deporte es basquet, mostrar la lista de horarios de basquet.
            if (deporteElegido == "BASQUET")
            {
                cmboxHorarios.DataSource = principal.ListaHorariosBasquet();
            }
        }

        private void cmboxCancha_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cancha canchaElegida = (Cancha)cmboxCancha.SelectedItem;  // una vez elegida la cancha
            txtPrecio.Text = canchaElegida.Precio.ToString(); // mostrar en el textbox de precio, precio de esa cancha elegida
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente(this);
            altaCliente.Show();
            this.Hide();
        }

        private void btnAddCanchas_Click(object sender, EventArgs e)
        {
            AltaCanchas altaCancha = new AltaCanchas(this);
            altaCancha.Show();
            this.Hide();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            HistorialTurnos historialTurnos = new HistorialTurnos();
            historialTurnos.Show();
            this.Hide();
        }

        private void ModificarTurno_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationDbContex context = new ApplicationDbContex();

            // Preguntar si desea cerrar el programa o no.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var rta = MessageBox.Show("¿Seguro que deseas salir?", "Confirmar salida ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rta == DialogResult.OK)
                {

                    Application.Exit();

                    // Cambiarle al administrador que esta logueado (actual) la propiedad Logueado a NO.
                    Administrador.admLogueado.Logueado = Administrador.SioNo.NO;
                    context.Administradores.Update(Administrador.admLogueado);
                    context.SaveChanges();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void cmboxTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Turno turnoElegido = (Turno) cmboxTurnos.SelectedItem;

            cmboxCliente.Text = turnoElegido.Cliente.ToString();
            cmboxDeporte.Text  = turnoElegido.Cancha.Deporte.ToString();
            cmboxCancha.Text = turnoElegido.Cancha.nombre.ToString();
            FechaTurno.Text = turnoElegido.Fecha;
            cmboxHorarios.Text = turnoElegido.Horario.ToString();
        }
    }
}