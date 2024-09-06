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
using System.Text.RegularExpressions;

namespace Gestion
{
  public partial class FrmEmpresa : Form
  {
    private Empresa Actual;

    public FrmEmpresa()
    {
      InitializeComponent();
    }

    private void BtnNuevo_Click(object sender, EventArgs e)
    {
      this.Actual = null;
      this.ActivarControles(true);
      this.LimpiarControles();
    }

    private void LimpiarControles()
    {
      this.TxtRazonSocial.Text = "";
      this.TxtRUC.Text = "";
      this.TxtDireccion.Text = "";
      this.TxtTelefono.Text = "";
      this.TxtCorreo.Text = "";
      this.ChkVigente.Checked = true;
    }

    private void ActivarControles(bool estado)
    {
      this.GbEntidad.Enabled = estado;
      this.GbListado.Enabled = !estado;

      if (estado == true)
      {
        this.TxtRazonSocial.Focus();
      }
      else
      {
        this.BtnListar.Focus();
      }
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
      this.ActivarControles(false);
    }

    private void BtnListar_Click(object sender, EventArgs e)
    {
      RNEmpresa rn = new RNEmpresa();
      List<Empresa> empresas;

      try
      {
        empresas = rn.Listar();

        this.DgvListado.DataSource = null;
        if (Program.Empresas.Count > 0)
        {
          this.DgvListado.AutoGenerateColumns = false;
          this.DgvListado.DataSource = empresas;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("No se pudo listar las empresas", this.Text);
      }
    }

    private void BtnAceptar_Click(object sender, EventArgs e)
    {
      RNEmpresa rn;
      Empresa nuevo;

      if (this.ValidateChildren() == true)
      {
        nuevo = this.CrearEntidad();
        rn = new RNEmpresa();
        try
        {
          if (this.Actual == null)
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

    private Empresa CrearEntidad()
    {
      Empresa nuevo = new Empresa()
      {
        RazonSocial = this.TxtRazonSocial.Text,
        RUC = this.TxtRUC.Text,
        Dirección = this.TxtDireccion.Text,
        Telefono = this.TxtTelefono.Text,
        Correo = this.TxtCorreo.Text,
        Vigente = this.ChkVigente.Checked
      };

      if (this.Actual != null)
      {
        nuevo.Codigo = this.Actual.Codigo;
      }

      return nuevo;
    }

    private void BtnModificar_Click(object sender, EventArgs e)
    {

      if (this.DgvListado.CurrentRow != null)
      {
        this.Actual = (Empresa)this.DgvListado.CurrentRow.DataBoundItem;
        this.PresentarDatos();
      }
      else
      {
        MessageBox.Show("Debe seleccionarse una empresa", this.Text);
      }
    }

    private void PresentarDatos()
    {
      RNEmpresa rn = new RNEmpresa();

      try
      {
        this.Actual = rn.Leer(this.Actual.Codigo);

        if (this.Actual != null)
        {
          this.TxtRazonSocial.Text = this.Actual.RazonSocial;
          this.TxtRUC.Text = this.Actual.RUC;
          this.TxtDireccion.Text = this.Actual.Dirección;
          this.TxtTelefono.Text = this.Actual.Telefono;
          this.TxtCorreo.Text = this.Actual.Correo;
          this.ChkVigente.Checked = this.Actual.Vigente;

          this.ActivarControles(true);
        }
        else
        {
          MessageBox.Show("No se encontraron los datos solicitados", this.Text);
        }
      }catch(Exception ex)
      {
        MessageBox.Show("No se pudo obtener los datos solicitados", this.Text);
      }
    }

    private void TxtRazonSocial_Validating(object sender, CancelEventArgs e)
    {
      this.TxtRazonSocial.Text = this.TxtRazonSocial.Text.Trim();
      if (string.IsNullOrEmpty(this.TxtRazonSocial.Text) == false)
      {
        this.ErrMensaje.SetError(this.TxtRazonSocial, "");
      }
      else
      {
        this.ErrMensaje.SetError(this.TxtRazonSocial, "Debe indicar la razón social de la empresa");
        e.Cancel = true;
      }
    }

    private void FrmEmpresa_FormClosing(object sender, FormClosingEventArgs e)
    {
      DialogResult respuesta;

      if (this.GbEntidad.Enabled == true)
      {
        respuesta = MessageBox.Show("Haz iniciado una operación de registro/actualización\n" +
                  "¿Está seguro que desea salir?", this.Text, MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (respuesta == DialogResult.No)
        {
          e.Cancel = true;
        }
      }
    }

    private void BtnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void TxtRazonSocial_Enter(object sender, EventArgs e)
    {
      ((TextBox)sender).BackColor = Color.Yellow;
    }

    private void TxtRazonSocial_Leave(object sender, EventArgs e)
    {
      ((TextBox)sender).BackColor = Color.White;
    }

        private bool DigitarNumeros(KeyPressEventArgs e)
        {
            return !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = this.DigitarNumeros(e);
        }

        private void TxtCorreo_Validating(object sender, CancelEventArgs e)
        {
            this.TxtCorreo.Text = this.TxtCorreo.Text.Trim();
            string aux_Correo = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(TxtCorreo.Text, aux_Correo) &&
                Regex.Replace(TxtCorreo.Text, aux_Correo, String.Empty).Length == 0)
            {
                this.ErrMensaje.SetError(this.TxtCorreo, "");
            }
            else
            {
                this.ErrMensaje.SetError(this.TxtCorreo, "Debe indicar un correo electrónico válido");
                e.Cancel = true;
            }
        }

        private void TxtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = this.DigitarNumeros(e);
        }

        private void TxtTelefono_Validating(object sender, CancelEventArgs e)
        {
            this.TxtTelefono.Text = this.TxtTelefono.Text.Trim();
            string auxTelefono = "9\\d{8,8}";

            if (Regex.IsMatch(TxtTelefono.Text, auxTelefono) &&
                Regex.Replace(TxtTelefono.Text, auxTelefono, String.Empty).Length == 0)
            {
                this.ErrMensaje.SetError(this.TxtTelefono, "");
            }
            else
            {
                this.ErrMensaje.SetError(this.TxtTelefono, "Debe indicar un número telefónico válido");
                e.Cancel = true;
            }
        }
    }
}
