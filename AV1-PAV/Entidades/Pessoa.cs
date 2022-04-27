using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_PAV.Entidades
{
    public abstract class Pessoa : Entidade
    {
        public const string ATRIBUTO_NOME = "NOME";
        public const string ATRIBUTO_CPF_CNPJ = "CPF_CNPJ";
        public const string ATRIBUTO_LOGRADOURO = "LOGRADOURO";
        public const string ATRIBUTO_NUMERO = "NUMERO";
        public const string ATRIBUTO_COMPLEMENTO = "COMPLEMENTO";
        public const string ATRIBUTO_BAIRRO = "BAIRRO";
        public const string ATRIBUTO_CIDADE = "CIDADE";
        public const string ATRIBUTO_ESTADO = "ESTADO";
        public const string ATRIBUTO_CEP = "CEP";
        public const string ATRIBUTO_TELEFONE = "TELEFONE";
        public const string ATRIBUTO_EMAIL = "EMAIL";

        public string nome { get; set; }
        public string cpfCnpj { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
