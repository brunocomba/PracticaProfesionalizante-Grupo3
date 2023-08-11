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
    public partial class HistorialTurnos : Form
    {
        public HistorialTurnos()
        {
            InitializeComponent();
        }

        private void HistorialTurnos_Load(object sender, EventArgs e)
        {
            dgvTurnos.DataSource = Principal.ObtenerTurnos();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
            this.Hide();
        }

        private void txtFiltrarTurnos_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtFiltrarTurnos.Text.ToLower(); // Convierte el término de búsqueda a minúsculas
            var resultados = Principal.ObtenerTurnos().Where(turno => turno.id.ToString().Contains(busqueda) || turno.fecha.ToString().Contains(busqueda)).ToList();

            dgvTurnos.DataSource = resultados;
        }

        private void dgvCanchas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AltaTurno altaTurno = new AltaTurno();
            altaTurno.Show();
            this.Hide();
        }
    }

}
