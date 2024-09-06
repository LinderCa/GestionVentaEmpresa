
namespace Gestion
{
  partial class FrmDetalle
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
            this.LblProducto = new System.Windows.Forms.Label();
            this.CboProducto = new System.Windows.Forms.ComboBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.NudPrecio = new System.Windows.Forms.NumericUpDown();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Location = new System.Drawing.Point(8, 15);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(50, 13);
            this.LblProducto.TabIndex = 0;
            this.LblProducto.Text = "Producto";
            // 
            // CboProducto
            // 
            this.CboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProducto.FormattingEnabled = true;
            this.CboProducto.Location = new System.Drawing.Point(88, 12);
            this.CboProducto.Name = "CboProducto";
            this.CboProducto.Size = new System.Drawing.Size(273, 21);
            this.CboProducto.TabIndex = 1;
            this.CboProducto.SelectedIndexChanged += new System.EventHandler(this.CboProducto_SelectedIndexChanged);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(8, 46);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(37, 13);
            this.LblPrecio.TabIndex = 2;
            this.LblPrecio.Text = "Precio";
            // 
            // NudPrecio
            // 
            this.NudPrecio.Location = new System.Drawing.Point(88, 44);
            this.NudPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudPrecio.Name = "NudPrecio";
            this.NudPrecio.Size = new System.Drawing.Size(93, 20);
            this.NudPrecio.TabIndex = 3;
            this.NudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudPrecio.ValueChanged += new System.EventHandler(this.NudPrecio_ValueChanged);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(8, 77);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(49, 13);
            this.LblCantidad.TabIndex = 4;
            this.LblCantidad.Text = "Cantidad";
            // 
            // NudCantidad
            // 
            this.NudCantidad.Location = new System.Drawing.Point(88, 75);
            this.NudCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(93, 20);
            this.NudCantidad.TabIndex = 5;
            this.NudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCantidad.ValueChanged += new System.EventHandler(this.NudCantidad_ValueChanged);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(205, 162);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 6;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(286, 162);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(224, 120);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(137, 20);
            this.TxtTotal.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total";
            // 
            // FrmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 197);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.NudCantidad);
            this.Controls.Add(this.NudPrecio);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.CboProducto);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalle";
            this.Text = "Detalle de venta";
            this.Load += new System.EventHandler(this.FrmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LblProducto;
    private System.Windows.Forms.ComboBox CboProducto;
    private System.Windows.Forms.Label LblPrecio;
    private System.Windows.Forms.NumericUpDown NudPrecio;
    private System.Windows.Forms.Label LblCantidad;
    private System.Windows.Forms.NumericUpDown NudCantidad;
    private System.Windows.Forms.Button BtnAceptar;
    private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label1;
    }
}