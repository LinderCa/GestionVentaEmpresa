using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Sesion.CerrarSesion = true;
            this.Close();
        }

        private void MnuEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmpresa frm = new FrmEmpresa();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuTrabajador_Click(object sender, EventArgs e)
        {
            FrmTrabajador frm = new FrmTrabajador();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuVenta_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuListadoVentas_Click(object sender, EventArgs e)
        {
            FrmListadoVentas frm = new FrmListadoVentas();

            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuDarBajaAltaVentas_Click(object sender, EventArgs e)
        {
            FrmDarBajaAltaVentas frm = new FrmDarBajaAltaVentas();
            frm.MdiParent = this;   
            frm.Show();
        }

        private void MnuCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuProducto_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuCatalogoProductos_Click(object sender, EventArgs e)
        {
            FrmCatalogoProductos frm = new FrmCatalogoProductos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuListadoIngresosDocumento_Click(object sender, EventArgs e)
        {
            FrmListadoIngresosPorDocumento frm = new FrmListadoIngresosPorDocumento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuListadoProductosVendidosAnio_Click(object sender, EventArgs e)
        {
            FrmListadoProductosVendidosPorAnio frm = new FrmListadoProductosVendidosPorAnio();
            frm.MdiParent = this;
            frm.Show();
        }
    }

}
