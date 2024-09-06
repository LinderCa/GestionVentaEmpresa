using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
  static class Program
  {

    public static List<Empresa> Empresas = new List<Empresa>();
    public static List<Trabajador> Trabajadores = new List<Trabajador>();
    public static List<Categoria> Categorias = new List<Categoria>();
    public static List<Producto> Productos = new List<Producto>();
    public static List<Venta> Ventas = new List<Venta>();

    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
      LlenarDatos();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FrmIniciarSesion());
    }

    private static void LlenarDatos()
    {
      LlenarEmpresas();
      LlenarCategorias();
      LlenarProductos();
    }

    private static void LlenarProductos()
    {
      Productos.Add(new Producto() { Nombre = "Televisor", Categoria = Categorias[1], Precio = 1500 });
      Productos.Add(new Producto() { Nombre = "Lavadora", Categoria = Categorias[0], Precio = 750 });
    }

    private static void LlenarCategorias()
    {
      Categorias.Add(new Categoria() { Nombre = "Linea Blanca" });
      Categorias.Add(new Categoria() { Nombre = "Linea Marrón" });
    }

    private static void LlenarEmpresas()
    {
      Empresas.Add(new Empresa
      {
        RazonSocial = "XYZ",
        RUC = "12345678901",
        Dirección = "Su local",
        Telefono = "074123123",
        Correo = "empresa@servidor.com",
        Vigente = true
      });
      Empresas.Add(new Empresa
      {
        RazonSocial = "ABC",
        RUC = "00345678901",
        Dirección = "Local propio",
        Telefono = "074252252",
        Correo = "abc@correo.com",
        Vigente = false
      });
    }
  }
}
