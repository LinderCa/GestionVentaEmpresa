
namespace Gestion
{
  partial class FrmEmpresa
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.GbEntidad = new System.Windows.Forms.GroupBox();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.LblRUC = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.CdRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.ErrMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbEntidad.SuspendLayout();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // GbEntidad
            // 
            this.GbEntidad.Controls.Add(this.ChkVigente);
            this.GbEntidad.Controls.Add(this.TxtCorreo);
            this.GbEntidad.Controls.Add(this.LblCorreo);
            this.GbEntidad.Controls.Add(this.TxtTelefono);
            this.GbEntidad.Controls.Add(this.LblTelefono);
            this.GbEntidad.Controls.Add(this.TxtDireccion);
            this.GbEntidad.Controls.Add(this.LblDireccion);
            this.GbEntidad.Controls.Add(this.TxtRUC);
            this.GbEntidad.Controls.Add(this.LblRUC);
            this.GbEntidad.Controls.Add(this.TxtRazonSocial);
            this.GbEntidad.Controls.Add(this.LblRazonSocial);
            this.GbEntidad.Controls.Add(this.BtnCancelar);
            this.GbEntidad.Controls.Add(this.BtnAceptar);
            this.GbEntidad.Enabled = false;
            this.GbEntidad.Location = new System.Drawing.Point(12, 12);
            this.GbEntidad.Name = "GbEntidad";
            this.GbEntidad.Size = new System.Drawing.Size(403, 289);
            this.GbEntidad.TabIndex = 0;
            this.GbEntidad.TabStop = false;
            this.GbEntidad.Text = "Empresa";
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(85, 212);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 10;
            this.ChkVigente.Text = "&Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(85, 171);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(300, 20);
            this.TxtCorreo.TabIndex = 9;
            this.TxtCorreo.Enter += new System.EventHandler(this.TxtRazonSocial_Enter);
            this.TxtCorreo.Leave += new System.EventHandler(this.TxtRazonSocial_Leave);
            this.TxtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCorreo_Validating);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(11, 178);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(38, 13);
            this.LblCorreo.TabIndex = 8;
            this.LblCorreo.Text = "C&orreo";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(85, 134);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(300, 20);
            this.TxtTelefono.TabIndex = 7;
            this.TxtTelefono.Enter += new System.EventHandler(this.TxtRazonSocial_Enter);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            this.TxtTelefono.Leave += new System.EventHandler(this.TxtRazonSocial_Leave);
            this.TxtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTelefono_Validating);
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(11, 137);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 6;
            this.LblTelefono.Text = "&Teléfono";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(85, 97);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(300, 20);
            this.TxtDireccion.TabIndex = 5;
            this.TxtDireccion.Enter += new System.EventHandler(this.TxtRazonSocial_Enter);
            this.TxtDireccion.Leave += new System.EventHandler(this.TxtRazonSocial_Leave);
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(11, 100);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 4;
            this.LblDireccion.Text = "&Dirección";
            // 
            // TxtRUC
            // 
            this.TxtRUC.Location = new System.Drawing.Point(85, 60);
            this.TxtRUC.MaxLength = 11;
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.Size = new System.Drawing.Size(300, 20);
            this.TxtRUC.TabIndex = 3;
            this.TxtRUC.Enter += new System.EventHandler(this.TxtRazonSocial_Enter);
            this.TxtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRUC_KeyPress);
            this.TxtRUC.Leave += new System.EventHandler(this.TxtRazonSocial_Leave);
            // 
            // LblRUC
            // 
            this.LblRUC.AutoSize = true;
            this.LblRUC.Location = new System.Drawing.Point(11, 64);
            this.LblRUC.Name = "LblRUC";
            this.LblRUC.Size = new System.Drawing.Size(30, 13);
            this.LblRUC.TabIndex = 2;
            this.LblRUC.Text = "R&UC";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(85, 19);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(300, 20);
            this.TxtRazonSocial.TabIndex = 1;
            this.TxtRazonSocial.Enter += new System.EventHandler(this.TxtRazonSocial_Enter);
            this.TxtRazonSocial.Leave += new System.EventHandler(this.TxtRazonSocial_Leave);
            this.TxtRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRazonSocial_Validating);
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Location = new System.Drawing.Point(10, 23);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.LblRazonSocial.TabIndex = 0;
            this.LblRazonSocial.Text = "&Razon social";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(310, 245);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(214, 245);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // GbListado
            // 
            this.GbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Location = new System.Drawing.Point(421, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(504, 420);
            this.GbListado.TabIndex = 1;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdRazonSocial,
            this.CdRUC,
            this.CdVigente});
            this.DgvListado.Location = new System.Drawing.Point(17, 78);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(472, 284);
            this.DgvListado.TabIndex = 1;
            // 
            // CdRazonSocial
            // 
            this.CdRazonSocial.DataPropertyName = "RazonSocial";
            this.CdRazonSocial.HeaderText = "Razón social";
            this.CdRazonSocial.Name = "CdRazonSocial";
            this.CdRazonSocial.ReadOnly = true;
            // 
            // CdRUC
            // 
            this.CdRUC.DataPropertyName = "RUC";
            this.CdRUC.HeaderText = "RUC";
            this.CdRUC.Name = "CdRUC";
            this.CdRUC.ReadOnly = true;
            // 
            // CdVigente
            // 
            this.CdVigente.DataPropertyName = "Vigente";
            this.CdVigente.HeaderText = "Vigente";
            this.CdVigente.Name = "CdVigente";
            this.CdVigente.ReadOnly = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Location = new System.Drawing.Point(113, 379);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "&Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Location = new System.Drawing.Point(414, 34);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 0;
            this.BtnListar.Text = "&Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.Location = new System.Drawing.Point(17, 379);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(850, 449);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "Ce&rrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // ErrMensaje
            // 
            this.ErrMensaje.ContainerControl = this;
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(937, 484);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbEntidad);
            this.MinimumSize = new System.Drawing.Size(902, 466);
            this.Name = "FrmEmpresa";
            this.Text = "Gestión de empresas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmpresa_FormClosing);
            this.GbEntidad.ResumeLayout(false);
            this.GbEntidad.PerformLayout();
            this.GbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox GbEntidad;
    private System.Windows.Forms.Button BtnCancelar;
    private System.Windows.Forms.Button BtnAceptar;
    private System.Windows.Forms.GroupBox GbListado;
    private System.Windows.Forms.Button BtnModificar;
    private System.Windows.Forms.Button BtnListar;
    private System.Windows.Forms.Button BtnNuevo;
    private System.Windows.Forms.Button BtnCerrar;
    private System.Windows.Forms.CheckBox ChkVigente;
    private System.Windows.Forms.TextBox TxtCorreo;
    private System.Windows.Forms.Label LblCorreo;
    private System.Windows.Forms.TextBox TxtTelefono;
    private System.Windows.Forms.Label LblTelefono;
    private System.Windows.Forms.TextBox TxtDireccion;
    private System.Windows.Forms.Label LblDireccion;
    private System.Windows.Forms.TextBox TxtRUC;
    private System.Windows.Forms.Label LblRUC;
    private System.Windows.Forms.TextBox TxtRazonSocial;
    private System.Windows.Forms.Label LblRazonSocial;
    private System.Windows.Forms.DataGridView DgvListado;
    private System.Windows.Forms.DataGridViewTextBoxColumn CdRazonSocial;
    private System.Windows.Forms.DataGridViewTextBoxColumn CdRUC;
    private System.Windows.Forms.DataGridViewCheckBoxColumn CdVigente;
    private System.Windows.Forms.ErrorProvider ErrMensaje;
  }
}

