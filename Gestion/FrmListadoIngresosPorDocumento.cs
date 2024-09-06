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
    public partial class FrmListadoIngresosPorDocumento : Form
    {
        public FrmListadoIngresosPorDocumento()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNVenta rn = new RNVenta();
            List<Venta> encontradas = null;

            try
            {
                encontradas = rn.ListarPorDocumentoFecha(this.DtpInicio.Value, this.CboDocumento.Text.Substring(0, 1));
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

        private void FrmListadoIngresosPorDocumento_Load(object sender, EventArgs e)
        {
            CboDocumento.SelectedIndex = 0;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
