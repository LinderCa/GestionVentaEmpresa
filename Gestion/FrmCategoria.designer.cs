
namespace Gestion
{
    partial class FrmCategoria
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
            this.CdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GbEntidad = new System.Windows.Forms.GroupBox();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblRUC = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.ErrMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbEntidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(867, 471);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "Ce&rrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
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
            this.GbListado.Location = new System.Drawing.Point(428, 12);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(514, 453);
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
            this.CdNombre,
            this.CdVigente});
            this.DgvListado.Location = new System.Drawing.Point(17, 48);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(482, 347);
            this.DgvListado.TabIndex = 1;
            // 
            // CdNombre
            // 
            this.CdNombre.DataPropertyName = "Nombre";
            this.CdNombre.HeaderText = "Nombre";
            this.CdNombre.Name = "CdNombre";
            this.CdNombre.ReadOnly = true;
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
            this.BtnModificar.Location = new System.Drawing.Point(113, 412);
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
            this.BtnListar.Location = new System.Drawing.Point(424, 19);
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
            this.BtnNuevo.Location = new System.Drawing.Point(17, 412);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "&Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GbEntidad
            // 
            this.GbEntidad.Controls.Add(this.ChkVigente);
            this.GbEntidad.Controls.Add(this.TxtDescripcion);
            this.GbEntidad.Controls.Add(this.LblRUC);
            this.GbEntidad.Controls.Add(this.TxtNombre);
            this.GbEntidad.Controls.Add(this.LblRazonSocial);
            this.GbEntidad.Controls.Add(this.BtnCancelar);
            this.GbEntidad.Controls.Add(this.BtnAceptar);
            this.GbEntidad.Enabled = false;
            this.GbEntidad.Location = new System.Drawing.Point(12, 12);
            this.GbEntidad.Name = "GbEntidad";
            this.GbEntidad.Size = new System.Drawing.Size(410, 242);
            this.GbEntidad.TabIndex = 3;
            this.GbEntidad.TabStop = false;
            this.GbEntidad.Text = "Empresa";
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(86, 143);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 10;
            this.ChkVigente.Text = "&Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(86, 64);
            this.TxtDescripcion.MaxLength = 150;
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(300, 51);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // LblRUC
            // 
            this.LblRUC.AutoSize = true;
            this.LblRUC.Location = new System.Drawing.Point(12, 71);
            this.LblRUC.Name = "LblRUC";
            this.LblRUC.Size = new System.Drawing.Size(58, 13);
            this.LblRUC.TabIndex = 2;
            this.LblRUC.Text = "Decripción";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(86, 23);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(300, 20);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Location = new System.Drawing.Point(12, 30);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(44, 13);
            this.LblRazonSocial.TabIndex = 0;
            this.LblRazonSocial.Text = "Nombre";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(311, 187);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(215, 187);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 11;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // ErrMensaje
            // 
            this.ErrMensaje.ContainerControl = this;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(954, 506);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbEntidad);
            this.Name = "FrmCategoria";
            this.Text = "Categoria";
            this.GbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbEntidad.ResumeLayout(false);
            this.GbEntidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox GbEntidad;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblRUC;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CdVigente;
        private System.Windows.Forms.ErrorProvider ErrMensaje;
    }
}