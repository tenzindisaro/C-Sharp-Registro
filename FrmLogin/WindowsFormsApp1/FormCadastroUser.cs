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
        Class_loja loja;
        private string emailAntigo;
        public FormCadastroUser(Class_loja lojaAtual)
        {
            loja = lojaAtual;
            
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox2.Text, senha = textBox3.Text, telefone = maskedTextBox2.Text, cpf = maskedTextBox1.Text, email = maskedTextBox3.Text, senha_confirmacao = textBox7.Text, endereco = comboBox2.Text;
            
            FormValidacaoLogin formValidacaoLogin = new FormValidacaoLogin(Bd);

            bool dadosValidos = user.checkInput(email, senha, cpf, senha_confirmacao, nome, telefone, endereco);
            bool arg = false;

            if (dadosValidos)
            {
                int indiceInicioId = endereco.IndexOf("ID: ") + "ID: ".Length;
                int indiceFimId = endereco.IndexOf(",", indiceInicioId);
                string idString = endereco.Substring(indiceInicioId, indiceFimId - indiceInicioId);
                
                try
                {
                    Bd.setBD_Open();
                    DialogResult resultado = formValidacaoLogin.ShowDialog();
                    if (formValidacaoLogin.getValidacaoCredenciais())
                    {
                        formValidacaoLogin.Close();
                        Bd.setInputBd_funcionario(email, cpf, nome, telefone, senha, idString);
                        arg = false;
                    }
                    else
                    {
                        formValidacaoLogin.Close();
                        ArgumentException argumentException = new ArgumentException("Erro");
                        arg = true;
                        throw argumentException;
                    }

                    MessageBox.Show("Funcionário adicionado com sucesso!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string id = loja.getIdLoja();
                    dataGridView1.DataSource = Bd.setRead_funcionarios_id(id);
                    Bd.setBD_Close();

                    button1.Enabled = true;
                    button2.Enabled = false;
                    button4.Enabled = false;
                    textBox3.Enabled = true;
                    textBox7.Enabled = true;
                    
                    if (!arg)
                    {                        
                        maskedTextBox1.Text = "";
                        maskedTextBox2.Text = "";
                        maskedTextBox3.Text = "";
                        maskedTextBox4.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox7.Text = "";
                        comboBox2.Text = "";
                        comboBox1.Text = "";
                        emailAntigo = "";
                    }
                }
            }
        }

        private void FormCadastroUser_Load(object sender, EventArgs e)
        {
            try
            {
                Bd.setBD_Open();
                List<string> lojas = Bd.setRead_endereco_lojas();
                Bd.setBD_Close();

                comboBox2.Items.Clear();

                foreach (string loja in lojas)
                {
                    comboBox2.Items.Add(loja);
                }

                
            }
            catch
            {
                MessageBox.Show("Não foi possível carregar as informações de endereços de loja.\nPor favor verifique sua conexão com a internete e abra esta janela novamente.","Erro de carregamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Bd.setBD_Close();
            }

            try
            {
                Bd.setBD_Open();
                string id = loja.getIdLoja();
                dataGridView1.DataSource = Bd.setRead_funcionarios_id(id);


                button1.Enabled = true;
                button2.Enabled = false;
                button4.Enabled = false;
                textBox3.Enabled = true;
                textBox7.Enabled = true;
                textBox2.Focus();

            }
            catch
            {
                MessageBox.Show("Não foi possível carregar as informações de funcionários cadastrados.\nPor favor verifique sua conexão com a internete e abra esta janela novamente.", "Erro de carregamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Bd.setBD_Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = false;
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
                    emailAntigo = email;
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
                    MessageBox.Show("Nenhum valor na linha selecionada!", "Seleção inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
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
                    emailAntigo = email;
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
                    MessageBox.Show("Nenhum valor na linha selecionada!", "Seleção inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nome, email, telefone, cpf, endereco;

            email = maskedTextBox3.Text;
            cpf = maskedTextBox1.Text;
            nome = textBox2.Text;
            telefone = maskedTextBox2.Text;
            endereco = comboBox2.Text;

            int indiceInicioId = endereco.IndexOf("ID:") + "ID: ".Length;
            
            int indiceFimId = endereco.IndexOf(",", indiceInicioId);

            string idString = endereco.Substring(indiceInicioId, indiceFimId - indiceInicioId);

            FormValidacaoLogin formValidacaoLogin = new FormValidacaoLogin(Bd);

            try
            {
                Bd.setBD_Open();
                formValidacaoLogin.ShowDialog();
                if (formValidacaoLogin.getValidacaoCredenciais())
                {
                    formValidacaoLogin.Close();
                    Bd.setEdit_funcionario(email, emailAntigo, cpf, nome, telefone, idString);

                    MessageBox.Show("Funcionário editado com sucesso!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.DataSource = Bd.setRead_funcionarios_id(idString);

                    emailAntigo = "";
                    maskedTextBox1.Text = "";
                    maskedTextBox2.Text = "";
                    maskedTextBox3.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox7.Text = "";
                    comboBox2.Text = "";
                    comboBox1.Text = "";

                    textBox3.Enabled = true;
                    textBox7.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button4.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas! Operação de edição não realizada!", "Operação interrompida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                formValidacaoLogin.Close();
                MessageBox.Show("Infelizmente não foi possível efetuar a edição do funcionário!\nVerifique se sua conexão está boa e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Bd.setBD_Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(comboBox1.Text != "" && comboBox1.Text != "Escolha uma opção" && maskedTextBox4.Text != "")
            {
                string busca = comboBox1.Text;
                string valor = maskedTextBox4.Text;
                bool maskCompleted = false;

                if (!(maskedTextBox4.Mask == ""))
                {
                    maskCompleted = maskedTextBox4.MaskedTextProvider.MaskCompleted;
                }

                if (maskCompleted || busca == "Nome" || busca == "Email")
                {
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

                        if (dataGridView1.DataSource == null)
                        {
                            MessageBox.Show("Não foi encontrado funcionário cadastrado com a informação apresentada na busca!", "Funcionário não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Infelizmente não foi possível efetuar a busca do funcionário!\nVerifique se sua conexão está boa e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        Bd.setBD_Close();
                        emailAntigo = "";
                        button2.Enabled = true;
                        button4.Enabled = true;
                        textBox3.Enabled = false;
                        textBox7.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Digite o elemento completo que será buscado!", "Busca Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Você deve escolher uma opção de busca e digitar um valor para a pesquisa!", "Erro de Busca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox1.Text = "Escolha uma opção";
            }          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Bd.setBD_Open();
                string id = loja.getIdLoja();
                dataGridView1.DataSource = Bd.setRead_funcionarios_id(id);

            }
            catch
            {
                MessageBox.Show("Não foi possível carregar as informações de funcionários cadastrados.\nPor favor verifique sua conexão com a internete e abra esta janela novamente.", "Erro de carregamento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Bd.setBD_Close();
            }

            button1.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = false;
            textBox3.Enabled = true;
            textBox7.Enabled = true;
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox4.Mask = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            emailAntigo = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = maskedTextBox3.Text, novoEmail = "";

            FormValidacaoLogin formValidacaoLogin = new FormValidacaoLogin(Bd);

            bool arg = false;

            DialogResult result = MessageBox.Show($"Tem certeza que dejesa apagar o funcionário com email {email}?", "Confirme a operação", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                try
                {
                    Bd.setBD_Open(); 
                    formValidacaoLogin.ShowDialog();
                    novoEmail = formValidacaoLogin.getInputEmail();

                    if (formValidacaoLogin.getValidacaoCredenciais())
                    {
                        formValidacaoLogin.Close();
                        Bd.setDelet_funcionario(email, novoEmail);
                        arg = false;
                    }
                    else
                    {
                        formValidacaoLogin.Close();
                        ArgumentException argumentException = new ArgumentException();
                        arg = true;
                        throw argumentException;
                    }

                    
                    MessageBox.Show("Funcionário apagado com sucesso!", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string id = loja.getIdLoja();
                    dataGridView1.DataSource = Bd.setRead_funcionarios_id(id);

                    textBox3.Enabled = true;
                    textBox7.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button4.Enabled = false;
                }
                catch (Exception)
                {
                    if (arg)
                    {
                        MessageBox.Show("Infelizmente não foi possível validar as credencias para criar o novo usuário.", "Credenciais inválidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Infelizmente não foi possível apagar o funcionário!\nVerifique se o funcionário está cadastrado ou se sua conexão está boa e tente novamente, além disso, não é possível o próprio usuário apagar seu cadastro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    Bd.setBD_Close();
                
                    if (!arg)
                    {
                        maskedTextBox1.Text = "";
                        maskedTextBox2.Text = "";
                        maskedTextBox3.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox7.Text = "";
                        comboBox2.Text = "";
                        comboBox1.Text = "";
                        emailAntigo = "";
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBox4.Mask = "";
            maskedTextBox4.Text = "";

            if (comboBox1.Text == "CPF")
            {
                maskedTextBox4.Mask = "000,000,000-00";
            }
            else if (comboBox1.Text == "Telefone")
            {
                maskedTextBox4.Mask = "(00) 00000-0000";
            }
            else if (comboBox1.Text == "CEP")
            {
                maskedTextBox4.Mask = "00000-000";
            }
        }
    }
}
