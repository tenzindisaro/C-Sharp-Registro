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

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtEmail.Focus();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

            User firstAdm = new User("Administrador Padrão", "admin@americanas.com.br", "admin12345");
        }
    }
}
