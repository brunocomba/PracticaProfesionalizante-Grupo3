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

namespace Frontend.Elementos
{
    public partial class AgregarStock : Form
    {
        public AgregarStock()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();
        private void AgregarStock_Load(object sender, EventArgs e)
        {
            cmboxElementos.Items.AddRange(principal.ObtenerElementos().ToArray());

        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            Elemento elementoElegido = (Elemento)cmboxElementos.SelectedItem;

            principal.AgregarStock(elementoElegido, txtStock.Text);
            MessageBox.Show($"El stock al elemento: {elementoElegido.Nombre} fue agregado con exito!\n\nStock actual del elemento {elementoElegido.Nombre} es: {elementoElegido.Stock}", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            StockElementos stockElementos = new StockElementos();
            stockElementos.Show();
            this.Hide();
        }
    }
}
