using System;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using Syncfusion.Licensing;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;


namespace WindowsFormsApp1
{
    public class PdfGenerator
    {
        public void GeneratePDF(DataGridViewRow selectedRow, string filePath)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;

            // Posições iniciais para desenhar texto
            float xPosition = 10;
            float yPosition = 10;
            float lineHeight = 20;

            // Configuração da fonte
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular);

            // Adiciona os dados da linha selecionada ao PDF
            foreach (DataGridViewCell cell in selectedRow.Cells)
            {
                graphics.DrawString($"{cell.OwningColumn.HeaderText}: {cell.Value}", font, PdfBrushes.Black, new PointF(xPosition, yPosition));
                yPosition += lineHeight; // Move para a próxima linha
            }

            // Salva o documento PDF
            document.Save(filePath);
            document.Close(true);
        }
    }
    
}

