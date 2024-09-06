
namespace Gestion
{
    partial class FrmProducto
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
            this.ErrMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.LblPrecioMinimo = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtDescripción = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.CdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdPrecioMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.LblTrabajador = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.GbEntidad = new System.Windows.Forms.GroupBox();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.NudPrecioMinimo = new System.Windows.Forms.NumericUpDown();
            this.NudPrecio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbListado.SuspendLayout();
            this.GbEntidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrecioMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrMensaje
            // 
            this.ErrMensaje.ContainerControl = this;
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(90, 185);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 10;
            this.ChkVigente.Text = "&Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // LblPrecioMinimo
            // 
            this.LblPrecioMinimo.AutoSize = true;
            this.LblPrecioMinimo.Location = new System.Drawing.Point(10, 151);
            this.LblPrecioMinimo.Name = "LblPrecioMinimo";
            this.LblPrecioMinimo.Size = new System.Drawing.Size(74, 13);
            this.LblPrecioMinimo.TabIndex = 8;
            this.LblPrecioMinimo.Text = "Precio mínimo";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(10, 118);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(37, 13);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "&Precio";
            // 
            // TxtDescripción
            // 
            this.TxtDescripción.Location = new System.Drawing.Point(90, 83);
            this.TxtDescripción.Name = "TxtDescripción";
            this.TxtDescripción.Size = new System.Drawing.Size(294, 20);
            this.TxtDescripción.TabIndex = 5;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(10, 87);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LblDescripcion.TabIndex = 4;
            this.LblDescripcion.Text = "&Descripción";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(90, 51);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(294, 20);
            this.TxtNombre.TabIndex = 3;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(10, 54);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "&Nombre";
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Location = new System.Drawing.Point(113, 368);
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
            this.BtnListar.Location = new System.Drawing.Point(524, 34);
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
            this.BtnNuevo.Location = new System.Drawing.Point(17, 368);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(10, 22);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(52, 13);
            this.LblCategoria.TabIndex = 0;
            this.LblCategoria.Text = "&Categoria";
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
            this.CdCategoria,
            this.CdNombre,
            this.CdPrecio,
            this.CdPrecioMinimo,
            this.CdVigente});
            this.DgvListado.Location = new System.Drawing.Point(17, 78);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(582, 273);
            this.DgvListado.TabIndex = 1;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            // 
            // CdCategoria
            // 
            this.CdCategoria.DataPropertyName = "NombreCategoria";
            this.CdCategoria.HeaderText = "Categoría";
            this.CdCategoria.Name = "CdCategoria";
            this.CdCategoria.ReadOnly = true;
            // 
            // CdNombre
            // 
            this.CdNombre.DataPropertyName = "Nombre";
            this.CdNombre.HeaderText = "Nombre";
            this.CdNombre.Name = "CdNombre";
            this.CdNombre.ReadOnly = true;
            // 
            // CdPrecio
            // 
            this.CdPrecio.DataPropertyName = "Precio";
            this.CdPrecio.HeaderText = "Precio";
            this.CdPrecio.Name = "CdPrecio";
            this.CdPrecio.ReadOnly = true;
            // 
            // CdPrecioMinimo
            // 
            this.CdPrecioMinimo.DataPropertyName = "PrecioMinimo";
            this.CdPrecioMinimo.HeaderText = "Precio mínimo";
            this.CdPrecioMinimo.Name = "CdPrecioMinimo";
            this.CdPrecioMinimo.ReadOnly = true;
            // 
            // CdVigente
            // 
            this.CdVigente.DataPropertyName = "Vigente";
            this.CdVigente.HeaderText = "Vigente";
            this.CdVigente.Name = "CdVigente";
            this.CdVigente.ReadOnly = true;
            // 
            // GbListado
            // 
            this.GbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListado.Controls.Add(this.TxtProducto);
            this.GbListado.Controls.Add(this.LblTrabajador);
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Location = new System.Drawing.Point(425, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(614, 409);
            this.GbListado.TabIndex = 4;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProducto.Location = new System.Drawing.Point(89, 37);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(366, 20);
            this.TxtProducto.TabIndex = 5;
            // 
            // LblTrabajador
            // 
            this.LblTrabajador.AutoSize = true;
            this.LblTrabajador.Location = new System.Drawing.Point(17, 44);
            this.LblTrabajador.Name = "LblTrabajador";
            this.LblTrabajador.Size = new System.Drawing.Size(50, 13);
            this.LblTrabajador.TabIndex = 4;
            this.LblTrabajador.Text = "Producto";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(309, 206);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(213, 206);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(964, 427);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "Ce&rrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // GbEntidad
            // 
            this.GbEntidad.Controls.Add(this.CboCategoria);
            this.GbEntidad.Controls.Add(this.ChkVigente);
            this.GbEntidad.Controls.Add(this.NudPrecioMinimo);
            this.GbEntidad.Controls.Add(this.NudPrecio);
            this.GbEntidad.Controls.Add(this.LblPrecioMinimo);
            this.GbEntidad.Controls.Add(this.LblPrecio);
            this.GbEntidad.Controls.Add(this.TxtDescripción);
            this.GbEntidad.Controls.Add(this.LblDescripcion);
            this.GbEntidad.Controls.Add(this.TxtNombre);
            this.GbEntidad.Controls.Add(this.LblNombre);
            this.GbEntidad.Controls.Add(this.LblCategoria);
            this.GbEntidad.Controls.Add(this.BtnCancelar);
            this.GbEntidad.Controls.Add(this.BtnAceptar);
            this.GbEntidad.Enabled = false;
            this.GbEntidad.Location = new System.Drawing.Point(12, 12);
            this.GbEntidad.Name = "GbEntidad";
            this.GbEntidad.Size = new System.Drawing.Size(407, 252);
            this.GbEntidad.TabIndex = 3;
            this.GbEntidad.TabStop = false;
            this.GbEntidad.Text = "Producto";
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(90, 19);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(294, 21);
            this.CboCategoria.TabIndex = 6;
            this.CboCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.CboCategoria_Validating);
            // 
            // NudPrecioMinimo
            // 
            this.NudPrecioMinimo.DecimalPlaces = 2;
            this.NudPrecioMinimo.Location = new System.Drawing.Point(90, 149);
            this.NudPrecioMinimo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudPrecioMinimo.Name = "NudPrecioMinimo";
            this.NudPrecioMinimo.Size = new System.Drawing.Size(294, 20);
            this.NudPrecioMinimo.TabIndex = 6;
            // 
            // NudPrecio
            // 
            this.NudPrecio.DecimalPlaces = 2;
            this.NudPrecio.Location = new System.Drawing.Point(90, 116);
            this.NudPrecio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudPrecio.Name = "NudPrecio";
            this.NudPrecio.Size = new System.Drawing.Size(294, 20);
            this.NudPrecio.TabIndex = 6;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1051, 462);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.GbEntidad);
            this.Name = "FrmProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            this.GbEntidad.ResumeLayout(false);
            this.GbEntidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrecioMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrMensaje;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.GroupBox GbEntidad;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.Label LblPrecioMinimo;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtDescripción;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.NumericUpDown NudPrecio;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.NumericUpDown NudPrecioMinimo;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label LblTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdPrecioMinimo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CdVigente;
    }
}