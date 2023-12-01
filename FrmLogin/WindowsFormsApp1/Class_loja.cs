using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Class_loja
    {
        private string Id, cep, rua, bairro, numero, telefone;

        public Class_loja (string id_loja, string cep_loja, string rua_loja, string bairro_loja, string numero_loja, string telefone_loja)
        {
            Id = id_loja;
            cep = cep_loja;
            rua = rua_loja; 
            bairro = bairro_loja;
            numero = numero_loja;
            telefone = telefone_loja;
        }

        public string getIdLoja()
        {
            return Id;
        }

        public string getCepLoja()
        {
            return cep;
        }

        public string getRuaLoja()
        {
            return rua;
        }

        public string getBairroLoja()
        {
            return bairro;
        }

        public string getNumeroLoja()
        {
            return numero;
        }
        
        public string getTelefoneLoja()
        {
            return telefone;
        }
    }
}
