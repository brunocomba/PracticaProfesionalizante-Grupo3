using Frontend;
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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrontEnd
{
    public partial class AltaCanchas : Form
    {

        private Form formularioPrevio;
        public AltaCanchas(Form formularioPrevio)
        {
            InitializeComponent();
            this.formularioPrevio = formularioPrevio;
        }

        Principal principal = new Principal();
        ListaCanchas listaCanchas = new ListaCanchas();

        string CantJugadores;
        string Deporte;

        private void AltaCanchas_Load(object sender, EventArgs e)
        {
            // Cargar combo de tipo de deporte
            cmboxDeporte.Items.Add("BASQUET");
            cmboxDeporte.Items.Add("FUTBOL");

            // Cargar combo de cantidad de jugadores
            cmboxCantJugadores.Items.Add("8");
            cmboxCantJugadores.Items.Add("10");
        }
        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmboxDeporte.SelectedItem == null || cmboxCantJugadores.SelectedItem == null)
                {
                    throw new Exception("No se ha seleccionado ningún elemento en el ComboBox."); // si los combos estan incompletos tira esta excepcion  
                }

            }
            catch (Exception cmboxIncompletos)
            {
                MessageBox.Show("Error: " + cmboxIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                var confirmacion = MessageBox.Show($"Seguro que desea agregar una cancha con los siguientes datos?\n" +
                $" Nombre: {txtNombre.Text}\n Tipo: {cmboxDeporte.SelectedItem}\n Cantidad de Jugadores: {cmboxCantJugadores.SelectedItem}", "Atencion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmacion == DialogResult.OK)
                {
                    principal.AltaCancha(txtNombre.Text, cmboxDeporte.Text, cmboxCantJugadores.Text, (txtPrecio.Text));
                    MessageBox.Show($"La cancha {txtNombre.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    cmboxCantJugadores.Text = "";
                    cmboxDeporte.Text = "";
                    txtPrecio.Clear();

                }
                else
                {
                    var confirmarCancelacion = MessageBox.Show($"Seguro que desea cancelar la operacion?", "Atencion", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                    if (confirmarCancelacion == DialogResult.OK)
                    {
                        txtNombre.Clear();
                        cmboxCantJugadores.Text = "";
                        cmboxDeporte.Text = "";
                        txtPrecio.Clear();
                    }
                }
            }
            catch (Exception camposIncompletos)
            {
                MessageBox.Show("Error: " + camposIncompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formularioPrevio.Show();
        }

        private void AltaCanchas_FormClosing(object sender, FormClosingEventArgs e)
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
