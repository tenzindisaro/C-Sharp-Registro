using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Class_BD_CRUD
    {       

        public Class_BD_CRUD() 
        {
            var strConnection = "server=localhost;port=3307;User Id=root;database=projeto_registro_sql;password=usbw";
            MySqlConnection conn = new MySqlConnection(strConnection);
            //abre o BD
            conn.Open();
            MessageBox.Show("Banco de Dados open.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
        public void setBD_Open()
        {
            var strConnection = "server=localhost;port=3307;User Id=root;database=projeto_registro_sql;password=usbw";
            MySqlConnection conn = new MySqlConnection(strConnection);
            //abre o BD
            conn.Open();
            MessageBox.Show("Banco de Dados open.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void setBD_Close() 
        {
            var strConnection = "server=localhost;port=3307;User Id=root;database=projeto_registro_sql;password=usbw";
            MySqlConnection conn = new MySqlConnection(strConnection);
            //fecha o BD
            conn.Close();
            MessageBox.Show("BD fechado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void setInputBd_funcionario(string nome_funcionario)
        {
            var strConnection = "server=localhost;port=3307;User Id=root;database=projeto_registro_sql;password=usbw";
            MySqlConnection conn = new MySqlConnection(strConnection);

            //?????? como referenciar fazer ainda...
        }

        public void setInputBd_titular (string cpf_titular, string nome, string email, string telefone)
        {
            var strConnection = "server=localhost;port=3307;User Id=root;database=projeto_registro_sql;password=usbw";
            MySqlConnection conn = new MySqlConnection(strConnection);

            MySqlCommand objcmd_titular = new MySqlCommand("insert into titular (cpf_titular, nome, email, telefone) values (?, ?, ?, ?)", conn);
            // parametros para o sql titular
            objcmd_titular.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = "88888888888"; //dadosValidos_CPF ;
            objcmd_titular.Parameters.Add("@nome", MySqlDbType.VarChar, 75).Value = "joao";//dadosValidos_titular;
            objcmd_titular.Parameters.Add("@email", MySqlDbType.VarChar, 30).Value = "americanas12";//dadosValidos_email;
            objcmd_titular.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = "123654879"; //dadosValidos_telefone;
            // executando querys            
            objcmd_titular.ExecuteNonQuery();
            MessageBox.Show("envio de dados titular ok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void setInputBd_data(string chegada_data, string retirada_data)
        {
            var strConnection = "server=localhost;port=3307;User Id=root;database=projeto_registro_sql;password=usbw";
            MySqlConnection conn = new MySqlConnection(strConnection);

            MySqlCommand objcmd_data = new MySqlCommand("insert into tbl_data (id_data, chegada_data, retirada_data) values (NULL, ?, ?)", conn);
            // parametros para o sql data
            objcmd_data.Parameters.Add("@chegada_data", MySqlDbType.VarChar, 10).Value = "12061995";//dadosValidos_data;
            objcmd_data.Parameters.Add("@retirada_data", MySqlDbType.VarChar, 10).Value = "25131998";//dadosValidos_data;
             // executando query                       
            objcmd_data.ExecuteNonQuery();
            MessageBox.Show("envio de dados data ok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
        
        public void setInputBd_hora(string chegada_hora, string retirada_hora)
        {
            var strConnection = "server=localhost;port=3307;User Id=root;database=projeto_registro_sql;password=usbw";
            MySqlConnection conn = new MySqlConnection(strConnection);

            MySqlCommand objcmd_hora = new MySqlCommand("insert into hora (id_hora, chegada_hora, retirada_hora) values (NULL, ?, ?)", conn);
            // parametros para o sql hora
            objcmd_hora.Parameters.Add("@chegada_hora", MySqlDbType.VarChar, 10).Value = "0809";//dadosValidos_hora;
            objcmd_hora.Parameters.Add("@retirada_hora", MySqlDbType.VarChar, 10).Value = "2122";//dadosValidos_hora;
            // executando query                       
            objcmd_hora.ExecuteNonQuery();
            MessageBox.Show("envio de dados hora ok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void setInputBd_pacote(string nota_fiscal, string situacao_pacote)
        {
            // string de conexão BD
            var strConnection = "server=localhost;port=3307;User Id=root;database=projeto_registro_sql;password=usbw";
            MySqlConnection conn = new MySqlConnection(strConnection);

            MySqlCommand objcmd_pacote = new MySqlCommand("insert into pacote (nota_fiscal_pacote, situacao_pacote) values (?, ?)", conn);
            // parametros para o sql pacote
            objcmd_pacote.Parameters.Add("@nota_fiscal_pacote", MySqlDbType.VarChar, 45).Value = "2222222222222";//dadosValidos_notaFiscal;
            objcmd_pacote.Parameters.Add("@situacao_pacote", MySqlDbType.VarChar, 20).Value = "recebido";//dadosValidos_situacao;
            // executando query                       
            objcmd_pacote.ExecuteNonQuery();
            MessageBox.Show("envio de dados pacote ok.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
