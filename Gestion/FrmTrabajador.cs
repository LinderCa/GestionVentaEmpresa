using ReglasNegocio;
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
    public partial class FrmTrabajador : Form
    {
        private Trabajador Actual;

        public FrmTrabajador()
        {
            InitializeComponent();
        }

        private void FrmTrabajador_Load(object sender, EventArgs e)
        {
            this.ListarEmpresas();
        }

        private void ListarEmpresas()
        {
            RNEmpresa rn = new RNEmpresa();
            List<Empresa> empresas;

            try
            {
                empresas = rn.ListarVigentes();
                this.CboEmpresa.DataSource = null;
                if (empresas != null && empresas.Count > 0)
                {
                    this.CboEmpresa.ValueMember = "Codigo";
                    this.CboEmpresa.DisplayMember = "RazonSocial";
                    this.CboEmpresa.DataSource = empresas;
                }
                else
                {
                    MessageBox.Show("No se pudo listar las empresas", this.Text);
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
            this.CboEmpresa.SelectedIndex = -1;
            this.TxtNombres.Text = "";
            this.TxtApellidoPaterno.Text = "";
            this.TxtApellidoMaterno.Text = "";
            this.CboGenero.SelectedIndex = -1;
            this.DtpFechaNacimiento.Value = DateTime.Now.AddYears(-20);
            this.CboEstadoCivil.SelectedIndex = -1;
            this.NudSueldo.Value = this.NudSueldo.Minimum;
        }

        private void ActivarControles(bool estado)
        {
            this.GbTrabajador.Enabled = estado;
            this.GbListado.Enabled = !estado;

            if (estado == true)
            {
                this.CboEmpresa.Focus();
            }
            else
            {
                this.TxtTrabajador.Focus();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.ActivarControles(false);
            this.LimpiarControles();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            RNTrabajador rn;
            Trabajador trab;

            if (this.ValidateChildren() == true)
            {
                trab = this.CrearInstancia();
                rn = new RNTrabajador();
                try
                {
                    if (this.Actual == null)
                    {
                        rn.Registrar(trab);
                    }
                    else
                    {
                        rn.Actualizar(trab);
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

        private Trabajador CrearInstancia()
        {
            Trabajador trab = new Trabajador()
            {
                Empresa = (Empresa)this.CboEmpresa.SelectedItem,
                Nombres = this.TxtNombres.Text,
                ApellidoPaterno = this.TxtApellidoPaterno.Text,
                ApellidoMaterno = this.TxtApellidoMaterno.Text,
                Genero = this.CboGenero.Text.Substring(0, 1),
                FechaNacimiento = this.DtpFechaNacimiento.Value,
                EstadoCivil = this.CboEstadoCivil.Text.Substring(0, 1),
                Sueldo = (double)this.NudSueldo.Value
            };

            if (this.Actual != null)
            {
                trab.Codigo = this.Actual.Codigo;
            }

            return trab;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNTrabajador rn = new RNTrabajador();
            List<Trabajador> seleccionados;

            try
            {
                seleccionados = rn.Listar(this.TxtTrabajador.Text);
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
                this.Actual = (Trabajador)this.DgvListado.CurrentRow.DataBoundItem;
                this.PresentarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un trabajador", this.Text);
            }
        }

        private void PresentarDatos()
        {
            RNTrabajador rn = new RNTrabajador();

            try
            {
                this.Actual = rn.Leer(this.Actual.Codigo);
                if (this.Actual != null)
                {
                    this.CboEmpresa.SelectedValue = this.Actual.Empresa.Codigo;
                    this.TxtNombres.Text = this.Actual.Nombres;
                    this.TxtApellidoPaterno.Text = this.Actual.ApellidoPaterno;
                    this.TxtApellidoMaterno.Text = this.Actual.ApellidoMaterno;
                    this.CboGenero.SelectedIndex = "FM".IndexOf(this.Actual.Genero);
                    this.DtpFechaNacimiento.Value = this.Actual.FechaNacimiento;
                    this.CboEstadoCivil.SelectedIndex = "CDSV".IndexOf(this.Actual.EstadoCivil);
                    this.NudSueldo.Value = (decimal)this.Actual.Sueldo;

                    this.ActivarControles(true);
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el trabajador solicitado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operación");
            }
        }

        private void TxtNombres_Validating(object sender, CancelEventArgs e)
        {
            this.TxtNombres.Text = this.TxtNombres.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtNombres.Text) == false)
            {
                this.ErrMensaje.SetError(this.TxtNombres, "");
            }
            else
            {
                this.ErrMensaje.SetError(this.TxtNombres, "Debe indicar el nombre del trabajador");
                e.Cancel = true;
            }
        }

        private void TxtApellidoPaterno_Validating(object sender, CancelEventArgs e)
        {
            this.TxtApellidoPaterno.Text = this.TxtApellidoPaterno.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtApellidoPaterno.Text) == false)
            {
                this.ErrMensaje.SetError(this.TxtApellidoPaterno, "");
            }
            else
            {
                this.ErrMensaje.SetError(this.TxtApellidoPaterno, "Debe indicar el apellido paterno del trabajador");
                e.Cancel = true;
            }
        }

        private void TxtApellidoMaterno_Validating(object sender, CancelEventArgs e)
        {
            this.TxtApellidoMaterno.Text = this.TxtApellidoMaterno.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtApellidoMaterno.Text) == false)
            {
                this.ErrMensaje.SetError(this.TxtApellidoMaterno, "");
            }
            else
            {
                this.ErrMensaje.SetError(this.TxtApellidoMaterno, "Debe indicar el apellido materno del trabajador");
                e.Cancel = true;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
