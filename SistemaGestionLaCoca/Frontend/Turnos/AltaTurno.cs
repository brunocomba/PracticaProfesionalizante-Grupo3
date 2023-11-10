using Frontend.Turnos;
using FrontEnd;
using Logica;
using Logica.Clases;

namespace Frontend
{
    public partial class AltaTurno : Form
    {
        public AltaTurno()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void AltaTurno_Load(object sender, EventArgs e)
        {
            cmboxCliente.Items.AddRange(principal.ObtenerListClientes().ToArray());


            cmboxDeporte.Items.AddRange(principal.DeportesSinRepetir().ToArray());
            cmboxDeporte.DisplayMember = "Deporte";   // Establecer la propiedad a mostrar en el ComboBox

            FechaTurno.Value = DateTime.Now; // Establecer el dia de la fecha al ejecutarse.
            FechaTurno.CustomFormat = "dd/MM/yyyy";


            //  MOSTRAR UN MENSAJE AL PASAR EL MOUSE POR ARRIBA DEL BOTON.
            toolTip1.SetToolTip(btnAgregarClientes, "Agregar un nuevo cliente.");
            toolTip1.SetToolTip(btnAddCanchas, "Agregar nuevas canchas.");

        }

        private void btnAgregarCancha_Click(object sender, EventArgs e)
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


                        var respuesta = MessageBox.Show($"DATOS DEL TURNO\nCliente: {clienteElegido.Nombre} {clienteElegido.Apellido}\n" +
                        $"Fecha: {fecha}\nHora: {horario}\nCancha: {canchaElegida.nombre}\nDeporte: {canchaElegida.Deporte}\nPrecio del turno: ${canchaElegida.Precio}\n" +
                        $"Precio por jugador ${canchaElegida.Precio / canchaElegida.Cantidad_Jugadores}", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (respuesta == DialogResult.OK)
                        {
                            principal.AltaTurno(clienteElegido, canchaElegida, fecha, horario);
                            MessageBox.Show($"El turno para la cancha: {canchaElegida.nombre} de: {canchaElegida.Deporte} el dia: {fecha} a las {horario} al cliente {clienteElegido}  fue registrado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            cmboxCancha.DataSource =  principal.CanchasDeSoloUnDeporte(deporteElegido);

            cmboxCancha.DisplayMember = "Nombre";

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

        private void AltaTurno_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
