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
        string Tipo;
        string CantJugadores;
        private Form formularioPrevio;
        public AltaCanchas(Form formularioPrevio)
        {
            InitializeComponent();
            this.formularioPrevio = formularioPrevio;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Principal principal = new Principal();
        private void AltaCanchas_Load(object sender, EventArgs e)
        {
            /*
            cmboxTipo.DisplayMember = "DNI"; // Establecer la propiedad a mostrar en el ComboBox
            cmboxTipo.Items.AddRange(Principal.ObtenerClientes().ToArray());   
            */

            cmboxTipo.Items.Add("BASQUET");
            cmboxTipo.Items.Add("FUTBOL");
            cmboxTipo.Items.Add("PADEL");


            cmboxCantJugadores.Items.Add("4");
            cmboxCantJugadores.Items.Add("8");
            cmboxCantJugadores.Items.Add("10");
        }
        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            var confirmacion = MessageBox.Show($"Seguro que desea agregar una cancha con los siguientes datos?\n" +
                $" Nombre: {txtNombre.Text}\n Tipo: {Tipo}\n Cantidad de Jugadores: {int.Parse(CantJugadores)}", "Atencion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmacion == DialogResult.OK)
            {
                principal.AltaCancha(txtNombre.Text, Tipo, int.Parse(CantJugadores), int.Parse(txtPrecio.Text));
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
            Tipo = cmboxTipo.SelectedItem.ToString();
        }

        private void cmboxCantJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            CantJugadores = cmboxCantJugadores.SelectedItem.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioPrevio.Show();
        }
    }
}
