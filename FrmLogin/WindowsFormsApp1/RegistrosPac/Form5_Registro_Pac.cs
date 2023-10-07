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
        Class_CadastroPac cadastro; 

        public Form5_Registro_Pac()
        {
            InitializeComponent();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            
            
            if (textBox_Funcionario.Text != null && textBox_NotaFiscal.Text != null && maskedTextBox_Data.Text != null && textBox_Titular.Text != null
                && maskedTextBox_CPF.Text != null && comboBox_Situacao.Text != null && textBox_Email.Text != null && maskedTextBox_telefone.Text != null)
            {
                string funcionario = textBox_Funcionario.Text;

                if (Regex.IsMatch(funcionario, "^[a-zA-Z ]+$"))
                {
                    funcionario = textBox_Funcionario.Text;
                }
                else
                {
                    Console.WriteLine("erro campo funcionario");
                }

                string entradaNotaFiscal = textBox_NotaFiscal.Text;
                int notaFiscal;
                int.TryParse(entradaNotaFiscal, out notaFiscal);

                if (int.TryParse(entradaNotaFiscal, out notaFiscal) == false)
                {
                    Console.WriteLine("nota fiscal errada");
                }


                





                
                int data = int.Parse(maskedTextBox_Data.Text);
                string titular = textBox_Titular.Text;
                int cpf = int.Parse(maskedTextBox_CPF.Text);
                string situacao = comboBox_Situacao.Text;
                string email = textBox_Email.Text;
                int telefone = int.Parse(maskedTextBox_telefone.Text);
                int hora = int.Parse(maskedTextBox_Hora.Text);

               



                cadastro = new Class_CadastroPac( funcionario, titular, situacao, email, notaFiscal, data, telefone, cpf, hora);

            }
            else
            {
                Console.WriteLine("fazer uma msg pra preencher campos em branco.");
            }
        }
    }
}
