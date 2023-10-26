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
            try
            {
                var confirmacion = MessageBox.Show($"Seguro que desea agregar este nuevo elemento?\n" +
                $" Nombre: {txtNombre.Text}\n Stock: {txtStock.Text}", "Atencion",  MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmacion == DialogResult.OK)
                {
                    principal.altaElemento(txtNombre.Text, txtStock.Text);
                    MessageBox.Show($"El elemento {txtNombre.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    var confirmarCancelacion = MessageBox.Show($"Seguro que desea cancelar la operacion?", "Atencion", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                    if (confirmarCancelacion == DialogResult.OK)
                    {
                        txtNombre.Clear();
                        txtStock.Clear();
                      
                    }
                }
                
            }
            catch (Exception camposIncompletos)
            {
                MessageBox.Show("Error: " + camposIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            StockElementos listaElementos = new StockElementos();
            listaElementos.Show();
            this.Hide();
        }
    }
}
