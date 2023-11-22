using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class CadastroUsuarios
    {
        public CadastroUsuarios ()
        {
      
        }

        public bool checkInput(string inputEmail, string inputPassword, string inputConfirmPassword, string inputName, string inputPhoneNumber, string inputEndereco)
        {
            string campo = "";
            int opr;

            if (inputName != "")
            {
                opr = 0;
            }
            else
            {
                opr = 1;
                campo = "\"Nome\"";
            }

            if (inputPassword != "")
            {
                if (inputPassword.Length > 6 && inputPassword.Length < 32) 
                { 
                    opr = 0;
                }
                else
                {
                    opr = 4;
                }
            }
            else
            {
                opr = 1;
                campo = "\"Senha\"";
            }

            if (inputConfirmPassword != "")
            {
                if (inputPassword.Length > 6 && inputPassword.Length < 32)
                {
                    opr = 0;

                }
                else
                {
                    opr = 4;
                }
            }
            else
            {
                opr = 1;
                campo = "\"Confirme a Senha\"";
            }

            if (inputPassword == inputConfirmPassword)
            {
                opr = 0; 
            }
            else
            {
                opr = 3;
            }

            if (inputPhoneNumber != "")
            {
                opr = 0;
            }
            else
            {
                opr = 1;
                campo = "\"Telefone\"";
            }

            if (inputEmail != "")
            {
                opr = 0;
            }
            else
            {
                opr = 1;
                campo = "\"Email\"";
            }

            if (inputEmail.Contains("@americanas.com.br"))
            {
                opr = 0; 
            }
            else
            {
                opr = 5;
            }

            if (inputEndereco != "")
            {
                opr = 0;
            }
            else
            {
                opr = 1;
                campo = "\"Loja do Funcionário\"";
            }

            switch (opr) 
            {
                case 0:
                    return true;

                case 1:
                    MessageBox.Show($"Campo {campo} não preenchido!\nPor favor, preencha todos os campos!", "Erro no cadastro");
                    break;
                
                case 2:
                    MessageBox.Show("");
                    break;
                case 3:
                    MessageBox.Show("As senhas inseridas não coincidem!", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 4:
                    MessageBox.Show("A senha inserida não está no formato correto! Digite uma senha de 6 a 32 dígitos.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 5:
                    MessageBox.Show("O email inserido não está no formato correto! Digite um email corporativo.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            return false;
        }

    }
}
