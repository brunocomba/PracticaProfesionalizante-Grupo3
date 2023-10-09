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

namespace Frontend.Elementos_Cancha
{
    public partial class AsignarElemento : Form
    {
        public AsignarElemento()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void AsignarElemento_Load(object sender, EventArgs e)
        {
            cmboxCancha.Items.AddRange(principal.ObtenerListaCanchas().ToArray());
            cmboxElementos.Items.AddRange(principal.ObtenerElementos().ToArray());
        }

        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {
            Cancha canchaElegida = (Cancha)cmboxCancha.SelectedItem;
            Elemento elementoElegido = (Elemento)cmboxElementos.SelectedItem;

            principal.AsigElementoCancha(canchaElegida, elementoElegido, int.Parse(txtCantidad.Text));
            MessageBox.Show($"El elemento: {elementoElegido.Nombre} fue asignado a la cancha: {canchaElegida.Nombre} exitosamente! ");
        }
    }
}
