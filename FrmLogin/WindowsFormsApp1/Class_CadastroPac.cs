using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    internal class Class_CadastroPac
    {
        string funcionario, titular, situacao, email;
        int notaFiscal, data, telefone, CPF, hora;
        public Class_CadastroPac()
        {
            funcionario = null;
            titular = null;
            situacao = null;
            email = null;
            notaFiscal = 0;
            data = 0;
            telefone = 0;
            CPF = 0;
            hora = 0;
        }
        // set para validação de dados.
        public bool setValid_dados(string funcionario_txt, string titular_txt, string situacao_txt, string email_txt, string notaFiscal_txt, string data_txt, string telefone_txt, string cpf_txt, string hora_txt)
        {
            bool EntradaFuncionario = Regex.IsMatch(funcionario_txt, "^[a-zA-Z ]+$");
            bool EntradaNotaFiscal = int.TryParse(notaFiscal_txt, out int valid_notaFiscal);
            bool EntradaData = int.TryParse(data_txt, out int valid_data);
            bool EntradaTitular = Regex.IsMatch(titular_txt, "^[a-zA-Z ]+$");
            bool EntradaCpf = int.TryParse(cpf_txt, out int valid_cpf);
            bool EntradaHora = int.TryParse(hora_txt, out int valid_hora);
            bool EntradaTelefone = int.TryParse(telefone_txt, out int valid_telefone);



            if (EntradaFuncionario == false)
            {
                MessageBox.Show("Insira apenas letras no campo Funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (EntradaNotaFiscal == false)
            {
                MessageBox.Show("Insira apenas números no campo Nota Fiscal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (EntradaData == false)
            {
                MessageBox.Show("Insira apenas números no campo Data.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (EntradaTitular == false)
            {
                MessageBox.Show("Insira apenas letras no campo Titular.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (EntradaCpf == false)
            {
                MessageBox.Show("Insira apenas números no campo CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (EntradaHora == false)
            {
                MessageBox.Show("Insira apenas numeros no campo Hora.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (EntradaTelefone == false)
            {
                MessageBox.Show("Insira apenas numeros no campo Telefone.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // email e situação precisa pensar em validação
            funcionario = funcionario_txt;
            titular = titular_txt;
            situacao = situacao_txt;
            email = email_txt;
            notaFiscal = valid_notaFiscal;
            data = valid_data;
            telefone = valid_telefone;
            CPF = valid_cpf;
            hora = valid_hora;

            return true;
        }
        /* get para obter dados validados.
        public (string funcionario_nome, string titular_nome, string situacao, string email, int nota_fiscal, int data, int telefone, int cpf, int hora) GetValid_dados()
        {
            return (funcionario, titular, situacao, email, notaFiscal, data, telefone, CPF, hora);
        }*/
        public string getCad_Funcionario() { return funcionario; }
        public string getCad_Titular() { return titular; }
        public string getCad_Situacao() { return situacao; }
        public string getCad_Email() { return email; }
        public int getCad_NotaFiscal() { return notaFiscal; }
        public int getCad_Telefone() { return telefone; }
        public int getCad_Data() { return data; }
        public int getCad_Cpf() { return CPF; }
        public int getCad_Hora() { return hora; }

    }    
}
