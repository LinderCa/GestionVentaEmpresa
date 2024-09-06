using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        public int Codigo { get; set; }
        public Categoria Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public double PrecioMinimo { get; set; }
        public bool Vigente { get; set; }

        public string NombreCategoria { 
            get { return Categoria.Nombre; }
        }
    }

}
