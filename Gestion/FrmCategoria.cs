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
    public partial class FrmCategoria : Form
    {
        private Categoria actual; 
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            RNCategoria rn;
            Categoria nuevo;

            if (this.ValidateChildren() == true)
            {
                nuevo = this.CrearEntidad();
                rn = new RNCategoria();
                try
                {
                    if (this.actual == null)
                    {
                        rn.Registrar(nuevo);
                    }
                    else
                    {
                        rn.Actualizar(nuevo);
                    }
                    this.ActivarControles(false);
                    this.BtnListar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la operación", this.Text);
                }
                finally
                {
                    rn = null;
                }
            }
        }

        private Categoria CrearEntidad()
        {
            Categoria nuevo = new Categoria()
            {
                Nombre = this.TxtNombre.Text,
                Descripcion = this.TxtDescripcion.Text,
                Vigente = this.ChkVigente.Checked
            };

            if (this.actual != null)
            {
                nuevo.Codigo = this.actual.Codigo;
            }

            return nuevo;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            actual = null;
            this.ActivarControles(true);
            this.LimpiarControles();
        }

        private void LimpiarControles()
        {
            this.TxtNombre.Text = "";
            this.TxtDescripcion.Text = "";
            this.ChkVigente.Checked = true;
        }

        private void ActivarControles(bool estado)
        {
            this.GbEntidad.Enabled = estado;
            this.GbListado.Enabled = !estado;

            if (estado == true)
            {
                this.TxtNombre.Focus();
            }
            else
            {
                this.BtnListar.Focus();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(this.DgvListado.CurrentRow != null)
            {
                this.actual = (Categoria)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionarse una categoría",  this.Text);
            }
        }

        private void PresentarDatos()
        {
            RNCategoria rn = new RNCategoria();

            try
            {
                this.actual = rn.Leer(this.actual.Codigo);

                if (this.actual != null)
                {
                    this.TxtNombre.Text = this.actual.Nombre;
                    this.TxtDescripcion.Text = this.actual.Descripcion;
                    this.ChkVigente.Checked = this.actual.Vigente;

                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se encontraron los datos solicitados", this.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener los datos solicitados", this.Text);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNCategoria rn = new RNCategoria();
            List<Categoria> categorias;

            try
            {
                categorias = rn.ListarVigentes();

                this.DgvListado.DataSource = null;
                if (categorias.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = categorias;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo listar las empresas", this.Text);
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
                this.ErrMensaje.SetError(this.TxtNombre, "Debe indicar la razón social de la empresa");
                e.Cancel = true;
            }
        }
    }
}
