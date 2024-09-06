
namespace Gestion
{
    partial class FrmListadoIngresosPorDocumento
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
            this.CdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.LblInicio = new System.Windows.Forms.Label();
            this.CboDocumento = new System.Windows.Forms.ComboBox();
            this.LblDocumento = new System.Windows.Forms.Label();
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
            this.CdDocumento,
            this.CdTotal});
            this.DgvVentas.Location = new System.Drawing.Point(12, 98);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.ReadOnly = true;
            this.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVentas.Size = new System.Drawing.Size(486, 407);
            this.DgvVentas.TabIndex = 10;
            // 
            // CdDocumento
            // 
            this.CdDocumento.DataPropertyName = "Documento";
            this.CdDocumento.HeaderText = "Documento";
            this.CdDocumento.Name = "CdDocumento";
            this.CdDocumento.ReadOnly = true;
            this.CdDocumento.Width = 150;
            // 
            // CdTotal
            // 
            this.CdTotal.DataPropertyName = "TotalBD";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.CdTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.CdTotal.HeaderText = "Total";
            this.CdTotal.Name = "CdTotal";
            this.CdTotal.ReadOnly = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(422, 523);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(422, 30);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 9;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // DtpInicio
            // 
            this.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpInicio.Location = new System.Drawing.Point(80, 17);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(107, 20);
            this.DtpInicio.TabIndex = 7;
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Location = new System.Drawing.Point(12, 19);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(37, 13);
            this.LblInicio.TabIndex = 5;
            this.LblInicio.Text = "Fecha";
            // 
            // CboDocumento
            // 
            this.CboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDocumento.FormattingEnabled = true;
            this.CboDocumento.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.CboDocumento.Location = new System.Drawing.Point(80, 56);
            this.CboDocumento.Name = "CboDocumento";
            this.CboDocumento.Size = new System.Drawing.Size(175, 21);
            this.CboDocumento.TabIndex = 12;
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.Location = new System.Drawing.Point(9, 59);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(62, 13);
            this.LblDocumento.TabIndex = 11;
            this.LblDocumento.Text = "Documento";
            // 
            // FrmListadoIngresosPorDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 558);
            this.Controls.Add(this.CboDocumento);
            this.Controls.Add(this.LblDocumento);
            this.Controls.Add(this.DgvVentas);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.DtpInicio);
            this.Controls.Add(this.LblInicio);
            this.Name = "FrmListadoIngresosPorDocumento";
            this.Text = "Listado ingresos por documento";
            this.Load += new System.EventHandler(this.FrmListadoIngresosPorDocumento_Load);
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
        private System.Windows.Forms.ComboBox CboDocumento;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTotal;
    }
}