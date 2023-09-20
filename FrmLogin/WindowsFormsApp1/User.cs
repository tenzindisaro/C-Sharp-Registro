using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class User
    {
        public string name, password, email, phoneNumber;
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
            if (inputEmail == "@americanas") 
            { 
                return true;
            }
            
            return false;
        }
    }
}
