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
        Class_BD_CRUD Bd = new Class_BD_CRUD();
        Class_UsuarioAtual listaUsuario = new Class_UsuarioAtual();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private string inputEmail, inputPassword;
        private bool tentativa_login;
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            inputEmail = txtEmail.Text;
            inputPassword = txtSenha.Text;

            if (inputEmail != "" && inputPassword != "")
            {
                try
                {
                    Bd.setBD_Open();
                    tentativa_login = Bd.setReadBd_login(inputEmail , inputPassword);
                    Bd.setBD_Close();
                }
                catch (Exception ex)
                {
                    tentativa_login = false;
                    MessageBox.Show("Erro ao conectar dados no banco de dados.\n\n" + ex, "Erro de conexão");
                }
            }
            else
            {
                tentativa_login = false;
            }
            
            if (tentativa_login)   
            {
                label1.Visible = false;
                try
                {
                    /*
                    Bd.setBD_Open();
                    User funcionario = Bd.setReadBd_funcionario(inputEmail, inputPassword);
                    Bd.setBD_Close();
                    */
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erro");
                }


                User funcionario = new User("Ângelo", "angelo@americanas.com.br", "angelo", "527527038-05", 11, "(11)99755-6556");

                listaUsuario.adicionarUsuario(funcionario);
                
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
            //listaUsuario.removerUsuario();
        }

        private void abrirMenu(object obj)
        {
            Application.Run(new Form3_Tela_Menu(listaUsuario));
        }
    }
}
