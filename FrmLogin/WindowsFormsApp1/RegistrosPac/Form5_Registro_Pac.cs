using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            
            
            if (textBox_Funcionario.Text != null && textBox_NotaFiscal.Text != null && textBox_Data.Text != null && textBox_Titular.Text != null
                && textBox_CPF.Text != null && comboBox_Situacao.Text != null && textBox_Email.Text != null && textBox_Telefone.Text != null)
            {
                string funcionario = textBox_Funcionario.Text;
                int notaFiscal = int.Parse(textBox_NotaFiscal.Text);
                int data = int.Parse(textBox_Data.Text);
                string titular = textBox_Titular.Text;
                int cpf = int.Parse(textBox_CPF.Text);
                string situacao = comboBox_Situacao.Text;
                string email = textBox_Email.Text;
                int telefone = int.Parse(textBox_Telefone.Text);



                cadastro = new Class_CadastroPac( funcionario, titular, situacao, email, notaFiscal, data, telefone, cpf);

            }
            else
            {
                Console.WriteLine("fazer uma msg pra preencher campos em branco.");
            }
        }
    }
}
