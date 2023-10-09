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
    public partial class AltaElemento : Form
    {
        public AltaElemento()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void btnAgregarElemento_Click(object sender, EventArgs e)
        {
            principal.altaElemento(txtNombre.Text, int.Parse(txtStock.Text));
            MessageBox.Show("Elemento agregado con exito!");
        }
    }
}
