using Logica;
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
            try
            {
                Elemento elementoElegido = (Elemento)cmboxElementos.SelectedItem;

                principal.AgregarStock(elementoElegido, txtStock.Text);
                MessageBox.Show($"El stock al elemento: {elementoElegido.Nombre} fue agregado con exito!\n\nEl stock actual del elemento {elementoElegido.Nombre} es de: {elementoElegido.Stock}", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtStock.Clear();
            }
            catch (Exception camposIncompletos)
            {
                MessageBox.Show("Error: " + camposIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            StockElementos stockElementos = new StockElementos();
            stockElementos.Show();
            this.Hide();
        }

        private void AgregarStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationDbContex context = new ApplicationDbContex();

            // Preguntar si desea cerrar el programa o no.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var rta = MessageBox.Show("¿Seguro que deseas salir?", "Confirmar salida ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rta == DialogResult.OK)
                {

                    Application.Exit();

                    // Cambiarle al administrador que esta logueado (actual) la propiedad Logueado a NO.
                    Administrador.admLogueado.Logueado = Administrador.SioNo.NO;
                    context.Administradores.Update(Administrador.admLogueado);
                    context.SaveChanges();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
