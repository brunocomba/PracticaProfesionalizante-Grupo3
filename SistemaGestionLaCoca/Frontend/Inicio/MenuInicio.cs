using Frontend;
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

namespace FrontEnd
{
    public partial class MenuInicio : Form
    {

        public MenuInicio()
        {
            InitializeComponent();
        }


        Principal principal = new Principal();

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            ListaAdmi listaAdmi = new ListaAdmi();
            listaAdmi.Show();
            this.Hide();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            HistorialTurnos historialTurnos = new HistorialTurnos();
            historialTurnos.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.Show();
            this.Hide();
        }

        private void MenuInicio_Load(object sender, EventArgs e)
        {
            dgvTurnosDeHoy.DataSource = principal.turnosDelDia();
            btnAdministrador.Text = $"{Administrador.admLogueado.Nombre} {Administrador.admLogueado.Apellido}";
        }

        private void btnCanchas_Click(object sender, EventArgs e)
        {
            ListaCanchas listaCanchas = new ListaCanchas();
            listaCanchas.Show();
            this.Hide();
        }

        private void btneElementos_Click(object sender, EventArgs e)
        {
            StockElementos listaElementos = new StockElementos();
            listaElementos.Show();
            this.Hide();
        }


        private void MenuInicio_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            // si no esta visible,  lo va a mostrar
            if (!panelAdmiLogueado.Visible)
            {
                panelAdmiLogueado.Visible = true;
            }
            else // si lo esta mostrando, lo va a ocultar
            {
                panelAdmiLogueado.Visible = false;
            }
        }

        private void btnCambiarCuenta_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }


        private void btnCerrarCesion_Click(object sender, EventArgs e)
        {
            ApplicationDbContex context = new ApplicationDbContex();

            var rta = MessageBox.Show("¿Seguro que deseas salir?", "Confirmar salida ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rta == DialogResult.OK)
            {
                Application.Exit();
                Administrador.admLogueado.Logueado = Administrador.SioNo.NO;
                context.Administradores.Update(Administrador.admLogueado);
                context.SaveChanges();
            }
        }

        private void dgvTurnosDeHoy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
