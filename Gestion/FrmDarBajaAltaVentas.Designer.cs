namespace Gestion
{
    partial class FrmDarBajaAltaVentas
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.DtpFin = new System.Windows.Forms.DateTimePicker();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.LblFin = new System.Windows.Forms.Label();
            this.LblInicio = new System.Windows.Forms.Label();
            this.BtnDarDeBaja = new System.Windows.Forms.Button();
            this.CdDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdVigente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.CdTotal,
            this.cdVigente});
            this.DgvVentas.Location = new System.Drawing.Point(16, 55);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.ReadOnly = true;
            this.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVentas.Size = new System.Drawing.Size(486, 411);
            this.DgvVentas.TabIndex = 10;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(427, 482);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 8;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(425, 18);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 9;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // DtpFin
            // 
            this.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFin.Location = new System.Drawing.Point(242, 19);
            this.DtpFin.Name = "DtpFin";
            this.DtpFin.Size = new System.Drawing.Size(96, 20);
            this.DtpFin.TabIndex = 6;
            // 
            // DtpInicio
            // 
            this.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpInicio.Location = new System.Drawing.Point(59, 19);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(107, 20);
            this.DtpInicio.TabIndex = 7;
            // 
            // LblFin
            // 
            this.LblFin.AutoSize = true;
            this.LblFin.Location = new System.Drawing.Point(201, 22);
            this.LblFin.Name = "LblFin";
            this.LblFin.Size = new System.Drawing.Size(21, 13);
            this.LblFin.TabIndex = 4;
            this.LblFin.Text = "Fin";
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Location = new System.Drawing.Point(12, 21);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(32, 13);
            this.LblInicio.TabIndex = 5;
            this.LblInicio.Text = "Inicio";
            // 
            // BtnDarDeBaja
            // 
            this.BtnDarDeBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarDeBaja.Location = new System.Drawing.Point(16, 482);
            this.BtnDarDeBaja.Name = "BtnDarDeBaja";
            this.BtnDarDeBaja.Size = new System.Drawing.Size(112, 23);
            this.BtnDarDeBaja.TabIndex = 8;
            this.BtnDarDeBaja.Text = "Dar de baja/alta";
            this.BtnDarDeBaja.UseVisualStyleBackColor = true;
            this.BtnDarDeBaja.Click += new System.EventHandler(this.BtnDarDeBaja_Click);
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
            // cdVigente
            // 
            this.cdVigente.DataPropertyName = "Vigente";
            this.cdVigente.HeaderText = "Vigente";
            this.cdVigente.Name = "cdVigente";
            this.cdVigente.ReadOnly = true;
            this.cdVigente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cdVigente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmDarBajaAltaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 517);
            this.Controls.Add(this.DgvVentas);
            this.Controls.Add(this.BtnDarDeBaja);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.DtpFin);
            this.Controls.Add(this.DtpInicio);
            this.Controls.Add(this.LblFin);
            this.Controls.Add(this.LblInicio);
            this.Name = "FrmDarBajaAltaVentas";
            this.Text = "Dar de baja o alta a las ventas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.DateTimePicker DtpFin;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.Label LblFin;
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.Button BtnDarDeBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cdVigente;
    }
}