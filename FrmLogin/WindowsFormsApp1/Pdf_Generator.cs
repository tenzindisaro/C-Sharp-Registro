using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace WindowsFormsApp1
{
    public class PdfGenerator
    {
        public void GerarRelatorioDadoSelecionado(DataGridViewRow linhaSelecionada, string caminhoArquivo)
        {
            try
            {
                PdfWriter writer = new PdfWriter(caminhoArquivo);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Cria um parágrafo para adicionar os dados
                Paragraph paragraph = new Paragraph();

                foreach (DataGridViewCell cell in linhaSelecionada.Cells)
                {
                    string columnName = cell.OwningColumn.HeaderText;
                    string cellValue = cell.Value?.ToString() ?? string.Empty;

                    paragraph.Add($"{columnName}: {cellValue}\n");
                }

                // Adiciona o parágrafo ao documento
                document.Add(paragraph);

                // Fecha o documento
                document.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao gerar o PDF: {ex.Message}");
            }
        }
    }

}
