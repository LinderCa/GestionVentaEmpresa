using Entidades;
using iTextSharp.text.pdf.codec.wmf;
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
    public partial class FrmUsuario : Form
    {
        private Usuario Actual;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ListarTrabajadores();
        }

        private void ListarTrabajadores()
        {
            RNTrabajador rn = new RNTrabajador();
            List<Trabajador> trabajadores;

            try
            {
                trabajadores = rn.ListarVigentes();
                this.CboTrabajador.DataSource = null;
                if (trabajadores != null && trabajadores.Count > 0)
                {
                    this.CboTrabajador.ValueMember = "Codigo";
                    this.CboTrabajador.DisplayMember = "NombreCompleto";
                    this.CboTrabajador.DataSource = trabajadores;
                }
                else
                {
                    MessageBox.Show("No se pudo listar a los trabajadores", this.Text);
                }
            }
            catch (Exception)
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
            CboTrabajador.SelectedIndex = -1;
            TxtNombre.Text = "";
            TxtClave.Text = "";
            TxtConfirmarClave.Text = "";
        }

        private void ActivarControles(bool estado)
        {
            this.GbTrabajador.Enabled = estado;
            this.GbListado.Enabled = !estado;
            this.ChkVigente.Checked = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            this.LimpiarControles();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            RNUsuario rn;
            Usuario usuario;

            if (this.ValidateChildren() == true)
            {
                usuario = this.CrearInstancia();
                rn = new RNUsuario();
                try
                {
                    if (this.Actual == null)
                    {
                        rn.Registrar(usuario);
                    }
                    else
                    {
                        rn.Actualizar(usuario);
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

        private Usuario CrearInstancia()
        {
            Usuario usuario = new Usuario()
            {
                Trabajador = (Trabajador)this.CboTrabajador.SelectedItem,
                Nombre = this.TxtNombre.Text,
                Clave = this.TxtClave.Text
            };

            if (this.Actual != null)
            {
                usuario.Codigo = this.Actual.Codigo;
            }

            return usuario;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNUsuario rn = new RNUsuario();
            List<Usuario> seleccionados;

            try
            {
                seleccionados = rn.Listar();
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
                this.Actual = (Usuario)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario", this.Text);
            }
        }

        private void PresentarDatos()
        {
            RNUsuario rn = new RNUsuario();

            try
            {
                this.Actual = rn.Leer(Actual.Codigo);
                if (this.Actual != null)
                {
                    this.CboTrabajador.SelectedValue = this.Actual.Trabajador.Codigo;
                    this.TxtNombre.Text = this.Actual.Nombre;
                    this.TxtClave.Text = this.Actual.Clave;
                    this.TxtConfirmarClave.Text = this.Actual.Clave;
                  
                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar al usuario solicitado");
                }
            }
            catch (Exception ex)
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
                this.ErrMensaje.SetError(this.TxtNombre, "Debe indicar el nombre del usuario");
                e.Cancel = true;
            }
        }

        private void TxtClave_Validating(object sender, CancelEventArgs e)
        {
            this.TxtClave.Text = this.TxtClave.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtClave.Text) == false)
            {
                this.ErrMensaje.SetError(this.TxtClave, "");
            }
            else
            {
                this.ErrMensaje.SetError(this.TxtClave, "Debe indicar una clave");
                e.Cancel = true;
            }
        }

        private void TxtConfirmarClave_Validating(object sender, CancelEventArgs e)
        {
            this.TxtConfirmarClave.Text = this.TxtConfirmarClave.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtConfirmarClave.Text) == false)
            {
                if (TxtClave.Text.Equals(TxtConfirmarClave.Text))
                {
                    this.ErrMensaje.SetError(this.TxtConfirmarClave, "");
                } else
                {
                    this.ErrMensaje.SetError(this.TxtConfirmarClave, "Las claves deben ser iguales");
                    e.Cancel = true;
                }
                
            }
            else
            {
                this.ErrMensaje.SetError(this.TxtConfirmarClave, "Debe volver a escribir la clave");
                e.Cancel = true;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
