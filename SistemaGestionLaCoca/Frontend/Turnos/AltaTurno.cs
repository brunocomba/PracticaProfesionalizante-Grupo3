using LogicaClases.Clases;
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
            cmboxPrecio.DataSource = Principal.ObtenerCanchas();
            cmboxPrecio.DisplayMember = "Precio";

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




        }

        
        public List<Cancha> canchasFiltradas = new List<Cancha>();
        private void button1_Click(object sender, EventArgs e)
        {
            HistorialTurnos historialTurnos = new HistorialTurnos();
            historialTurnos.Show();
            this.Hide();
        }


        // MOSTRAR EL ID DE LAS CANCHAS AL ELEGIR EL TIPO DE DEPORTE 
        private void cmboxDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {

            string deporteElegido = cmboxDeporte.SelectedItem.ToString();
            List<Cancha> canchasFiltradas = Principal.ObtenerCanchas().Where(cancha => cancha.tipo == deporteElegido).ToList();

            cmboxCancha.DataSource = canchasFiltradas;
            cmboxCancha.DisplayMember = "idYnombre";

            cmboxPrecio.DataSource = canchasFiltradas;
            cmboxPrecio.DisplayMember = "precio";
           

        }



        private void cmboxPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmboxCancha_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
