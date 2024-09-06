namespace Entidades
{
  public class DetalleVenta
  {

    public int Codigo { get; set; }
    public Venta Venta { get; set; }
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }


    public string NombreProducto
    {
      get
      {
        var nom = "";

        if (this.Producto != null)
        {
          nom = this.Producto.Nombre;
        }

        return nom;
      }
    }

    public double Total
    {
      get
      {
        return this.Cantidad * this.Precio;
      }
    }
  }


}