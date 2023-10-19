using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        Thread t1;
        public FrmLogin()
        {
            InitializeComponent();
            txtEmail.Focus();
        }

        private string inputEmail, inputPassword;
        private void btnContinuar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            inputEmail = txtEmail.Text;
            inputPassword = txtSenha.Text;

            User actualyUser = new User("Administrador Padrão", "admin@americanas.com.br", "admin12345", "undefined", "undefined");   //deve se ignorar este objeto e seus dados por enquanto

            if (/*nome-Sugestivo_funcaoValidar(inputEmail, inputPassword) == */true)   //aqui, deve-se avaliar se os dados do usuário estão no banco de dados. 
            {
                label1.Visible = false;
                this.Close();
                t1 = new Thread(abrirMenu);
                t1.SetApartmentState(ApartmentState.MTA);
                t1.Start();
            }
            else
            {
                label1.Visible = true;
            }
        }
        private void abrirMenu(object obj)
        {
            Application.Run(new Form3_Tela_Menu());
=======
            User actualyUser = new User("Administrador Padrão", "admin@americanas.com.br", "admin12345");   //deve se ignorar este objeto e seus dados por enquanto

            //este if é para validar se o formato dos dados de entrada são condizentes
            if (actualyUser.CheckUser(txtEmail.Text, actualyUser.GetUserData(4)))
            {
                if (/*nome-Sugestivo_funcaoValidar() == */true)   //aqui, deve-se avaliar se os dados do usuário estão no banco de dados. 
                {
                    label1.Visible = false;
                    this.Close();
                    t1 = new Thread(abrirMenu);
                    t1.SetApartmentState(ApartmentState.MTA);
                    t1.Start();
                }
            }
>>>>>>> Angelo_Branch
        }
        private void abrirMenu(object obj)
        {
            Application.Run(new Form3_Tela_Menu());
        }
    }
}
