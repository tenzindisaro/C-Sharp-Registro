using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Class_UsuarioAtual
    {
        private List<User> usuarioAtual;
        public Class_UsuarioAtual()
        {
            usuarioAtual = new List<User>();
        }

        public void adicionarUsuario (User obj)
        {
            if (obj != null)
            {
                usuarioAtual.Add(obj);
            }
        }

        public void removerUsuario ()
        {
            usuarioAtual.Clear();
        }

        public User getUserAtual()
        {
            if (usuarioAtual.Count > 0)
            {
                MessageBox.Show(usuarioAtual[0].GetUserData(1));
                return usuarioAtual[0];
            }
            else
            {
                MessageBox.Show("A lista de usuários está vazia.");
                return null;
            }
        }
    }
}
