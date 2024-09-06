
namespace Gestion
{
  partial class FrmPrincipal
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MnuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTrabajador = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuDarBajaAltaVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListadoVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCatalogoProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListadoIngresosDocumento = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuListadoProductosVendidosAnio = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuGestion,
            this.MnuOperaciones,
            this.MnuReportes});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // MnuGestion
            // 
            this.MnuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEmpresa,
            this.MnuTrabajador,
            this.MnuCategoria,
            this.MnuProducto,
            this.MnuUsuario,
            this.toolStripMenuItem1,
            this.MnuSalir});
            this.MnuGestion.Name = "MnuGestion";
            this.MnuGestion.Size = new System.Drawing.Size(59, 20);
            this.MnuGestion.Text = "&Gestión";
            // 
            // MnuEmpresa
            // 
            this.MnuEmpresa.Name = "MnuEmpresa";
            this.MnuEmpresa.Size = new System.Drawing.Size(180, 22);
            this.MnuEmpresa.Text = "&Empresa";
            this.MnuEmpresa.Click += new System.EventHandler(this.MnuEmpresa_Click);
            // 
            // MnuTrabajador
            // 
            this.MnuTrabajador.Name = "MnuTrabajador";
            this.MnuTrabajador.Size = new System.Drawing.Size(180, 22);
            this.MnuTrabajador.Text = "Trabajador";
            this.MnuTrabajador.Click += new System.EventHandler(this.MnuTrabajador_Click);
            // 
            // MnuCategoria
            // 
            this.MnuCategoria.Name = "MnuCategoria";
            this.MnuCategoria.Size = new System.Drawing.Size(180, 22);
            this.MnuCategoria.Text = "Categoria";
            this.MnuCategoria.Click += new System.EventHandler(this.MnuCategoria_Click);
            // 
            // MnuProducto
            // 
            this.MnuProducto.Name = "MnuProducto";
            this.MnuProducto.Size = new System.Drawing.Size(180, 22);
            this.MnuProducto.Text = "Producto";
            this.MnuProducto.Click += new System.EventHandler(this.MnuProducto_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuSalir
            // 
            this.MnuSalir.Name = "MnuSalir";
            this.MnuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MnuSalir.Size = new System.Drawing.Size(180, 22);
            this.MnuSalir.Text = "&Salir";
            this.MnuSalir.Click += new System.EventHandler(this.MnuSalir_Click);
            // 
            // MnuOperaciones
            // 
            this.MnuOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuVenta,
            this.MnuDarBajaAltaVentas});
            this.MnuOperaciones.Name = "MnuOperaciones";
            this.MnuOperaciones.Size = new System.Drawing.Size(85, 20);
            this.MnuOperaciones.Text = "Operaciones";
            // 
            // MnuVenta
            // 
            this.MnuVenta.Name = "MnuVenta";
            this.MnuVenta.Size = new System.Drawing.Size(220, 22);
            this.MnuVenta.Text = "Venta";
            this.MnuVenta.Click += new System.EventHandler(this.MnuVenta_Click);
            // 
            // MnuDarBajaAltaVentas
            // 
            this.MnuDarBajaAltaVentas.Name = "MnuDarBajaAltaVentas";
            this.MnuDarBajaAltaVentas.Size = new System.Drawing.Size(220, 22);
            this.MnuDarBajaAltaVentas.Text = "Dar de baja/alta a las ventas";
            this.MnuDarBajaAltaVentas.Click += new System.EventHandler(this.MnuDarBajaAltaVentas_Click);
            // 
            // MnuReportes
            // 
            this.MnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuListadoVentas,
            this.MnuCatalogoProductos,
            this.MnuListadoIngresosDocumento,
            this.MnuListadoProductosVendidosAnio});
            this.MnuReportes.Name = "MnuReportes";
            this.MnuReportes.Size = new System.Drawing.Size(65, 20);
            this.MnuReportes.Text = "Reportes";
            // 
            // MnuListadoVentas
            // 
            this.MnuListadoVentas.Name = "MnuListadoVentas";
            this.MnuListadoVentas.Size = new System.Drawing.Size(267, 22);
            this.MnuListadoVentas.Text = "Listado ventas";
            this.MnuListadoVentas.Click += new System.EventHandler(this.MnuListadoVentas_Click);
            // 
            // MnuCatalogoProductos
            // 
            this.MnuCatalogoProductos.Name = "MnuCatalogoProductos";
            this.MnuCatalogoProductos.Size = new System.Drawing.Size(267, 22);
            this.MnuCatalogoProductos.Text = "Catálogo de productos";
            this.MnuCatalogoProductos.Click += new System.EventHandler(this.MnuCatalogoProductos_Click);
            // 
            // MnuUsuario
            // 
            this.MnuUsuario.Name = "MnuUsuario";
            this.MnuUsuario.Size = new System.Drawing.Size(180, 22);
            this.MnuUsuario.Text = "Usuario";
            this.MnuUsuario.Click += new System.EventHandler(this.MnuUsuario_Click);
            // 
            // MnuListadoIngresosDocumento
            // 
            this.MnuListadoIngresosDocumento.Name = "MnuListadoIngresosDocumento";
            this.MnuListadoIngresosDocumento.Size = new System.Drawing.Size(267, 22);
            this.MnuListadoIngresosDocumento.Text = "Listado ingresos por documento";
            this.MnuListadoIngresosDocumento.Click += new System.EventHandler(this.MnuListadoIngresosDocumento_Click);
            // 
            // MnuListadoProductosVendidosAnio
            // 
            this.MnuListadoProductosVendidosAnio.Name = "MnuListadoProductosVendidosAnio";
            this.MnuListadoProductosVendidosAnio.Size = new System.Drawing.Size(267, 22);
            this.MnuListadoProductosVendidosAnio.Text = "Listado productos vendidos por anio";
            this.MnuListadoProductosVendidosAnio.Click += new System.EventHandler(this.MnuListadoProductosVendidosAnio_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Gestión Empresarial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip MnuPrincipal;
    private System.Windows.Forms.ToolStripMenuItem MnuGestion;
    private System.Windows.Forms.ToolStripMenuItem MnuEmpresa;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem MnuSalir;
    private System.Windows.Forms.ToolStripMenuItem MnuTrabajador;
    private System.Windows.Forms.ToolStripMenuItem MnuOperaciones;
    private System.Windows.Forms.ToolStripMenuItem MnuVenta;
    private System.Windows.Forms.ToolStripMenuItem MnuReportes;
    private System.Windows.Forms.ToolStripMenuItem MnuListadoVentas;
        private System.Windows.Forms.ToolStripMenuItem MnuDarBajaAltaVentas;
        private System.Windows.Forms.ToolStripMenuItem MnuCategoria;
        private System.Windows.Forms.ToolStripMenuItem MnuProducto;
        private System.Windows.Forms.ToolStripMenuItem MnuCatalogoProductos;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem MnuListadoIngresosDocumento;
        private System.Windows.Forms.ToolStripMenuItem MnuListadoProductosVendidosAnio;
    }
}