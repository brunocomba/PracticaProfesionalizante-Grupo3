using Frontend.Turnos;
using FrontEnd;
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

namespace Frontend
{
    public partial class AltaTurno : Form
    {
        public AltaTurno()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();


        // METODO  PARA QUE AL CREAR UNA NUEVA CANCHA DE UN DEPORTE QUE YA ESTE CREADA, NO LO VUELVA A AGREGAR
        // AL COMBOBOX DE DEPORTE A ELEGIR A LA HORA DE AGENDAR UN NUEVO TURNO.
        public void AgregarDeportesUnicos(List<Cancha> nuevosDeportes)
        {
            foreach (Cancha deporte in nuevosDeportes)
            {
                if (!cmboxDeporte.Items.Cast<string>().Any(item => item.Equals(deporte.Deporte)))
                {
                    cmboxDeporte.Items.Add(deporte.Deporte);
                }
            }
        }



        private void AltaTurno_Load(object sender, EventArgs e)
        {
            cmboxCliente.Items.AddRange(principal.ObtenerListClientes().ToArray());


            cmboxDeporte.Items.AddRange(principal.DeportesSinRepetir().ToArray());
            cmboxDeporte.DisplayMember = "Deporte";   // Establecer la propiedad a mostrar en el ComboBox


            //cmboxCliente.Items.AddRange(Principal.ObtenerClientes().ToArray());


            // AgregarDeportesUnicos(Principal.ObtenerCanchas());
            //cmboxDeporte.DisplayMember = "Tipo";
            //cmboxDeporte.Items.AddRange(Principal.ObtenerCanchas().ToArray()); 

            FechaTurno.Value = DateTime.Now; // Establecer el dia de la fecha al ejecutarse.
            FechaTurno.CustomFormat = "dd/MM/yyyy";

            // Cargar horarios de turnos.



            //  MOSTRAR UN MENSAJE AL PASAR EL MOUSE POR ARRIBA DEL BOTON.
            toolTip1.SetToolTip(btnAgregarClientes, "Agregar un nuevo cliente.");
            toolTip1.SetToolTip(btnAddCanchas, "Agregar nuevas canchas.");
            toolTip1.SetToolTip(btnAgregarHorario, "Agregar nuevos horarios.");


        }


        private void button1_Click(object sender, EventArgs e)
        {
            HistorialTurnos historialTurnos = new HistorialTurnos();
            historialTurnos.Show();
            this.Hide();
        }

        public List<Cancha> canchasFiltradas = new List<Cancha>();

        // MOSTRAR EL ID DE LAS CANCHAS AL ELEGIR EL TIPO DE DEPORTE 
        private void cmboxDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {

            string deporteElegido = cmboxDeporte.SelectedItem.ToString();

            cmboxCancha.Items.AddRange(principal.CanchasDeSoloUnDeporte(deporteElegido).ToArray());

            cmboxCancha.DisplayMember = "Nombre";








            // hacer inspecciones y ver si funciona ver lo de horarios

        }


        private void button2_Click(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente(this);
            altaCliente.Show();
            this.Hide();

        }


        private void btnAddHorarios_Click(object sender, EventArgs e)
        {
            AltaCanchas altaCancha = new AltaCanchas(this);
            altaCancha.Show();
            this.Hide();

        }

        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {
            Cliente clienteElegido = (Cliente)cmboxCliente.SelectedItem;
            Cancha canchaElegida = (Cancha)cmboxCancha.SelectedItem;
            DateTime fecha = FechaTurno.Value; // obtener la fecha del timePicker
            string fechaSelecciona = fecha.ToString("yyyy-MM-dd");  // convertirla a string con el formato de fecha solamente
            string horario = cmboxHorarios.SelectedItem.ToString();

            MessageBox.Show($"DATOS DEL TURNO\nCliente: {clienteElegido.Nombre} {clienteElegido.Apellido}\n" +
                $"Fecha: {fechaSelecciona}\nHora: {horario}\nDeporte: {canchaElegida.nombre}\nDeporte: {canchaElegida.Deporte}");

            try
            {
                principal.AltaTurno(clienteElegido, canchaElegida, fechaSelecciona, horario);

            }
            catch (Exception turnoYaRegistrado)
            {
                MessageBox.Show("Error: " + turnoYaRegistrado.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cmboxCancha_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cancha canchaElegida = (Cancha)cmboxCancha.SelectedItem;
            txtPrecio.Text = canchaElegida.Precio.ToString(); // mostrar en el textbox de precio,el precio de la cancha elegida

            if (canchaElegida.Deporte == "FUTBOL")
            {
                cmboxHorarios.Items.AddRange(Principal.ListaHorariosFutbol().ToArray());
            }
            if (canchaElegida.Deporte == "BASQUET")
            {
                cmboxHorarios.Items.AddRange(Principal.ListaHorariosBasquet().ToArray());
            }

        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            AgregarHorario agregarHorario = new AgregarHorario();
            agregarHorario.Show();
            this.Hide();
        }
    }
}
