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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion
{
    public partial class FrmProducto : Form
    {
        private Producto Actual;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarCategorias();
        }

        private void ListarCategorias()
        {
            RNCategoria rn = new RNCategoria();
            List<Categoria> categorias;

            try
            {
                categorias = rn.ListarVigentes();
                this.CboCategoria.DataSource = null;
                if (categorias != null && categorias.Count > 0)
                {
                    this.CboCategoria.ValueMember = "Codigo";
                    this.CboCategoria.DisplayMember = "Nombre";
                    this.CboCategoria.DataSource = categorias;
                }
                else
                {
                    MessageBox.Show("No se pudo listar las categorias", this.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operación", this.Text);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Actual = null;
            this.ActivarControles(true);
            this.LimpiarControles();
        }

        private void LimpiarControles()
        {
            this.CboCategoria.SelectedIndex = -1;
            this.TxtNombre.Text = "";
            this.TxtDescripción.Text = "";
            this.NudPrecioMinimo.Value = this.NudPrecioMinimo.Minimum;
            this.NudPrecio.Value = this.NudPrecio.Minimum;
            this.ChkVigente.Checked = true;
        }

        private void ActivarControles(bool estado)
        {
            this.GbEntidad.Enabled = estado;
            this.GbListado.Enabled = !estado;

            if (estado == true)
            {
                this.CboCategoria.Focus();
            }
            else
            {
                this.BtnListar.Focus();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            this.LimpiarControles();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            RNProducto rn;
            Producto producto;

            if (this.ValidateChildren() == true)
            {
                producto = this.CrearInstancia();
                rn = new RNProducto();
                try
                {
                    if (this.Actual == null)
                    {
                        rn.Registrar(producto);
                    }
                    else
                    {
                        rn.Actualizar(producto);
                    }
                    this.LimpiarControles();
                    this.ActivarControles(false);
                    BtnListar.PerformClick();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la operación", this.Text);
                }
            }
        }

        private Producto CrearInstancia()
        {
            Producto producto = new Producto()
            {
                Categoria = (Categoria)this.CboCategoria.SelectedItem,
                Nombre = this.TxtNombre.Text,
                Descripcion = this.TxtDescripción.Text,
                PrecioMinimo = (double)this.NudPrecioMinimo.Value,
                Precio = (double)this.NudPrecio.Value,
                Vigente = ChkVigente.Checked
            };

            if (this.Actual != null)
            {
                producto.Codigo = this.Actual.Codigo;
            }

            return producto;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNProducto rn = new RNProducto();
            List<Producto> seleccionados;

            try
            {
                seleccionados = rn.Listar(this.TxtProducto.Text);
                this.DgvListado.DataSource = null;
                if (seleccionados != null && seleccionados.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = seleccionados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operación", this.Text);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (this.DgvListado.CurrentRow != null)
            {
                this.Actual = (Producto)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", this.Text);
            }
        }

        private void PresentarDatos()
        {
            RNProducto rn = new RNProducto();

            try
            {
                this.Actual = rn.Leer(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    this.CboCategoria.Text = this.Actual.Categoria.Nombre;
                    this.TxtNombre.Text = this.Actual.Nombre;
                    this.TxtDescripción.Text = this.Actual.Descripcion;
                    this.NudPrecio.Value = (decimal)this.Actual.Precio;
                    this.NudPrecioMinimo.Value = (decimal)this.Actual.PrecioMinimo;
                    this.ChkVigente.Checked = this.Actual.Vigente;
                    this.ActivarControles(true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la operación");
            }
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNombre.Text = this.TxtNombre.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNombre.Text) == false)
            {
                this.ErrMensaje.SetError(this.TxtNombre, "");
            }
            else
            {
                this.ErrMensaje.SetError(this.TxtNombre, "Debe indicar un nombre");
                e.Cancel = true;
            }
        }

        private void CboCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (CboCategoria.SelectedIndex > -1)
            {
                this.ErrMensaje.SetError(this.CboCategoria, "");
            }
            else
            {
                this.ErrMensaje.SetError(this.CboCategoria, "Debe seleccionar una categoría");
                e.Cancel = true;
            }
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
