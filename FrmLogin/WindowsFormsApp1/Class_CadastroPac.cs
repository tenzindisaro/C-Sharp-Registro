using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Class_CadastroPac
    {
        private string funcionario_txt, titular_txt, situacao_txt, email_txt;
        private int notaFiscal_txt, data_txt, telefone_txt, cpf_txt;

        public Class_CadastroPac(string funcionario_txt, string titular_txt, string situacao_txt, string email_txt,
            int notaFiscal_txt, int data_txt, int telefone_txt, int cpf_txt)
        {
            // a validação dos items ira ser feita nesse campo..
            this.funcionario_txt = funcionario_txt;
            this.titular_txt = titular_txt;
            this.situacao_txt = situacao_txt;
            this.email_txt = email_txt; 
            this.notaFiscal_txt = notaFiscal_txt;
            this.data_txt = data_txt;   
            this.telefone_txt = telefone_txt;
            this.cpf_txt = cpf_txt;
        }


    }    
}
