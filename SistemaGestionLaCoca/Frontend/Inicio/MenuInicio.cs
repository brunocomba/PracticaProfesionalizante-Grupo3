using Frontend;
using Frontend.Elementos;
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

namespace FrontEnd
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }


        Principal principal = new Principal();

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            ListaAdmi listaAdmi = new ListaAdmi();
            listaAdmi.Show();
            this.Hide();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            HistorialTurnos historialTurnos = new HistorialTurnos();
            historialTurnos.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.Show();
            this.Hide();
        }

        private void MenuInicio_Load(object sender, EventArgs e)
        {
            dgvTurnosDeHoy.DataSource = principal.turnosDelDia();

        }

        private void btnCanchas_Click(object sender, EventArgs e)
        {
            ListaCanchas listaCanchas = new ListaCanchas();
            listaCanchas.Show();
            this.Hide();
        }

        private void btneElementos_Click(object sender, EventArgs e)
        {
            StockElementos listaElementos = new StockElementos();
            listaElementos.Show();
            this.Hide();
        }
    }
}
