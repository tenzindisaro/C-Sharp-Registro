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
        private User usuario;
        private Class_BD_CRUD database = new Class_BD_CRUD();
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
            FormCadastroUser form = new FormCadastroUser(usuario);
            form.ShowDialog();            
        }

        private void registroToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form5_Registro_Pac form = new RegistrosPac.Form5_Registro_Pac(usuario);
            form.ShowDialog();
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
                int id = int.Parse(usuario.GetUserData(6));

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

            if (usuario != null)
            {
                //1nome2email3phone4senha5cpf6id_endereco
                label11.Text = usuario.GetUserData(2);
                label12.Text = usuario.GetUserData(1);
                label10.Text = usuario.GetUserData(3);
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
            Form5_Registro_Pac form = new RegistrosPac.Form5_Registro_Pac(usuario);
            form.ShowDialog();
        }

        private void btnListaPac_Click(object sender, EventArgs e)
        {
            t2 = new Thread(abrirLista);
            t2.SetApartmentState(ApartmentState.MTA);
            t2.Start();
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
            t2 = new Thread(abrirRelatorios);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void abrirRelatorios(object obj)
        {
            Application.Run(new FormRelatorio());
        }
    }
}
