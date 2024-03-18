using Logica;
using Logica.Clases;

namespace Frontend
{
    public partial class ModificarCancha : Form
    {
        public ModificarCancha()
        {
            InitializeComponent();
        }


        Principal principal = new Principal();


        private Cancha CanchaQueEdito;
        private void ModificarCancha_Load(object sender, EventArgs e)
        {
            cmboxDeporte.Items.AddRange(principal.ObtenerListaDeportes().ToArray());
            cmboxDeporte.DisplayMember = "Name";

            /*
            cmboxDeporte.Items.Add("BASQUET");
            cmboxDeporte.Items.Add("FUTBOL");


            cmboxCantJugadores.Items.Add("8");
            cmboxCantJugadores.Items.Add("10");
            */

            cmboxCanchas.Items.AddRange(principal.ObtenerListaCanchas().ToArray());
        }


        private void btnModificarCancha_Click_1(object sender, EventArgs e)
        {
            Deporte deporteElegido = (Deporte)cmboxDeporte.SelectedItem;

            // verificar que los combos no esten incompletos
            try
            {
                if (cmboxDeporte.SelectedItem == null)
                {
                    throw new Exception("No se ha seleccionado ningún elemento en el ComboBox.");
                }
            }
            catch (Exception comboxImcompletos)
            {
                MessageBox.Show("Error: " + comboxImcompletos.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // si lo estan tira este msj de error

            }

            try
            {
                var SIoNO = MessageBox.Show($"Seguro desea realizar esta modificacion?\n\n{CanchaQueEdito.nombre} por {txtNombre.Text}\n{CanchaQueEdito.Deporte} por {cmboxDeporte.Text}\n{CanchaQueEdito.Precio} por {txtPrecio.Text}\n\nPresione ACEPTAR para continuar.   ",
                "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (SIoNO == DialogResult.OK)
                {
                    principal.modificarCancha(CanchaQueEdito, txtNombre.Text, deporteElegido, txtPrecio.Text);

                    MessageBox.Show($"La cancha ha sido modificado con exito! ", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtPrecio.Clear();
                    cmboxDeporte.Text = "";

                }
                else
                {
                    var rtaCancel = MessageBox.Show("Seguro quiere cancelar los cambios?", "Advertencia", MessageBoxButtons.YesNo);
                    if (rtaCancel == DialogResult.Yes)
                    {
                        txtNombre.Clear();
                        txtPrecio.Clear();
                        cmboxDeporte.Text = "";

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
            ListaCanchas listaCanchas = new ListaCanchas();
            listaCanchas.Show();
            this.Hide();
        }



        // DESAHABILITAR LA OPCION DE PODER INGRESAR TEXTO EN EL COMBO UNA VEZ HAYA HECHO CLICK EN EL COMBOBOX ESPECIFICO.
        private void cmboxDeporte_MouseClick(object sender, MouseEventArgs e)
        {
            cmboxDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmboxCantJugadores_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ModificarCancha_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cmboxCanchas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cancha canchaElegida = (Cancha)cmboxCanchas.SelectedItem;

            CanchaQueEdito = canchaElegida;
            txtNombre.Text = CanchaQueEdito.nombre;
            cmboxDeporte.Text = canchaElegida.Deporte.Name;
            txtPrecio.Text = CanchaQueEdito.Precio.ToString();

        }
    }
}