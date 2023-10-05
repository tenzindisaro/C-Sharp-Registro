using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class User
    {
        private string name, password, email, phoneNumber, cargo, address ;
       // private int id_codigo, lvl_acess;        
        
        public User(string inputName , string inputEmail, string inputPassword, string inputCargo, 
            int inputId_codigo, string inputAddress, int inputLvl_acess ) 
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

            address = inputAddress;
            cargo = inputCargo;
            //id_codigo = inputId_codigo;            
            //lvl_acess = inputLvl_acess;
        }

        /*public User()
        {
            name = "";
            password = "";
            email = ""; 
            phoneNumber = "";
            cargo = "";
            address = "";
            id_codigo = 0;
            lvl_acess = 0;
        }*/

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
