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
    public partial class FrmListadoProductosVendidosPorAnio : Form
    {
        public FrmListadoProductosVendidosPorAnio()
        {
            InitializeComponent();
        }


        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNVenta rn = new RNVenta();
            List<ReporteListadoProductosVendidosPorAnio> encontradas = null;

            try
            {
                encontradas = rn.ListarProductosVendidosPorAnio(this.DtpInicio.Value);
                this.DgvVentas.DataSource = null;
                if (encontradas.Count > 0)
                {
                    this.DgvVentas.AutoGenerateColumns = false;
                    this.DgvVentas.DataSource = encontradas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se pudo obtener los datos solicitados");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
