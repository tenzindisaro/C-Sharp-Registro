using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal partial class FormValidacaoLogin : Form
    {
        Class_BD_CRUD Bd;
        private bool validacaoCredenciais = false;
        public FormValidacaoLogin(Class_BD_CRUD database)
        {
            Bd = database;
            InitializeComponent();
            txtEmail.Text = "";
            txtEmail.Enabled = true;
        }
        public FormValidacaoLogin(Class_BD_CRUD database, string funcionario)
        {
            Bd = database;
            InitializeComponent();
            txtEmail.Text = funcionario;
            txtEmail.Enabled = false;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text, senha = txtSenha.Text;
            
            try
            {
                validacaoCredenciais = Bd.setReadBd_login(email, senha);
            }
            catch 
            {
                MessageBox.Show("Não foi possível efetuar o Login!\nVerifique sua conexão com a internete.", "Erro inesperado");
            }
            
            if (validacaoCredenciais)
            {
                this.Hide();
            }
        }

        public string getInputEmail ()
        {
            return txtEmail.Text;
        }

        public bool getValidacaoCredenciais ()
        {
            return validacaoCredenciais;
        }
    }
}
