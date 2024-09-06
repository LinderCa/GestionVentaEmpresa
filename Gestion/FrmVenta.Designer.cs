
namespace Gestion
{
  partial class FrmVenta
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
            this.LblDocumento = new System.Windows.Forms.Label();
            this.CboDocumento = new System.Windows.Forms.ComboBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.NudNumero = new System.Windows.Forms.NumericUpDown();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.GbDetalles = new System.Windows.Forms.GroupBox();
            this.TxtIGV = new System.Windows.Forms.TextBox();
            this.LblIGV = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvDetalles = new System.Windows.Forms.DataGridView();
            this.CdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.ErrMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NudNumero)).BeginInit();
            this.GbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Location = new System.Drawing.Point(13, 16);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(62, 13);
            this.LblDocumento.TabIndex = 0;
            this.LblDocumento.Text = "Documento";
            // 
            // CboDocumento
            // 
            this.CboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDocumento.FormattingEnabled = true;
            this.CboDocumento.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.CboDocumento.Location = new System.Drawing.Point(78, 14);
            this.CboDocumento.Name = "CboDocumento";
            this.CboDocumento.Size = new System.Drawing.Size(175, 21);
            this.CboDocumento.TabIndex = 1;
            this.CboDocumento.SelectedIndexChanged += new System.EventHandler(this.CboDocumento_SelectedIndexChanged);
            this.CboDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.CboDocumento_Validating);
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(388, 17);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(19, 13);
            this.LblNumero.TabIndex = 2;
            this.LblNumero.Text = "Nº";
            // 
            // TxtSerie
            // 
            this.TxtSerie.Location = new System.Drawing.Point(415, 13);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(63, 20);
            this.TxtSerie.TabIndex = 3;
            this.TxtSerie.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSerie_Validating);
            // 
            // NudNumero
            // 
            this.NudNumero.Location = new System.Drawing.Point(484, 14);
            this.NudNumero.Name = "NudNumero";
            this.NudNumero.Size = new System.Drawing.Size(64, 20);
            this.NudNumero.TabIndex = 4;
            this.NudNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(13, 54);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 5;
            this.LblFecha.Text = "Fecha";
            // 
            // DtpFecha
            // 
            this.DtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFecha.Location = new System.Drawing.Point(78, 52);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(175, 20);
            this.DtpFecha.TabIndex = 6;
            // 
            // GbDetalles
            // 
            this.GbDetalles.Controls.Add(this.TxtIGV);
            this.GbDetalles.Controls.Add(this.LblIGV);
            this.GbDetalles.Controls.Add(this.TxtTotal);
            this.GbDetalles.Controls.Add(this.label1);
            this.GbDetalles.Controls.Add(this.BtnEliminar);
            this.GbDetalles.Controls.Add(this.BtnAgregar);
            this.GbDetalles.Controls.Add(this.DgvDetalles);
            this.GbDetalles.Location = new System.Drawing.Point(12, 78);
            this.GbDetalles.Name = "GbDetalles";
            this.GbDetalles.Size = new System.Drawing.Size(653, 342);
            this.GbDetalles.TabIndex = 7;
            this.GbDetalles.TabStop = false;
            // 
            // TxtIGV
            // 
            this.TxtIGV.Enabled = false;
            this.TxtIGV.Location = new System.Drawing.Point(202, 307);
            this.TxtIGV.Name = "TxtIGV";
            this.TxtIGV.Size = new System.Drawing.Size(137, 20);
            this.TxtIGV.TabIndex = 14;
            this.TxtIGV.Visible = false;
            // 
            // LblIGV
            // 
            this.LblIGV.AutoSize = true;
            this.LblIGV.Location = new System.Drawing.Point(171, 310);
            this.LblIGV.Name = "LblIGV";
            this.LblIGV.Size = new System.Drawing.Size(25, 13);
            this.LblIGV.TabIndex = 12;
            this.LblIGV.Text = "IGV";
            this.LblIGV.Visible = false;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(424, 307);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(137, 20);
            this.TxtTotal.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(567, 69);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(567, 28);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvDetalles
            // 
            this.DgvDetalles.AllowUserToAddRows = false;
            this.DgvDetalles.AllowUserToDeleteRows = false;
            this.DgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdProducto,
            this.CdCantidad,
            this.CdPrecioUnitario,
            this.CdSubTotal});
            this.DgvDetalles.Location = new System.Drawing.Point(15, 28);
            this.DgvDetalles.MultiSelect = false;
            this.DgvDetalles.Name = "DgvDetalles";
            this.DgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvDetalles.Size = new System.Drawing.Size(546, 264);
            this.DgvDetalles.TabIndex = 0;
            this.DgvDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalles_CellEndEdit);
            // 
            // CdProducto
            // 
            this.CdProducto.DataPropertyName = "NombreProducto";
            this.CdProducto.HeaderText = "Producto";
            this.CdProducto.Name = "CdProducto";
            this.CdProducto.ReadOnly = true;
            // 
            // CdCantidad
            // 
            this.CdCantidad.DataPropertyName = "Cantidad";
            this.CdCantidad.HeaderText = "Cantidad";
            this.CdCantidad.Name = "CdCantidad";
            // 
            // CdPrecioUnitario
            // 
            this.CdPrecioUnitario.DataPropertyName = "Precio";
            this.CdPrecioUnitario.HeaderText = "Precio";
            this.CdPrecioUnitario.Name = "CdPrecioUnitario";
            this.CdPrecioUnitario.ReadOnly = true;
            // 
            // CdSubTotal
            // 
            this.CdSubTotal.DataPropertyName = "Total";
            this.CdSubTotal.HeaderText = "Subtotal";
            this.CdSubTotal.Name = "CdSubTotal";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(565, 430);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 33);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(459, 430);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(100, 33);
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // ErrMensaje
            // 
            this.ErrMensaje.ContainerControl = this;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 473);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.GbDetalles);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.NudNumero);
            this.Controls.Add(this.TxtSerie);
            this.Controls.Add(this.CboDocumento);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblDocumento);
            this.Name = "FrmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudNumero)).EndInit();
            this.GbDetalles.ResumeLayout(false);
            this.GbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrMensaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LblDocumento;
    private System.Windows.Forms.ComboBox CboDocumento;
    private System.Windows.Forms.Label LblNumero;
    private System.Windows.Forms.TextBox TxtSerie;
    private System.Windows.Forms.NumericUpDown NudNumero;
    private System.Windows.Forms.Label LblFecha;
    private System.Windows.Forms.DateTimePicker DtpFecha;
    private System.Windows.Forms.GroupBox GbDetalles;
    private System.Windows.Forms.Button BtnEliminar;
    private System.Windows.Forms.Button BtnAgregar;
    private System.Windows.Forms.DataGridView DgvDetalles;
    private System.Windows.Forms.Button BtnCancelar;
    private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtIGV;
        private System.Windows.Forms.Label LblIGV;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdSubTotal;
        private System.Windows.Forms.ErrorProvider ErrMensaje;
    }
}