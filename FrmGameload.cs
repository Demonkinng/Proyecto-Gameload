using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gameload_2
{
    struct Categoria
    {
        public string nombre;
        public string identificador;
    }
    struct Producto
    {
        public string nombre;
        public Categoria tipoJuego;
        public string categoria;
        public double precioUnitario;
    }

    struct Usuario
    {
        public string nombre;
        public string apellido;
        public string cedula;
    }

    struct Fecha
    {
        public int dia;
        public int mes;
        public int anio;
    }

    struct Factura
    {
        public Usuario usuario;
        public Fecha fecha;
        public double subtotal;
        public double IVA;
        public double total;
    }
    public partial class Gameload : Form
    {
        public Gameload()
        {
            InitializeComponent();
        }

        private void Gameload_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void AbrirFormularios<FormularioAbrir>() where FormularioAbrir : Form, new()
        {
            Form Formularios;

            Formularios = panelContenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            if (Formularios == null)
            {
                Formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };

                panelContenedor.Controls.Add(Formularios);
                panelContenedor.Tag = Formularios;
                Formularios.Show();
                Formularios.BringToFront();
            }
            else
            {
                Formularios.BringToFront();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmInfo>();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmAyuda>();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmInicio>();
        }
    }
}
