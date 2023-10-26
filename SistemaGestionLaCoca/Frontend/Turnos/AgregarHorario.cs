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
    public partial class AgregarHorario : Form
    {
        public AgregarHorario()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        private void AgregarHorario_Load(object sender, EventArgs e)
        {
            cmboxDeporte.Items.AddRange(principal.DeportesSinRepetir().ToArray());
            cmboxDeporte.DisplayMember = "Deporte";   // Establecer la propiedad a mostrar en el ComboBox

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AltaTurno altaTurno = new AltaTurno();
            altaTurno.Show();
            this.Hide();
        }

        private void btnAgregarElemento_Click(object sender, EventArgs e)
        {
            try
            {
                string horario = txtHorario.Text;
            }
            catch (Exception horaIncompleta)
            {
                MessageBox.Show("Error: " + horaIncompleta.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                Principal.AgregarHorario(txtHorario.Text, cmboxDeporte.SelectedItem.ToString());
            }
            catch (Exception formatoInvalido)
            {
                MessageBox.Show("Error: " + formatoInvalido.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
