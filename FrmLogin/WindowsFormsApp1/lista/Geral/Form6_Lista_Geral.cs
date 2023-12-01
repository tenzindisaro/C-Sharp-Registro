using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.RegistrosPac;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.lista.Geral
{
    internal partial class Form6_Lista_Geral : Form
    {
        private Class_BD_CRUD Bd = new Class_BD_CRUD();
        private Class_loja loja = null;
        private string notaFiscal, funcionario, situacao, nomeTitular, telefoneTitular, emailTitular, cpfTitular, nomeEntregador, cpfEntregador, dataChegada, horaChegada;

        private void button6_Click(object sender, EventArgs e)
        {
            InitializeDataGrid();
        }

        public Form6_Lista_Geral(Class_loja lojaAtual)
        {
            loja = lojaAtual;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //deletar
            DialogResult result = MessageBox.Show($"Tem certeza que dejesa apagar o pacote com a nota fiscal {notaFiscal}?", "Confirme a operação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Bd.setBD_Open();
                    Bd.setDelet_pacote(notaFiscal);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao deletar dados do pacote no banco de dados.\n\n" + erro, "Erro de conexão");
                }
                finally
                {
                    Bd.setBD_Close();
                    InitializeDataGrid();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(situacao != "Retirado")
            {
                this.Hide();
                FormRetirarPac form = new FormRetirarPac(loja, notaFiscal, funcionario, nomeEntregador, nomeTitular, telefoneTitular, cpfEntregador, emailTitular, cpfTitular, situacao, dataChegada, horaChegada);
                form.ShowDialog();
                this.Show();
                InitializeDataGrid();
            }
            else
            {
                MessageBox.Show("O pacote selecionado já foi retirado");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5_Registro_Pac form = new Form5_Registro_Pac(loja);
            form.ShowDialog();
            this.Show();
            InitializeDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5_Registro_Pac form = new Form5_Registro_Pac(loja, notaFiscal, funcionario, nomeEntregador, nomeTitular, telefoneTitular, cpfEntregador, emailTitular, cpfTitular, situacao,  dataChegada, horaChegada);
            form.ShowDialog();
            this.Show();
            InitializeDataGrid();

        }

        private void Form6_Lista_Geral_Load(object sender, EventArgs e)
        {
            InitializeDataGrid();
        }

        private void InitializeDataGrid ()
        {
            try
            {
                string date = DateTime.Now.Date.ToString("yyyy-MM-dd");
                Bd.setBD_Open();
                DataTable datatable_dos_pacotes_registrados_no_dia = Bd.setDataTable_pacotes(loja.getIdLoja());
                dataGridView1.DataSource = datatable_dos_pacotes_registrados_no_dia;
            }
            catch
            {
                MessageBox.Show("Houve um erro no carregamento dos pacotes registrados.\nVerifique sua conexão com a internete e abra a janela novamente.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Bd.setBD_Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataBusca = dateTimePicker1.Value;
            string data = dataBusca.Date.ToString("yyyy-MM-dd");
            string ordem = "";

            if (radioButton1.Checked)
            {
                ordem = "ORDER BY t.nome ASC;";
            }
            else if (radioButton2.Checked)
            {
                ordem = "ORDER BY p.situacao_pacote;";
            }
            else if (radioButton3.Checked)
            {
                ordem = "ORDER BY h.chegada_hora ASC;";
            }

            try
            {
                Bd.setBD_Open();
                dataGridView1.DataSource = Bd.setDataTable_pacotesPorOrdem(data, ordem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Bd.setBD_Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                if (selectedRow != null)
                {
                    notaFiscal = selectedRow.Cells["Nota Fiscal"].Value.ToString();
                    funcionario = selectedRow.Cells["Funcionário"].Value.ToString();
                    situacao = selectedRow.Cells["Situação"].Value.ToString();
                    nomeTitular = selectedRow.Cells["Titular"].Value.ToString();
                    telefoneTitular = selectedRow.Cells["Telefone"].Value.ToString();
                    emailTitular = selectedRow.Cells["Email"].Value.ToString();
                    cpfTitular = selectedRow.Cells["CPF Titular"].Value.ToString();
                    nomeEntregador = selectedRow.Cells["Entregador"].Value.ToString();
                    cpfEntregador = selectedRow.Cells["CPF Entregador"].Value.ToString();
                    dataChegada = selectedRow.Cells["Data de Chegada"].Value.ToString();
                    horaChegada = selectedRow.Cells["Hora de Chegada"].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Nenhum valor na linha selecionada!", "Seleção inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
               
                if (selectedRow != null)
                {
                    notaFiscal = selectedRow.Cells["Nota Fiscal"].Value.ToString();
                    funcionario = selectedRow.Cells["Funcionário"].Value.ToString();
                    situacao = selectedRow.Cells["Situação"].Value.ToString();
                    nomeTitular = selectedRow.Cells["Titular"].Value.ToString();
                    telefoneTitular = selectedRow.Cells["Telefone"].Value.ToString();
                    emailTitular = selectedRow.Cells["Email"].Value.ToString();
                    cpfTitular = selectedRow.Cells["CPF Titular"].Value.ToString();
                    nomeEntregador = selectedRow.Cells["Entregador"].Value.ToString();
                    cpfEntregador = selectedRow.Cells["CPF Entregador"].Value.ToString();
                    dataChegada = selectedRow.Cells["Data de Chegada"].Value.ToString();
                    horaChegada = selectedRow.Cells["Hora de Chegada"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Nenhum valor na linha selecionada!", "Seleção inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
