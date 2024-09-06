using Entidades;
using ReglasNegocio;
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
    public partial class FrmDarBajaAltaVentas : Form
    {
        public FrmDarBajaAltaVentas()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNVenta rn = new RNVenta();
            List<Venta> seleccionados;

            try
            {
                seleccionados = rn.ListarTodoPorPeriodo(this.DtpInicio.Value, this.DtpFin.Value);
                this.DgvVentas.DataSource = null;
                if (seleccionados != null && seleccionados.Count > 0)
                {
                    this.DgvVentas.AutoGenerateColumns = false;
                    this.DgvVentas.DataSource = seleccionados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operación", this.Text);
            }
        }

        private void BtnDarDeBaja_Click(object sender, EventArgs e)
        {
            var rpta = MessageBox.Show("¿Está seguro que desea dar de baja o alta a la venta?", this.Text,
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1);

            if (rpta == DialogResult.Yes)
            {
                try
                {
                    RNVenta rn = new RNVenta();
                    Venta distrito = (Venta)this.DgvVentas.CurrentRow.DataBoundItem;
                    rn.DarDeBaja(distrito.Codigo);
                    BtnListar.PerformClick();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo realizar la operación", this.Text);
                }
                
            }
        }
    }
}
