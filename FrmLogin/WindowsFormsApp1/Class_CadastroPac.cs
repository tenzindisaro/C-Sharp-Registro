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
        string funcionario, titular, situacao, email, notaFiscal, data, telefone, CPF, hora, cpf_entregador, nome_entregador;

        public Class_CadastroPac()
        {
            funcionario = null;
            titular = null;
            situacao = null;
            email = null;
            notaFiscal = null;
            data = null;
            telefone = null;
            CPF = null;
            hora = null;
            cpf_entregador = null;
            nome_entregador = null;

        }
        // set para validação de dados.
        public bool setValid_dados(string funcionario_txt, string titular_txt, string situacao_txt, string email_txt, string notaFiscal_txt, string data_txt, string telefone_txt, string cpf_txt, string hora_txt, string cpf_entregador_txt, string nome_entregador_txt)
        {
            bool EntradaFuncionario = true; //Regex.IsMatch(funcionario_txt, "^[a-zA-ZÀ-ú ]+$");
            
            bool EntradaNotaFiscal = true; //int.TryParse(notaFiscal_txt, out int valid_notaFiscal);

            bool EntradaData = true; //Regex.IsMatch(data_txt, @"^\d{2}/\d{2}/\d{4}$");

            bool EntradaTitular = true; //Regex.IsMatch(titular_txt, "^[a-zA-ZÀ-ú ]+$");

            bool EntradaCpf = true; //long.TryParse(cpf_txt, out long valid_cpf);

            bool EntradaHora = true; //Regex.IsMatch(hora_txt, @"^\d{2}:\d{2}$");

            bool EntradaTelefone = true; //long.TryParse(telefone_txt, out long valid_telefone);

            bool EntredaCpfEntregador = true;

            bool EntradaNomeEntregador = true;


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
            notaFiscal = notaFiscal_txt; //valid_notaFiscal.ToString();
            data = data_txt;
            telefone = telefone_txt; //valid_telefone.ToString();
            CPF = cpf_txt; //valid_cpf.ToString();
            hora = hora_txt;
            nome_entregador = nome_entregador_txt;
            cpf_entregador = cpf_entregador_txt;

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
        public string getCad_NotaFiscal() { return notaFiscal; }
        public string getCad_Telefone() { return telefone; }
        public string getCad_Data() { return data; }
        public string getCad_Cpf() { return CPF; }
        public string getCad_Hora() { return hora; }
        public string getCpf_entregador() { return cpf_entregador; }
        public string getNome_entregador() { return nome_entregador; }



    }    
}
