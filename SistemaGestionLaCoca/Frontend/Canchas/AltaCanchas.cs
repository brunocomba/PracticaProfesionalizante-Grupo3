using Frontend;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrontEnd
{
    public partial class AltaCanchas : Form
    {

        private Form formularioPrevio;
        public AltaCanchas(Form formularioPrevio)
        {
            InitializeComponent();
            this.formularioPrevio = formularioPrevio;
        }

        Principal principal = new Principal();
        private void AltaCanchas_Load(object sender, EventArgs e)
        {
            // Cargar combo de tipo de deporte
            cmboxTipo.Items.Add("BASQUET");
            cmboxTipo.Items.Add("FUTBOL");
            cmboxTipo.Items.Add("PADEL");

            // Cargar combo de cantidad de jugadores
            cmboxCantJugadores.Items.Add("4");
            cmboxCantJugadores.Items.Add("8");
            cmboxCantJugadores.Items.Add("10");
        }
        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            var confirmacion = MessageBox.Show($"Seguro que desea agregar una cancha con los siguientes datos?\n" +
                $" Nombre: {txtNombre.Text}\n Tipo: {cmboxTipo.SelectedItem}\n Cantidad de Jugadores: {cmboxCantJugadores.SelectedItem}", "Atencion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmacion == DialogResult.OK)
            {
                principal.AltaCancha(txtNombre.Text, cmboxCantJugadores.SelectedItem.ToString(), int.Parse(cmboxCantJugadores.SelectedItem.ToString()), int.Parse(txtPrecio.Text));
                ListaCanchas listaCanchas = new ListaCanchas();
                listaCanchas.Show();
                this.Hide();
            }
            else
            {
                var confirmarCancelacion = MessageBox.Show($"Seguro que desea cancelar la operacion?", "Atencion", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (confirmarCancelacion == DialogResult.OK)
                {
                    txtNombre.Text = "";
                    cmboxCantJugadores.Text = "";
                    cmboxTipo.Text = "";
                    txtPrecio.Text = "";
                }
            }
        }

        private void cmboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Tipo = cmboxTipo.SelectedItem.ToString();
        }

        private void cmboxCantJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CantJugadores = cmboxCantJugadores.SelectedItem.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioPrevio.Show();
        }
    }
}
