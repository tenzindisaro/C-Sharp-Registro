using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{

    internal class Class_BD_CRUD
    {   //"server=localhost;port=3307;User Id=root;database=projeto_registro_sql;password=usbw"
        //'server=americanas.mysql.database.azure.com;port=3307;User Id=joao;database=teste_sql;password=Adriana1
        //"server=containers-us-west-156.railway.app;port=6863;User Id=root;database=railway;password=uoNk5WCFgcxKJ1AjalxJ"
        //private MySqlConnection conn = new MySqlConnection("server=containers-us-west-156.railway.app;port=6863;User Id=root;database=railway;password=uoNk5WCFgcxKJ1AjalxJ");
        private MySqlConnection conn = new MySqlConnection("server=americanas.mysql.database.azure.com;port=3306;User Id=joao;database=teste_sql;password=Adriana1");

        private int id_hora, id_data;
        // váriaveis a baixo para busca dados
        string retorna_nf, retorna_situacao, retorna_cpf_titular, retorna_cpf_entregador, nome_titular, email_titular, telefone_titular, retorna_nome_entregador, retorna_chegada_data, 
            retorna_retirada_data, retorna_chegada_hora, retorna_retirada_hora, retorna_email_funcionario;
        int retorna_id_data, retorna_id_hora;

        public Class_BD_CRUD()
        {
            /* campo vazio, abertura do BD sera manual
             MessageBox.Show("Banco de Dados public inicializado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);*/
        }
        public void setBD_Open()
        {
            //abre o BD
            conn.Open();
            //MessageBox.Show("Banco de Dados open.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void setBD_Close()
        {
            //fecha o BD
            conn.Close();
            //MessageBox.Show("BD fechado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void setInputBd_titular(string cpf_titular, string nome, string email, string telefone)
        {
            MySqlCommand objcmd_titular = new MySqlCommand("insert into titular (cpf_titular, nome, email, telefone) values (?, ?, ?, ?)", conn);
            // parametros para o sql titular
            objcmd_titular.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = cpf_titular;
            objcmd_titular.Parameters.Add("@nome", MySqlDbType.VarChar, 75).Value = nome;
            objcmd_titular.Parameters.Add("@email", MySqlDbType.VarChar, 30).Value = email;
            objcmd_titular.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = telefone;
            // executando querys            
            objcmd_titular.ExecuteNonQuery();
            MessageBox.Show("envio de dados titular ok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void setInputBd_data(string chegada_data)
        {
            MySqlCommand objcmd_data = new MySqlCommand("insert into tbl_data (id_data, chegada_data) values (NULL, ?)", conn);
            // parametros para o sql data
            objcmd_data.Parameters.Add("@chegada_data", MySqlDbType.VarChar, 10).Value = chegada_data;
            // executando query                       
            objcmd_data.ExecuteNonQuery();
            MessageBox.Show("envio de dados data ok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MySqlCommand last_id_data = new MySqlCommand("SELECT LAST_INSERT_ID();", conn);

            id_data = Convert.ToInt32(last_id_data.ExecuteScalar());
            MessageBox.Show("valor id data = " + id_data.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void setInputBd_hora(string chegada_hora)
        {
            MySqlCommand objcmd_hora = new MySqlCommand("insert into hora (id_hora, chegada_hora) values (NULL, ?)", conn);
            // parametros para o sql hora
            objcmd_hora.Parameters.Add("@chegada_hora", MySqlDbType.VarChar, 10).Value = chegada_hora;
            // executando query                       
            objcmd_hora.ExecuteNonQuery();
            MessageBox.Show("envio de dados hora ok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            MySqlCommand last_id_hora = new MySqlCommand("SELECT LAST_INSERT_ID();", conn);


            id_hora = Convert.ToInt32(last_id_hora.ExecuteScalar());
            MessageBox.Show("valor id hora = " + id_hora.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void setInputBd_funcionario(string email_funcionario, string cpf_funcionario, string nome_funcionario, string telefone_funcionario, string senha_funcionario, string id_americanas)
        {
            MySqlCommand objcmd_funcionario = new MySqlCommand("INSERT INTO funcionario (email_americanas_funcionario, cpf_funcionario, nome_funcionario, telefone_funcionario, senha_funcionario, id_americanas) VALUES (?, ?, ?, ?, ?, ?)", conn);
            // parametros para o sql pacote
            objcmd_funcionario.Parameters.Add("@email_americanas_funcionario", MySqlDbType.VarChar, 75).Value = email_funcionario;
            objcmd_funcionario.Parameters.Add("@cpf_funcionario", MySqlDbType.VarChar, 15).Value = cpf_funcionario;
            objcmd_funcionario.Parameters.Add("@nome_funcionario", MySqlDbType.VarChar, 45).Value = nome_funcionario;
            objcmd_funcionario.Parameters.Add("@telefone_funcionario", MySqlDbType.VarChar, 15).Value = telefone_funcionario;
            objcmd_funcionario.Parameters.Add("@senha_funcionario", MySqlDbType.VarChar).Value = senha_funcionario;
            objcmd_funcionario.Parameters.Add("@id_americanas", MySqlDbType.VarChar, 36).Value = id_americanas;
            // executando query                       
            objcmd_funcionario.ExecuteNonQuery();
        }

        public void setInputBd_entregador(string cpf_entregador, string nome_entregador)
        {
            MySqlCommand objcmd_entregador = new MySqlCommand("INSERT INTO entregador (cpf_entregador, nome_entregador) VALUES (?, ?)", conn);
            // parametros para o sql entregador

            objcmd_entregador.Parameters.Add("@cpf_entregador", MySqlDbType.VarChar, 15).Value = cpf_entregador;
            objcmd_entregador.Parameters.Add("@nome_entregador", MySqlDbType.VarChar, 75).Value = nome_entregador;
            // executando query 
            objcmd_entregador.ExecuteNonQuery();
            MessageBox.Show("envio de dados entregador ok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }


        public void setInputBd_pacote(string nota_fiscal, string situacao_pacote, string email_americanas_funcionario, string cpf_titular, string cpf_entregador)
        {
            MySqlCommand objcmd_pacote = new MySqlCommand("INSERT INTO pacote (nota_fiscal_pacote, situacao_pacote, email_americanas_funcionario, cpf_titular, cpf_entregador, id_data, id_hora) VALUES (?, ?, ?, ?, ?, ?, ?);", conn);
            
            objcmd_pacote.Parameters.Add("@nota_fiscal_pacote", MySqlDbType.VarChar, 45).Value = nota_fiscal;
            objcmd_pacote.Parameters.Add("@situacao_pacote", MySqlDbType.VarChar, 20).Value = situacao_pacote;
            objcmd_pacote.Parameters.Add("@email_americanas_funcionario", MySqlDbType.VarChar, 75).Value = email_americanas_funcionario;
            objcmd_pacote.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = cpf_titular;
            objcmd_pacote.Parameters.Add("@cpf_entregador", MySqlDbType.VarChar, 15).Value = cpf_entregador;
            objcmd_pacote.Parameters.Add("@id_data", MySqlDbType.VarChar, 15).Value = id_data;
            objcmd_pacote.Parameters.Add("@id_hora", MySqlDbType.VarChar, 15).Value = id_hora;

            // Executar a consulta de inserção e recuperar o ID gerado automaticamente
            objcmd_pacote.ExecuteNonQuery();
            MessageBox.Show("Envio de dados pacote ok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // A BAIXO ESTÃO OS MÉTODOS PARA BUSCAR OS DADOS DO BD**************************************************************************************
        
        public bool setReadBd_CountPacote (string notaFiscal_txt)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM pacote WHERE nota_fiscal_pacote = @NumeroNotaFiscal", conn);
            cmd.Parameters.AddWithValue("@NumeroNotaFiscal", notaFiscal_txt);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Nota Fiscal já existente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool setReadBd_CountEmailFuncionario(string emailFuncionario)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM funcionario WHERE email_americanas_funcionario = @emailFuncionario", conn);
            cmd.Parameters.AddWithValue("@emailFuncionario", emailFuncionario);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)
            {
                MessageBox.Show("Funcionario email não existente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public bool setReadBd_CountCpfTitular(string cpf)
        {
            MessageBox.Show("ENTROU TITULAR", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM titular WHERE cpf_titular = @cpfTitular", conn);
            cmd.Parameters.AddWithValue("@cpfTitular", cpf);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("box de teste cpf titular.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public bool setReadBd_CountCpfEntregador(string cpf)
        {
            MessageBox.Show("ENTROU ENTREGADOR", "Operação concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM entregador WHERE cpf_entregador = @cpfEntregador", conn);
            cmd.Parameters.AddWithValue("@cpfEntregador", cpf);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("box de teste cpf entregador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public DataTable setReadBd_Pacote_notaFiscal (string inputNotaFiscal)
        {
            string query = "SELECT p.nota_fiscal_pacote, p.email_americanas_funcionario, t.nome, p.cpf_titular, e.nome_entregador, p.cpf_entregador, d.chegada_data, d.retirada_data, h.chegada_hora, h.retirada_horaFROM pacote p INNER JOIN titular t ON t.cpf_titular = p.cpf_titular INNER JOIN entregador e ON e.cpf_entregador = p.cpf_entregador INNER JOIN tbl_data d ON d.id_data = p.id_data INNER JOIN hora h ON h.id_hora = p.id_hora WHERE p.nota_fiscal_pacote = @notaFiscal;";

            MySqlCommand obj = new MySqlCommand(query, conn);
            obj.Parameters.Clear();
            obj.Parameters.Add("@notaFiscal", MySqlDbType.VarChar, 45).Value = inputNotaFiscal;

            MySqlDataReader reader = obj.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string notaFiscal = reader["nota_fiscal_pacote"].ToString();
                    string cep_loja = reader["cep_americanas"].ToString();
                    string rua_loja = reader["rua_americanas"].ToString();
                    string bairro_loja = reader["bairro_americanas"].ToString();
                    string numero_loja = reader["numero_americanas"].ToString();
                    string telefone_loja = reader["telefone_americanas"].ToString();
                }
            }
            return null;
        }
        
        public Class_loja setReadBd_credLoja (string id, string senha)
        {
            string query = "SELECT id_americanas, cep_americanas, rua_americanas, bairro_americanas, numero_americanas, telefone_americanas FROM americanas WHERE id_americanas = @id AND senha_americanas = @senha";
            Class_loja loja = null;

            MySqlCommand obj = new MySqlCommand(query, conn);
            obj.Parameters.Add("@id", MySqlDbType.VarChar, 36).Value = id;
            obj.Parameters.Add("@senha", MySqlDbType.VarChar, 36).Value = senha;

            MySqlDataReader reader = obj.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string id_loja = reader["id_americanas"].ToString();
                    string cep_loja = reader["cep_americanas"].ToString();
                    string rua_loja = reader["rua_americanas"].ToString();
                    string bairro_loja = reader["bairro_americanas"].ToString();
                    string numero_loja = reader["numero_americanas"].ToString();
                    string telefone_loja = reader["telefone_americanas"].ToString();

                    loja = new Class_loja(id_loja, cep_loja, rua_loja, bairro_loja, numero_loja, telefone_loja);
                    MessageBox.Show("Login bem-sucedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return loja;
                }
            }
            MessageBox.Show("Credenciais inválidas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;            
        }
        
        public bool setReadBd_login(string usuario, string senha)
        {
            // Construa a consulta SQL para verificar as credenciais do usuário
            string query = "SELECT COUNT(*) FROM funcionario WHERE email_americanas_funcionario = @usuario AND senha_funcionario = @senha";

            MySqlCommand objcmd_login = new MySqlCommand(query, conn);
            objcmd_login.Parameters.Add("@usuario", MySqlDbType.VarChar, 255).Value = usuario;
            objcmd_login.Parameters.Add("@senha", MySqlDbType.VarChar, 32).Value = senha; // Certifique-se de usar o mesmo tipo de dados que está armazenado no banco de dados para senhas.

            // Execute a consulta para verificar as credenciais
            int result = Convert.ToInt32(objcmd_login.ExecuteScalar());

            if (result > 0)
            {
                MessageBox.Show("Login bem-sucedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        public User setReadBd_funcionario(string usuario, string senha)
        {
            try
            {
                string query = "SELECT * FROM funcionario WHERE email_americanas_funcionario = @usuario AND senha_funcionario = @senha";

                MySqlCommand objcmd_user = new MySqlCommand(query, conn);
                objcmd_user.Parameters.Add("@usuario", MySqlDbType.VarChar, 255).Value = usuario;
                objcmd_user.Parameters.Add("@senha", MySqlDbType.VarChar, 32).Value = senha;

                using (MySqlDataReader reader = objcmd_user.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string email, cpf, nome, telefone;
                        int id_americanas;

                        email = reader["email_americanas_funcionario"].ToString();
                        cpf = reader["cpf_funcionario"].ToString();
                        nome = reader["nome_funcionario"].ToString();
                        telefone = reader["telefone_funcionario"].ToString();
                        id_americanas = Convert.ToInt32(reader["id_americanas"]);

                        User funcionario = new User(nome, email, senha, cpf, id_americanas, telefone);
                        return funcionario;
                    }
                }

                // Se não encontrou um funcionário com as credenciais fornecidas, você pode lançar uma exceção ou retornar um valor padrão.
                // Exemplo lançando uma exceção:
                throw new InvalidOperationException("Funcionário não encontrado com as credenciais fornecidas.");
            }
            catch (Exception ex)
            {
                // Lidar com exceções de banco de dados ou conexão aqui
                // Pode ser útil logar o erro ou tomar outras ações apropriadas.
                Console.WriteLine("Erro: " + ex.Message);
                return null;
            }
        }

        public DataTable setRead_funcionarios_id(string id_americanas)
        {
            DataTable datatable = new DataTable();
            DataRow novalinha;

            datatable.Columns.Add("Email");
            datatable.Columns.Add("CPF");
            datatable.Columns.Add("Nome");
            datatable.Columns.Add("Telefone");
            datatable.Columns.Add("Id da Loja");
            datatable.Columns.Add("Cep da Loja");
            datatable.Columns.Add("Rua da Loja");
            datatable.Columns.Add("Bairro da Loja");
            datatable.Columns.Add("Número da Loja");

            string query = "SELECT f.email_americanas_funcionario, f.cpf_funcionario, f.nome_funcionario, f.telefone_funcionario, f.id_americanas, a.cep_americanas, a.rua_americanas, a.bairro_americanas, a.numero_americanas FROM funcionario f INNER JOIN americanas a ON f.id_americanas = a.id_americanas WHERE f.id_americanas = @id_americanas AND f.email_americanas_funcionario <> \"administrador@americanas.com.br\"";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add("@id_americanas", MySqlDbType.VarChar, 36).Value = id_americanas;

            MySqlDataReader select = cmd.ExecuteReader();

            while (select.Read())
            {
                novalinha = datatable.NewRow();
                novalinha["Email"] = select.GetString(0);
                novalinha["CPF"] = select.GetString(1);
                novalinha["Nome"] = select.GetString(2);
                novalinha["Telefone"] = select.GetString(3);
                novalinha["Id da Loja"] = select.GetString(4);
                novalinha["Cep da Loja"] = select.GetString(5);
                novalinha["Rua da Loja"] = select.GetString(6);
                novalinha["Bairro da Loja"] = select.GetString(7);
                novalinha["Número da Loja"] = select.GetString(8);
                datatable.Rows.Add(novalinha);
            }

            return datatable;
        }

         public void setRead_pacote_cpf(string cpf)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT pacote.nota_fiscal_pacote, pacote.situacao_pacote, titular.cpf_titular, entregador.cpf_entregador, tbl_data.id_data, hora.id_hora, funcionario.email_americanas_funcionario " +
                                       "FROM pacote " +
                                       "INNER JOIN titular ON pacote.cpf_titular = titular.cpf_titular " +
                                       "INNER JOIN entregador ON pacote.cpf_entregador = entregador.cpf_entregador " +
                                       "INNER JOIN tbl_data ON pacote.id_data = tbl_data.id_data " +
                                       "INNER JOIN hora ON pacote.id_hora = hora.id_hora " +
                                       "INNER JOIN funcionario ON pacote.email_americanas_funcionario = funcionario.email_americanas_funcionario " +
                                       "WHERE titular.cpf_titular = ?", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = cpf;

            cmd.CommandType = CommandType.Text;

            //recebe conteudo do banco
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                //variaveis globais que recebem dados e as chaves estrangeiras da tabela pacote
                retorna_nf = dr.GetString(0);
                retorna_situacao = dr.GetString(1);
                retorna_cpf_titular = dr.GetString(2);
                retorna_cpf_entregador = dr.GetString(3);
                retorna_id_data = dr.GetInt32(4);
                retorna_id_hora = dr.GetInt32(5);
                retorna_email_funcionario = dr.GetString(6);

            }

            dr.Close();
        }
        public void setRead_pacote_nf(string nota_fiscal)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT pacote.nota_fiscal_pacote, pacote.situacao_pacote, titular.cpf_titular, entregador.cpf_entregador, tbl_data.id_data, hora.id_hora, funcionario.email_americanas_funcionario " +
                                       "FROM pacote " +
                                       "INNER JOIN titular ON pacote.cpf_titular = titular.cpf_titular " +
                                       "INNER JOIN entregador ON pacote.cpf_entregador = entregador.cpf_entregador " +
                                       "INNER JOIN tbl_data ON pacote.id_data = tbl_data.id_data " +
                                       "INNER JOIN hora ON pacote.id_hora = hora.id_hora " +
                                       "INNER JOIN funcionario ON pacote.email_americanas_funcionario = funcionario.email_americanas_funcionario " +
                                       "WHERE pacote.nota_fiscal_pacote = @nota_fiscal_pacote;", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@nota_fiscal_pacote", MySqlDbType.VarChar, 75).Value = nota_fiscal;

            cmd.CommandType = CommandType.Text;

            //recebe conteudo do banco
            MySqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                retorna_nf = dr.GetString(0);
                retorna_situacao = dr.GetString(1);
                retorna_cpf_titular = dr.GetString(2);
                retorna_cpf_entregador = dr.GetString(3);
                retorna_id_data = dr.GetInt32(4);
                retorna_id_hora = dr.GetInt32(5);
                retorna_email_funcionario = dr.GetString(6);
            }
            //variaveis globais que recebem dados e as chaves estrangeiras da tabela pacote
            

            dr.Close();
        }


        public void setRead_titular_cpf()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT nome, email, telefone FROM titular WHERE cpf_titular = ?", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = retorna_cpf_titular;

            cmd.CommandType = CommandType.Text;

            //recebe conteudo do banco
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                nome_titular = dr.GetString(0);
                email_titular = dr.GetString(1);
                telefone_titular = dr.GetString(2);

            }
            //nome_titular, email_titular, telefone_titular;
            dr.Close();
        }
        
        public string setRead_titular_ByCpf(string cpf_titular)
        {
            string result = null;

            MySqlCommand cmd = new MySqlCommand("SELECT cpf_titular FROM titular WHERE cpf_titular = ?", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = cpf_titular;

            cmd.CommandType = CommandType.Text;

            MySqlDataReader select = cmd.ExecuteReader();

            if (select.Read())
            {
                result = select.GetString(0);
            }
            select.Close();
            return result;
        }

        public void setRead_entregador()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT nome_entregador FROM entregador WHERE cpf_entregador = ?", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cpf_entregador", MySqlDbType.VarChar, 15).Value = retorna_cpf_entregador;

            cmd.CommandType = CommandType.Text;

            //recebe conteudo do banco
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                retorna_nome_entregador = dr.GetString(0);
            }
    
            dr.Close();
        }
        
        public string setRead_entregador_ByCpf(string cpf_entregador)
        {
            string result = null;

            MySqlCommand cmd = new MySqlCommand("SELECT cpf_entregador FROM entregador WHERE cpf_entregador = ?", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@cpf_entregador", MySqlDbType.VarChar, 15).Value = cpf_entregador;

            cmd.CommandType = CommandType.Text;

            MySqlDataReader select = cmd.ExecuteReader();

            if (select.Read())
            {
                result = select.GetString(0);
            }
            select.Close();
            return result;
        }

        public void setRead_data()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT chegada_data, retirada_data  FROM tbl_data WHERE id_data = ?", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id_data", MySqlDbType.Int32).Value = retorna_id_data;

            cmd.CommandType = CommandType.Text;

            //recebe conteudo do banco
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                retorna_chegada_data = dr.GetDateTime(0).ToString("dd/MM/yyyy");
            }

            dr.Close();
        }

        public void setRead_hora()
        {
            
            MySqlCommand cmd = new MySqlCommand("SELECT chegada_hora  FROM hora WHERE id_hora = ?", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id_hora", MySqlDbType.Int32).Value = retorna_id_hora;

            cmd.CommandType = CommandType.Text;

            //recebe conteudo do banco
            MySqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                retorna_chegada_hora = dr.GetTimeSpan(0).ToString(@"hh\:mm\:ss");
            }

            dr.Close();
        }
        

        public string setRead_Presentes(string id_americanas)
        {
            string pacotesPresentes = "0";

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(p.nota_fiscal_pacote) FROM pacote p INNER JOIN funcionario f ON p.email_americanas_funcionario = f.email_americanas_funcionario WHERE p.situacao_pacote = \"Presente\" AND @id_americanas = f.id_americanas;", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id_americanas", MySqlDbType.VarChar, 36).Value = id_americanas;
            
            MySqlDataReader select = cmd.ExecuteReader();

            if (select.HasRows)
            {
                select.Read();
                pacotesPresentes = Convert.ToString(select[0]);
            }

            select.Close();
            return pacotesPresentes;
        }

        public string setRead_Retirados(string id_americanas)
        {
            string pacotesRetirados = "0";

            DateTime data_atual = DateTime.Now.Date;

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(p.nota_fiscal_pacote) FROM pacote p INNER JOIN tbl_data d ON p.id_data = d.id_data INNER JOIN funcionario f ON p.email_americanas_funcionario = f.email_americanas_funcionario WHERE p.situacao_pacote = \"Retirado\" AND d.retirada_data = @dataAtual AND @id_americanas = f.id_americanas", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id_americanas", MySqlDbType.VarChar, 36).Value = id_americanas;
            cmd.Parameters.Add("@dataAtual", MySqlDbType.Date).Value = data_atual;

            MySqlDataReader select = cmd.ExecuteReader();

            if (select.HasRows)
            {
                select.Read();
                pacotesRetirados = Convert.ToString(select[0]);
            }

            select.Close();
            return pacotesRetirados;
        }
        
        public string setRead_Todos(string id_americanas)
        {
            string pacotesRetirados = "0";

            DateTime data_atual = DateTime.Now.Date;

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(p.nota_fiscal_pacote) FROM pacote p INNER JOIN tbl_data d ON p.id_data = d.id_data INNER JOIN funcionario f ON p.email_americanas_funcionario = f.email_americanas_funcionario WHERE (d.chegada_data = @dataAtual OR d.retirada_data = @dataAtual) AND @id_americanas = f.id_americanas", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id_americanas", MySqlDbType.VarChar, 36).Value = id_americanas;
            cmd.Parameters.Add("@dataAtual", MySqlDbType.Date).Value = data_atual;

            MySqlDataReader select = cmd.ExecuteReader();

            if (select.HasRows)
            {
                select.Read();
                pacotesRetirados = Convert.ToString(select[0]);
            }

            select.Close();
            return pacotesRetirados;
        }

        public List<string> setRead_email_funcionarios_id (string id_americanas)
        {
            List<string> emails = new List<string>();

            MySqlCommand cmd = new MySqlCommand("SELECT email_americanas_funcionario FROM funcionario WHERE funcionario.id_americanas = @id_americanas AND funcionario.email_americanas_funcionario <> \"administrador@americanas.com.br\"", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id_americanas", MySqlDbType.VarChar, 36).Value = id_americanas;

            MySqlDataReader select = cmd.ExecuteReader();

            while (select.Read())
            {
                string email = select.GetString(0);
                emails.Add(email);
            }

            return emails;
        }
        
        public List<string> setRead_endereco_lojas ()
        {
            List<string> lojas = new List<string>();

            MySqlCommand cmd = new MySqlCommand("SELECT id_americanas, cep_americanas, rua_americanas, bairro_americanas, numero_americanas FROM americanas", conn);

            MySqlDataReader select = cmd.ExecuteReader();

            while (select.Read())
            {
                string id = select.GetString(0);
                string cep = select.GetString(1);
                string rua = select.GetString(2);
                string bairro = select.GetString(3);
                string numero = select.GetString(4);

                string loja = $"ID: {id}, CEP: {cep}, {rua}, {bairro}, Número: {numero}";

                lojas.Add(loja);
            }

            return lojas;
        }

        public DataTable setRead_funcionario_Nome (string nome)
        {
            DataTable datatable = new DataTable();
            DataRow novalinha;

            datatable.Columns.Add("Email");
            datatable.Columns.Add("CPF");
            datatable.Columns.Add("Nome");
            datatable.Columns.Add("Telefone");
            datatable.Columns.Add("Id da Loja");
            datatable.Columns.Add("Cep da Loja");
            datatable.Columns.Add("Rua da Loja");
            datatable.Columns.Add("Bairro da Loja");
            datatable.Columns.Add("Número da Loja");

            string query = "SELECT f.email_americanas_funcionario, f.cpf_funcionario, f.nome_funcionario, f.telefone_funcionario, f.id_americanas, a.cep_americanas, a.rua_americanas, a.bairro_americanas, a.numero_americanas FROM funcionario f INNER JOIN americanas a ON f.id_americanas = a.id_americanas WHERE f.nome_funcionario LIKE @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = "%" + nome + "%"; 

            MySqlDataReader select = cmd.ExecuteReader();

            while (select.Read())
            {
                novalinha = datatable.NewRow();
                novalinha["Email"] = select.GetString(0);
                novalinha["CPF"] = select.GetString(1);
                novalinha["Nome"] = select.GetString(2);
                novalinha["Telefone"] = select.GetString(3);
                novalinha["Id da Loja"] = select.GetString(4);
                novalinha["Cep da Loja"] = select.GetString(5);
                novalinha["Rua da Loja"] = select.GetString(6);
                novalinha["Bairro da Loja"] = select.GetString(7);
                novalinha["Número da Loja"] = select.GetString(8);
                datatable.Rows.Add(novalinha);
            }

            return datatable;
        }
        
        public DataTable setRead_funcionario_Cpf (string cpf)
        {
            DataTable datatable = new DataTable();
            DataRow novalinha;

            datatable.Columns.Add("Email");
            datatable.Columns.Add("CPF");
            datatable.Columns.Add("Nome");
            datatable.Columns.Add("Telefone");
            datatable.Columns.Add("Id da Loja");
            datatable.Columns.Add("Cep da Loja");
            datatable.Columns.Add("Rua da Loja");
            datatable.Columns.Add("Bairro da Loja");
            datatable.Columns.Add("Número da Loja");

            string query = "SELECT f.email_americanas_funcionario, f.cpf_funcionario, f.nome_funcionario, f.telefone_funcionario, f.id_americanas, a.cep_americanas, a.rua_americanas, a.bairro_americanas, a.numero_americanas FROM funcionario f INNER JOIN americanas a ON f.id_americanas = a.id_americanas WHERE f.cpf_funcionario LIKE @cpf";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 100).Value = "%" + cpf + "%";

            MySqlDataReader select = cmd.ExecuteReader();

            while (select.Read())
            {
                novalinha = datatable.NewRow();
                novalinha["Email"] = select.GetString(0);
                novalinha["CPF"] = select.GetString(1);
                novalinha["Nome"] = select.GetString(2);
                novalinha["Telefone"] = select.GetString(3);
                novalinha["Id da Loja"] = select.GetString(4);
                novalinha["Cep da Loja"] = select.GetString(5);
                novalinha["Rua da Loja"] = select.GetString(6);
                novalinha["Bairro da Loja"] = select.GetString(7);
                novalinha["Número da Loja"] = select.GetString(8);
                datatable.Rows.Add(novalinha);
            }

            return datatable;
        }
        
        
        public DataTable setRead_funcionario_Email (string email)
        {
            DataTable datatable = new DataTable();
            DataRow novalinha;

            datatable.Columns.Add("Email");
            datatable.Columns.Add("CPF");
            datatable.Columns.Add("Nome");
            datatable.Columns.Add("Telefone");
            datatable.Columns.Add("Id da Loja");
            datatable.Columns.Add("Cep da Loja");
            datatable.Columns.Add("Rua da Loja");
            datatable.Columns.Add("Bairro da Loja");
            datatable.Columns.Add("Número da Loja");

            string query = "SELECT f.email_americanas_funcionario, f.cpf_funcionario, f.nome_funcionario, f.telefone_funcionario, f.id_americanas, a.cep_americanas, a.rua_americanas, a.bairro_americanas, a.numero_americanas FROM funcionario f INNER JOIN americanas a ON f.id_americanas = a.id_americanas WHERE f.email_americanas_funcionario LIKE @email";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = "%" + email + "%";

            MySqlDataReader select = cmd.ExecuteReader();

            while (select.Read())
            {
                novalinha = datatable.NewRow();
                novalinha["Email"] = select.GetString(0);
                novalinha["CPF"] = select.GetString(1);
                novalinha["Nome"] = select.GetString(2);
                novalinha["Telefone"] = select.GetString(3);
                novalinha["Id da Loja"] = select.GetString(4);
                novalinha["Cep da Loja"] = select.GetString(5);
                novalinha["Rua da Loja"] = select.GetString(6);
                novalinha["Bairro da Loja"] = select.GetString(7);
                novalinha["Número da Loja"] = select.GetString(8);
                datatable.Rows.Add(novalinha);
            }

            return datatable;
        }

        public DataTable setRead_funcionario_Telefone (string telefone)
        {
            DataTable datatable = new DataTable();
            DataRow novalinha;

            datatable.Columns.Add("Email");
            datatable.Columns.Add("CPF");
            datatable.Columns.Add("Nome");
            datatable.Columns.Add("Telefone");
            datatable.Columns.Add("Id da Loja");
            datatable.Columns.Add("Cep da Loja");
            datatable.Columns.Add("Rua da Loja");
            datatable.Columns.Add("Bairro da Loja");
            datatable.Columns.Add("Número da Loja");

            string query = "SELECT f.email_americanas_funcionario, f.cpf_funcionario, f.nome_funcionario, f.telefone_funcionario, f.id_americanas, a.cep_americanas, a.rua_americanas, a.bairro_americanas, a.numero_americanas FROM funcionario f INNER JOIN americanas a ON f.id_americanas = a.id_americanas WHERE f.telefone_funcionario LIKE @telefone";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 100).Value = "%" + telefone + "%";

            MySqlDataReader select = cmd.ExecuteReader();

            while (select.Read())
            {
                novalinha = datatable.NewRow();
                novalinha["Email"] = select.GetString(0);
                novalinha["CPF"] = select.GetString(1);
                novalinha["Nome"] = select.GetString(2);
                novalinha["Telefone"] = select.GetString(3);
                novalinha["Id da Loja"] = select.GetString(4);
                novalinha["Cep da Loja"] = select.GetString(5);
                novalinha["Rua da Loja"] = select.GetString(6);
                novalinha["Bairro da Loja"] = select.GetString(7);
                novalinha["Número da Loja"] = select.GetString(8);
                datatable.Rows.Add(novalinha);
            }

            return datatable;
        }

        public DataTable setRead_funcionario_Cep (string cep)
        {
            DataTable datatable = new DataTable();
            DataRow novalinha;

            datatable.Columns.Add("Email");
            datatable.Columns.Add("CPF");
            datatable.Columns.Add("Nome");
            datatable.Columns.Add("Telefone");
            datatable.Columns.Add("Id da Loja");
            datatable.Columns.Add("Cep da Loja");
            datatable.Columns.Add("Rua da Loja");
            datatable.Columns.Add("Bairro da Loja");
            datatable.Columns.Add("Número da Loja");

            string query = "SELECT f.email_americanas_funcionario, f.cpf_funcionario, f.nome_funcionario, f.telefone_funcionario, f.id_americanas, a.cep_americanas, a.rua_americanas, a.bairro_americanas, a.numero_americanas FROM funcionario f INNER JOIN americanas a ON f.id_americanas = a.id_americanas WHERE a.cep_americanas LIKE @cep";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 100).Value = "%" + cep + "%";

            MySqlDataReader select = cmd.ExecuteReader();

            while (select.Read())
            {
                novalinha = datatable.NewRow();
                novalinha["Email"] = select.GetString(0);
                novalinha["CPF"] = select.GetString(1);
                novalinha["Nome"] = select.GetString(2);
                novalinha["Telefone"] = select.GetString(3);
                novalinha["Id da Loja"] = select.GetString(4);
                novalinha["Cep da Loja"] = select.GetString(5);
                novalinha["Rua da Loja"] = select.GetString(6);
                novalinha["Bairro da Loja"] = select.GetString(7);
                novalinha["Número da Loja"] = select.GetString(8);
                datatable.Rows.Add(novalinha);
            }

            return datatable;
        }


        //GET PARA RECUPERAR TODOS OS DADOS SEPARADAMENTE DO BANCO DE DADOS MENOS FUNCIONARIO*******************************************************
        public string getRetorna_nf() { return retorna_nf; }
        public string getRetorna_emailFuncionario() { return retorna_email_funcionario; }
        public string getRetorna_situacao() { return retorna_situacao; }
        public string getRetorna_cpf_titular() { return retorna_cpf_titular; }
        public string getRetorna_cpf_entregador() { return retorna_cpf_entregador; }
        public string getNome_titular() { return nome_titular; }
        public string getEmail_titular() { return email_titular; }
        public string getTelefone_titular() { return telefone_titular; }
        public string getRetorna_nome_entregador() { return retorna_nome_entregador; }
        public string getRetorna_chegada_data() { return retorna_chegada_data; }
        public string getRetorna_retirada_data() { return retorna_retirada_data; }
        public string getRetorna_chegada_hora() { return retorna_chegada_hora; }
        public string getRetorna_retirada_hora() { return retorna_retirada_hora; }
        public int getRetorna_id_data() { return retorna_id_data; }
        public int getRetorna_id_hora() { return retorna_id_hora; }

        // MÉTODOS ENVIO DE DADOS EDITADOS PELO USUÁRIO********************************************************************

        public void setEdit_Retirada(string notaFiscal, string dataRetirada, string horaRetirada)
        {
            string query = "UPDATE pacote p " +
                   "INNER JOIN tbl_data d ON p.id_data = d.id_data " +
                   "INNER JOIN hora h ON p.id_hora = h.id_hora " +
                   "SET p.situacao_pacote = \"Retirado\", d.retirada_data = @dataRetirada, h.retirada_hora = @horaRetirada " +
                   "WHERE p.nota_fiscal_pacote = @notaFiscal;";
            MySqlCommand obj = new MySqlCommand(query, conn);
            obj.Parameters.Clear();
            obj.Parameters.Add("@dataRetirada", MySqlDbType.VarChar, 10).Value = dataRetirada;
            obj.Parameters.Add("@horaRetirada", MySqlDbType.VarChar, 10).Value = horaRetirada;
            obj.Parameters.Add("@notaFiscal", MySqlDbType.VarChar, 75).Value = notaFiscal;

            obj.CommandType = CommandType.Text;
            obj.ExecuteNonQuery();
        }

        public void setEdit_pacote(string nota_fiscal_antiga, string nota_fiscal, string situacao, string funcionario, string cpf_titular, string cpf_entregador)
        {
            MySqlCommand objEdit = new MySqlCommand("UPDATE pacote SET nota_fiscal_pacote = @nova_nota_fiscal_pacote, situacao_pacote = @situacao_pacote, email_americanas_funcionario = @email_americanas_funcionario, cpf_titular = @cpf_titular, cpf_entregador = @cpf_entregador WHERE nota_fiscal_pacote = @nota_fiscal_pacote", conn);
            objEdit.Parameters.Clear();
            objEdit.Parameters.Add("@nova_nota_fiscal_pacote", MySqlDbType.VarChar, 75).Value = nota_fiscal;
            objEdit.Parameters.Add("@situacao_pacote", MySqlDbType.VarChar, 20).Value = situacao;
            objEdit.Parameters.Add("@email_americanas_funcionario", MySqlDbType.VarChar, 30).Value = funcionario;
            objEdit.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = cpf_titular;
            objEdit.Parameters.Add("@cpf_entregador", MySqlDbType.VarChar, 15).Value = cpf_entregador;
            objEdit.Parameters.Add("@nota_fiscal_pacote", MySqlDbType.VarChar, 75).Value = nota_fiscal_antiga; // nota fiscal antiga
            MessageBox.Show(nota_fiscal_antiga);

            objEdit.CommandType = CommandType.Text;
            objEdit.ExecuteNonQuery();
        }

        public void setEdit_titular(string cpf, string nome, string email, string telefone)
        {
            string query = "UPDATE titular t SET t.nome = @nome, t.email = @email, t.telefone = @telefone WHERE t.cpf_titular = @cpf_titular;";

            MySqlCommand objEdit = new MySqlCommand(query, conn);

            //MySqlCommand objEdit = new MySqlCommand("UPDATE titular SET cpf_titular = ?, nome = ?, email = ?, telefone = ? WHERE cpf_titular = ?", conn);
            objEdit.Parameters.Clear();
            objEdit.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = cpf;
            objEdit.Parameters.Add("@nome", MySqlDbType.VarChar, 75).Value = nome;
            objEdit.Parameters.Add("@email", MySqlDbType.VarChar, 30).Value = email;
            objEdit.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = telefone;

            objEdit.CommandType = CommandType.Text;
            objEdit.ExecuteNonQuery();
        }

        public void setEdit_entregador(string cpf, string nome)
        {
            string query = "UPDATE entregador e SET e.nome_entregador = @nome_entregador WHERE e.cpf_entregador = @cpf_entregador;";

            MySqlCommand objEdit = new MySqlCommand(query, conn);
            objEdit.Parameters.Clear();
            objEdit.Parameters.Add("@cpf_entregador", MySqlDbType.VarChar, 15).Value = cpf;
            objEdit.Parameters.Add("@nome_entregador", MySqlDbType.VarChar, 75).Value = nome;


            objEdit.CommandType = CommandType.Text;
            objEdit.ExecuteNonQuery();
        }

        /* public void setEdit_data(string chegada)
         {
             MySqlConnection conn = new MySqlConnection("server=containers-us-west-156.railway.app;port=6863;User Id=root;database=railway;password=uoNk5WCFgcxKJ1AjalxJ");

             MySqlCommand objEdit = new MySqlCommand("UPDATE tbl_data SET chegada_data = ? WHERE id_data = ?", conn);
             objEdit.Parameters.Clear();
             objEdit.Parameters.Add("@chegada_data", MySqlDbType.VarChar, 10).Value = chegada;
             //objEdit.Parameters.Add("@retirada_data", MySqlDbType.VarChar, 10).Value = retirada;
             objEdit.Parameters.Add("@id_data", MySqlDbType.Int32).Value = retorna_id_data;


             objEdit.CommandType = CommandType.Text;
             objEdit.ExecuteNonQuery();
         }

         public void setEdit_hora(string chegada)
         {
             MySqlConnection conn = new MySqlConnection("server=containers-us-west-156.railway.app;port=6863;User Id=root;database=railway;password=uoNk5WCFgcxKJ1AjalxJ");

             MySqlCommand objEdit = new MySqlCommand("UPDATE hora SET chegada_hora = ? WHERE id_hora = ?", conn);
             objEdit.Parameters.Clear();
             objEdit.Parameters.Add("@chegada_hora", MySqlDbType.VarChar, 10).Value = chegada;
             //objEdit.Parameters.Add("@retirada_hora", MySqlDbType.VarChar, 10).Value = '0';
             objEdit.Parameters.Add("@id_hora", MySqlDbType.Int32).Value = retorna_id_hora;


             objEdit.CommandType = CommandType.Text;
             objEdit.ExecuteNonQuery();
         }
        */

        public void setEdit_funcionario (string email, string emailAntigo, string cpf, string nome, string telefone, string id)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE funcionario f SET f.email_americanas_funcionario = @email, f.cpf_funcionario = @cpf, f.nome_funcionario = @nome, f.telefone_funcionario = @telefone, f.id_americanas = @id WHERE f.email_americanas_funcionario = @emailAntigo;", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 30).Value = email;
            cmd.Parameters.Add("@emailAntigo", MySqlDbType.VarChar, 30).Value = emailAntigo;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 15).Value = cpf;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 75).Value = nome;
            cmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = telefone;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar, 36).Value = id;

            cmd.ExecuteNonQuery();
        }


        // MÉTODOS A BAIXO PARA DELETAR DADOS DO BANCO DE DADOS***********************************************************************************************

        public void setDelet_pacote(string notaFiscal) 
        {
            MySqlCommand cmdDelet = new MySqlCommand("DELETE FROM pacote WHERE nota_fiscal_pacote = @nota_fiscal_pacote", conn);
            cmdDelet.Parameters.Clear();
            cmdDelet.Parameters.Add("@nota_fiscal_pacote", MySqlDbType.VarChar, 45).Value = notaFiscal;

            cmdDelet.CommandType = CommandType.Text;
            cmdDelet.ExecuteNonQuery();
            
        }

        public void setDelet_titular(string cpf) 
        {
            MySqlCommand cmdDelet = new MySqlCommand("DELETE FROM titular WHERE cpf_titular = @cpf_titular", conn);
            cmdDelet.Parameters.Clear();
            cmdDelet.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = cpf;

            cmdDelet.CommandType = CommandType.Text;
            cmdDelet.ExecuteNonQuery();
        }

        public void setDelet_entregador(string cpf_entregador) 
        {
            MySqlCommand cmdDelet = new MySqlCommand("DELETE FROM entregador WHERE cpf_entregador = @cpf_entregador", conn);
            cmdDelet.Parameters.Clear();
            cmdDelet.Parameters.Add("@cpf_entregador", MySqlDbType.VarChar, 15).Value = cpf_entregador;

            cmdDelet.CommandType = CommandType.Text;
            cmdDelet.ExecuteNonQuery();
        }

        public void setDelet_data(int id_data) 
        {
            MySqlCommand cmdDelet = new MySqlCommand("DELETE FROM tbl_data WHERE id_data = @id_data", conn);
            cmdDelet.Parameters.Clear();
            cmdDelet.Parameters.Add("@id_data", MySqlDbType.Int32).Value = id_data;

            cmdDelet.CommandType = CommandType.Text;
            cmdDelet.ExecuteNonQuery();
        }

        public void setDelet_hora(int id_hora) 
        {
            MySqlCommand cmdDelet = new MySqlCommand("DELETE FROM hora WHERE id_hora = @id_hora", conn);
            cmdDelet.Parameters.Clear();
            cmdDelet.Parameters.Add("@id_hora", MySqlDbType.Int32).Value = id_hora;

            cmdDelet.CommandType = CommandType.Text;
            cmdDelet.ExecuteNonQuery();
        }

        public void setDelet_funcionario (string email, string novoEmail)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE pacote SET email_americanas_funcionario = @novoEmail WHERE email_americanas_funcionario = @email; DELETE FROM funcionario WHERE email_americanas_funcionario = @email;", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 75).Value = email;
            cmd.Parameters.Add("@novoEmail", MySqlDbType.VarChar, 75).Value = novoEmail;

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        
        }


        // MÉTODOS A BAIXO PARA DATA GRID QUERYIES***********************************************************************************************


        public DataTable setDataTable_pacotesDoDia(string data)
        {
            DataTable dt_pacsDia = new DataTable();
            DataRow newRow;

            // Crie as colunas do DataTable
            dt_pacsDia.Columns.Add("Nota Fiscal");
            dt_pacsDia.Columns.Add("Funcionário");
            dt_pacsDia.Columns.Add("Situação");
            dt_pacsDia.Columns.Add("Titular");
            dt_pacsDia.Columns.Add("Telefone");
            dt_pacsDia.Columns.Add("Email");
            dt_pacsDia.Columns.Add("CPF Titular");
            dt_pacsDia.Columns.Add("Entregador");
            dt_pacsDia.Columns.Add("CPF Entregador");
            dt_pacsDia.Columns.Add("Data de Chegada");
            dt_pacsDia.Columns.Add("Hora de Chegada");
            dt_pacsDia.Columns.Add("Data de Retirada");
            dt_pacsDia.Columns.Add("Hora de Retirada");

            string query = "SELECT p.nota_fiscal_pacote, p.email_americanas_funcionario, p.situacao_pacote, t.nome, t.telefone, t.email, p.cpf_titular, e.nome_entregador," +
                " p.cpf_entregador, d.chegada_data, h.chegada_hora, d.retirada_data, h.retirada_hora FROM pacote p " +
                "INNER JOIN funcionario f ON p.email_americanas_funcionario = f.email_americanas_funcionario " +
                "INNER JOIN titular t ON p.cpf_titular = t.cpf_titular " +
                "INNER JOIN entregador e ON p.cpf_entregador = e.cpf_entregador " +
                "INNER JOIN tbl_data d ON p.id_data = d.id_data " +
                "INNER JOIN hora h ON p.id_hora = h.id_hora " +
                "WHERE d.chegada_data = @chegada_data " +
                "ORDER BY h.chegada_hora ASC, t.nome";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@chegada_data", MySqlDbType.Date).Value = data;

            cmd.CommandType = CommandType.Text;
            try // caso não tenha pacotes ele inicializa pelo try sem pacotes
            {
                //recebe conteudo do banco
                MySqlDataReader select = cmd.ExecuteReader();

                while (select.Read())
                {
                    //recebendo dados para enviar pro Datagridview
                    
                    newRow = dt_pacsDia.NewRow();//cria uma nova linha no datatable
                    newRow["Nota Fiscal"] = select.GetString(0);
                    newRow["Funcionário"] = select.GetString(1);
                    newRow["Situação"] = select.GetString(2);
                    newRow["Titular"] = select.GetString(3);
                    newRow["Telefone"] = select.GetString(4);
                    newRow["Email"] = select.GetString(5);
                    newRow["CPF Titular"] = select.GetString(6);
                    newRow["Entregador"] = select.GetString(7);
                    newRow["CPF Entregador"] = select.GetString(8);
                    newRow["Data de Chegada"] = select.GetDateTime(9).ToString("dd/MM/yyyy");
                    newRow["Hora de Chegada"] = select.GetTimeSpan(10).ToString(@"hh\:mm\:ss");
                    if(!select.IsDBNull(11))
                    {
                        newRow["Data de Retirada"] = select.GetDateTime(11).ToString("dd/MM/yyyy");
                        newRow["Hora de Retirada"] = select.GetTimeSpan(12).ToString(@"hh\:mm\:ss");
                    }
                    else
                    {
                        newRow["Data de Retirada"] = "";
                        newRow["Hora de Retirada"] = "";
                    }
                    // add as linhas do datagridview
                    dt_pacsDia.Rows.Add(newRow);
                }
                select.Close();
                
            }
            catch (Exception ex)
            {
                // Captura e trata a exceção
                MessageBox.Show("Nenhum pacote cadastrado:\n\n" + ex);
            }

            return dt_pacsDia;
        }

        public DataTable setDataTable_pacotesPorOrdem(string data, string order)
        {
            DataTable dt_pacsDia = new DataTable();
            DataRow newRow;

            // Crie as colunas do DataTable
            dt_pacsDia.Columns.Add("Nota Fiscal");
            dt_pacsDia.Columns.Add("Funcionário");
            dt_pacsDia.Columns.Add("Situação");
            dt_pacsDia.Columns.Add("Titular");
            dt_pacsDia.Columns.Add("Telefone");
            dt_pacsDia.Columns.Add("Email");
            dt_pacsDia.Columns.Add("CPF Titular");
            dt_pacsDia.Columns.Add("Entregador");
            dt_pacsDia.Columns.Add("CPF Entregador");
            dt_pacsDia.Columns.Add("Data de Chegada");
            dt_pacsDia.Columns.Add("Hora de Chegada");
            dt_pacsDia.Columns.Add("Data de Retirada");
            dt_pacsDia.Columns.Add("Hora de Retirada");

            string query = "SELECT p.nota_fiscal_pacote, p.email_americanas_funcionario, p.situacao_pacote, t.nome, t.telefone, t.email, p.cpf_titular, e.nome_entregador," +
                " p.cpf_entregador, d.chegada_data, h.chegada_hora, d.retirada_data, h.retirada_hora FROM pacote p " +
                "INNER JOIN funcionario f ON p.email_americanas_funcionario = f.email_americanas_funcionario " +
                "INNER JOIN titular t ON p.cpf_titular = t.cpf_titular " +
                "INNER JOIN entregador e ON p.cpf_entregador = e.cpf_entregador " +
                "INNER JOIN tbl_data d ON p.id_data = d.id_data " +
                "INNER JOIN hora h ON p.id_hora = h.id_hora " +
                "WHERE d.chegada_data = @chegada_data " + order;

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@chegada_data", MySqlDbType.Date).Value = data;

            cmd.CommandType = CommandType.Text;
            try // caso não tenha pacotes ele inicializa pelo try sem pacotes
            {
                //recebe conteudo do banco
                MySqlDataReader select = cmd.ExecuteReader();

                while (select.Read())
                {
                    //recebendo dados para enviar pro Datagridview

                    newRow = dt_pacsDia.NewRow();//cria uma nova linha no datatable
                    newRow["Nota Fiscal"] = select.GetString(0);
                    newRow["Funcionário"] = select.GetString(1);
                    newRow["Situação"] = select.GetString(2);
                    newRow["Titular"] = select.GetString(3);
                    newRow["Telefone"] = select.GetString(4);
                    newRow["Email"] = select.GetString(5);
                    newRow["CPF Titular"] = select.GetString(6);
                    newRow["Entregador"] = select.GetString(7);
                    newRow["CPF Entregador"] = select.GetString(8);
                    newRow["Data de Chegada"] = select.GetDateTime(9).ToString("dd/MM/yyyy");
                    newRow["Hora de Chegada"] = select.GetTimeSpan(10).ToString(@"hh\:mm\:ss");
                    if (!select.IsDBNull(11))
                    {
                        newRow["Data de Retirada"] = select.GetDateTime(11).ToString("dd/MM/yyyy");
                        newRow["Hora de Retirada"] = select.GetTimeSpan(12).ToString(@"hh\:mm\:ss");
                    }
                    else
                    {
                        newRow["Data de Retirada"] = "";
                        newRow["Hora de Retirada"] = "";
                    }
                    // add as linhas do datagridview
                    dt_pacsDia.Rows.Add(newRow);
                }
                select.Close();

            }
            catch (Exception ex)
            {
                // Captura e trata a exceção
                MessageBox.Show("Nenhum pacote cadastrado:\n\n" + ex);
            }

            return dt_pacsDia;
        }

        public DataTable setDataTable_pacotes_presentes()
        {
            DataTable dt_pacsDia = new DataTable();
            DataRow newRow;

            // Crie as colunas do DataTable
            dt_pacsDia.Columns.Add("Nota Fiscal");
            dt_pacsDia.Columns.Add("Funcionário");
            dt_pacsDia.Columns.Add("Situação");
            dt_pacsDia.Columns.Add("Titular");
            dt_pacsDia.Columns.Add("Telefone");
            dt_pacsDia.Columns.Add("Email");
            dt_pacsDia.Columns.Add("CPF Titular");
            dt_pacsDia.Columns.Add("Entregador");
            dt_pacsDia.Columns.Add("CPF Entregador");
            dt_pacsDia.Columns.Add("Data de Chegada");
            dt_pacsDia.Columns.Add("Hora de Chegada");
            dt_pacsDia.Columns.Add("Data de Retirada");
            dt_pacsDia.Columns.Add("Hora de Retirada");

            MySqlCommand cmd = new MySqlCommand("SELECT p.nota_fiscal_pacote, p.email_americanas_funcionario, p.situacao_pacote, t.nome, t.telefone, t.email, p.cpf_titular, e.nome_entregador," +
                " p.cpf_entregador, d.chegada_data, h.chegada_hora, d.retirada_data, h.retirada_hora FROM pacote p " +
                "INNER JOIN funcionario f ON p.email_americanas_funcionario = f.email_americanas_funcionario " +
                "INNER JOIN titular t ON p.cpf_titular = t.cpf_titular " +
                "INNER JOIN entregador e ON p.cpf_entregador = e.cpf_entregador " +
                "INNER JOIN tbl_data d ON p.id_data = d.id_data " +
                "INNER JOIN hora h ON p.id_hora = h.id_hora " +
                "WHERE p.situacao_pacote = \"Presente\"" +
                "ORDER BY h.chegada_hora ASC, t.nome", conn);

            cmd.Parameters.Clear();

            cmd.CommandType = CommandType.Text;
            try 
            {
                MySqlDataReader select = cmd.ExecuteReader();

                while (select.Read())
                {
                    newRow = dt_pacsDia.NewRow();
                    newRow["Nota Fiscal"] = select.GetString(0);
                    newRow["Funcionário"] = select.GetString(1);
                    newRow["Situação"] = select.GetString(2);
                    newRow["Titular"] = select.GetString(3);
                    newRow["Telefone"] = select.GetString(4);
                    newRow["Email"] = select.GetString(5);
                    newRow["CPF Titular"] = select.GetString(6);
                    newRow["Entregador"] = select.GetString(7);
                    newRow["CPF Entregador"] = select.GetString(8);
                    newRow["Data de Chegada"] = select.GetDateTime(9).ToString("dd/MM/yyyy");
                    newRow["Hora de Chegada"] = select.GetTimeSpan(10).ToString(@"hh\:mm\:ss");
                    if(!select.IsDBNull(11))
                    {
                        newRow["Data de Retirada"] = select.GetDateTime(11).ToString("dd/MM/yyyy");
                        newRow["Hora de Retirada"] = select.GetTimeSpan(12).ToString(@"hh\:mm\:ss");
                    }
                    else
                    {
                        newRow["Data de Retirada"] = "";
                        newRow["Hora de Retirada"] = "";
                    }

                    dt_pacsDia.Rows.Add(newRow);
                }
                select.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum pacote cadastrado:\n\n" + ex);
            }

            return dt_pacsDia;
        } 
        
        public DataTable setDataTable_pacotes(string id_loja)
        {
            DataTable dt_pacsDia = new DataTable();
            DataRow newRow;

            // Crie as colunas do DataTable
            dt_pacsDia.Columns.Add("Nota Fiscal");
            dt_pacsDia.Columns.Add("Funcionário");
            dt_pacsDia.Columns.Add("Situação");
            dt_pacsDia.Columns.Add("Titular");
            dt_pacsDia.Columns.Add("Telefone");
            dt_pacsDia.Columns.Add("Email");
            dt_pacsDia.Columns.Add("CPF Titular");
            dt_pacsDia.Columns.Add("Entregador");
            dt_pacsDia.Columns.Add("CPF Entregador");
            dt_pacsDia.Columns.Add("Data de Chegada");
            dt_pacsDia.Columns.Add("Hora de Chegada");
            dt_pacsDia.Columns.Add("Data de Retirada");
            dt_pacsDia.Columns.Add("Hora de Retirada");

            MySqlCommand cmd = new MySqlCommand("SELECT p.nota_fiscal_pacote, p.email_americanas_funcionario, p.situacao_pacote, t.nome, t.telefone, t.email, p.cpf_titular, e.nome_entregador," +
                " p.cpf_entregador, d.chegada_data, h.chegada_hora, d.retirada_data, h.retirada_hora FROM pacote p " +
                "INNER JOIN funcionario f ON p.email_americanas_funcionario = f.email_americanas_funcionario " +
                "INNER JOIN titular t ON p.cpf_titular = t.cpf_titular " +
                "INNER JOIN entregador e ON p.cpf_entregador = e.cpf_entregador " +
                "INNER JOIN tbl_data d ON p.id_data = d.id_data " +
                "INNER JOIN hora h ON p.id_hora = h.id_hora " +
                "WHERE f.id_americanas = @id_loja " +
                "ORDER BY p.situacao_pacote ASC, h.chegada_hora ASC, t.nome", conn);

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@id_loja", MySqlDbType.VarChar, 50).Value = id_loja;

            cmd.CommandType = CommandType.Text;
            try 
            {
                MySqlDataReader select = cmd.ExecuteReader();

                while (select.Read())
                {
                    newRow = dt_pacsDia.NewRow();
                    newRow["Nota Fiscal"] = select.GetString(0);
                    newRow["Funcionário"] = select.GetString(1);
                    newRow["Situação"] = select.GetString(2);
                    newRow["Titular"] = select.GetString(3);
                    newRow["Telefone"] = select.GetString(4);
                    newRow["Email"] = select.GetString(5);
                    newRow["CPF Titular"] = select.GetString(6);
                    newRow["Entregador"] = select.GetString(7);
                    newRow["CPF Entregador"] = select.GetString(8);
                    newRow["Data de Chegada"] = select.GetDateTime(9).ToString("dd/MM/yyyy");
                    newRow["Hora de Chegada"] = select.GetTimeSpan(10).ToString(@"hh\:mm\:ss");
                    if(!select.IsDBNull(11))
                    {
                        newRow["Data de Retirada"] = select.GetDateTime(11).ToString("dd/MM/yyyy");
                        newRow["Hora de Retirada"] = select.GetTimeSpan(12).ToString(@"hh\:mm\:ss");
                    }
                    else
                    {
                        newRow["Data de Retirada"] = "";
                        newRow["Hora de Retirada"] = "";
                    }

                    dt_pacsDia.Rows.Add(newRow);
                }
                select.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum pacote cadastrado:\n\n" + ex);
            }

            return dt_pacsDia;
        } 
        
    }
}
