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
    public partial class FrmDetalle : Form
    {

        private DetalleVenta detalle;
        List<Producto> productos;
        private List<DetalleVenta> detalles;

        public FrmDetalle()
        {
            InitializeComponent();
        }

        internal DetalleVenta Agregar(List<DetalleVenta> detalles)
        {
            this.detalles = detalles;
            this.ShowDialog();
            return this.detalle;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            bool esRegistrado = false;
            if (this.ValidateChildren() == true)
            {
                foreach (var det in detalles)
                {
                    if (det.Producto.Codigo == ((Producto)this.CboProducto.SelectedItem).Codigo)
                    {
                        esRegistrado = true;
                    }
                }

                if (esRegistrado)
                {
                    MessageBox.Show("Producto ya registrado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.detalle = new DetalleVenta()
                    {
                        Producto = (Producto)this.CboProducto.SelectedItem,
                        Cantidad = (int)this.NudCantidad.Value,
                        Precio = (double)this.NudPrecio.Value
                    };
                    this.Close();
                }
            }
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            this.CargarProductos();
        }

        private void CargarProductos()
        {
            RNProducto rn = new RNProducto();
            try
            {
                productos = rn.ListarVigentes();
                this.CboProducto.DataSource = null;
                if (Program.Productos.Count > 0)
                {
                    this.CboProducto.DisplayMember = "Nombre";
                    this.CboProducto.DataSource = productos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la lista de productos");
            }
        }

        private void CboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productos.Any())
            {
                var producto = (Producto)this.CboProducto.SelectedItem;
                NudPrecio.Value = (decimal)producto.Precio;
                CalcularTotal();
            }
        }

        private void NudPrecio_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void NudCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            TxtTotal.Text = (NudPrecio.Value * NudCantidad.Value).ToString();
        }
    }
}
