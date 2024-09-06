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
using static System.Collections.Specialized.BitVector32;
using ReglasNegocio;

namespace Gestion
{
    public partial class FrmIniciarSesion : Form
    {
        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = null;
            if (ValidateChildren() == true)
            {
                try
                {
                    RNUsuario rn = new RNUsuario();
                    usuario = rn.Login(TxtNombreDeUsuario.Text, TxtClave.Text);
                    if (usuario != null)
                    {
                        Sesion.Usuario = usuario;
                        IniciarPrincipal();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Clave incorrectas", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void IniciarPrincipal()
        {
            try
            {
                FrmPrincipal frm = new FrmPrincipal();
                this.Hide();
                frm.FormClosed += (s, args) =>
                {
                    if (Sesion.CerrarSesion)
                    {
                        LimpiarControles();
                        this.Show();
                    }
                    else
                    {
                        this.Close();
                    }
                };
                frm.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtClave_Validating(object sender, CancelEventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
            if (string.IsNullOrEmpty(((TextBox)sender).Text) == false)
            {
                ErrNotificador.SetError((TextBox)sender, "");
            }
            else
            {
                ErrNotificador.SetError((TextBox)sender, "Llene este campo");
                e.Cancel = true;
            }
        }

        private void LimpiarControles()
        {
            TxtClave.Text = "";
            TxtNombreDeUsuario.Text = "";
        }
    }
}
