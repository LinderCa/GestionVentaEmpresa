namespace Gestion
{
    partial class FrmUsuario
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.CdNombreTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdVigencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GbTrabajador = new System.Windows.Forms.GroupBox();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.TxtConfirmarClave = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.LblConfirmarClave = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblClave = new System.Windows.Forms.Label();
            this.CboTrabajador = new System.Windows.Forms.ComboBox();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.ErrMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbTrabajador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(898, 447);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "C&errar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
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
            this.GbListado.Location = new System.Drawing.Point(454, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(519, 429);
            this.GbListado.TabIndex = 4;
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
            this.CdNombreTrabajador,
            this.CdNombreUsuario,
            this.CdVigencia});
            this.DgvListado.Location = new System.Drawing.Point(18, 61);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(491, 319);
            this.DgvListado.TabIndex = 3;
            // 
            // CdNombreTrabajador
            // 
            this.CdNombreTrabajador.DataPropertyName = "NombreTrabajador";
            this.CdNombreTrabajador.HeaderText = "Nombre trabajador";
            this.CdNombreTrabajador.Name = "CdNombreTrabajador";
            this.CdNombreTrabajador.ReadOnly = true;
            // 
            // CdNombreUsuario
            // 
            this.CdNombreUsuario.DataPropertyName = "Nombre";
            this.CdNombreUsuario.HeaderText = "Nombre usuario";
            this.CdNombreUsuario.Name = "CdNombreUsuario";
            this.CdNombreUsuario.ReadOnly = true;
            // 
            // CdVigencia
            // 
            this.CdVigencia.DataPropertyName = "Vigente";
            this.CdVigencia.HeaderText = "Vigencia";
            this.CdVigencia.Name = "CdVigencia";
            this.CdVigencia.ReadOnly = true;
            this.CdVigencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CdVigencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Location = new System.Drawing.Point(438, 23);
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
            this.BtnModificar.Location = new System.Drawing.Point(99, 390);
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
            this.BtnNuevo.Location = new System.Drawing.Point(18, 390);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GbTrabajador
            // 
            this.GbTrabajador.Controls.Add(this.ChkVigente);
            this.GbTrabajador.Controls.Add(this.TxtConfirmarClave);
            this.GbTrabajador.Controls.Add(this.TxtClave);
            this.GbTrabajador.Controls.Add(this.LblConfirmarClave);
            this.GbTrabajador.Controls.Add(this.TxtNombre);
            this.GbTrabajador.Controls.Add(this.LblClave);
            this.GbTrabajador.Controls.Add(this.CboTrabajador);
            this.GbTrabajador.Controls.Add(this.LblNombres);
            this.GbTrabajador.Controls.Add(this.LblEmpresa);
            this.GbTrabajador.Controls.Add(this.BtnCancelar);
            this.GbTrabajador.Controls.Add(this.BtnAceptar);
            this.GbTrabajador.Enabled = false;
            this.GbTrabajador.Location = new System.Drawing.Point(12, 12);
            this.GbTrabajador.Name = "GbTrabajador";
            this.GbTrabajador.Size = new System.Drawing.Size(436, 233);
            this.GbTrabajador.TabIndex = 3;
            this.GbTrabajador.TabStop = false;
            this.GbTrabajador.Text = "Usuario";
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(100, 164);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 18;
            this.ChkVigente.Text = "&Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // TxtConfirmarClave
            // 
            this.TxtConfirmarClave.Location = new System.Drawing.Point(100, 126);
            this.TxtConfirmarClave.Name = "TxtConfirmarClave";
            this.TxtConfirmarClave.PasswordChar = '*';
            this.TxtConfirmarClave.Size = new System.Drawing.Size(226, 20);
            this.TxtConfirmarClave.TabIndex = 7;
            this.TxtConfirmarClave.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfirmarClave_Validating);
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(100, 92);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(226, 20);
            this.TxtClave.TabIndex = 5;
            this.TxtClave.Validating += new System.ComponentModel.CancelEventHandler(this.TxtClave_Validating);
            // 
            // LblConfirmarClave
            // 
            this.LblConfirmarClave.AutoSize = true;
            this.LblConfirmarClave.Location = new System.Drawing.Point(14, 129);
            this.LblConfirmarClave.Name = "LblConfirmarClave";
            this.LblConfirmarClave.Size = new System.Drawing.Size(80, 13);
            this.LblConfirmarClave.TabIndex = 6;
            this.LblConfirmarClave.Text = "Confirmar clave";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(100, 61);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(226, 20);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Location = new System.Drawing.Point(14, 95);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(34, 13);
            this.LblClave.TabIndex = 4;
            this.LblClave.Text = "Clave";
            // 
            // CboTrabajador
            // 
            this.CboTrabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTrabajador.FormattingEnabled = true;
            this.CboTrabajador.Location = new System.Drawing.Point(100, 29);
            this.CboTrabajador.Name = "CboTrabajador";
            this.CboTrabajador.Size = new System.Drawing.Size(314, 21);
            this.CboTrabajador.TabIndex = 1;
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Location = new System.Drawing.Point(14, 64);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(44, 13);
            this.LblNombres.TabIndex = 2;
            this.LblNombres.Text = "Nombre";
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Location = new System.Drawing.Point(14, 33);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(58, 13);
            this.LblEmpresa.TabIndex = 0;
            this.LblEmpresa.Text = "Trabajador";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(339, 192);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(258, 192);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 16;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // ErrMensaje
            // 
            this.ErrMensaje.ContainerControl = this;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(985, 482);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbTrabajador);
            this.Name = "FrmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.GbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbTrabajador.ResumeLayout(false);
            this.GbTrabajador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox GbTrabajador;
        private System.Windows.Forms.TextBox TxtConfirmarClave;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label LblConfirmarClave;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.ComboBox CboTrabajador;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.ErrorProvider ErrMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombreTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombreUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CdVigencia;
    }
}