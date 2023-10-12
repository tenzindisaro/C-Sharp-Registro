using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    internal class Class_CadastroPac
    {
        Class_Pacote envio_dadosValidados = new Class_Pacote();        

        public Class_CadastroPac(string funcionario_txt, string titular_txt, string situacao_txt, string email_txt,    
            string notaFiscal_txt, string data_txt, string telefone_txt, string cpf_txt, string hora_txt)
        {
            // a validação dos items ira ser feita nesse campo..
            string EntradaFuncionario = funcionario_txt;
            string EntradaTitular = titular_txt;
            string EntradaSituacao = situacao_txt;
            string EntradaEmail = email_txt;
            string EntradaNotaFiscal = notaFiscal_txt;
            string EntradaData = data_txt;
            string EntradaTelefone = telefone_txt;
            string EntradaCpf = cpf_txt;
            string EntradaHora = hora_txt;

            // validação para caso de inserção de letras em campos int.
            bool transform_notaFiscal = int.TryParse(EntradaNotaFiscal, out int valid_notaFiscal);
            bool transform_entradaData = int.TryParse(EntradaData, out int valid_data);
            bool transform_CPF = int.TryParse(EntradaCpf, out int valid_cpf);
            bool transform_telefone = int.TryParse(EntradaTelefone, out int valid_telefone);
            bool transform_hora = int.TryParse(EntradaHora, out int valid_hora);

            // Para entender o código melhor comece pelo If do meio do código.
            if (Regex.IsMatch(EntradaFuncionario, "^[a-zA-Z ]+$"))
            {
                string funcionario = EntradaFuncionario;               
                
                if (transform_notaFiscal == true)
                {
                    int notaFiscal = valid_notaFiscal;                                    
                                        
                    if (transform_entradaData == true)
                    {
                        int data = valid_data;
                                                
                        if (Regex.IsMatch(EntradaTitular, "^[a-zA-Z ]+$"))
                        {
                            string titular = EntradaTitular;                                                       

                            if (transform_CPF == true)
                            {
                                int CPF = valid_cpf;
                                /*se precisar fazer validação????
                                 * string situacao = comboBox_Situacao.Text;
                                string email = maskedTextBox_email.Text; */


                                if (transform_telefone == true)
                                {
                                    int telefone = valid_telefone;

                                    if (transform_hora == true)
                                    {
                                        int hora = valid_hora;

                                        // envia dados validados para class_pacote
                                        envio_dadosValidados.SetCadastro(funcionario, titular, EntradaSituacao, EntradaEmail, notaFiscal, data, telefone, CPF, hora);
                                    }
                                    else { MessageBox.Show("Insira apenas numeros no campo Hora.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                                }
                                else { MessageBox.Show("Insira apenas numeros no campo Telefone.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }                                

                            }
                            else { MessageBox.Show("Insira apenas numeros no campo CPF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                        }
                        else { MessageBox.Show("Insira apenas letras no campo Titular.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("Insira apenas numeros no campo Data.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                else { MessageBox.Show("Insira apenas numeros no campo Nota Fiscal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else { MessageBox.Show("Insira apenas letras no campo Funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }         

        }    

    }    
}
