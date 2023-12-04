using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using FastReport;
using FastReport.Export.PdfSimple;
using System.IO;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PdfGenerator
    {
        public void RelatorioFinal(string caminhoRelatorioFrx, string caminhoPDF, string NF, string func, string sit, string tit, string tel, string email, string cpf, string dataC, string horaC, string dataR, string horaR)
        {
            try
            {
                // Carrega o relatório do arquivo .frx
                Report report = new Report();
                report.Load(caminhoRelatorioFrx);

                report.SetParameterValue("NF", NF);
                report.SetParameterValue("Func", func);
                report.SetParameterValue("Sit", sit);
                report.SetParameterValue("Tit", tit);
                report.SetParameterValue("Tel", tel);
                report.SetParameterValue("Email", email);
                report.SetParameterValue("CPF", cpf);
                report.SetParameterValue("DataC", dataC);
                report.SetParameterValue("HoraC", horaC);
                report.SetParameterValue("DataR", dataR);
                report.SetParameterValue("HoraR", horaR);

               
                report.Prepare();

                // Exporta o relatório para PDF
                PDFSimpleExport exportadorPDF = new PDFSimpleExport();
                using (FileStream fileStream = new FileStream(caminhoPDF, FileMode.Create, FileAccess.Write))
                {
                    exportadorPDF.Export(report, fileStream);
                }

                MessageBox.Show("Relatório exportado com sucesso para: " + caminhoPDF, "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar o relatório para PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void RelatorioChegada(string caminhoRelatorioFrx, string caminhoPDF, string NF, string func, string sit, string tit, string tel, string email, string cpf, string dataC, string horaC)
        {
            try
            {
                // Carrega o relatório do arquivo .frx
                Report report = new Report();
                report.Load(caminhoRelatorioFrx);

                report.SetParameterValue("NF", NF);
                report.SetParameterValue("Func", func);
                report.SetParameterValue("Sit", sit);
                report.SetParameterValue("Tit", tit);
                report.SetParameterValue("Tel", tel);
                report.SetParameterValue("Email", email);
                report.SetParameterValue("CPF", cpf);
                report.SetParameterValue("DataC", dataC);
                report.SetParameterValue("HoraC", horaC);
    
                report.Prepare();
  
                PDFSimpleExport exportadorPDF = new PDFSimpleExport();
                using (FileStream fileStream = new FileStream(caminhoPDF, FileMode.Create, FileAccess.Write))
                {
                    exportadorPDF.Export(report, fileStream);
                }

                MessageBox.Show("Relatório exportado com sucesso para: " + caminhoPDF, "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar o relatório para PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RelatorioSaida(string caminhoRelatorioFrx, string caminhoPDF, string NF, string func, string sit, string tit, string tel, string email, string cpf, string dataR, string horaR)
        {
            try
            {
                // Carrega o relatório do arquivo .frx
                Report report = new Report();
                report.Load(caminhoRelatorioFrx);

                report.SetParameterValue("NF", NF);
                report.SetParameterValue("Func", func);
                report.SetParameterValue("Sit", sit);
                report.SetParameterValue("Tit", tit);
                report.SetParameterValue("Tel", tel);
                report.SetParameterValue("Email", email);
                report.SetParameterValue("CPF", cpf);
                report.SetParameterValue("DataR", dataR);
                report.SetParameterValue("HoraR", horaR);

                report.Prepare();

                PDFSimpleExport exportadorPDF = new PDFSimpleExport();
                using (FileStream fileStream = new FileStream(caminhoPDF, FileMode.Create, FileAccess.Write))
                {
                    exportadorPDF.Export(report, fileStream);
                }

                MessageBox.Show("Relatório exportado com sucesso para: " + caminhoPDF, "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar o relatório para PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    }
}   
