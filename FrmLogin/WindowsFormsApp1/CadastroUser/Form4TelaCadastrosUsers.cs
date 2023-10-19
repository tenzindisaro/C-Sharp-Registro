using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1.Cadastros
{
    public partial class Form4TelaCadastrosUsers : Form
    {
        public Form4TelaCadastrosUsers()
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
