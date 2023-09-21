using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class User
    {
        private string name, password, email, phoneNumber;

        public User(string inputName , string inputEmail, string inputPassword) 
        {
            name = inputName;

            if (inputPassword.Length >= 6 && inputPassword.Length <= 32)
            {
                password = inputPassword;
            }

            if (inputEmail != "")
            {
                email = inputEmail;
            }
            phoneNumber = "undefined";
        }

        public bool CheckUser (string inputEmail, string inputPassword)
        {
            if (inputEmail.Contains("@americanas.com.br")) 
            {
                if (inputPassword.Length >= 6 && inputPassword.Length <= 32)
                {
                    return true;
                }
            }
            return false;            
        }

        public string GetUserData (int data)
        {
            switch (data) {
                case 1: return name;
                case 2: return email;
                case 3: return phoneNumber;
                case 4: return password;
            }
            return "undefined";
        }
    }
}
