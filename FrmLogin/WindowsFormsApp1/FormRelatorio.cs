using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormRelatorio : Form
    {

        private User usuario;
        Class_CadastroPac cadastroPacote = new Class_CadastroPac();
        Class_BD_CRUD Bd = new Class_BD_CRUD();
        private DataTable dataTable = new DataTable();
        DataRow newRow;
        public FormRelatorio()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            string date = DateTime.Now.Date.ToString("yyyy-MM-dd");
            Bd.setBD_Open();
            DataTable datatable_dos_pacotes_registrados_no_dia = Bd.setDataTable_pacotesDoDia(date);


            dataGridRelatorio.DataSource = datatable_dos_pacotes_registrados_no_dia;
            Bd.setBD_Close();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

            }
            else if (radioButton2.Checked)
            {

            }
            else if (radioButton3.Checked)
            {

            }
        }
    }
}
