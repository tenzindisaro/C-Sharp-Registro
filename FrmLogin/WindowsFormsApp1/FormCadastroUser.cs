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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    internal partial class FormCadastroUser : Form
    {
        Class_BD_CRUD Bd = new Class_BD_CRUD();
        CadastroUsuarios user = new CadastroUsuarios();
        User usuario;
        public FormCadastroUser(User usuarioAtual)
        {
            usuario = usuarioAtual;
            
            InitializeComponent();

            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text, senha = textBox3.Text, telefone = textBox4.Text, cpf = textBox5.Text, email = textBox6.Text, senha_confirmacao = textBox7.Text;
            bool dadosValidos = user.checkInput(email, senha, senha_confirmacao, nome, telefone);
            
            string[] endereco = comboBox2.Text.Split(',');
            int id_loja = int.Parse(endereco[0]);

            if (dadosValidos)
            {
                try
                {
                    Bd.setBD_Open();
                    Bd.setInputBd_funcionario(email, cpf, nome, telefone, senha, id_loja);
                    Bd.setBD_Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar dados no banco de dados.\n\n" + ex, "Erro de conexão");
                    Bd.setBD_Close();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastroUser_Load(object sender, EventArgs e)
        {
            Bd.setBD_Open();
            List<string> lojas = Bd.setRead_endereco_lojas();
            Bd.setBD_Close();

            comboBox2.Items.Clear();

            foreach (string loja in lojas)
            {
                comboBox2.Items.Add(loja);
            }

            Bd.setBD_Open();
            int id = int.Parse(usuario.GetUserData(6));
            dataGridView1.DataSource = Bd.setRead_funcionarios_id(id);
            Bd.setBD_Close();

            button2.Enabled = false;
            button4.Enabled = false;
            textBox3.Enabled = true;
            textBox7.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            button4.Enabled = true;
            textBox3.Enabled = false;
            textBox7.Enabled = false;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string nome, email, telefone, cpf, id, cep, rua, bairro, numero, endereco;


                if (selectedRow != null)
                {
                    email = selectedRow.Cells[0].Value.ToString();
                    cpf = selectedRow.Cells[1].Value.ToString();
                    nome = selectedRow.Cells[2].Value.ToString();
                    telefone = selectedRow.Cells[3].Value.ToString();
                    id = selectedRow.Cells[4].Value.ToString();
                    cep = selectedRow.Cells[5].Value.ToString();
                    rua = selectedRow.Cells[6].Value.ToString();
                    bairro = selectedRow.Cells[7].Value.ToString();
                    numero = selectedRow.Cells[8].Value.ToString();
                    endereco = $"ID: {id}, CEP: {cep}, {rua}, {bairro}, Número: {numero}";

                    textBox6.Text = email;
                    textBox5.Text = cpf;
                    textBox2.Text = nome;
                    textBox4.Text = telefone;
                    comboBox2.Text = endereco;
                    textBox3.Enabled = false;
                    textBox7.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Nenhum valor na linha selecionada!");
                }
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button4.Enabled = true;
            textBox3.Enabled = false;
            textBox7.Enabled = false;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string nome, email, telefone, cpf, id, cep, rua, bairro, numero, endereco;


                if (selectedRow != null)
                {
                    email = selectedRow.Cells[0].Value.ToString();
                    cpf = selectedRow.Cells[1].Value.ToString();
                    nome = selectedRow.Cells[2].Value.ToString();
                    telefone = selectedRow.Cells[3].Value.ToString();
                    id = selectedRow.Cells[4].Value.ToString();
                    cep = selectedRow.Cells[5].Value.ToString();
                    rua = selectedRow.Cells[6].Value.ToString();
                    bairro = selectedRow.Cells[7].Value.ToString();
                    numero = selectedRow.Cells[8].Value.ToString();
                    endereco = $"ID: {id}, CEP: {cep}, {rua}, {bairro}, Número: {numero}";

                    textBox6.Text = email;
                    textBox5.Text = cpf;
                    textBox2.Text = nome;
                    textBox4.Text = telefone;
                    comboBox2.Text = endereco;
                    textBox3.Enabled = false;
                    textBox7.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Nenhum valor na linha selecionada!");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nome, email, telefone, cpf, endereco;
            int id;

            email = textBox6.Text;
            cpf = textBox5.Text;
            nome = textBox2.Text;
            telefone = textBox4.Text;
            endereco = comboBox2.Text;

            int indiceInicioId = endereco.IndexOf("ID:") + "ID: ".Length;
            
            int indiceFimId = endereco.IndexOf(",", indiceInicioId);

            string idString = endereco.Substring(indiceInicioId, indiceFimId - indiceInicioId);

            int.TryParse(idString, out id);

            try
            {
                Bd.setBD_Open();
                Bd.setEdit_funcionario(email, cpf, nome, telefone, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Bd.setBD_Close();
            }

            textBox3.Enabled = true;
            textBox7.Enabled = true;
            button1.Enabled = true; 
            button2.Enabled = false; 
            button4.Enabled = false; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(comboBox1.Text != "" && comboBox1.Text != "Escolha uma opção" && textBox1.Text != "")
            {
                string busca = comboBox1.Text;
                string valor = textBox1.Text;

                try
                {
                    Bd.setBD_Open();
                    switch (busca)
                    {
                        case "Nome":
                            dataGridView1.DataSource = Bd.setRead_funcionario_Nome(valor);
                            break;

                        case "CPF":
                            dataGridView1.DataSource = Bd.setRead_funcionario_Cpf(valor);
                            break;

                        case "Email":
                            dataGridView1.DataSource = Bd.setRead_funcionario_Email(valor);
                            break;

                        case "Telefone":
                            dataGridView1.DataSource = Bd.setRead_funcionario_Telefone(valor);
                            break;

                        case "CEP":
                            dataGridView1.DataSource = Bd.setRead_funcionario_Cep(valor);
                            break;

                    }
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
            else
            {
                MessageBox.Show("Você deve escolher uma opção de busca e digitar um valor para a pesquisa!", "Erro de Busca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox1.Text = "Escolha uma opção";
            }

            button2.Enabled = false;
            button4.Enabled = false;
            textBox3.Enabled = true;
            textBox7.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = false;
            textBox3.Enabled = true;
            textBox7.Enabled = true;
            textBox6.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
        }
    }
}
