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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void lblFIFA22_Click(object sender, EventArgs e)
        {

        }

        private void btnFifa_Click(object sender, EventArgs e)
        {

        }

        private void btnFifa_Click_1(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto fifa = new Producto();
            fifa.nombre = lblFIFA22.Text;
            fifa.tipoJuego.nombre = lblCategoriaD1.Text;
            fifa.tipoJuego.identificador = lblCodigoFifa.Text;
            fifa.precioUnitario = double.Parse(lblPrecioFifa.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = fifa.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = fifa.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = fifa.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = fifa.precioUnitario;
            frm.Show();
        }

        private void btnPes_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto pes = new Producto();
            pes.nombre = lblPes.Text;
            pes.tipoJuego.nombre = lblCategoriaD2.Text;
            pes.tipoJuego.identificador = lblCodigoPes.Text;
            pes.precioUnitario = double.Parse(lblPrecioPes.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = pes.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = pes.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = pes.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = pes.precioUnitario;
            frm.Show();
        }

        private void btnUfc_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto ufc = new Producto();
            ufc.nombre = lblUfc.Text;
            ufc.tipoJuego.nombre = lblCategoriaD3.Text;
            ufc.tipoJuego.identificador = lblCodigoUfc.Text;
            ufc.precioUnitario = double.Parse(lblPrecioUfc.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = ufc.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = ufc.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = ufc.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = ufc.precioUnitario;
            frm.Show();
        }

        private void btnNba_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto nba = new Producto();
            nba.nombre = lblNba.Text;
            nba.tipoJuego.nombre = lblCategoriaD4.Text;
            nba.tipoJuego.identificador = lblCodigoNba.Text;
            nba.precioUnitario = double.Parse(lblPrecioNba.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = nba.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = nba.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = nba.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = nba.precioUnitario;
            frm.Show();
        }

        private void btnPubg_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto pubg = new Producto();
            pubg.nombre = lblPubg.Text;
            pubg.tipoJuego.nombre = lblCategoriaS1.Text;
            pubg.tipoJuego.identificador = lblCodigoPubg.Text;
            pubg.precioUnitario = double.Parse(lblPrecioPubg.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = pubg.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = pubg.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = pubg.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = pubg.precioUnitario;
            frm.Show();
        }

        private void btnMinecraft_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto mnc = new Producto();
            mnc.nombre = lblMinecraft.Text;
            mnc.tipoJuego.nombre = lblCategoriaS2.Text;
            mnc.tipoJuego.identificador = lblCodigoMinecraft.Text;
            mnc.precioUnitario = double.Parse(lblPrecioMinecraft.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = mnc.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = mnc.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = mnc.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = mnc.precioUnitario;
            frm.Show();
        }

        private void btnRust_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto rust = new Producto();
            rust.nombre = lblRust.Text;
            rust.tipoJuego.nombre = lblCategoriaS3.Text;
            rust.tipoJuego.identificador = lblCodigoRust.Text;
            rust.precioUnitario = double.Parse(lblPrecioRust.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = rust.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = rust.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = rust.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = rust.precioUnitario;
            frm.Show();
        }

        private void btnArk_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto ark = new Producto();
            ark.nombre = lblArk.Text;
            ark.tipoJuego.nombre = lblCategoriaS4.Text;
            ark.tipoJuego.identificador = lblCodigoArk.Text;
            ark.precioUnitario = double.Parse(lblPrecioArk.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = ark.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = ark.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = ark.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = ark.precioUnitario;
            frm.Show();
        }

        private void btnDbd_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto dbd = new Producto();
            dbd.nombre = lblDbd.Text;
            dbd.tipoJuego.nombre = lblCategoriaT1.Text;
            dbd.tipoJuego.identificador = lblCodigoDbd.Text;
            dbd.precioUnitario = double.Parse(lblPrecioDbd.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = dbd.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = dbd.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = dbd.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = dbd.precioUnitario;
            frm.Show();
        }

        private void btnOtl_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto otl = new Producto();
            otl.nombre = lblOtl.Text;
            otl.tipoJuego.nombre = lblCategoriaT2.Text;
            otl.tipoJuego.identificador = lblCodigoOut.Text;
            otl.precioUnitario = double.Parse(lblPrecioOut.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = otl.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = otl.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = otl.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = otl.precioUnitario;
            frm.Show();
        }

        private void btnRevil_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto revil = new Producto();
            revil.nombre = lblRevil.Text;
            revil.tipoJuego.nombre = lblCategoriaT3.Text;
            revil.tipoJuego.identificador = lblCodigoRevil.Text;
            revil.precioUnitario = double.Parse(lblPrecioRevil.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = revil.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = revil.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = revil.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = revil.precioUnitario;
            frm.Show();
        }

        private void btnFnaf_Click(object sender, EventArgs e)
        {
            FrmCarrito frm = new FrmCarrito();
            Producto fnaf = new Producto();
            fnaf.nombre = lblFnaf.Text;
            fnaf.tipoJuego.nombre = lblCategoriaT4.Text;
            fnaf.tipoJuego.identificador = lblCodigoFnaf.Text;
            fnaf.precioUnitario = double.Parse(lblPrecioFnaf.Text);
            int n = frm.dgvCarrito.Rows.Add();
            frm.dgvCarrito.Rows[n].Cells[0].Value = fnaf.nombre;
            frm.dgvCarrito.Rows[n].Cells[1].Value = fnaf.tipoJuego.identificador;
            frm.dgvCarrito.Rows[n].Cells[2].Value = fnaf.tipoJuego.nombre;
            frm.dgvCarrito.Rows[n].Cells[3].Value = fnaf.precioUnitario;
            frm.Show();
        }
    }
}
