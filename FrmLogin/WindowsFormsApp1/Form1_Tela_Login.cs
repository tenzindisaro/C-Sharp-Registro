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
        private string inputId, inputPassword;
        private Class_loja loja = null;

        public FrmLogin()
        {
            InitializeComponent();
            enchiosacodeporloginesenha();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            inputId = txtEmail.Text;
            inputPassword = txtSenha.Text;

            if (inputId != "" && inputPassword != "")
            {
                try
                {
                    Bd.setBD_Open();
                    loja = Bd.setReadBd_credLoja(inputId , inputPassword);
                    Bd.setBD_Close();
                }
                catch (Exception ex)
                {
                    loja = null;
                    MessageBox.Show("Erro ao conectar dados no banco de dados.\n\n" + ex, "Erro de conexão");
                }
            }
            else
            {
                loja = null;
            }
            
            if (loja != null)   
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
        }
        private void enchiosacodeporloginesenha()
        {
            txtEmail.Text = "1";
            txtSenha.Text = "123456";
        }

        private void abrirMenu(object obj)
        {
            Application.Run(new Form3_Tela_Menu(loja));
        }
    }
}
