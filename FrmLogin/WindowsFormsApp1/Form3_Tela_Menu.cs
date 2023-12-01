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
using WindowsFormsApp1.RegistrosPac;

namespace WindowsFormsApp1
{
    internal partial class Form3_Tela_Menu : Form
    {
        Thread t2;
        private Class_loja loja;
        private Class_BD_CRUD database = new Class_BD_CRUD();
        public Form3_Tela_Menu(Class_loja lojaAtual)
        {
            loja = lojaAtual;
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
            FormCadastroUser form = new FormCadastroUser(loja);
            form.ShowDialog();            
        }

        private void registroToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form5_Registro_Pac form = new RegistrosPac.Form5_Registro_Pac(loja);
            form.ShowDialog();
        }
                
        private void geralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            lista.Geral.Form6_Lista_Geral form = new lista.Geral.Form6_Lista_Geral(loja);
            form.ShowDialog();
            this.Show();
        }

        private void Form3_Tela_Menu_Load(object sender, EventArgs e)
        {
            try
            {
                string id = loja.getIdLoja();

                database.setBD_Open();
                label8.Text = database.setRead_Presentes(id);
                label9.Text = database.setRead_Retirados(id);
                label13.Text = database.setRead_Todos(id);
                database.setBD_Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (loja != null)
            {
                string textMenu = $"ID: {loja.getIdLoja()}, CEP: {loja.getCepLoja()}, {loja.getRuaLoja()}, {loja.getBairroLoja()}, {loja.getNumeroLoja()}";
                
                label11.Text = textMenu;
                label10.Text = loja.getTelefoneLoja();
                //label4.Text

                AtualizarHorario();
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // Intervalo em milissegundos
                timer.Tick += Timer_Tick;
                timer.Start();

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

        private void btnCadastroPacMenu_Click(object sender, EventArgs e)
        {
            Form5_Registro_Pac form = new RegistrosPac.Form5_Registro_Pac(loja);
            form.ShowDialog();
        }

        private void btnListaPac_Click(object sender, EventArgs e)
        {
            this.Hide();
            lista.Geral.Form6_Lista_Geral form = new lista.Geral.Form6_Lista_Geral(loja);
            form.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelHorarioAtual_Click(object sender, EventArgs e)
        {
            
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AtualizarHorario();
        }

        private void AtualizarHorario()
        {
            labelHorarioAtual.Text = $"{DateTime.Now:HH:mm:ss}";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(abrirRelatorios);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void abrirRelatorios(object obj)
        {
            Application.Run(new FormRelatorio());
        }

        private void btnRetiradaPac_Click(object sender, EventArgs e)
        {
            FormRetirarPac form = new FormRetirarPac(loja);
            form.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRetirarPac form = new FormRetirarPac(loja);
            form.ShowDialog();
        }
    }
}
