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
            cmboxDeporte.SelectedIndexChanged += cmboxDeporte_SelectedIndexChanged;
            //  MOSTRAR UN MENSAJE AL PASAR EL MOUSE POR ARRIBA DEL BOTON.
            toolTip1.SetToolTip(btnAgregarClientes, "Agregar un nuevo cliente.");
            toolTip1.SetToolTip(btnAddHorarios, "Agregar nuevos horarios para turnos.");


        }




        // METODO  PARA QUE AL CREAR UNA NUEVA CANCHA DE UN DEPORTE QUE YA ESTE CREADA, NO LO VUELVA A AGREGAR
        // AL COMBOBOX DE DEPORTE A ELEGIR A LA HORA DE AGENDAR UN NUEVO TURNO.
        public void AgregarDeportesUnicos(List<Cancha> nuevosDeportes)
        {
            foreach (Cancha deporte in nuevosDeportes)
            {
                if (!cmboxDeporte.Items.Cast<string>().Any(item => item.Equals(deporte.tipo)))
                {
                    cmboxDeporte.Items.Add(deporte.tipo);
                }
            }
        }



        private void AltaTurno_Load(object sender, EventArgs e)
        {
            cmboxCliente.DisplayMember = "nombreYapellido"; // Establecer la propiedad a mostrar en el ComboBox
            cmboxCliente.Items.AddRange(Principal.ObtenerClientes().ToArray());


            AgregarDeportesUnicos(Principal.ObtenerCanchas());
            //cmboxDeporte.DisplayMember = "Tipo";
            //cmboxDeporte.Items.AddRange(Principal.ObtenerCanchas().ToArray()); 

            dateTimePicker1.Value = DateTime.Now; // Establecer el dia de la fecha al ejecutarse.
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            // Cargar horarios de turnos.
            cmboxHorarios.DisplayMember = "hora";
            cmboxHorarios.Items.AddRange(Principal.ObtenerHorarios().ToArray());


            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Direccion", "Dirección");
            dataGridView1.Columns.Add("Contacto", "Contacto");
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("PrecioUnitario", "Precio Unitario");

            // Ajustar el modo de visualización
            dataGridView1.AutoGenerateColumns = false;


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
            List<Cancha> canchasFiltradas = Principal.ObtenerCanchas().Where(cancha => cancha.tipo == deporteElegido).ToList();

            cmboxCancha.DataSource = canchasFiltradas;
            cmboxCancha.DisplayMember = "idYnombre";

            cmboxPrecio.DataSource = canchasFiltradas;
            cmboxPrecio.DisplayMember = "precio";

            cmboxHorarios.DataSource = canchasFiltradas;
            cmboxHorarios.DisplayMember = "hora";


            // hacer inspecciones y ver si funciona ver lo de horarios

        }


        public List<Horario> horasFiltradas = new List<Horario>();
        private void cmboxPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmboxCancha_SelectedIndexChanged(object sender, EventArgs e)
        {
            string canchaElegida = cmboxCancha.SelectedItem.ToString();
            List<Horario> horasFiltradas = Principal.ObtenerHorarios().Where(hora => hora.nombreCancha == canchaElegida).ToList();

            cmboxHorarios.DataSource = horasFiltradas;
            cmboxHorarios.DisplayMember = "horario";

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente();
            altaCliente.Show();
            this.Hide();
        }


        private void btnAddHorarios_Click(object sender, EventArgs e)
        {
            AltaNuevosHorarios altaNuevosHorarios = new AltaNuevosHorarios();
            altaNuevosHorarios.Show();
            this.Hide();
        }

        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.altaTurno((Cancha)cmboxCancha.SelectedItem, (Cliente)cmboxCliente.SelectedItem);
            MessageBox.Show($"Turno creado con exito al cliente");

            //PRUEBA, FUNCIONA EL ALTA. ARREGLAR CAMBIOS DE PANTALLA AL IR DESDE ESTE FORMULARIO.
            // HACER VALIDACIONES
            // VER TEMAS HORARIOS.
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("sksk");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
