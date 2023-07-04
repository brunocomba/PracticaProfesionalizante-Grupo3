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

namespace FrontEnd
{
    public partial class AltaCanchas : Form
    {
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

           
        }
    }
}
