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

namespace WindowsFormsApp1.RegistrosPac
{
    public partial class Form5_Registro_Pac : Form
    {
        Class_CadastroPac cadastroPacote = new Class_CadastroPac();
        Class_BD_CRUD Bd = new Class_BD_CRUD();

        public Form5_Registro_Pac()
        {
            InitializeComponent();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string funcionario = textBox_Funcionario.Text;
            string notaFiscal = textBox_NotaFiscal.Text;
            string data = maskedTextBox_Data.Text;
            string titular = textBox_Titular.Text;
            string CPF = (maskedTextBox_CPF.Text).Replace("-", "").Replace(".", "");
            string situacao = comboBox_Situacao.Text;
            string email = maskedTextBox_email.Text;
            string telefone = maskedTextBox_telefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string hora = maskedTextBox_Hora.Text;


            if (funcionario != "" && notaFiscal != "" && data != "" && titular != "" & CPF != "" && situacao != ""
                && email != "" && telefone != "" && hora != "")
            {

                bool dadosOk = cadastroPacote.setValid_dados(funcionario, titular, situacao, email, notaFiscal, data, telefone, CPF, hora);

                if (dadosOk == true)
                {
                    //DÚVIDA EM QUESTÃO DE BOAS PRÁTICAS?
                    string dadosValidos_funcionario = cadastroPacote.getCad_Funcionario();
                    string dadosValidos_nomeTitular = cadastroPacote.getCad_Titular();
                    string dadosValidos_situacao = cadastroPacote.getCad_Situacao();
                    string dadosValidos_email = cadastroPacote.getCad_Email();
                    string dadosValidos_notaFiscal = cadastroPacote.getCad_NotaFiscal();
                    string dadosValidos_data = cadastroPacote.getCad_Data(); //precisa criar uma validação para data de entrada e saida
                    string dadosValidos_telefone = cadastroPacote.getCad_Telefone();
                    string dadosValidos_CPF = cadastroPacote.getCad_Cpf();
                    string dadosValidos_hora = cadastroPacote.getCad_Hora(); //precisa criar uma validação para hora de entrada e saida                  
                    string funcionario_atual = "funcionario@americanas.com.br";
                    string cpf_entregador = "15";

                    try
                    {
                        Bd.setBD_Open();
                        Bd.setInputBd_titular(dadosValidos_CPF, dadosValidos_nomeTitular, dadosValidos_email, dadosValidos_telefone);
                        Bd.setInputBd_data(dadosValidos_data, dadosValidos_data);
                        Bd.setInputBd_hora(dadosValidos_hora, dadosValidos_hora);
                        Bd.setInputBd_pacote(dadosValidos_notaFiscal, dadosValidos_situacao, funcionario_atual, dadosValidos_CPF, cpf_entregador);
                        Bd.setBD_Close();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao conectar dados no banco de dados.\n\n" + erro, "Erro de conexão");
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
            string funcionario = textBox_Funcionario.Text;
            string notaFiscal = textBox_NotaFiscal.Text;
            string data = maskedTextBox_Data.Text;
            string titular = textBox_Titular.Text;
            string CPF = (maskedTextBox_CPF.Text).Replace("-", "").Replace(".", "");
            string situacao = comboBox_Situacao.Text;
            string email = maskedTextBox_email.Text;
            string telefone = maskedTextBox_telefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string hora = maskedTextBox_Hora.Text;


            MySqlConnection conn = new MySqlConnection("server=containers-us-west-156.railway.app;port=6863;User Id=root;database=railway;password=uoNk5WCFgcxKJ1AjalxJ");
                conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELET FROM pacote WHERE nota_fiscal_pacote = ?", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@nota_fiscal_pacote", MySqlDbType.VarChar, 45).Value = notaFiscal;

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBox_buscar.Text;

            MySqlConnection conn = new MySqlConnection("server=containers-us-west-156.railway.app;port=6863;User Id=root;database=railway;password=uoNk5WCFgcxKJ1AjalxJ");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT cpf_titular, nome, email, telefone  FROM titular WHERE cpf_titular = ?", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = buscar;
            
            cmd.CommandType = CommandType.Text;

            //recebe conteudo do banco
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            textBox_Funcionario.Text = dr.GetString(1);

            conn.Close();
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            string funcionario = textBox_Funcionario.Text;
            string notaFiscal = textBox_NotaFiscal.Text;
            string data = maskedTextBox_Data.Text;
            string titular = textBox_Titular.Text;
            string CPF = (maskedTextBox_CPF.Text).Replace("-", "").Replace(".", "");
            string situacao = comboBox_Situacao.Text;
            string email = maskedTextBox_email.Text;
            string telefone = maskedTextBox_telefone.Text.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            string hora = maskedTextBox_Hora.Text;

            MySqlConnection conn = new MySqlConnection("server=containers-us-west-156.railway.app;port=6863;User Id=root;database=railway;password=uoNk5WCFgcxKJ1AjalxJ");
            conn.Open();
            MySqlCommand objEdit = new MySqlCommand("UPDATE *tabela SET *coluna=? WHERE *indice = ?", conn);
            objEdit.Parameters.Clear();
            objEdit.Parameters.Add("@nota_fiscal_pacote", MySqlDbType.VarChar, 45).Value = notaFiscal;

            objEdit.CommandType = CommandType.Text;
            objEdit.ExecuteNonQuery();
            conn.Close();
        }

        private void Form5_Registro_Pac_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
