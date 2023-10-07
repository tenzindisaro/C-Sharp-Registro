using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using WindowsFormsApp1.Cadastros;
using System.Threading;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class Form3_Tela_Menu : Form
    {
        Thread t2;
        public Form3_Tela_Menu()
        {
            InitializeComponent();
        }
        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(abrirLogin);
            t2.SetApartmentState(ApartmentState.MTA);
            t2.Start();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            t2 = new Thread(abrirCadastrarUsuario);
            t2.SetApartmentState(ApartmentState.MTA);
            t2.Start();
        }
        private void abrirLogin (object obj)
        {
            Application.Run(new FrmLogin());
        }

        private void abrirCadastrarUsuario (object obj)
        {
            Application.Run(new Cadastros.Form4TelaCadastrosUsers());
        }  

    }
}
