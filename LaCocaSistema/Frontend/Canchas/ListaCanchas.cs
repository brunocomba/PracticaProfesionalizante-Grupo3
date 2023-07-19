using FrontEnd;
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
    public partial class ListaCanchas : Form
    {
        public ListaCanchas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ListaCanchas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Principal.ObtenerCanchas();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaCanchas altaCanchas = new AltaCanchas();
            altaCanchas.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();   
            menuInicio.Show();
            this.Hide();
        }
    }
}
