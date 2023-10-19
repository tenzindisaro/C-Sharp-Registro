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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "");
            {
                MessageBox.Show("Existem campos não preenchidos!\nPor favor, complete todas as caixas de texto.", "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
