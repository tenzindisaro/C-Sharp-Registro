using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
            string CPF = maskedTextBox_CPF.Text;
            string situacao = comboBox_Situacao.Text;
            string email = maskedTextBox_email.Text;
            string telefone = maskedTextBox_telefone.Text;
            string hora = maskedTextBox_Hora.Text;
            

            if (funcionario != null && notaFiscal != null && data != null && titular != null & CPF != null && situacao != null 
                && email != null && telefone != null && hora != null)
            {          
                              
                bool dadosOk = cadastroPacote.setValid_dados(funcionario, titular, situacao, email, notaFiscal, data, telefone, CPF, hora );
                
                if (dadosOk == true ) 
                {
                    //DÚVIDA EM QUESTÃO DE BOAS PRÁTICAS?
                    string dadosValidos_funcionario = cadastroPacote.getCad_Funcionario();
                    string dadosValidos_nomeTitular = cadastroPacote.getCad_Titular();
                    string dadosValidos_situacao = cadastroPacote.getCad_Situacao();
                    string dadosValidos_email = cadastroPacote.getCad_Email();
                    string dadosValidos_notaFiscal = cadastroPacote.getCad_NotaFiscal();
                    string dadosValidos_data = cadastroPacote.getCad_Data(); //precisa criar uma validação para data de eentrada e saida
                    string dadosValidos_telefone = cadastroPacote.getCad_Telefone();
                    string dadosValidos_CPF = cadastroPacote.getCad_Cpf();
                    string dadosValidos_hora = cadastroPacote.getCad_Hora(); //precisa criar uma validação para hora de eentrada e saida                  

                    try
                    {
                        Bd.setBD_Open();
                        Bd.setInputBd_titular(dadosValidos_CPF, dadosValidos_nomeTitular, dadosValidos_email, dadosValidos_telefone);
                        Bd.setInputBd_data(dadosValidos_data, dadosValidos_data);
                        Bd.setInputBd_hora(dadosValidos_hora, dadosValidos_hora);
                        Bd.setInputBd_pacote(dadosValidos_notaFiscal, dadosValidos_situacao);
                        Bd.setBD_Close();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("erro conectar dados no banco de dados." + erro);
                    }
                }
                else { return; }              

            }
            else
            {                
                MessageBox.Show("Todos os campos de cadastro precisam ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

           
        }

       
    }
}
