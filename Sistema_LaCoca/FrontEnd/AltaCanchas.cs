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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrontEnd
{
    public partial class AltaCanchas : Form
    {
        string Tipo;
        string CantJugadores;
        public AltaCanchas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaCanchas_Load(object sender, EventArgs e)
        {
            cmboxTipo.Items.Add("Basquet");
            cmboxTipo.Items.Add("Futbol");
            cmboxTipo.Items.Add("Padel");


            cmboxCantJugadores.Items.Add("4");
            cmboxCantJugadores.Items.Add("8");
            cmboxCantJugadores.Items.Add("10");



        }

        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            principal.altaCancha(txtNombre.Text, Tipo, int.Parse(CantJugadores));

            MessageBox.Show($"Segurom que desea agregar una cancha con los siguientes datos?\n" +
                $" Nombre: {txtNombre.Text}\n Tipo: {Tipo}\n Cantidad de Jugadores: {int.Parse(CantJugadores)}");

        }

        private void cmboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tipo = cmboxTipo.SelectedItem.ToString();
        }

        private void cmboxCantJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            CantJugadores = cmboxCantJugadores.SelectedItem.ToString();

        }
    }
}
