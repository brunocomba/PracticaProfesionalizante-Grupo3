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
    public partial class GestionTurnos : Form
    {
        public GestionTurnos()
        {
            InitializeComponent();
        }

        private void GestionTurnos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaTurnos altaTurnos = new AltaTurnos();
            altaTurnos.Show();
            this.Hide();
        }
    }
}
