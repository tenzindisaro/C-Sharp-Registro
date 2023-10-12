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
        Class_Pacote envio_dadosValidados = new Class_Pacote();

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
                              
                cadastroPacote.setValid_dados(funcionario, titular, situacao, email, notaFiscal, data, telefone, CPF, hora );

                string dadosValidos_funcionario = cadastroPacote.getCad_Funcionario();
                string dadosValidos_titular = cadastroPacote.getCad_Titular();
                string dadosValidos_situacao = cadastroPacote.getCad_Situacao();
                string dadosValidos_email = cadastroPacote.getCad_Email();
                int dadosValidos_notaFiscal = cadastroPacote.getCad_NotaFiscal();
                int dadosValidos_data = cadastroPacote.getCad_Data();
                int dadosValidos_telefone = cadastroPacote.getCad_Telefone();
                int dadosValidos_CPF = cadastroPacote.getCad_Cpf();
                int dadosValidos_hora = cadastroPacote.getCad_Hora();

                envio_dadosValidados.SetCadastro(dadosValidos_funcionario, dadosValidos_titular, dadosValidos_situacao, dadosValidos_email, dadosValidos_notaFiscal, dadosValidos_data, dadosValidos_telefone, dadosValidos_CPF,
                    dadosValidos_hora);

            }
            else
            {                
                MessageBox.Show("Todos os campos de cadastro precisam ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        
    }
}
