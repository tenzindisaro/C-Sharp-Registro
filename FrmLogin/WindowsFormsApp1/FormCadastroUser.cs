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
        public FormCadastroUser()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private string inputEmail , inputPassword, inputConfirmPassword, inputName, inputAddress, inputPhoneNumber;
        CadastroUsuarios cadastrados = new CadastroUsuarios();



        private void button1_Click(object sender, EventArgs e)
        {
            inputName = textBox2.Text;
            inputPassword = textBox3.Text;
            inputConfirmPassword = textBox7.Text;
            inputPhoneNumber = textBox4.Text;
            inputAddress = textBox5.Text;
            inputEmail = textBox6.Text;

            if ( inputName != "")
            {
                
            }
            else
            {
                MessageBox.Show("Campo \"Nome\" não preenchido!\nPor favor, complete todas as caixas de texto.", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
