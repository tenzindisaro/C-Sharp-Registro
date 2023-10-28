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
        private List<User> listaUsuarios;
        private User novoUser;
        public CadastroUsuarios ()
        {
            //listaUsuarios = new List<User> ();        não removi pois pode ser útil!
        }


        public bool checkInput(string inputEmail, string inputPassword, string inputConfirmPassword, string inputName, string inputPhoneNumber)
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

            if (inputEmail != "" && inputEmail.Contains("@americanas.com.br"))
            {
                opr = 0;
            }
            else
            {
                opr = 1;
                campo = "\"Email\"";
            }


            switch (opr) 
            {
                case 0:
                    return true;

                case 1:
                    MessageBox.Show("Campo {0} não preenchido!\nPor favor, preencha todos os campos!" + campo, "Erro no cadastro");
                    break;
                
                case 2:
                    MessageBox.Show("");
                    break;
                case 3:
                    MessageBox.Show("As senhas inseridas não coincidem!", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 4:
                    MessageBox.Show("As senha inserida não está no formato correto! Digite uma senha de 6 a 32 dígitos.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            return false;
        }

        private void adicionarUsuario (User user)
        {
            listaUsuarios.Add(user);
        }
    }
}
