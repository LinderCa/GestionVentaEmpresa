using Entidades;
using Microsoft.Office.Interop.Word;
using ReglasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Office = Microsoft.Office.Interop.Word;

namespace Gestion
{
    public partial class FrmCatalogoProductos : Form
    {
        public FrmCatalogoProductos()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            RNProducto rn = new RNProducto();
            List<Producto> seleccionados;

            try
            {
                seleccionados = rn.Listar("");
                this.DgvListado.DataSource = null;
                if (seleccionados != null && seleccionados.Count > 0)
                {
                    this.DgvListado.AutoGenerateColumns = false;
                    this.DgvListado.DataSource = seleccionados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operación", this.Text);
            }
        }

        private void BtnExportarWord_Click(object sender, EventArgs e)
        {
            if(DgvListado.RowCount == 0)
            {
                MessageBox.Show("Primero liste los productos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.BtnListar.Focus();
            }
            else
            {
                GuardarArchivoDialogo.Filter = "Libro de Word|*.docx";
                GuardarArchivoDialogo.FileName = $"{this.Text}{DateTime.Now:ddMMyyHHmmss}";
                GuardarArchivoDialogo.DefaultExt = ".docx";

                if (GuardarArchivoDialogo.ShowDialog() == DialogResult.OK)
                {
                    string ruta = GuardarArchivoDialogo.FileName;

                    Office.Application app = new Office.Application();
                    Document doc = app.Documents.Add();

                    object missing = Missing.Value;

                    object DefaultTableBehavior = WdDefaultTableBehavior.wdWord9TableBehavior;
                    object WdAutoFitBehavior = Office.WdAutoFitBehavior.wdAutoFitWindow;

                    object DefaultTableBehavior2 = WdDefaultTableBehavior.wdWord8TableBehavior;
                    Table tablaTitulo = doc.Tables.Add(app.Application.ActiveDocument.Range(0, 0), 1, 1, ref DefaultTableBehavior2, ref WdAutoFitBehavior);
                    tablaTitulo.Cell(1, 1).Range.Text = "CATÁLOGO DE PRODUCTOS";
                    tablaTitulo.Cell(1, 1).Range.Font.Bold = 1;
                    tablaTitulo.Cell(1, 1).Range.Font.Size = 14;
                    tablaTitulo.Cell(1, 1).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    int filas = DgvListado.Rows.Count + 1;

                    Table tabla1 = doc.Tables.Add(app.Application.ActiveDocument.Range(21, 21), filas, 4, ref DefaultTableBehavior, ref WdAutoFitBehavior);
                    tabla1.set_Style("Tabla con cuadrícula 4 - Énfasis 5");
                    tabla1.Cell(1, 1).Range.Text = "Categoría";
                    tabla1.Cell(1, 2).Range.Text = "Nombre";
                    tabla1.Cell(1, 3).Range.Text = "Precio";
                    tabla1.Cell(1, 4).Range.Text = "Precio mínimo";

                    int i = 2;

                    foreach (DataGridViewRow row in DgvListado.Rows)
                    {
                        tabla1.Cell(i, 1).Range.Text = row.Cells["CdCategoria"].Value.ToString();
                        tabla1.Cell(i, 2).Range.Text = row.Cells["CdNombre"].Value.ToString();
                        tabla1.Cell(i, 3).Range.Text = row.Cells["CdPrecio"].Value.ToString();
                        tabla1.Cell(i, 4).Range.Text = row.Cells["CdPrecioMinimo"].Value.ToString();
                        i++;
                    }

                    doc.SaveAs(ruta);

                    doc.Close(ref missing, ref missing, ref missing);

                    MessageBox.Show("Se exportó correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
