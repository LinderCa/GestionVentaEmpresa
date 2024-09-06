
namespace Gestion
{
    partial class FrmListadoProductosVendidosPorAnio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.CdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.LblInicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.AllowUserToDeleteRows = false;
            this.DgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdNombre,
            this.CdCantidad,
            this.CdTotal});
            this.DgvVentas.Location = new System.Drawing.Point(15, 73);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.ReadOnly = true;
            this.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVentas.Size = new System.Drawing.Size(482, 419);
            this.DgvVentas.TabIndex = 17;
            // 
            // CdNombre
            // 
            this.CdNombre.DataPropertyName = "NombreProducto";
            this.CdNombre.HeaderText = "Nombre";
            this.CdNombre.Name = "CdNombre";
            this.CdNombre.ReadOnly = true;
            // 
            // CdCantidad
            // 
            this.CdCantidad.DataPropertyName = "Cantidad";
            this.CdCantidad.HeaderText = "Cantidad";
            this.CdCantidad.Name = "CdCantidad";
            this.CdCantidad.ReadOnly = true;
            // 
            // CdTotal
            // 
            this.CdTotal.DataPropertyName = "TotalVendido";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.CdTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.CdTotal.HeaderText = "Total vendido";
            this.CdTotal.Name = "CdTotal";
            this.CdTotal.ReadOnly = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(422, 511);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 15;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(425, 27);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 16;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // DtpInicio
            // 
            this.DtpInicio.CustomFormat = "yyyy";
            this.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpInicio.Location = new System.Drawing.Point(86, 30);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(107, 20);
            this.DtpInicio.TabIndex = 14;
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Location = new System.Drawing.Point(18, 32);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(37, 13);
            this.LblInicio.TabIndex = 13;
            this.LblInicio.Text = "Fecha";
            // 
            // FrmListadoProductosVendidosPorAnio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 546);
            this.Controls.Add(this.DgvVentas);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.DtpInicio);
            this.Controls.Add(this.LblInicio);
            this.Name = "FrmListadoProductosVendidosPorAnio";
            this.Text = "Listado productos vendidos por anio";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTotal;
    }
}