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
    public partial class FrmConfirmar : Form
    {
        public FrmConfirmar()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtDia.Clear();
            txtMes.Clear();
            txtAnio.Clear();
            txtFactura.Clear();
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

        private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nombre = txtNombre.Text;
            usuario.apellido = txtApellido.Text;
            usuario.cedula = txtCedula.Text;
            Fecha fecha = new Fecha();
            fecha.dia = Convert.ToInt32(txtDia.Text);
            fecha.mes = Convert.ToInt32(txtMes.Text);
            fecha.anio = Convert.ToInt32(txtAnio.Text);
            MessageBox.Show("La factura se generó exitosamente", "Notificación");
            Factura factura = new Factura();
            factura.subtotal = Convert.ToDouble(dgvCarrito.CurrentRow.Cells[3].Value.ToString());
            factura.IVA = factura.subtotal * 0.12;
            factura.total = factura.subtotal + factura.IVA;
            txtFactura.Text = "DATOS DEL CLIENTE\r\nNombre: " + usuario.nombre + "\r\nApellido: " + usuario.apellido +"\r\nCédula: "+ usuario.cedula
                +"\r\nDATOS DE LA COMPRA\r\nFecha: " + fecha.dia +"/" + fecha.mes +"/" + fecha.anio + "\r\nProducto: " + dgvCarrito.CurrentRow.Cells[0].Value.ToString()
                +"\r\nIdentificador: " + dgvCarrito.CurrentRow.Cells[1].Value.ToString() + "\r\nCategoría: " + dgvCarrito.CurrentRow.Cells[2].Value.ToString()
                +"\r\nSubtotal: $" + factura.subtotal + "\r\nIVA 12%: $" + factura.IVA + "\r\nTotal: $" + factura.total;
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                epError.SetError(txtNombre, "Introduce nombre...");
                txtNombre.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtApellido_Validated(object sender, EventArgs e)
        {
            if (txtApellido.Text.Trim() == "")
            {
                epError.SetError(txtApellido, "Introduce apellido...");
                txtApellido.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtCedula_Validated(object sender, EventArgs e)
        {
            if (txtCedula.Text.Trim() == "")
            {
                epError.SetError(txtCedula, "Introduce cédula...");
                txtCedula.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDia_Validated(object sender, EventArgs e)
        {
            if (txtDia.Text.Trim() == "")
            {
                epError.SetError(txtDia, "Introduce el día...");
                txtDia.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtMes_Validated(object sender, EventArgs e)
        {
            if (txtMes.Text.Trim() == "")
            {
                epError.SetError(txtMes, "Introduce el mes...");
                txtMes.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtAnio_Validated(object sender, EventArgs e)
        {
            if (txtAnio.Text.Trim() == "")
            {
                epError.SetError(txtAnio, "Introduce el año...");
                txtAnio.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
