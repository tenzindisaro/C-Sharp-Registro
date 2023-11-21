using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.RegistrosPac
{
    internal partial class Form5_Registro_Pac : Form
    {
        private User usuario;
        Class_CadastroPac cadastroPacote = new Class_CadastroPac();
        Class_BD_CRUD Bd = new Class_BD_CRUD();
        private DataTable dataTable = new DataTable();
        DataRow newRow;
        public Form5_Registro_Pac(User usuarioAtual)
        {
            usuario = usuarioAtual;
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            string date = DateTime.Now.Date.ToString("yyyy-MM-dd");
            Bd.setBD_Open();
            DataTable datatable_dos_pacotes_registrados_no_dia = Bd.setDataTable_pacotesDoDia(date);

            
            dataGridView_registro_pac.DataSource = datatable_dos_pacotes_registrados_no_dia;
            Bd.setBD_Close();
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


                    try
                    {
                        Bd.setBD_Open();
                        Bd.setInputBd_hora(hour);
                        Bd.setInputBd_data(date);
                        Bd.setInputBd_titular(dadosValidos_CPF, dadosValidos_nomeTitular, dadosValidos_email, dadosValidos_telefone);
                        Bd.setInputBd_entregador(dadosValidos_cpf_entregador, dadosValidos_nome_entregador);
                        Bd.setInputBd_pacote(dadosValidos_notaFiscal, dadosValidos_situacao, dadosValidos_funcionario, dadosValidos_CPF, dadosValidos_cpf_entregador);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao conectar dados no banco de dados.\n\n" + erro, "Erro de conexão");
                    }
                    finally
                    {
                        Bd.setBD_Close();
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
                try
                {
                    Bd.setBD_Open();
                    Bd.setDelet_pacote(notaFiscal);
                    Bd.setDelet_data(id_data);
                    Bd.setDelet_hora(id_hora);
                    Bd.setDelet_entregador(cpf_entregador);
                    Bd.setDelet_titular(CPF);
                    

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao deletar dados do pacote no banco de dados.\n\n" + erro, "Erro de conexão");
                }
                finally
                {
                    Bd.setBD_Close();
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
            newRow["Nota Fiscal"] =  Bd.getRetorna_nf();
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
                    string dadosValidos_funcionario = cadastroPacote.getCad_Funcionario();//avaliar se vai integrar realmente no cadastro do pacote
                    string dadosValidos_nomeTitular = cadastroPacote.getCad_Titular();
                    string dadosValidos_situacao = cadastroPacote.getCad_Situacao();
                    string dadosValidos_email = cadastroPacote.getCad_Email();
                    string dadosValidos_notaFiscal = cadastroPacote.getCad_NotaFiscal();
                    string dadosValidos_telefone = cadastroPacote.getCad_Telefone();
                    string dadosValidos_CPF = cadastroPacote.getCad_Cpf();
                    string dadosValidos_cpf_entregador = cadastroPacote.getCpf_entregador();
                    string dadosValidos_nome_entregador = cadastroPacote.getNome_entregador();
                    string hour = (DateTime.Now).ToString("HH:mm:ss");
                    string date = DateTime.Now.Date.ToString("yyyy-MM-dd");

                    try
                    {
                        Bd.setBD_Open();
                        Bd.setEdit_titular(dadosValidos_CPF, dadosValidos_nomeTitular, dadosValidos_email, dadosValidos_telefone);
                        Bd.setEdit_entregador(dadosValidos_cpf_entregador, dadosValidos_nome_entregador);
                        Bd.setEdit_pacote(dadosValidos_notaFiscal, dadosValidos_situacao, dadosValidos_funcionario, dadosValidos_CPF, dadosValidos_cpf_entregador);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao editar dados no banco de dados.\n\n" + erro, "Erro de conexão");
                    }
                    finally
                    {
                        Bd.setBD_Close();
                    }
                }
                else { return; }

            }
            else
            {
                MessageBox.Show("Todos os campos de cadastro precisam ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

       
        private void Form5_Registro_Pac_Load(object sender, EventArgs e)
        {
            int id = int.Parse(usuario.GetUserData(6));
            Bd.setBD_Open();
            List<string> emails = Bd.setRead_email_funcionarios_id(id);
            Bd.setBD_Close();
            
            comboBox_funcionario.Items.Clear();
            
            foreach (string email in emails)
            {
                comboBox_funcionario.Items.Add(email);
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

    }
}
