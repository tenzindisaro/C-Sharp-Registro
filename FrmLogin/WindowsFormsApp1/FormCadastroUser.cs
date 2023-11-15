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
    internal partial class FormCadastroUser : Form
    {
        Class_BD_CRUD Bd = new Class_BD_CRUD();
        CadastroUsuarios user = new CadastroUsuarios();
        User usuario;
        public FormCadastroUser(User usuarioAtual)
        {
            usuario = usuarioAtual;
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

        private void FormCadastroUser_Load(object sender, EventArgs e)
        {
            Bd.setBD_Open();
            List<string> lojas = Bd.setRead_endereco_lojas();
            Bd.setBD_Close();

            comboBox2.Items.Clear();

            foreach (string loja in lojas)
            {
                comboBox2.Items.Add(loja);
            }
        }
    }
}
