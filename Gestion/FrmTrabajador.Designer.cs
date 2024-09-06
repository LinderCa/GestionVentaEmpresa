
namespace Gestion
{
  partial class FrmTrabajador
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.GbTrabajador = new System.Windows.Forms.GroupBox();
            this.NudSueldo = new System.Windows.Forms.NumericUpDown();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.TxtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.LblApMaterno = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.LblApPaterno = new System.Windows.Forms.Label();
            this.CboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.CboGenero = new System.Windows.Forms.ComboBox();
            this.CboEmpresa = new System.Windows.Forms.ComboBox();
            this.LblSueldo = new System.Windows.Forms.Label();
            this.LblEstadoCivil = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.CdTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtTrabajador = new System.Windows.Forms.TextBox();
            this.LblTrabajador = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.ErrMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbTrabajador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSueldo)).BeginInit();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // GbTrabajador
            // 
            this.GbTrabajador.Controls.Add(this.NudSueldo);
            this.GbTrabajador.Controls.Add(this.DtpFechaNacimiento);
            this.GbTrabajador.Controls.Add(this.TxtApellidoMaterno);
            this.GbTrabajador.Controls.Add(this.TxtApellidoPaterno);
            this.GbTrabajador.Controls.Add(this.LblApMaterno);
            this.GbTrabajador.Controls.Add(this.TxtNombres);
            this.GbTrabajador.Controls.Add(this.LblApPaterno);
            this.GbTrabajador.Controls.Add(this.CboEstadoCivil);
            this.GbTrabajador.Controls.Add(this.CboGenero);
            this.GbTrabajador.Controls.Add(this.CboEmpresa);
            this.GbTrabajador.Controls.Add(this.LblSueldo);
            this.GbTrabajador.Controls.Add(this.LblEstadoCivil);
            this.GbTrabajador.Controls.Add(this.LblFechaNacimiento);
            this.GbTrabajador.Controls.Add(this.LblGenero);
            this.GbTrabajador.Controls.Add(this.LblNombres);
            this.GbTrabajador.Controls.Add(this.LblEmpresa);
            this.GbTrabajador.Controls.Add(this.BtnCancelar);
            this.GbTrabajador.Controls.Add(this.BtnAceptar);
            this.GbTrabajador.Enabled = false;
            this.GbTrabajador.Location = new System.Drawing.Point(12, 12);
            this.GbTrabajador.Name = "GbTrabajador";
            this.GbTrabajador.Size = new System.Drawing.Size(436, 348);
            this.GbTrabajador.TabIndex = 0;
            this.GbTrabajador.TabStop = false;
            this.GbTrabajador.Text = "Trabajador";
            // 
            // NudSueldo
            // 
            this.NudSueldo.Location = new System.Drawing.Point(91, 249);
            this.NudSueldo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudSueldo.Name = "NudSueldo";
            this.NudSueldo.Size = new System.Drawing.Size(141, 20);
            this.NudSueldo.TabIndex = 15;
            this.NudSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(91, 190);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(141, 20);
            this.DtpFechaNacimiento.TabIndex = 11;
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(91, 126);
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(226, 20);
            this.TxtApellidoMaterno.TabIndex = 7;
            this.TxtApellidoMaterno.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellidoMaterno_Validating);
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(91, 92);
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(226, 20);
            this.TxtApellidoPaterno.TabIndex = 5;
            this.TxtApellidoPaterno.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellidoPaterno_Validating);
            // 
            // LblApMaterno
            // 
            this.LblApMaterno.AutoSize = true;
            this.LblApMaterno.Location = new System.Drawing.Point(23, 129);
            this.LblApMaterno.Name = "LblApMaterno";
            this.LblApMaterno.Size = new System.Drawing.Size(65, 13);
            this.LblApMaterno.TabIndex = 6;
            this.LblApMaterno.Text = "Ap. Materno";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(91, 61);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(226, 20);
            this.TxtNombres.TabIndex = 3;
            this.TxtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombres_Validating);
            // 
            // LblApPaterno
            // 
            this.LblApPaterno.AutoSize = true;
            this.LblApPaterno.Location = new System.Drawing.Point(23, 95);
            this.LblApPaterno.Name = "LblApPaterno";
            this.LblApPaterno.Size = new System.Drawing.Size(63, 13);
            this.LblApPaterno.TabIndex = 4;
            this.LblApPaterno.Text = "Ap. Paterno";
            // 
            // CboEstadoCivil
            // 
            this.CboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstadoCivil.FormattingEnabled = true;
            this.CboEstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Divorciado",
            "Soltero",
            "Viudo"});
            this.CboEstadoCivil.Location = new System.Drawing.Point(91, 222);
            this.CboEstadoCivil.Name = "CboEstadoCivil";
            this.CboEstadoCivil.Size = new System.Drawing.Size(314, 21);
            this.CboEstadoCivil.TabIndex = 13;
            // 
            // CboGenero
            // 
            this.CboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboGenero.FormattingEnabled = true;
            this.CboGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.CboGenero.Location = new System.Drawing.Point(91, 157);
            this.CboGenero.Name = "CboGenero";
            this.CboGenero.Size = new System.Drawing.Size(314, 21);
            this.CboGenero.TabIndex = 9;
            // 
            // CboEmpresa
            // 
            this.CboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEmpresa.FormattingEnabled = true;
            this.CboEmpresa.Location = new System.Drawing.Point(91, 29);
            this.CboEmpresa.Name = "CboEmpresa";
            this.CboEmpresa.Size = new System.Drawing.Size(314, 21);
            this.CboEmpresa.TabIndex = 1;
            // 
            // LblSueldo
            // 
            this.LblSueldo.AutoSize = true;
            this.LblSueldo.Location = new System.Drawing.Point(23, 252);
            this.LblSueldo.Name = "LblSueldo";
            this.LblSueldo.Size = new System.Drawing.Size(40, 13);
            this.LblSueldo.TabIndex = 14;
            this.LblSueldo.Text = "Sueldo";
            // 
            // LblEstadoCivil
            // 
            this.LblEstadoCivil.AutoSize = true;
            this.LblEstadoCivil.Location = new System.Drawing.Point(23, 226);
            this.LblEstadoCivil.Name = "LblEstadoCivil";
            this.LblEstadoCivil.Size = new System.Drawing.Size(61, 13);
            this.LblEstadoCivil.TabIndex = 12;
            this.LblEstadoCivil.Text = "Estado civil";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(23, 192);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(63, 13);
            this.LblFechaNacimiento.TabIndex = 10;
            this.LblFechaNacimiento.Text = "Fecha Nac.";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(23, 161);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(42, 13);
            this.LblGenero.TabIndex = 8;
            this.LblGenero.Text = "Género";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(23, 64);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(49, 13);
            this.LblNombres.TabIndex = 2;
            this.LblNombres.Text = "Nombres";
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Location = new System.Drawing.Point(23, 33);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.LblEmpresa.TabIndex = 0;
            this.LblEmpresa.Text = "Empresa";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(330, 289);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(249, 289);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 16;
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
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Controls.Add(this.TxtTrabajador);
            this.GbListado.Controls.Add(this.LblTrabajador);
            this.GbListado.Location = new System.Drawing.Point(454, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(511, 483);
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
            this.CdTrabajador,
            this.CdSueldo,
            this.CdEmpresa});
            this.DgvListado.Location = new System.Drawing.Point(18, 61);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(483, 373);
            this.DgvListado.TabIndex = 3;
            // 
            // CdTrabajador
            // 
            this.CdTrabajador.DataPropertyName = "NombreCompleto";
            this.CdTrabajador.HeaderText = "Trabajador";
            this.CdTrabajador.Name = "CdTrabajador";
            this.CdTrabajador.ReadOnly = true;
            // 
            // CdSueldo
            // 
            this.CdSueldo.DataPropertyName = "Sueldo";
            this.CdSueldo.HeaderText = "Sueldo";
            this.CdSueldo.Name = "CdSueldo";
            this.CdSueldo.ReadOnly = true;
            // 
            // CdEmpresa
            // 
            this.CdEmpresa.DataPropertyName = "NombreEmpresa";
            this.CdEmpresa.HeaderText = "Empresa";
            this.CdEmpresa.Name = "CdEmpresa";
            this.CdEmpresa.ReadOnly = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Location = new System.Drawing.Point(430, 23);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 2;
            this.BtnListar.Text = "&Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Location = new System.Drawing.Point(99, 444);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.Text = "&Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.Location = new System.Drawing.Point(18, 444);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TxtTrabajador
            // 
            this.TxtTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTrabajador.Location = new System.Drawing.Point(87, 26);
            this.TxtTrabajador.Name = "TxtTrabajador";
            this.TxtTrabajador.Size = new System.Drawing.Size(328, 20);
            this.TxtTrabajador.TabIndex = 1;
            // 
            // LblTrabajador
            // 
            this.LblTrabajador.AutoSize = true;
            this.LblTrabajador.Location = new System.Drawing.Point(15, 33);
            this.LblTrabajador.Name = "LblTrabajador";
            this.LblTrabajador.Size = new System.Drawing.Size(58, 13);
            this.LblTrabajador.TabIndex = 0;
            this.LblTrabajador.Text = "Trabajador";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(890, 501);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "C&errar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // ErrMensaje
            // 
            this.ErrMensaje.ContainerControl = this;
            // 
            // FrmTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 536);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbTrabajador);
            this.Name = "FrmTrabajador";
            this.Text = "Trabajador";
            this.Load += new System.EventHandler(this.FrmTrabajador_Load);
            this.GbTrabajador.ResumeLayout(false);
            this.GbTrabajador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSueldo)).EndInit();
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox GbTrabajador;
    private System.Windows.Forms.Button BtnCancelar;
    private System.Windows.Forms.Button BtnAceptar;
    private System.Windows.Forms.GroupBox GbListado;
    private System.Windows.Forms.Button BtnListar;
    private System.Windows.Forms.Button BtnModificar;
    private System.Windows.Forms.Button BtnNuevo;
    private System.Windows.Forms.Button BtnCerrar;
    private System.Windows.Forms.TextBox TxtApellidoMaterno;
    private System.Windows.Forms.TextBox TxtApellidoPaterno;
    private System.Windows.Forms.Label LblApMaterno;
    private System.Windows.Forms.TextBox TxtNombres;
    private System.Windows.Forms.Label LblApPaterno;
    private System.Windows.Forms.ComboBox CboGenero;
    private System.Windows.Forms.ComboBox CboEmpresa;
    private System.Windows.Forms.Label LblGenero;
    private System.Windows.Forms.Label LblNombres;
    private System.Windows.Forms.Label LblEmpresa;
    private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
    private System.Windows.Forms.Label LblFechaNacimiento;
    private System.Windows.Forms.ComboBox CboEstadoCivil;
    private System.Windows.Forms.Label LblEstadoCivil;
    private System.Windows.Forms.NumericUpDown NudSueldo;
    private System.Windows.Forms.Label LblSueldo;
    private System.Windows.Forms.DataGridView DgvListado;
    private System.Windows.Forms.TextBox TxtTrabajador;
    private System.Windows.Forms.Label LblTrabajador;
    private System.Windows.Forms.DataGridViewTextBoxColumn CdTrabajador;
    private System.Windows.Forms.DataGridViewTextBoxColumn CdSueldo;
    private System.Windows.Forms.DataGridViewTextBoxColumn CdEmpresa;
        private System.Windows.Forms.ErrorProvider ErrMensaje;
    }
}