using Frontend;
using Frontend.Deportes;
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
            cmboxDeporte.Items.AddRange(principal.ObtenerListaDeportes().ToArray());
            cmboxDeporte.DisplayMember = "Name";

            /*
            cmboxDeporte.Items.Add("BASQUET");
            cmboxDeporte.Items.Add("FUTBOL");
            */




        }
        private void btnAgregarCancha_Click(object sender, EventArgs e)
        {
            Deporte deporteElegido = (Deporte)cmboxDeporte.SelectedItem;


            try
            {
                if (cmboxDeporte.SelectedItem == null)
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
                $" Nombre: {txtNombre.Text}\n Tipo: {deporteElegido.Name}\n Cantidad de Jugadores: {deporteElegido.Cant_Jugadores}", "Atencion",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmacion == DialogResult.OK)
                {
                    principal.AltaCancha(txtNombre.Text, deporteElegido, (txtPrecio.Text));
                    MessageBox.Show($"La cancha {txtNombre.Text} fue agregado con exito!", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
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

        private void btnAddDeporte_Click(object sender, EventArgs e)
        {
            AltaDeporte altaDepor = new AltaDeporte(this);
            altaDepor.Show();
            this.Hide();
        }
    }
}
