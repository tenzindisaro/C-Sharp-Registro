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
using MySqlX.XDevAPI.Common;

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
            string nome = textBox2.Text, senha = textBox3.Text, telefone = maskedTextBox2.Text, cpf = maskedTextBox1.Text, email = maskedTextBox3.Text, senha_confirmacao = textBox7.Text, endereco = comboBox2.Text;
            int id_loja;
            FormValidacaoLogin formValidacaoLogin = new FormValidacaoLogin(Bd);

            int indiceInicioId = endereco.IndexOf("ID: ") + "ID: ".Length;
            int indiceFimId = endereco.IndexOf(",", indiceInicioId);
            string idString = endereco.Substring(indiceInicioId, indiceFimId - indiceInicioId);

            int.TryParse(idString, out id_loja);

            bool dadosValidos = user.checkInput(email, senha, senha_confirmacao, nome, telefone, endereco);
            bool arg = false;

            if (dadosValidos)
            {
                try
                {
                    Bd.setBD_Open();
                    DialogResult resultado = formValidacaoLogin.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        Bd.setInputBd_funcionario(email, cpf, nome, telefone, senha, id_loja);
                        arg = false;
                    }
                    else
                    {
                        ArgumentException argumentException = new ArgumentException("Erro");
                        arg = true;
                        throw argumentException;
                    }
                }
                catch (ArgumentException)
                {
                    if(arg)
                    {
                        MessageBox.Show("Infelizmente não foi possível validar as credencias para criar o novo usuário.", "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Infelizmente não foi possível efetuar o cadastro do funcionário!\nVerifique se o funcionário já foi cadastrado ou se sua conexão está boa e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                finally
                {
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

                    maskedTextBox3.Text = email;
                    maskedTextBox1.Text = cpf;
                    textBox2.Text = nome;
                    maskedTextBox2.Text = telefone;
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

                    maskedTextBox3.Text = email;
                    maskedTextBox1.Text = cpf;
                    textBox2.Text = nome;
                    maskedTextBox2.Text = telefone;
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

            email = maskedTextBox3.Text;
            cpf = maskedTextBox1.Text;
            nome = textBox2.Text;
            telefone = maskedTextBox2.Text;
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
            catch
            {
                MessageBox.Show("Infelizmente não foi possível efetuar a edição do funcionário!\nVerifique se sua conexão está boa e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                catch
                {
                    MessageBox.Show("Infelizmente não foi possível efetuar a busca do funcionário!\nVerifique se sua conexão está boa e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            if(dataGridView1.DataSource == null)
            {
                MessageBox.Show("Não foi encontrado funcionário cadastrado com a informação apresentada na busca!", "Funcionário não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = false;
            textBox3.Enabled = true;
            textBox7.Enabled = true;
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = maskedTextBox3.Text;

            DialogResult result = MessageBox.Show($"Tem certeza que dejesa apagar o funcionário com email {email}?", "Confirme a operação", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                try
                {
                    Bd.setBD_Open();
                    Bd.setDelet_funcionario(email);
                    MessageBox.Show("Funcionário apagado com sucesso!", "Operação concluída");
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    Bd.setBD_Close();
                }
            }
                    
        }



    }
}
