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
            if (inputName != "")
            {
                if (inputPassword != "")
                {
                    if (inputConfirmPassword != "")
                    {
                        if (inputPassword == inputConfirmPassword)
                        {
                            if (inputPhoneNumber != "")
                            {
                                if (inputEmail != "")
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Campo \"Email\" não preenchido!\nPor favor, complete todas as caixas de texto.", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("As senhas inseridas não coincidem!", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Campo \"Telefone\" não preenchido!\nPor favor, complete todas as caixas de texto.", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Campo \"Confirme a Senha\" não preenchido!\nPor favor, complete todas as caixas de texto.", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Campo \"Senha\" não preenchido!\nPor favor, complete todas as caixas de texto.", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Campo \"Nome\" não preenchido!\nPor favor, complete todas as caixas de texto.", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }  
        
        private void adicionarUsuario (User user)
        {
            listaUsuarios.Add(user);
        }
    }
}
