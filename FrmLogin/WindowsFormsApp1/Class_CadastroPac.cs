﻿using Microsoft.Win32;
using MySql.Data.MySqlClient;
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
        string funcionario, titular, situacao, email, notaFiscal, telefone, CPF, cpf_entregador, nome_entregador, cpf_titular_buscar, nota_fiscal_buscar;

        public Class_CadastroPac()
        {
            funcionario = null;
            titular = null;
            situacao = null;
            email = null;
            telefone = null;
            CPF = null;
            cpf_entregador = null;
            nome_entregador = null;
            //string para validar buscar:
            cpf_titular_buscar = null;
            nota_fiscal_buscar = null;
        }
        // set para validação de dados.
        public bool setValid_dados(string funcionario_txt, string titular_txt, string situacao_txt, string email_txt, string notaFiscal_txt, string telefone_txt, string cpf_txt, string cpf_entregador_txt, string nome_entregador_txt)
        {
            bool EntradaFuncionario = true; //Regex.IsMatch(funcionario_txt, "^[a-zA-ZÀ-ú ]+$");
            
             //int.TryParse(notaFiscal_txt, out int valid_notaFiscal);

            bool EntradaTitular = true; //Regex.IsMatch(titular_txt, "^[a-zA-ZÀ-ú ]+$");

            bool EntradaCpf = true; //long.TryParse(cpf_txt, out long valid_cpf);
        
            bool EntradaTelefone = true; //long.TryParse(telefone_txt, out long valid_telefone);

            bool EntradaCpfEntregador = true;

            bool EntradaNomeEntregador = true;



            if (EntradaFuncionario == false)
            {
                MessageBox.Show("Insira apenas letras no campo Funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            if (EntradaTelefone == false)
            {
                MessageBox.Show("Insira apenas numeros no campo Telefone.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (EntradaCpfEntregador == false)
            {
                MessageBox.Show("Insira apenas números no campo CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (EntradaNomeEntregador == false)
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
            telefone = telefone_txt; //valid_telefone.ToString();
            CPF = cpf_txt; //valid_cpf.ToString();
            nome_entregador = nome_entregador_txt;
            cpf_entregador = cpf_entregador_txt;

            return true;
        }
        // sets a baixo para válidar a busca de CPF titular ou Nota fiscal do pacote:
        public bool setValid_cpf_buscar(string cpf)
        {
            bool cpf_titular_buscar = true;

            if (cpf_titular_buscar == false)
            {
                MessageBox.Show("Insira apenas números no campo CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            this.cpf_titular_buscar = cpf;
            return true;
        }

        public bool setValid_nf_buscar(string nf)
        {
            bool nota_fiscal_buscar = true;

            if (nota_fiscal_buscar == false)
            {
                MessageBox.Show("Insira apenas números no campo nota fiscal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            this.nota_fiscal_buscar = nf;
            return true;
        }
        public bool validarTelefone(string telefone)
        {

            if (!Regex.IsMatch(telefone, @"\(\d{2}\) \d{5}-\d{4}"))
            {
                MessageBox.Show("Insira o telefone completo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public bool validCPF(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
            {
                return false;
            }

            bool cpfTodosDigitosIguais = Enumerable.Range(1, 9).All(i => cpf[i] == cpf[0]);
            if (cpfTodosDigitosIguais)
            {
                return false;
            }

            int[] multiplicadoresPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadoresSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * multiplicadoresPrimeiroDigito[i];
            }

            int resto = soma % 11;
            int primeiroDigitoVerificador = resto < 2 ? 0 : 11 - resto;

            if (primeiroDigitoVerificador != int.Parse(cpf[9].ToString()))
            {
                return false;
            }

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * multiplicadoresSegundoDigito[i];
            }

            resto = soma % 11;
            int segundoDigitoVerificador = resto < 2 ? 0 : 11 - resto;

            if (segundoDigitoVerificador != int.Parse(cpf[10].ToString()))
            {
                return false;
            }

            return true;
        }
        public bool IsValidEmailTitular(string email)
        {
            string emailRegular = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            if(!Regex.IsMatch(email, emailRegular))
            {
                MessageBox.Show("Insira um formato de email válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
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
        public string getCad_Cpf() { return CPF; }
        public string getCpf_entregador() { return cpf_entregador; }
        public string getNome_entregador() { return nome_entregador; }
        public string getNota_fiscal_buscar() { return nota_fiscal_buscar; }
        public string getCpf_titular_buscar() { return cpf_titular_buscar; }



    }    
}
