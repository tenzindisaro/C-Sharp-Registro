using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.RegistrosPac
{
    public partial class Form5_Registro_Pac : Form
    {
        Class_CadastroPac cadastroPacote = new Class_CadastroPac();
        Class_Pacote  envio_dadosValidados = new Class_Pacote();
       
        /*DUVIDA EM QUESTÃO DO ENVEIO DE DADOS, SE É PRECISO MAIS DE UM OBJ
         * Class_Pacote  dadosValidos_funcionario = new Class_Pacote();
        Class_Pacote  dadosValidos_titular = new Class_Pacote();
        Class_Pacote  dadosValidos_situacao = new Class_Pacote();
        Class_Pacote  dadosValidos_email = new Class_Pacote();
        Class_Pacote  dadosValidos_notaFiscal = new Class_Pacote();
        Class_Pacote  dadosValidos_data = new Class_Pacote();
        Class_Pacote  dadosValidos_telefone = new Class_Pacote();
        Class_Pacote  dadosValidos_CPF = new Class_Pacote();
        Class_Pacote  dadosValidos_hora = new Class_Pacote();
        */


        public Form5_Registro_Pac()
        {
            InitializeComponent();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            string funcionario = textBox_Funcionario.Text;
            string notaFiscal = textBox_NotaFiscal.Text;
            string data = maskedTextBox_Data.Text;
            string titular = textBox_Titular.Text;
            string CPF = maskedTextBox_CPF.Text;
            string situacao = comboBox_Situacao.Text;
            string email = maskedTextBox_email.Text;
            string telefone = maskedTextBox_telefone.Text;
            string hora = maskedTextBox_Hora.Text;


            if (funcionario != null && notaFiscal != null && data != null && titular != null & CPF != null && situacao != null 
                && email != null && telefone != null && hora != null)
            {          
                              
                cadastroPacote.setValid_dados(funcionario, titular, situacao, email, notaFiscal, data, telefone, CPF, hora );

                 /*DÚVIDA EM QUESTÃO DE BOAS PRÁTICAS?
                  * dadosValidos_funcionario = cadastroPacote.getCad_Funcionario();
                 dadosValidos_titular = cadastroPacote.getCad_Titular();
                 dadosValidos_situacao = cadastroPacote.getCad_Situacao();
                 dadosValidos_email = cadastroPacote.getCad_Email();
                 dadosValidos_notaFiscal = cadastroPacote.getCad_NotaFiscal();
                 dadosValidos_data = cadastroPacote.getCad_Data();
                 dadosValidos_telefone = cadastroPacote.getCad_Telefone();
                 dadosValidos_CPF = cadastroPacote.getCad_Cpf();
                 dadosValidos_hora = cadastroPacote.getCad_Hora();
                 */

                envio_dadosValidados.SetCadastro(cadastroPacote.getCad_Funcionario(), cadastroPacote.getCad_Titular(), cadastroPacote.getCad_Situacao(), cadastroPacote.getCad_Email(), cadastroPacote.getCad_NotaFiscal(), cadastroPacote.getCad_Data(), cadastroPacote.getCad_Telefone(), cadastroPacote.getCad_Cpf(),
                    cadastroPacote.getCad_Hora());

            }
            else
            {                
                MessageBox.Show("Todos os campos de cadastro precisam ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            try
            {
                // string de conexão BD
                var strConnection = "server=localhost;port=3307;User Id=root;database=projeto_registro_sql;password=usbw";
                MySqlConnection conn = new MySqlConnection(strConnection);
                //abre o BD
                conn.Open();
                //comando para inserir dados Tableas BD
                MySqlCommand objcmd_titular = new MySqlCommand("insert into titular (cpf_titular, nome, email, telefone) values (?, ?, ?, ?)", conn);
                MySqlCommand objcmd_data = new MySqlCommand("insert into tbl_data (id_data, chegada_data, retirada_data) values (NULL, ?, ?)", conn);
                MySqlCommand objcmd_hora = new MySqlCommand("insert into hora (id_hora, chegada_hora, retirada_hora) values (NULL, ?, ?)", conn);
                MySqlCommand objcmd_pacote = new MySqlCommand("insert into pacote (nota_fiscal_pacote, situacao_pacote) values (?, ?)", conn);
                // parametros para o sql titular
                objcmd_titular.Parameters.Add("@cpf_titular", MySqlDbType.VarChar, 15).Value = envio_dadosValidados.getCpfPac();
                objcmd_titular.Parameters.Add("@nome", MySqlDbType.VarChar, 75).Value = envio_dadosValidados.getNomeTitularPac();
                objcmd_titular.Parameters.Add("@email", MySqlDbType.VarChar, 30).Value = envio_dadosValidados.getEmailPac();
                objcmd_titular.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = envio_dadosValidados.getTelefonePac();
                // parametros para o sql data
                objcmd_data.Parameters.Add("@chegada_data", MySqlDbType.VarChar, 10).Value = envio_dadosValidados.getDataPac();
                objcmd_data.Parameters.Add("@retirada_data", MySqlDbType.VarChar, 10).Value = envio_dadosValidados.getDataPac();
                // parametros para o sql hora
                objcmd_hora.Parameters.Add("@chegada_hora", MySqlDbType.VarChar, 10).Value = envio_dadosValidados.getHoraPac();
                objcmd_hora.Parameters.Add("@retirada_hora", MySqlDbType.VarChar, 10).Value = envio_dadosValidados.getHoraPac();
                // parametros para o sql pacote
                objcmd_pacote.Parameters.Add("@nota_fiscal_pacote", MySqlDbType.VarChar, 45).Value = envio_dadosValidados.getNotaFiscalPac();
                objcmd_pacote.Parameters.Add("@situacao_pacote", MySqlDbType.VarChar, 20).Value = envio_dadosValidados.getSituacaoPac();
                // executando querys
                objcmd_titular.ExecuteNonQuery();
                objcmd_data.ExecuteNonQuery();
                objcmd_hora.ExecuteNonQuery();
                objcmd_pacote.ExecuteNonQuery();
                
                //fecha o BD
                conn.Close();
                
            }
            catch(Exception erro)
            {
                MessageBox.Show("erro conectar banco de dados." + erro);
            }
        }

        
    }
}
