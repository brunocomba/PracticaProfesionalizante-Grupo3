using FrontEnd;
using LogicaClases.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class AltaNuevosHorarios : Form
    {
        public AltaNuevosHorarios()
        {
            InitializeComponent();
        }

        private void AltaNuevosHorarios_Load(object sender, EventArgs e)
        {
            cmboxCancha.DisplayMember = "idYnombre"; // Establecer la propiedad a mostrar en el ComboBox
            cmboxCancha.Items.AddRange(Principal.ObtenerCanchas().ToArray());

            dateTimePicker3.CustomFormat = "HH:mm";
            dateTimePicker3.ShowUpDown = true;

        }
        public TimeSpan selectedTime;
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddHorarios_Click(object sender, EventArgs e)
        {
            AltaCanchas altaCanchas = new AltaCanchas();
            altaCanchas.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaTurno altaTurno = new AltaTurno();
            altaTurno.Show();
            this.Hide();
        }

        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            DateTime selectedTime = dateTimePicker3.Value;

            // Solo guardar la hora y los minutos, ignorando la fecha
            string hora = selectedTime.Hour.ToString();
            string min = selectedTime.Minute.ToString();
            string sec = selectedTime.Second.ToString();
            string horaYmin = hora + ":" + min + sec;

            principal.altaHorario(horaYmin, (Cancha)cmboxCancha.SelectedItem);


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
