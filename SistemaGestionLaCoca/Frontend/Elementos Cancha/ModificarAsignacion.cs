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
    public partial class ModificarAsignacion : Form
    {
        public ModificarAsignacion()
        {
            InitializeComponent();
        }

        private ElementoCancha asignacionQueEdito;


        public void ModificarAsignacionElement(ElementoCancha asignacion)
        {
            asignacionQueEdito = asignacion;
            cmboxCancha.Text = asignacion.Cancha.ToString();
            cmboxElementos.Text = asignacion.Elemento.ToString();
            txtCantidad.Text = asignacion.Cantidad.ToString();

        }

        Principal principal = new Principal();
        private void ModificarAsignacion_Load(object sender, EventArgs e)
        {

            cmboxCancha.Items.AddRange(principal.ObtenerListaCanchas().ToArray());
            cmboxElementos.Items.AddRange(principal.ObtenerElementos().ToArray());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cancha canchaElegida = (Cancha)cmboxCancha.SelectedItem;
            Elemento elementoElegido = (Elemento)cmboxElementos.SelectedItem;

            principal.ModificarAsignacionElemento(asignacionQueEdito, canchaElegida, elementoElegido, int.Parse(txtCantidad.Text));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaElementosCancha listaElementosCancha = new ListaElementosCancha();
            listaElementosCancha.Show();
            this.Hide();
        }
    }
}

