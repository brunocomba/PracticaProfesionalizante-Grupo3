using FrontEnd;
using Logica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        List<string> listaPropiedades = new List<string>();
        private void HistorialTurnos_Load(object sender, EventArgs e)
        {

            foreach (var turno in Principal.ObtenerTurnos())
            {
                string propConcatenada = turno.MostrarInfo();
                listaPropiedades.Add(propConcatenada);

            }
            listBox1.DataSource = listaPropiedades;


            
        }


        private void txtFiltrarTurnos_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtFiltrarTurnos.Text.ToLower(); // Convierte el término de búsqueda a minúsculas
            var resultados = Principal.ObtenerTurnos().Where(turno => turno.Id.ToString().Contains(busqueda) || turno.Fecha.ToString().Contains(busqueda)).ToList();


        }



        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            AltaTurno altaTurno = new AltaTurno();
            altaTurno.Show();
            this.Hide();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.Show();
            this.Hide();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}
