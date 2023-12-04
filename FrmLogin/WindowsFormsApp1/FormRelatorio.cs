using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FastReport;
using FastReport.Export.PdfSimple;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FormRelatorio : Form
    {

        private User usuario;
        Class_CadastroPac cadastroPacote = new Class_CadastroPac();
        Class_BD_CRUD Bd = new Class_BD_CRUD();
        private DataTable dataTable = new DataTable();
        DataRow newRow;
        public FormRelatorio()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            string date = DateTime.Now.Date.ToString("yyyy-MM-dd");
            Bd.setBD_Open();
            DataTable datatable_dos_pacotes_registrados_no_dia = Bd.setDataTable_pacotesDoDia(date);


            dataGridRelatorio.DataSource = datatable_dos_pacotes_registrados_no_dia;
            Bd.setBD_Close();
        }

        private void SearchDateGrid()
        {

        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdb_Titular_cpf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string CPF, nota_fiscal;
            bool dadosOk, rdb_cpf_checked = rdb_Titular_cpf.Checked, rdb_nf_checked = rdb_NotaFiscal.Checked;

            /*textBox_NotaFiscal.Enabled = false;
            comboBox_funcionario.Enabled = false;
            txtbox_nome_entregador.Enabled = false;
            textBox_Titular.Enabled = false;
            maskedTextBox_telefone.Enabled = false;
            txtbox_cpf_entregador.Enabled = false;
            maskedTextBox_email.Enabled = false;
            maskedTextBox_CPF.Enabled = false;
            maskedTextBoxSituacao.Enabled = false;
            */

            if (rdb_cpf_checked)
            {
                CPF = txtBox_buscar_cpf.Text;
                if (CPF != "")
                {
                    dadosOk = cadastroPacote.setValid_cpf_buscar(CPF);
                    if (dadosOk)
                    {
                        try
                        {
                            Bd.setBD_Open();
                            Bd.setRead_pacote_cpf(CPF);
                            Bd.setRead_titular_cpf();
                            Bd.setRead_entregador();
                            Bd.setRead_data();
                            Bd.setRead_hora();

                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro ao buscar dados no banco de dados.\n\n" + erro, "Erro de conexão");
                        }
                        finally
                        {
                            Bd.setBD_Close();
                        }
                    }
                    else { MessageBox.Show("CPF Titular if dadosok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                }
                else
                { MessageBox.Show("CPF Titular vazio em opções do buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            else if (rdb_nf_checked)
            {
                nota_fiscal = txtBox_buscar.Text;
                if (nota_fiscal != "")
                {
                    dadosOk = cadastroPacote.setValid_nf_buscar(nota_fiscal);
                    if (dadosOk)
                    {
                        try
                        {
                            Bd.setBD_Open();
                            Bd.setRead_pacote_nf(nota_fiscal);
                            Bd.setRead_titular_cpf();
                            Bd.setRead_entregador();
                            Bd.setRead_data();
                            Bd.setRead_hora();

                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro ao buscar dados no banco de dados.\n\n" + erro, "Erro de conexão");
                        }
                        finally
                        {
                            Bd.setBD_Close();
                        }

                    }
                    else { MessageBox.Show("NF  if dadosok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                }
                else
                { MessageBox.Show("Nota Fiscal vazio em opções do buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            else { MessageBox.Show("Selecione uma das opções do buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return; }


            //Crie as colunas do DataTable
            dataTable.Columns.Add("Nota Fiscal");
            dataTable.Columns.Add("Funcionário");
            dataTable.Columns.Add("Situação");
            dataTable.Columns.Add("Titular");
            dataTable.Columns.Add("Telefone");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("CPF Titular");
            dataTable.Columns.Add("Entregador");
            dataTable.Columns.Add("CPF Entregador");
            dataTable.Columns.Add("Data");
            dataTable.Columns.Add("Hora");

            //recebendo dados para enviar pro Datagridview
            dataTable.Rows.Clear();// da clear nas linhas do datatable
            newRow = dataTable.NewRow();//cria uma nova linha no datatable
            newRow["Nota Fiscal"] = Bd.getRetorna_nf();
            newRow["Funcionário"] = Bd.getRetorna_emailFuncionario();
            newRow["Situação"] = Bd.getRetorna_situacao();
            newRow["Titular"] = Bd.getNome_titular();
            newRow["Telefone"] = Bd.getTelefone_titular();
            newRow["Email"] = Bd.getEmail_titular();
            newRow["CPF Titular"] = Bd.getRetorna_cpf_titular();
            newRow["Entregador"] = Bd.getRetorna_nome_entregador();
            newRow["CPF Entregador"] = Bd.getRetorna_cpf_entregador();
            newRow["Data"] = Bd.getRetorna_chegada_data();
            newRow["Hora"] = Bd.getRetorna_chegada_hora();
            // add as linhas do datagridview
            dataTable.Rows.Add(newRow);
            dataGridRelatorio.DataSource = dataTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                Dictionary<string, string> valoresLinhaSelecionada = ObterValoresDaLinhaSelecionada();

                if (valoresLinhaSelecionada.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione uma linha para gerar o relatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string caminhoRelatorioFrx = @"C:\Users\joao_\OneDrive\Área de Trabalho\americanas-PE2\FrmLogin\WindowsFormsApp1\tempRelatorioFinal.frx";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Salvar Relatório PDF";
                saveFileDialog.FileName = "Relatório.pdf"; // Nome padrão do arquivo
                saveFileDialog.InitialDirectory = @"C:\"; // Diretório inicial
                saveFileDialog.ShowDialog();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoPDF = saveFileDialog.FileName;

                    PdfGenerator pdfGenerator = new PdfGenerator();
                    pdfGenerator.RelatorioFinal(
                        caminhoRelatorioFrx,
                        caminhoPDF,
                        valoresLinhaSelecionada["Nota Fiscal"],
                        valoresLinhaSelecionada["Funcionário"],
                        valoresLinhaSelecionada["Situação"],
                        valoresLinhaSelecionada["Titular"],
                        valoresLinhaSelecionada["Telefone"],
                        valoresLinhaSelecionada["Email"],
                        valoresLinhaSelecionada["CPF Titular"],
                        valoresLinhaSelecionada["Data de Chegada"],
                        valoresLinhaSelecionada["Hora de Chegada"],
                        valoresLinhaSelecionada["Data de Retirada"],
                        valoresLinhaSelecionada["Hora de Retirada"]
                    );

                    MessageBox.Show("Relatório gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Dictionary<string, string> ObterValoresDaLinhaSelecionada()
        {
            Dictionary<string, string> valores = new Dictionary<string, string>();

            if (dataGridRelatorio.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridRelatorio.SelectedRows[0];

                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    string nomeDaColuna = dataGridRelatorio.Columns[cell.ColumnIndex].Name;
                    string valorDaCelula = cell.Value?.ToString() ?? string.Empty;

                    valores[nomeDaColuna] = valorDaCelula;
                }
            }

            return valores;
        }
    }
}


