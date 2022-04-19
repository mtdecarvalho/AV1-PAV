using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Entidades
{
    public class Cliente : Entidade
    {
        public const string ATRIBUTO_ID_CLIENTE = "ID_CLIENTE";
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

        public int idCliente                       { get; set; }
        public string nome                         { get; set; }
        public string cpfCnpj                      { get; set; }
        public string logradouro                   { get; set; }
        public int numero                          { get; set; }
        public string complemento                  { get; set; }
        public string bairro                       { get; set; }
        public string cidade                       { get; set; }
        public string estado                       { get; set; }
        public string cep                          { get; set; }
        public string telefone                     { get; set; }
        public string email                        { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = idCliente;
            comando.Parameters[ATRIBUTO_NOME].Value = nome;
            comando.Parameters[ATRIBUTO_CPF_CNPJ].Value = cpfCnpj;
            comando.Parameters[ATRIBUTO_LOGRADOURO].Value = logradouro;
            comando.Parameters[ATRIBUTO_NUMERO].Value = numero;
            comando.Parameters[ATRIBUTO_COMPLEMENTO].Value = complemento;
            comando.Parameters[ATRIBUTO_BAIRRO].Value = bairro;
            comando.Parameters[ATRIBUTO_CIDADE].Value = cidade;
            comando.Parameters[ATRIBUTO_ESTADO].Value = bairro;
            comando.Parameters[ATRIBUTO_CEP].Value = cep;
            comando.Parameters[ATRIBUTO_TELEFONE].Value = telefone;
            comando.Parameters[ATRIBUTO_EMAIL].Value = email;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = idCliente;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idCliente = int.Parse(leitorDados[ATRIBUTO_ID_CLIENTE].ToString());
            nome = leitorDados[ATRIBUTO_NOME].ToString();
            cpfCnpj = leitorDados[ATRIBUTO_CPF_CNPJ].ToString();
            logradouro = leitorDados[ATRIBUTO_LOGRADOURO].ToString();
            numero = int.Parse(leitorDados[ATRIBUTO_NUMERO].ToString());
            complemento = leitorDados[ATRIBUTO_COMPLEMENTO].ToString();
            bairro = leitorDados[ATRIBUTO_BAIRRO].ToString();
            cidade = leitorDados[ATRIBUTO_CIDADE].ToString();
            estado = leitorDados[ATRIBUTO_ESTADO].ToString();
            cep = leitorDados[ATRIBUTO_CEP].ToString();
            telefone = leitorDados[ATRIBUTO_TELEFONE].ToString();
            email = leitorDados[ATRIBUTO_EMAIL].ToString();
        }
    }
}
