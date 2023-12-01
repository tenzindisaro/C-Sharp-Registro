using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal partial class FormRetirarPac : Form
    {
        private Class_BD_CRUD Bd = new Class_BD_CRUD();
        private Class_CadastroPac cadastroPacote = new Class_CadastroPac();
        private string notaFiscalAntiga = "";
        private Class_loja loja;
        public FormRetirarPac(Class_loja lojaAtual)
        {
            loja = lojaAtual;
            InitializeComponent();
        }
        
        public FormRetirarPac(Class_loja lojaAtual, string notaFiscal, string funcionario, string nome_entregador, string nome_titular, string telefone, string cpf_entregador, string email_titular, string cpf_titular, string situacao, string chegada_data, string chegada_hora)
        {
            InitializeComponent();

            loja = lojaAtual;
            textBox_NotaFiscal.Text = notaFiscal;
            comboBox_funcionario.Text = funcionario;
            txtbox_nome_entregador.Text = nome_entregador;
            textBox_Titular.Text = nome_titular;
            maskedTextBox_telefone.Text = telefone;
            txtbox_cpf_entregador.Text = cpf_entregador;
            maskedTextBox_email.Text = email_titular;
            maskedTextBox_CPF.Text = cpf_entregador;
            maskedTextBoxSituacao.Text = situacao;
            textBox_data.Text = chegada_data;
            textBox_hora.Text = chegada_data;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string notaFiscal, funcionario, situacao, nomeTitular, telefoneTitular, emailTitular, nomeEntregador, cpfEntregador, dataChegada, horaChegada, dataRetirada, horaRetirada;

            notaFiscal = textBox_NotaFiscal.Text;
            funcionario = comboBox_funcionario.Text;
            situacao = maskedTextBoxSituacao.Text;
            nomeTitular = textBox_Titular.Text;
            telefoneTitular = maskedTextBox_telefone.Text;
            emailTitular = maskedTextBox_email.Text;
            nomeEntregador = txtbox_nome_entregador.Text;
            cpfEntregador = txtbox_cpf_entregador.Text;
            dataChegada = textBox_data.Text;
            horaChegada = textBox_hora.Text;
            
            if (situacao != "Retirado")
            {
                horaRetirada = DateTime.Now.ToString("HH:mm:ss");
                dataRetirada = DateTime.Now.Date.ToString("yyyy-MM-dd");

                FormValidacaoLogin formValidacaoLogin = new FormValidacaoLogin(Bd);

                try
                {
                    Bd.setBD_Open();
                    formValidacaoLogin.ShowDialog();
                    if (formValidacaoLogin.getValidacaoCredenciais())
                    {
                        formValidacaoLogin.Close();

                        Bd.setEdit_Retirada(notaFiscal, dataRetirada, horaRetirada);
                        MessageBox.Show("Pacote Retirado com sucesso!", "Operação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Credenciais inválidas! Operação de edição não realizada!", "Operação interrompida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possível retirar o pacote!\nVerifique sua conexão com a internete e tente novamente.", "Erro de Retirada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    Bd.setBD_Close();
                    InitializeDataGridView();
                }
            }
            else
            {
                MessageBox.Show("O pacote selecionado já foi retirado");
            }
        }

        private void InitializeDataGridView()
        {
            try
            {
                Bd.setBD_Open();
                DataTable datatable_dos_pacotes_retirados_no_dia = Bd.setDataTable_pacotes_presentes();
                dataGridView_retirada_pac.DataSource = datatable_dos_pacotes_retirados_no_dia;
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar os pacotes registrador!\nPor favor, verifique sua conexão com a internete.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Bd.setBD_Close();
            }
        }

        private void FormRetirarPac_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            string id = loja.getIdLoja();
            List<string> emails;

            try
            {
                Bd.setBD_Open();
                emails = Bd.setRead_email_funcionarios_id(id);

                comboBox_funcionario.Items.Clear();

                foreach (string email in emails)
                {
                    comboBox_funcionario.Items.Add(email);
                }
            }
            catch (Exception er)
            {
                //MessageBox.Show("Houve um erro durante o carregamento de fucionários", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(er.Message);
            }
            finally
            {
                Bd.setBD_Close();

            }
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            string funcionario = comboBox_funcionario.Text;
            string notaFiscal = textBox_NotaFiscal.Text;
            string titular = textBox_Titular.Text;
            string CPF = maskedTextBox_CPF.Text;
            string situacao = maskedTextBoxSituacao.Text;
            string email = maskedTextBox_email.Text;
            string telefone = maskedTextBox_telefone.Text;
            string cpf_entregador = txtbox_cpf_entregador.Text;
            string nome_entregador = txtbox_nome_entregador.Text;


            if (funcionario != "" && notaFiscal != "" && titular != "" & CPF != "" && situacao != ""
                && email != "" && telefone != "" && cpf_entregador != "" && nome_entregador != "")
            {

                bool dadosOk = cadastroPacote.setValid_dados(funcionario, titular, situacao, email, notaFiscal, telefone, CPF, cpf_entregador, nome_entregador);

                if (dadosOk == true)
                {
                    string dadosValidos_funcionario = cadastroPacote.getCad_Funcionario();
                    string dadosValidos_nomeTitular = cadastroPacote.getCad_Titular();
                    string dadosValidos_situacao = cadastroPacote.getCad_Situacao();
                    string dadosValidos_email = cadastroPacote.getCad_Email();
                    string dadosValidos_notaFiscal = cadastroPacote.getCad_NotaFiscal();
                    string dadosValidos_telefone = cadastroPacote.getCad_Telefone();
                    string dadosValidos_CPF = cadastroPacote.getCad_Cpf();
                    string dadosValidos_cpf_entregador = cadastroPacote.getCpf_entregador();
                    string dadosValidos_nome_entregador = cadastroPacote.getNome_entregador();

                    FormValidacaoLogin formValidacaoLogin = new FormValidacaoLogin(Bd);

                    try
                    {
                        Bd.setBD_Open();
                        formValidacaoLogin.ShowDialog();
                        if (formValidacaoLogin.getValidacaoCredenciais())
                        {
                            formValidacaoLogin.Close();

                            string pesquisaTitular = Bd.setRead_titular_ByCpf(dadosValidos_CPF);
                            string pesquisaEntregador = Bd.setRead_entregador_ByCpf(dadosValidos_cpf_entregador);
                            
                            if (pesquisaTitular != null)
                            {
                                Bd.setEdit_titular(dadosValidos_CPF, dadosValidos_nomeTitular, dadosValidos_email, dadosValidos_telefone);
                            }
                            else
                            {
                                Bd.setInputBd_titular(dadosValidos_CPF, dadosValidos_nomeTitular, dadosValidos_email, dadosValidos_telefone);
                            }

                            if (pesquisaEntregador != null)
                            {
                                Bd.setEdit_entregador(dadosValidos_cpf_entregador, dadosValidos_nome_entregador);
                            }
                            else
                            {
                                Bd.setInputBd_entregador(dadosValidos_cpf_entregador, dadosValidos_nome_entregador);
                            }

                            Bd.setEdit_pacote(notaFiscalAntiga, dadosValidos_notaFiscal, dadosValidos_situacao, dadosValidos_funcionario, dadosValidos_CPF, dadosValidos_cpf_entregador);
                            MessageBox.Show("Pacote Editado com sucesso!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Credenciais inválidas! Operação de edição não realizada", "Operação interrompida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao editar dados no banco de dados.\n\n" + erro, "Erro de conexão");
                    }
                    finally
                    {
                        Bd.setBD_Close();
                        InitializeDataGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos os campos de cadastro precisam ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            string funcionario = comboBox_funcionario.Text;
            string notaFiscal = textBox_NotaFiscal.Text;
            string titular = textBox_Titular.Text;
            string CPF = (maskedTextBox_CPF.Text).Replace("-", "").Replace(".", "");
            string situacao = maskedTextBoxSituacao.Text;
            string email = maskedTextBox_email.Text;
            string telefone = maskedTextBox_telefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string cpf_entregador = txtbox_cpf_entregador.Text;
            string nome_entregador = txtbox_nome_entregador.Text;
            int id_data = Bd.getRetorna_id_data();
            int id_hora = Bd.getRetorna_id_hora();



            if (funcionario != "" && notaFiscal != "" && titular != "" & CPF != "" && situacao != ""
                && email != "" && telefone != "" && cpf_entregador != "" && nome_entregador != "")
            {
                FormValidacaoLogin formValidacaoLogin = new FormValidacaoLogin(Bd);

                try
                {
                    Bd.setBD_Open();
                    formValidacaoLogin.ShowDialog();
                    if (formValidacaoLogin.getValidacaoCredenciais())
                    {
                        formValidacaoLogin.Close();

                        Bd.setDelet_pacote(notaFiscal);
                        Bd.setDelet_data(id_data);
                        Bd.setDelet_hora(id_hora);
                        Bd.setDelet_entregador(cpf_entregador);
                        Bd.setDelet_titular(CPF);

                        MessageBox.Show("Pacote excluído com sucesso!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Credenciais inválidas! Operação de remoção não realizada", "Operação interrompida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao deletar dados do pacote no banco de dados.\n\n" + erro, "Erro de conexão");
                }
                finally
                {
                    Bd.setBD_Close();
                    InitializeDataGridView();
                }

            }
            else
            {
                MessageBox.Show("Todos os campos de cadastro precisam estar corretos para localizar e deletar o pacote.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //variáveis do pacote selecionado
            string funcionario = comboBox_funcionario.Text;
            string notaFiscal = textBox_NotaFiscal.Text;
            string titular = textBox_Titular.Text;
            string CPF = (maskedTextBox_CPF.Text).Replace("-", "").Replace(".", "");
            string situacao = maskedTextBoxSituacao.Text;
            string email = maskedTextBox_email.Text;
            string telefone = maskedTextBox_telefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string cpf_entregador = txtbox_cpf_entregador.Text;
            string nome_entregador = txtbox_nome_entregador.Text;
            int id_data = Bd.getRetorna_id_data();
            int id_hora = Bd.getRetorna_id_hora();

            //gerar o relatório aqui
        }

        private void dataGridView_retirada_pac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_retirada_pac.Rows[e.RowIndex];
                string notaFiscal, funcionario, situacao, nomeTitular, telefoneTitular, emailTitular, cpfTitular, nomeEntregador, cpfEntregador, dataChegada, horaChegada;

                if (selectedRow != null)
                {
                    notaFiscal = selectedRow.Cells["Nota Fiscal"].Value.ToString();
                    notaFiscalAntiga = notaFiscal;
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

                    textBox_NotaFiscal.Text = notaFiscal;
                    comboBox_funcionario.Text = funcionario;
                    maskedTextBoxSituacao.Text = situacao;
                    textBox_Titular.Text = nomeTitular;
                    maskedTextBox_telefone.Text = telefoneTitular;
                    maskedTextBox_email.Text = emailTitular;
                    maskedTextBox_CPF.Text = cpfTitular;
                    txtbox_nome_entregador.Text = nomeEntregador;
                    txtbox_cpf_entregador.Text = cpfEntregador;
                    textBox_data.Text = dataChegada;
                    textBox_hora.Text = horaChegada;

                }
                else
                {
                    MessageBox.Show("Nenhum valor na linha selecionada!", "Seleção inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView_retirada_pac_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_retirada_pac.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_retirada_pac.SelectedRows[0];
                string notaFiscal, funcionario, situacao, nomeTitular, telefoneTitular, emailTitular, cpfTitular, nomeEntregador, cpfEntregador, dataChegada, horaChegada;


                if (selectedRow != null)
                {
                    notaFiscal = selectedRow.Cells["Nota Fiscal"].Value.ToString();
                    notaFiscalAntiga = notaFiscal;
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

                    textBox_NotaFiscal.Text = notaFiscal;
                    comboBox_funcionario.Text = funcionario;
                    maskedTextBoxSituacao.Text = situacao;
                    textBox_Titular.Text = nomeTitular;
                    maskedTextBox_telefone.Text = telefoneTitular;
                    maskedTextBox_email.Text = emailTitular;
                    maskedTextBox_CPF.Text = cpfTitular;
                    txtbox_nome_entregador.Text = nomeEntregador;
                    txtbox_cpf_entregador.Text = cpfEntregador;
                    textBox_data.Text = dataChegada;
                    textBox_hora.Text = horaChegada;

                }
                else
                {
                    MessageBox.Show("Nenhum valor na linha selecionada!", "Seleção inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_Buscar_Click(object sender, EventArgs e)
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
                    else { MessageBox.Show("CPF inserido na busca é inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                }
                else
                { MessageBox.Show("Campo de busca não preenchido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
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
                    else { MessageBox.Show("Nota ficasl inserida na busca é inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
                }
                else
                { MessageBox.Show("Campo de busca não preenchido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            else { MessageBox.Show("Selecione uma das opções do buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return; }
            
            DataTable dataTable = new DataTable();
            DataRow newRow;

            //recebendo dados para enviar pros text box nos form registro pacote
            textBox_NotaFiscal.Text = Bd.getRetorna_nf();
            comboBox_funcionario.Text = Bd.getRetorna_emailFuncionario();
            txtbox_nome_entregador.Text = Bd.getRetorna_nome_entregador();
            textBox_Titular.Text = Bd.getNome_titular();
            maskedTextBox_telefone.Text = Bd.getTelefone_titular();
            txtbox_cpf_entregador.Text = Bd.getRetorna_cpf_entregador();
            maskedTextBox_email.Text = Bd.getEmail_titular();
            maskedTextBox_CPF.Text = Bd.getRetorna_cpf_titular();
            maskedTextBoxSituacao.Text = Bd.getRetorna_situacao();
            textBox_data.Text = Bd.getRetorna_chegada_data();
            textBox_hora.Text = Bd.getRetorna_chegada_hora();//Bd.getRetorna_id_hora().ToString();//Bd.getRetorna_chegada_hora();

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
            dataGridView_retirada_pac.DataSource = dataTable;
        }

        private void rdb_NotaFiscal_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_buscar.Visible = true;
            txtBox_buscar_cpf.Visible = false;
        }

        private void rdb_Titular_cpf_CheckedChanged(object sender, EventArgs e)
        {
            txtBox_buscar.Visible = false;
            txtBox_buscar_cpf.Visible = true;
        }
    }
}

