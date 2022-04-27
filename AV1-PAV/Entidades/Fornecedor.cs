using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_PAV.Entidades
{
    public class Fornecedor : Pessoa
    {
        public const string ATRIBUTO_ID_FORNECEDOR = "ID_FORNECEDOR";

        public int idFornecedor { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_FORNECEDOR].Value = idFornecedor;
            comando.Parameters[ATRIBUTO_NOME].Value = nome;
            comando.Parameters[ATRIBUTO_CPF_CNPJ].Value = cpfCnpj;
            comando.Parameters[ATRIBUTO_LOGRADOURO].Value = logradouro;
            comando.Parameters[ATRIBUTO_NUMERO].Value = numero;
            comando.Parameters[ATRIBUTO_COMPLEMENTO].Value = complemento;
            comando.Parameters[ATRIBUTO_BAIRRO].Value = bairro;
            comando.Parameters[ATRIBUTO_CIDADE].Value = cidade;
            comando.Parameters[ATRIBUTO_ESTADO].Value = estado;
            comando.Parameters[ATRIBUTO_CEP].Value = cep;
            comando.Parameters[ATRIBUTO_TELEFONE].Value = telefone;
            comando.Parameters[ATRIBUTO_EMAIL].Value = email;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_FORNECEDOR].Value = idFornecedor;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idFornecedor = int.Parse(leitorDados[ATRIBUTO_ID_FORNECEDOR].ToString());
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
