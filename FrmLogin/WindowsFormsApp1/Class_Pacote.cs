using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Class_Pacote
    {
        private string funcionario_nome, titular_nome, situacao, email;
        private int nota_fiscal, data, telefone, cpf, hora;

        public Class_Pacote() 
        {
            funcionario_nome = null;
            titular_nome = null;
            situacao = null;
            email = null;
            nota_fiscal = 0;
            telefone = 0;
            data = 0;
            cpf = 0;
            hora = 0;
        }

        /*public Class_Pacote(string funcionario_txt, string titular_txt, string situacao_txt, string email_txt,
            int notaFiscal_txt, int data_txt, int telefone_txt, int cpf_txt, int hora_txt)
        {
            // a validação dos items ira ser feita nesse campo..
            this.funcionario_nome = funcionario_txt;
            this.titular_nome = titular_txt;
            this.situacao = situacao_txt;
            this.email = email_txt;
            this.nota_fiscal = notaFiscal_txt;
            this.data = data_txt;
            this.telefone = telefone_txt;
            this.cpf = cpf_txt;
            this.hora = hora_txt;
        }*/

        public void SetCadastro(string funcionario_nome, string titular_nome, string situacao, string email, int nota_fiscal, int data, int telefone, int cpf, int hora)
        {
            
            
            this.funcionario_nome= funcionario_nome;
            this.titular_nome= titular_nome;
            this.situacao= situacao;
            this.email= email;
            this.nota_fiscal= nota_fiscal;
            this.telefone= telefone;
            this.data= data;
            this.cpf= cpf;
            this.hora= hora;

        }

        /*opção de obter dados via tupla (Complica no caso da edição, mas é mais simples, pode ser usada)
         public (string funcionario_nome, string titular_nome, string situacao, string email, 
            int nota_fiscal, int data, int telefone, int cpf, int hora) GetCadString()
         {
            return (funcionario_nome, titular_nome, situacao, email, nota_fiscal, data, telefone, cpf, hora);
         }*/

        public string getFuncionarioPac() { return funcionario_nome; }
        public string getTitularPac() { return titular_nome; }
        public string getSituacaoPac() { return situacao; }
        public string getEmailPac() { return email; }
        public int getNotaFiscalPac() { return nota_fiscal; }
        public int getTelefonePac() { return telefone; }
        public int getDataPac() { return data; }
        public int getCpfPac() { return cpf;}
        public int getHoraPac() { return hora; }
    }
}
