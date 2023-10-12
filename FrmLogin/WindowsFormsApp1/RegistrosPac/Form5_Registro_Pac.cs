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
        Class_CadastroPac cadastroPacote; 

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
                


               
                cadastroPacote = new Class_CadastroPac(funcionario, notaFiscal, data, titular, CPF, situacao, email, telefone, hora );                 

            }
            else
            {                
                MessageBox.Show("Todos os campos de cadastro precisam ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        
    }
}
