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
        private int nota_fiscal, data, telefone, cpf;

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
        }

        public void SetCadastro(string funcionario_nome, string titular_nome, string situacao, string email, 
            int nota_fiscal, int data, int telefone, int cpf)
        {
            
            
            this.funcionario_nome= funcionario_nome;
            this.titular_nome= titular_nome;
            this.situacao= situacao;
            this.email= email;
            this.nota_fiscal= nota_fiscal;
            this.data= data;
            this.cpf= cpf;

        }

        //opção de obter dados via tupla (Complica no caso da edição, mas é mais simples, pode ser usada)
         public (string funcionario_nome, string titular_nome, string situacao, string email, 
            int nota_fiscal, int data, int telefone, int cpf) GetCadString()
         {
            return (funcionario_nome, titular_nome, situacao, email, nota_fiscal, data, telefone,cpf);
         }

        public string Funcionario() { return funcionario_nome; }
        public string Titular() { return titular_nome; }
        public string Situacao() { return situacao; }
        public string Email() { return email; }
        public int NotaFiscal() { return nota_fiscal; }
        public int Telefone() { return telefone; }
        public int Data() { return data; }
        public int Cpf() { return cpf;}

    }
}
