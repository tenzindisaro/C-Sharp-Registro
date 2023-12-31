﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class CadastroUsuarios
    {
        public CadastroUsuarios ()
        {
      
        }
        private bool IsValidName(string inputName)
        {
            return string.IsNullOrWhiteSpace(inputName) || (!Regex.IsMatch(inputName, @"^[\p{L} ]+$"));
        }

        private bool IsValidCPF(string inputCPF)
        {
            return string.IsNullOrWhiteSpace(inputCPF) || (!Regex.IsMatch(inputCPF, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"));
        }

        private bool IsValidPassword(string password)
        {
            return string.IsNullOrWhiteSpace(password) || (!(password.Length >= 6 && password.Length <= 32));
        }

        private bool ArePasswordsMatching(string password, string confirmPassword)
        {
            return !string.Equals(password, confirmPassword);
        }

        private bool IsValidPhoneNumber(string inputPhoneNumber)
        {
            return string.IsNullOrWhiteSpace(inputPhoneNumber) || (!Regex.IsMatch(inputPhoneNumber, @"\(\d{2}\) \d{5}-\d{4}"));
        }

        private bool IsValidEmail(string inputEmail)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?!.*[&=_\-'<>,.])(?!.*\.\.)[^&=_\-'<>,.]+$";
            return string.IsNullOrWhiteSpace(inputEmail) || (!Regex.IsMatch(inputEmail, pattern)) && (!inputEmail.Contains("@americanas.com.br"));
        }

        private bool IsValidAddress(string inputEndereco)
        {
            return string.IsNullOrWhiteSpace(inputEndereco);
        }

        public bool ValidaCPF(string cpf)
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

        public bool checkInput(string inputEmail, string inputPassword, string inputCPF, string inputConfirmPassword, string inputName, string inputPhoneNumber, string inputEndereco)
        {


            if (IsValidAddress(inputEndereco))
            {
                MessageBox.Show("O endereço não foi preenchido!", "Endereço inválido");
                return false;
            }
            else if (IsValidName(inputName))
            {
                MessageBox.Show("O nome possui caracteres incoerentes!\nPor favor, digite novamente o nome completo.", "Nome inválido");
                return false;
            }
            else if (IsValidCPF(inputCPF) || !ValidaCPF(inputCPF))
            {
                MessageBox.Show("O CPF possui caracteres incoerentes!\nPor favor, digite novamente o CPF.", "CPF inválido");
                return false;
            }
            else if (IsValidEmail(inputEmail))
            {
                MessageBox.Show("O email inserido não está no formato correto! Digite um email válido.", "Email inválido");
                return false;
            }
            else if (IsValidPhoneNumber(inputPhoneNumber))
            {
                MessageBox.Show("O telefone inserido não está no formato correto! Digite apenas números.", "Telefone inválido");
                return false;
            }
            else if(IsValidPassword(inputPassword))
            {
                MessageBox.Show("A senha inserida não está no formato correto! Digite uma senha de 6 a 32 dígitos.", "Senha inválida");
                return false;
            }
            else if (IsValidPassword(inputConfirmPassword) || ArePasswordsMatching(inputPassword, inputConfirmPassword))
            {
                MessageBox.Show("As senhas inseridas não coincidem!", "Senha inválida");
                return false;
            }

            return true;
        }

    }
}
