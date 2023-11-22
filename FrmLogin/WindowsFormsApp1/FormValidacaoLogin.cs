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
        public FormValidacaoLogin(Class_BD_CRUD database)
        {
            Bd = database;
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            bool validacaoCredenciais = false;
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                label1.Show();
            }
        }

        private void FormValidacaoLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
