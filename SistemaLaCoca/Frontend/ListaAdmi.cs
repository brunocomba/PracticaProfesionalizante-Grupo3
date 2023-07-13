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
    public partial class ListaAdmi : Form
    {
        public ListaAdmi()
        {
            InitializeComponent();
        }

        private void ListaAdmi_Load(object sender, EventArgs e)
        {
            dgvAdministradores.DataSource = null;
            dgvAdministradores.DataSource = Principal.ObtenerAdministradores();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
            this.Hide();
        }
    }
}
