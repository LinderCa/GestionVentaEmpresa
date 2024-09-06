using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    public class ReporteListadoProductosVendidosPorAnio
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double TotalVendido { get; set; }

        public string NombreProducto
        {
            get
            {
                return Producto.Nombre;
            }
        }
    }
}
