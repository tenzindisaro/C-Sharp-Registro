using System;
using System.Data;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.Linq;
using System.Xml.Linq;


namespace WindowsFormsApp1
{
    public class PdfGenerator
    {
        public void GerarRelatorioDadoSelecionado(DataGridViewRow linhaSelecionada, string caminhoArquivo)
        {
            try
            {
                PdfDocument pdfDoc = new PdfDocument(new PdfWriter(caminhoArquivo));
                Document doc = new Document(pdfDoc);

                PdfFont fontTitulo = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont fontDados = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                Paragraph titulo = new Paragraph("Relatório de Pacote").SetFont(fontTitulo).SetFontSize(20);
                doc.Add(titulo);

                DataTable dataTable = new DataTable();
                foreach (DataGridViewColumn column in linhaSelecionada.DataGridView.Columns)
                {
                    dataTable.Columns.Add(column.HeaderText);
                }

                DataRowView dataRow = (DataRowView)linhaSelecionada.DataBoundItem;
                dataTable.LoadDataRow(dataRow.Row.ItemArray, true);

                Table table = new Table(dataTable.Columns.Count, true);
                table.UseAllAvailableWidth();

                foreach (DataGridViewColumn column in linhaSelecionada.DataGridView.Columns)
                {
                    Cell headerCell = new Cell().Add(new Paragraph(column.HeaderText));
                    headerCell.SetFont(fontDados).SetFontColor(DeviceRgb.BLACK).SetBackgroundColor(DeviceRgb.WHITE);
                    table.AddHeaderCell(headerCell);
                }

                foreach (DataColumn dataColumn in dataTable.Columns)
                {
                    Cell dataCell = new Cell().Add(new Paragraph(dataRow[dataColumn.ColumnName].ToString()));
                    dataCell.SetFont(fontDados).SetFontColor(DeviceRgb.BLACK).SetBackgroundColor(DeviceRgb.WHITE);
                    table.AddCell(dataCell);
                }

                doc.Add(table);

                doc.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao gerar o PDF: {ex.Message}");
            }
        }
    }

}
