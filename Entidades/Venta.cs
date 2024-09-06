using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {

        public int Codigo { get; set; }
        public string TipoDocumento { get; set; }
        public string Serie { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public bool Vigente { get; set; }
        public Trabajador Trabajador { get; set; }
        public double TotalBD { get; set; }


        public List<DetalleVenta> Detalles = new List<DetalleVenta>();

        public string Documento
        {
            get
            {
                var doc = this.TipoDocumento;

                doc += " " + this.Serie + "-" + this.Numero.ToString("000000");

                return doc;
            }
        }

        public double Total
        {
            get
            {
                var monto = 0.0;

                foreach (DetalleVenta det in this.Detalles)
                {
                    monto += det.Total;
                }

                return monto;
            }

        }

        public string NombreTipoDocumento
        {
            get
            {
                var documento = "";
                if (TipoDocumento == "B")
                {
                    documento = "Boleta";
                }

                if (TipoDocumento == "F")
                {
                    documento = "Factura";
                }
                return documento;
            }
        }


    }

}
