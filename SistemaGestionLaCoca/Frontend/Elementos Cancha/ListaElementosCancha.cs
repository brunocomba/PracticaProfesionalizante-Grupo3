using Frontend.Elementos;
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

namespace Frontend.Elementos_Cancha
{
    public partial class ListaElementosCancha : Form
    {
        public ListaElementosCancha()
        {
            InitializeComponent();
        }

        Principal principal = new Principal();

        private void ListaElementosCancha_Load(object sender, EventArgs e)
        {
            dgvElementosCancha.DataSource = principal.ObtenerAsignacionDeElementos();


            toolTip1.SetToolTip(btnAgregarAsig, "Asignar un elemento a una cancha");
            toolTip1.SetToolTip(btnDeleteAsig, "Eliminar asignacion de un elemanto a una cancha.");
        }


        private void btnAgregarAsig_Click(object sender, EventArgs e)
        {
            AsignarElemento asignarElemento = new AsignarElemento();
            asignarElemento.Show();
            this.Hide();
        }

        private void btnDeleteAsig_Click(object sender, EventArgs e)
        {
            if (dgvElementosCancha.Rows.Count > 0)
            {
                object elemento = this.dgvElementosCancha.SelectedCells[3].Value; // obtener el valor de la columna Id-Elemento
                int idElemetno = (int)elemento; // convertirlo en INT

                object asig = this.dgvElementosCancha.SelectedCells[0].Value; // obtener el valor de la columna Id-Asignacion
                int idAsig = (int)asig; // convertirlo en INT


                var confirmacion = MessageBox.Show($"Seguro que desea eliminar la asignacion del elemento a la cancha?" +
                     $"\nLa cantidad del elemento en la asignacion sera otra vez agregado al stock.", "ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.OK)
                {
                    principal.RemoveAsignacionElemento(idElemetno, idAsig);
                }
            }
            else
            {
                MessageBox.Show("No hay asignaciones de elementos registradas para eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            dgvElementosCancha.DataSource = null;
            dgvElementosCancha.DataSource = principal.ObtenerAsignacionDeElementos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ListaCanchas listaCanchas = new ListaCanchas();
            listaCanchas.Show();
            this.Hide();
        }

        private void ListaElementosCancha_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvElementosCancha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
