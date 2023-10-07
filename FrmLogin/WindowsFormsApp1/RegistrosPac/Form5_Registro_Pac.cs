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
        Class_Pacote cadastroPacote; 

        public Form5_Registro_Pac()
        {
            InitializeComponent();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            
            
            if (textBox_Funcionario.Text != null && textBox_NotaFiscal.Text != null && maskedTextBox_Data.Text != null && textBox_Titular.Text != null
                && maskedTextBox_CPF.Text != null && comboBox_Situacao.Text != null && maskedTextBox_email.Text != null && maskedTextBox_telefone.Text != null)
            {
                string funcionario = textBox_Funcionario.Text;

                if (Regex.IsMatch(funcionario, "^[a-zA-Z ]+$"))
                {
                    funcionario = textBox_Funcionario.Text;
                }
                else
                {
                    MessageBox.Show("Insira apenas letras no campo Funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string entradaNotaFiscal = textBox_NotaFiscal.Text;
                int notaFiscal;
                int.TryParse(entradaNotaFiscal, out notaFiscal);

                if (int.TryParse(entradaNotaFiscal, out notaFiscal) == false)
                {
                    MessageBox.Show("Insira apenas numeros no campo Nota Fiscal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string entradaData = maskedTextBox_Data.Text;
                int data;
                int.TryParse(entradaData, out data);
                if (int.TryParse(entradaData, out data) == false)
                {
                    Console.WriteLine("data errada");
                }
                
                string titular = textBox_Titular.Text;

                if (Regex.IsMatch(titular, "^[a-zA-Z ]+$"))
                {
                    titular = textBox_Funcionario.Text;
                }
                else
                {
                    MessageBox.Show("Insira apenas letras no campo Titular.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string entradaCPF = maskedTextBox_CPF.Text;
                int cpf;
                int.TryParse(entradaCPF, out cpf);

                if(int.TryParse(entradaCPF, out cpf) == false)
                {
                    MessageBox.Show("Insira apenas numeros no campo CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                string situacao = comboBox_Situacao.Text;           
                string email = maskedTextBox_email.Text;
                
                string entradaTelefone = maskedTextBox_telefone.Text;
                int telefone;                
                int.TryParse(entradaTelefone, out telefone);

                if(int.TryParse(entradaTelefone, out telefone) == false)
                {
                    MessageBox.Show("Insira apenas numeros no campo Telefone.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string entradaHora = maskedTextBox_Hora.Text;
                int hora;
                int.TryParse(maskedTextBox_Hora.Text, out hora);
                if(int.TryParse(maskedTextBox_Hora.Text, out hora) == false)
                {
                    MessageBox.Show("Insira apenas numeros no campo Hora.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            

                cadastroPacote = new Class_Pacote( funcionario, titular, situacao, email, notaFiscal, data, telefone, cpf, hora);

            }
            else
            {                
                MessageBox.Show("Todos os campos de cadastro precisam ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
