namespace Gestion
{
    partial class FrmCatalogoProductos
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
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnExportarWord = new System.Windows.Forms.Button();
            this.GuardarArchivoDialogo = new System.Windows.Forms.SaveFileDialog();
            this.CdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdPrecioMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdCategoria,
            this.CdNombre,
            this.CdPrecio,
            this.CdPrecioMinimo});
            this.DgvListado.Location = new System.Drawing.Point(12, 41);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(803, 417);
            this.DgvListado.TabIndex = 3;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Location = new System.Drawing.Point(740, 12);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 2;
            this.BtnListar.Text = "&Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(740, 464);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnExportarWord
            // 
            this.BtnExportarWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportarWord.Location = new System.Drawing.Point(12, 12);
            this.BtnExportarWord.Name = "BtnExportarWord";
            this.BtnExportarWord.Size = new System.Drawing.Size(131, 23);
            this.BtnExportarWord.TabIndex = 2;
            this.BtnExportarWord.Text = "&Exportar a Word";
            this.BtnExportarWord.UseVisualStyleBackColor = true;
            this.BtnExportarWord.Click += new System.EventHandler(this.BtnExportarWord_Click);
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
            // FrmCatalogoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 499);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.BtnExportarWord);
            this.Controls.Add(this.BtnListar);
            this.Name = "FrmCatalogoProductos";
            this.Text = "Catálogo de productos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnExportarWord;
        private System.Windows.Forms.SaveFileDialog GuardarArchivoDialogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdPrecioMinimo;
    }
}