using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.RegistrosPac;

namespace WindowsFormsApp1.lista.Geral
{
    internal partial class Form6_Lista_Geral : Form
    {
        private Class_BD_CRUD Bd = new Class_BD_CRUD();
        private Class_loja loja = null;
        public Form6_Lista_Geral(Class_loja lojaAtual)
        {
            loja = lojaAtual;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5_Registro_Pac form = new Form5_Registro_Pac(loja);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Lista_Geral_Load(object sender, EventArgs e)
        {
            InitializeDataGrid();
        }

        private void InitializeDataGrid ()
        {
            try
            {
                string date = DateTime.Now.Date.ToString("yyyy-MM-dd");
                Bd.setBD_Open();
                DataTable datatable_dos_pacotes_registrados_no_dia = Bd.setDataTable_pacotes(loja.getIdLoja());
                dataGridView1.DataSource = datatable_dos_pacotes_registrados_no_dia;
            }
            catch
            {
                MessageBox.Show("Houve um erro no carregamento dos pacotes registrados.\nVerifique sua conexão com a internete e abra a janela novamente.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Bd.setBD_Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataBusca = dateTimePicker1.Value;
            string data = dataBusca.Date.ToString("yyyy-MM-dd");

            try
            {
                Bd.setBD_Open();
                dataGridView1.DataSource = Bd.setDataTable_pacotesDoDia(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Bd.setBD_Close();
            }
        }
    }
}
