﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.RegistrosPac
{
    internal partial class Form5_Registro_Pac : Form
    {
        private Class_loja loja = null;
        private Class_CadastroPac cadastroPacote = new Class_CadastroPac();
        private Class_BD_CRUD Bd = new Class_BD_CRUD();
        private string notaFiscalAntiga = "";

        public Form5_Registro_Pac(Class_loja lojaAtual)
        {
            loja = lojaAtual;
            InitializeComponent();
        }

        public Form5_Registro_Pac(Class_loja lojaAtual, string notaFiscal, string funcionario, string nome_entregador, string nome_titular, string telefone, string cpf_entregador, string email_titular, string cpf_titular, string situacao, string chegada_data, string chegada_hora)
        {
            loja = lojaAtual;
            InitializeComponent();

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

        private void InitializeDataGridView()
        {
            try
            {
                string date = DateTime.Now.Date.ToString("yyyy-MM-dd");
                Bd.setBD_Open();
                DataTable datatable_dos_pacotes_registrados_no_dia = Bd.setDataTable_pacotesDoDia(date);


                dataGridView_registro_pac.DataSource = datatable_dos_pacotes_registrados_no_dia;
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

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string hour = (DateTime.Now).ToString("HH:mm:ss");
            string date = DateTime.Now.Date.ToString("yyyy-MM-dd");
            string funcionario = comboBox_funcionario.Text;
            string notaFiscal = textBox_NotaFiscal.Text;
            string titular = textBox_Titular.Text;
            string CPF = maskedTextBox_CPF.Text;
            string situacao = maskedTextBoxSituacao.Text;
            string email = maskedTextBox_email.Text;
            string telefone = maskedTextBox_telefone.Text;
            string cpf_entregador = txtbox_cpf_entregador.Text;
            string nome_entregador = txtbox_nome_entregador.Text;

            //validações
            bool nf_existente = false;
            bool EmailFuncionario_check = false;
            bool validTelefone = false;
            bool validCpf_titular = false;
            bool validCpf_entregador = false;
            bool emailTitular_check = false;
            // Exibe a MessageBox com dois botões (OK e Cancelar)
            DialogResult result = MessageBox.Show("Deseja continuar com a operação?", "Confirmação",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica a resposta do usuário
            if (result != DialogResult.Yes)
            {

                MessageBox.Show("Operação cancelada.");
                // Coloque aqui o código que deve ser executado se o usuário escolher "Cancelar".
                return;
            }

            try
            {
                Bd.setBD_Open();
                nf_existente = Bd.setReadBd_CountPacote(notaFiscal);
                EmailFuncionario_check = Bd.setReadBd_CountEmailFuncionario(funcionario);
                validTelefone = cadastroPacote.validarTelefone(telefone);
                validCpf_titular = cadastroPacote.validCPF(CPF);
                validCpf_entregador = cadastroPacote.validCPF(cpf_entregador);

                if(validCpf_titular == false)
                {
                    MessageBox.Show("Insira CPF titular correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(validCpf_entregador == false)
                {
                    MessageBox.Show("Insira CPF entregador correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                emailTitular_check = cadastroPacote.IsValidEmailTitular(email);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro nas validações de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nf_existente = false;
                EmailFuncionario_check = false;
                validTelefone = false;
                validCpf_titular = false;
                validCpf_entregador = false;
            }
            finally
            {
                Bd.setBD_Close();
            }


            if (funcionario != "" && notaFiscal != "" && titular != "" & CPF != "" && situacao != ""
                && email != "" && telefone != "" && cpf_entregador != "" && nome_entregador != "")
            {
                
                bool dadosOk = cadastroPacote.setValid_dados(funcionario, titular, situacao, email, notaFiscal, telefone, CPF, cpf_entregador, nome_entregador);

                if (dadosOk == true && nf_existente == true && EmailFuncionario_check == true && validTelefone == true && validCpf_titular == true && validCpf_entregador == true && emailTitular_check == true)
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


                    FormValidacaoLogin formValidacaoLogin = new FormValidacaoLogin(Bd, dadosValidos_funcionario);

                    try
                    {
                        Bd.setBD_Open();
                        formValidacaoLogin.ShowDialog();
                        if (formValidacaoLogin.getValidacaoCredenciais())
                        {
                            formValidacaoLogin.Close();

                            Bd.setInputBd_hora(hour);
                            Bd.setInputBd_data(date);
                            //caso tenha o cpf titular já cadastrado:
                            if (Bd.setReadBd_CountCpfTitular(dadosValidos_CPF) == true)
                            {
                                Bd.setInputBd_titular(dadosValidos_CPF, dadosValidos_nomeTitular, dadosValidos_email, dadosValidos_telefone);
                            }
                            //caso tenha o cpf entregador já cadastrado:
                            if (Bd.setReadBd_CountCpfEntregador(dadosValidos_cpf_entregador) == true)
                            {
                                Bd.setInputBd_entregador(dadosValidos_cpf_entregador, dadosValidos_nome_entregador);
                            }
                            Bd.setInputBd_pacote(dadosValidos_notaFiscal, dadosValidos_situacao, dadosValidos_funcionario, dadosValidos_CPF, dadosValidos_cpf_entregador);
                            MessageBox.Show("Pacote cadastrado com sucesso!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Credenciais inválidas! Operação de cadastro não foi realizada.", "Operação interrompida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao conectar dados no banco de dados.\n\n" + erro, "Erro de conexão");
                    }
                    finally
                    {
                        Bd.setBD_Close();
                        InitializeDataGridView();

                    }
                }
                else { return; }

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
            string CPF = maskedTextBox_CPF.Text;
            string situacao = maskedTextBoxSituacao.Text;
            string email = maskedTextBox_email.Text;
            string telefone = maskedTextBox_telefone.Text;
            string cpf_entregador = txtbox_cpf_entregador.Text;
            string nome_entregador = txtbox_nome_entregador.Text;
            int id_data = Bd.getRetorna_id_data();
            int id_hora = Bd.getRetorna_id_hora();

            // Exibe a MessageBox com dois botões (OK e Cancelar)
            DialogResult result = MessageBox.Show("Deseja continuar com a operação?", "Confirmação",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica a resposta do usuário
            if (result != DialogResult.Yes)
            {

                MessageBox.Show("Operação cancelada.");
                // Coloque aqui o código que deve ser executado se o usuário escolher "Cancelar".
                return;
            }

            if (funcionario != "" && notaFiscal != "" && titular != "" & CPF != "" && situacao != ""
                && email != "" && telefone != "" && cpf_entregador != "" && nome_entregador != "")
            {
                FormValidacaoLogin formValidacaoLogin = new FormValidacaoLogin(Bd, funcionario);

                try
                {
                    Bd.setBD_Open();
                    formValidacaoLogin.ShowDialog();
                    if (formValidacaoLogin.getValidacaoCredenciais())
                    {
                        formValidacaoLogin.Close();

                        Bd.setDelet_pacote(notaFiscal);
                        MessageBox.Show("Pacote excluído com sucesso!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Credenciais inválidas! Operação de remoção não foi realizada.", "Operação interrompida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (CPF != "")      //Não está funcionando a validação de campo preenchido, é por causa da máscara!!!!!
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
                            DataTable pacotes_buscados = Bd.setRead_buscarRegistroPac();
                            dataGridView_registro_pac.DataSource = pacotes_buscados;
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
                }
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

                            DataTable dataTable = new DataTable();
                            DataRow newRow;
                            //Crie as colunas do DataTable
                            dataTable.Columns.Clear();
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
                            dataGridView_registro_pac.DataSource = dataTable;
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
                    
                }
                else
                { MessageBox.Show("Nota Fiscal vazio em opções do buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            else { MessageBox.Show("Selecione uma das opções do buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return; }

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

            // Exibe a MessageBox com dois botões (OK e Cancelar)
            DialogResult result = MessageBox.Show("Deseja continuar com a operação?", "Confirmação",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica a resposta do usuário
            if (result != DialogResult.Yes)
            {

                MessageBox.Show("Operação cancelada.");
                // Coloque aqui o código que deve ser executado se o usuário escolher "Cancelar".
                return;
            }


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

                    FormValidacaoLogin formValidacaoLogin = new FormValidacaoLogin(Bd, dadosValidos_funcionario);

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
                                Bd.setEdit_titular(dadosValidos_CPF, dadosValidos_nomeTitular, dadosValidos_email, dadosValidos_telefone, dadosValidos_notaFiscal);
                            }
                            else
                            {
                                Bd.setInputBd_titular(dadosValidos_CPF, dadosValidos_nomeTitular, dadosValidos_email, dadosValidos_telefone);
                            }

                            if (pesquisaEntregador != null)
                            {
                                Bd.setEdit_entregador(dadosValidos_cpf_entregador, dadosValidos_nome_entregador, dadosValidos_notaFiscal);
                            }
                            else
                            {
                                Bd.setInputBd_entregador(dadosValidos_cpf_entregador, dadosValidos_nome_entregador);
                            }

                            Bd.setEdit_pacote(notaFiscalAntiga, dadosValidos_notaFiscal, dadosValidos_situacao, dadosValidos_funcionario, dadosValidos_CPF, dadosValidos_cpf_entregador);
                            MessageBox.Show("Informações do Pacote alteradas com sucesso!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Credenciais inválidas! Operação de edição não foi realizada.", "Operação interrompida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

       
        private void Form5_Registro_Pac_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            InitializeDataGridView();
            dataGridView_registro_pac.ClearSelection();

            comboBox_funcionario.Text = "";
            textBox_NotaFiscal.Text = "";
            textBox_Titular.Text = "";
            maskedTextBox_CPF.Text = "";
            maskedTextBoxSituacao.Text = "";
            maskedTextBox_email.Text = "";
            maskedTextBox_telefone.Text = "";
            txtbox_cpf_entregador.Text = "";
            txtbox_nome_entregador.Text = "";

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
            catch
            {
                MessageBox.Show("Houve um erro durante o carregamento de fucionários", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Bd.setBD_Close();

            }


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

        private void dataGridView_registro_pac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_registro_pac.Rows[e.RowIndex];
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

        private void dataGridView_registro_pac_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_registro_pac.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_registro_pac.SelectedRows[0];
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

        private void button1_Click(object sender, EventArgs e)
        {
            //variáveis do pacote selecionado
            string notaFiscal, funcionario, situacao, nomeTitular, telefoneTitular, emailTitular, nomeEntregador, cpfTitular, dataChegada, horaChegada;

            notaFiscal = textBox_NotaFiscal.Text;
            funcionario = comboBox_funcionario.Text;
            situacao = maskedTextBoxSituacao.Text;
            nomeTitular = textBox_Titular.Text;
            telefoneTitular = maskedTextBox_telefone.Text;
            emailTitular = maskedTextBox_email.Text;
            nomeEntregador = txtbox_nome_entregador.Text;
            cpfTitular = maskedTextBox_CPF.Text;
            dataChegada = textBox_data.Text;
            horaChegada = textBox_hora.Text;

            //gerar o relatório aqui

            string pastaDeSaida = Application.StartupPath;
            string caminhoRelatorioFrx = Path.Combine(pastaDeSaida, "tempRelatorioChegada.frx");
            // Diálogo para seleção do local de salvamento
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Salvar Relatório PDF";
            saveFileDialog.FileName = "Relatório"; // Nome padrão do arquivo
            saveFileDialog.InitialDirectory = @"C:\"; // Diretório inicial

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoPDF = saveFileDialog.FileName;

                PdfGenerator pdfGenerator = new PdfGenerator();
                pdfGenerator.RelatorioChegada(caminhoRelatorioFrx, caminhoPDF, notaFiscal, funcionario, situacao,nomeTitular , telefoneTitular, emailTitular, cpfTitular, dataChegada, horaChegada);
            }
        }
    }
}
