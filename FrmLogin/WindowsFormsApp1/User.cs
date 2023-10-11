using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class User
    {
        private string name, password, email, phoneNumber, address;

        public User(string inputName , string inputEmail, string inputPassword, string inputPhone, string inputAddress) 
        {
            name = inputName;
            if (checkEmail(email))
            {
                email = inputEmail;
            }
            phoneNumber = inputPhone;
            address = inputAddress;

            if (checkPassword(inputPassword))
            {
                password = inputPassword;
            }
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
                case 5: return jobTitle;
                case 6: return address;
            }
            return "undefined";
        }
    }
}
