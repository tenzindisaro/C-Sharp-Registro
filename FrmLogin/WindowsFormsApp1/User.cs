using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class User
    {
        private string name, password, email, phoneNumber, cpf;
        private int id_endereco;

        public User(string inputName , string inputEmail, string inputPassword, string inputCpf, int inputId_endereco, string inputPhoneNumber) 
        {

            if (checkEmail(inputEmail))
            {
                email = inputEmail;
            }

            if (checkPassword(inputPassword))
            {
                password = inputPassword;
            }

            name = inputName;
            phoneNumber = inputPhoneNumber;
            cpf = inputCpf;
            id_endereco = inputId_endereco;
        }

        public bool checkEmail (string inputEmail)
        {
            if (inputEmail.Contains("@americanas.com.br")) 
            {
                return true;
            }
            return false;            
        }
        
        public bool checkPassword (string inputPassword)
        {
            if (inputPassword.Length >= 6 && inputPassword.Length <= 32) 
            {
                return true;
            }
            return false;            
        }

        public string GetUserData (int numData)
        {
            switch (numData) 
            {
                case 1: return name;
                case 2: return email;
                case 3: return phoneNumber;
                case 4: return password;
                case 5: return cpf;
                case 6: return id_endereco.ToString();
            }
            return "undefined";
        }
    }
}
