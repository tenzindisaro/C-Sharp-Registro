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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    internal partial class Form3_Tela_Menu : Form
    {
        Thread t2;
        private User usuario;
        public Form3_Tela_Menu(User usuarioAtual)
        {
            usuario = usuarioAtual;
            InitializeComponent();
        }
        
        private void trocarUsuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(abrirLogin);
            t2.SetApartmentState(ApartmentState.MTA);
            t2.Start();
        }

        private void abrirLogin(object obj)
        {
            Application.Run(new FrmLogin());
        }

        private void adicionarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            t2 = new Thread(abrirCadastrarUsuario);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }


        private void abrirCadastrarUsuario(object obj)
        {
            Application.Run(new FormCadastroUser());
        }

        private void registroToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            t2 = new Thread(abrirRegistroPac);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }
        
        private void abrirRegistroPac(object obj)
        {
            Application.Run(new RegistrosPac.Form5_Registro_Pac());
        }
        
        private void geralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            t2 = new Thread(abrirLista);
            t2.SetApartmentState(ApartmentState.MTA);
            t2.Start();
        }
               
        private void abrirLista(object obj)
        {
            Application.Run(new lista.Geral.Form6_Lista_Geral());
        }

        private void Form3_Tela_Menu_Load(object sender, EventArgs e)
        {

            if (usuario != null)
            {
                //1nome2email3phone4senha5cpf6id_endereco
                label11.Text = usuario.GetUserData(2);
                label12.Text = "Teste";
                label10.Text = usuario.GetUserData(3);
                MessageBox.Show("passou");
                //label4.Text
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(abrirLogin);
            t2.SetApartmentState(ApartmentState.MTA);
            t2.Start();
        }
    }
}
