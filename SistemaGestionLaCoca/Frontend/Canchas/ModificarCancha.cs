using LogicaClases.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class ModificarCancha : Form
    {
        public ModificarCancha()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();
        ListaCanchas listaCanchas = new ListaCanchas();

        private Cancha CanchaQueEdito;

        public void ModificacionCancha(Cancha cancha)
        {
            CanchaQueEdito = cancha;
            txtNombre.Text = CanchaQueEdito.nombre;
            cmboxTipo.Text = CanchaQueEdito.tipo;
            cmboxCantJugadores.Text = CanchaQueEdito.cantJugadores.ToString();
            txtPrecio.Text = CanchaQueEdito.precio.ToString();

        }


        private void ModificarCancha_Load(object sender, EventArgs e)
        {
            cmboxTipo.Items.Add("BASQUET");
            cmboxTipo.Items.Add("FUTBOL");
            cmboxTipo.Items.Add("PADEL");


            cmboxCantJugadores.Items.Add("4");
            cmboxCantJugadores.Items.Add("8");
            cmboxCantJugadores.Items.Add("10");

        }


        private void btnModificarCancha_Click_1(object sender, EventArgs e)
        {
            var SIoNO = MessageBox.Show($"Seguro desea realizar esta modificacion?\n\n{CanchaQueEdito.nombre} por {txtNombre.Text}\n{CanchaQueEdito.tipo} por {cmboxTipo.Text}\n" +
                $"{CanchaQueEdito.cantJugadores} por {cmboxCantJugadores.Text}\n{CanchaQueEdito.precio} por {txtPrecio.Text}\n\nPresione ACEPTAR para continuar.   ",
                "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (SIoNO == DialogResult.OK)
            {
                principal.modificarCancha(CanchaQueEdito, txtNombre.Text, cmboxTipo.Text, int.Parse(cmboxCantJugadores.Text),
                int.Parse(txtPrecio.Text));

                MessageBox.Show("Cancha modificado con exito!");
                listaCanchas.Show();
                this.Hide();
            }
            else
            {
                var rtaCancel = MessageBox.Show("Seguro quiere cancelar los cambios?", "Advertencia", MessageBoxButtons.YesNo);
                if (rtaCancel == DialogResult.Yes)
                {
                    listaCanchas.Show();
                    this.Hide();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaCanchas.Show();
            this.Hide();
        }




        // Deshabilitar que se pueda introducir texto en el comboBox una vez apretado el mismo
        private void cmboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboxTipo.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void cmboxCantJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmboxCantJugadores.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}