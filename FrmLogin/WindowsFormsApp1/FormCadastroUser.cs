using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormCadastroUser : Form
    {
        Class_BD_CRUD Bd = new Class_BD_CRUD();
        CadastroUsuarios user = new CadastroUsuarios();

        public FormCadastroUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text, senha = textBox3.Text, telefone = textBox4.Text, cpf = textBox5.Text, email = textBox6.Text, senha_confirmacao = textBox7.Text;
            bool dadosValidos = user.checkInput(email, senha, senha_confirmacao, nome, telefone);

            if (dadosValidos)
            {
                try
                {
                    Bd.setBD_Open();
                    Bd.setInputBd_funcionario(email, cpf, nome, telefone, senha);
                    Bd.setBD_Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar dados no banco de dados.\n\n" + ex, "Erro de conexão");
                    Bd.setBD_Close();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
