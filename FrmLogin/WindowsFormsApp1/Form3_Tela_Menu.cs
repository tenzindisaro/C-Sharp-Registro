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
    public partial class Form3_Tela_Menu : Form
    {
        Thread t2;
        public Form3_Tela_Menu()
        {
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
            try
            {
                // string de conexão BD
                var strConnection = "server=containers-us-west-156.railway.app;port=6863;User Id=root;database=railway;password=uoNk5WCFgcxKJ1AjalxJ";
                MySqlConnection conn = new MySqlConnection(strConnection);
                //abre o BD
                conn.Open();
                MessageBox.Show("conectado BD.");
                //fecha o BD
                conn.Close();
                
            }
            catch 
            {
                MessageBox.Show("erro conectar banco de dados.");                
            }           

        }
    }
}
