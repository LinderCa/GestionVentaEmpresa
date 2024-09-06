using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Gestion
{
    public partial class FrmVenta : Form
    {
        private readonly List<DetalleVenta> detalles = new List<DetalleVenta>();
        private readonly double IGV = 0.18;
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmDetalle frm = new FrmDetalle();
            DetalleVenta det;

            det = frm.Agregar(detalles);
            if (det != null)
            {
                this.detalles.Add(det);
                this.DgvDetalles.DataSource = null;
                this.DgvDetalles.AutoGenerateColumns = false;
                this.DgvDetalles.DataSource = this.detalles;
                CalcularTotal();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            RNVenta rn;
            Venta venta;


            if (this.ValidateChildren() == true)
            {
                venta = this.CrearEntidad();
                rn = new RNVenta();
                try
                {
                    rn.Registrar(venta);
                    GenerarDatosVenta(venta);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo registrar la venta");
                }

            }
        }

        private void GenerarDatosVenta(Venta venta)
        {
            var ruta = $"{Sesion.rutaGuardar}ComprobanteDeVenta_{DateTime.Now:ddMMyyHHmmss}.pdf";
            FileStream fs = new FileStream(@ruta, FileMode.Create);

            Document doc = new Document(PageSize.A4, 15, 15, 30, 10);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.AddTitle("Comprobante de venta");
            doc.AddCreator("Venta");

            doc.Open();

            iTextSharp.text.Font fuenteEstandar = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            iTextSharp.text.Font fuentaCabecera = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            PdfPTable tablaCabecera = new PdfPTable(2);
            tablaCabecera.WidthPercentage = 100;

            PdfPCell cell = new PdfPCell(new Phrase(" ", fuenteEstandar));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 0;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase(" ", fuentaCabecera));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 2;
            cell.BorderWidthBottom = 0;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase("GESTIÓN EMPRESARIAL", fuentaCabecera));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 0;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase(venta.NombreTipoDocumento, fuentaCabecera));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 2;
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase("GRUPO 4", fuenteEstandar));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 0;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase(venta.Documento, fuentaCabecera));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 2;
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase(" ", fuenteEstandar));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 0;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase(" ", fuentaCabecera));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 2;
            cell.BorderWidthTop = 0;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase(" ", fuenteEstandar));
            cell.BorderWidth = 0;
            cell.Colspan = 2;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase($"TRABAJADOR: {venta.Trabajador.NombreCompleto}", fuenteEstandar));
            cell.BorderWidthBottom = 0;
            cell.Colspan = 2;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase($"FECHA DE EMISION: {venta.Fecha}", fuenteEstandar));
            cell.BorderWidthTop = 0;
            cell.Colspan = 2;
            tablaCabecera.AddCell(cell);

            cell = new PdfPCell(new Phrase(" ", fuenteEstandar));
            cell.BorderWidth = 0;
            cell.Colspan = 2;
            tablaCabecera.AddCell(cell);

            doc.Add(tablaCabecera);

            PdfPTable tablaDetalle = new PdfPTable(8);
            tablaDetalle.WidthPercentage = 100;

            cell = new PdfPCell(new Phrase("CÓDIGO", fuenteEstandar));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaDetalle.AddCell(cell);

            cell = new PdfPCell(new Phrase("DESCRIPCIÓN", fuenteEstandar));
            cell.Colspan = 4;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaDetalle.AddCell(cell);

            cell = new PdfPCell(new Phrase($"CANT.", fuenteEstandar));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaDetalle.AddCell(cell);

            cell = new PdfPCell(new Phrase($"P. UNIT", fuenteEstandar));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaDetalle.AddCell(cell);

            cell = new PdfPCell(new Phrase("P. VENTA", fuenteEstandar));
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaDetalle.AddCell(cell);

            foreach (var detalle in venta.Detalles)
            {
                cell = new PdfPCell(new Phrase(detalle.Producto.Codigo.ToString(), fuenteEstandar));
                cell.BorderWidthTop = 0;
                cell.BorderWidthBottom = 0;
                tablaDetalle.AddCell(cell);

                cell = new PdfPCell(new Phrase(detalle.Producto.Nombre, fuenteEstandar));
                cell.Colspan = 4;
                cell.BorderWidth = 0;
                tablaDetalle.AddCell(cell);

                cell = new PdfPCell(new Phrase(detalle.Cantidad.ToString(), fuenteEstandar));
                cell.BorderWidthTop = 0;
                cell.BorderWidthBottom = 0;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                tablaDetalle.AddCell(cell);

                cell = new PdfPCell(new Phrase(detalle.Precio.ToString("0.00", CultureInfo.InvariantCulture), fuenteEstandar));
                cell.BorderWidth = 0;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                tablaDetalle.AddCell(cell);

                var precioVenta = detalle.Cantidad * detalle.Precio;
                cell = new PdfPCell(new Phrase(precioVenta.ToString("0.00", CultureInfo.InvariantCulture), fuenteEstandar));
                cell.BorderWidthTop = 0;
                cell.BorderWidthBottom = 0;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                tablaDetalle.AddCell(cell);
            }

            cell = new PdfPCell(new Phrase("TOTAL A PAGAR", fuenteEstandar));
            cell.Colspan = 6;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaDetalle.AddCell(cell);

            cell = new PdfPCell(new Phrase($"S/ {venta.Total.ToString("0.00", CultureInfo.InvariantCulture)}", fuenteEstandar));
            cell.Colspan = 2;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            tablaDetalle.AddCell(cell);

            doc.Add(tablaDetalle);

            doc.Close();
            writer.Close();
            System.Diagnostics.Process.Start(ruta);
        }

        private Venta CrearEntidad()
        {
            Venta venta = new Venta()
            {
                TipoDocumento = this.CboDocumento.Text.Substring(0, 1),
                Serie = this.TxtSerie.Text,
                Numero = (int)this.NudNumero.Value,
                Fecha = this.DtpFecha.Value,
                Detalles = this.detalles,
                Vigente = true,
                Trabajador = Sesion.Usuario.Trabajador,
            };

            return venta;
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in DgvDetalles.Rows)
            {
                total += Convert.ToDecimal(row.Cells["CdSubTotal"].Value);
            }

            if (CboDocumento.SelectedIndex == 1)
            {
                total += total * (decimal)IGV;
            }

            TxtTotal.Text = total.ToString();

        }

        private void CboDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboDocumento.SelectedIndex == 1)
            {
                LblIGV.Visible = true;
                TxtIGV.Visible = true;
                CalcularIGV();
                CalcularTotal();
            }
            else
            {
                LblIGV.Visible = false;
                TxtIGV.Visible = false;
                CalcularTotal();
            }
        }

        private void CalcularIGV()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in DgvDetalles.Rows)
            {
                total += Convert.ToDecimal(row.Cells["CdSubTotal"].Value);
            }

            total = total * (decimal)IGV;

            TxtIGV.Text = total.ToString();
        }

        private void CboDocumento_Validating(object sender, CancelEventArgs e)
        {
            if (CboDocumento.SelectedIndex > -1)
            {
                this.ErrMensaje.SetError(this.CboDocumento, "");
            }
            else
            {
                this.ErrMensaje.SetError(this.CboDocumento, "Debe seleccionar un tipo de documento");
                e.Cancel = true;
            }
        }

        private void TxtSerie_Validating(object sender, CancelEventArgs e)
        {
            this.TxtSerie.Text = this.TxtSerie.Text.Trim();
            if (string.IsNullOrEmpty(this.TxtSerie.Text) == false)
            {
                this.ErrMensaje.SetError(this.TxtSerie, "");
            }
            else
            {
                this.ErrMensaje.SetError(this.TxtSerie, "Debe indicar una serie");
                e.Cancel = true;
            }
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            CboDocumento.SelectedIndex = 0;
        }

        private void DgvDetalles_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            this.DgvDetalles.DataSource = null;
            this.DgvDetalles.AutoGenerateColumns = false;
            this.DgvDetalles.DataSource = this.detalles;
            CalcularTotal();
        }

        private void DgvDetalles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotal();
            this.DgvDetalles.Refresh();
            
        }
    }
}
