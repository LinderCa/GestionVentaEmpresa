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
    public partial class FrmListadoVentas : Form
    {
        public FrmListadoVentas()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            this.ListarVentas();


        }

        private void ListarVentas()
        {
            RNVenta rn = new RNVenta();
            List<Venta> encontradas = null;

            try
            {
                encontradas = rn.ListarPorPeriodo(this.DtpInicio.Value, this.DtpFin.Value);
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
    }
}
