using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Entidades
{
    public class Produto : Entidade
    {
        public const string ATRIBUTO_ID_PRODUTO = "ID_PRODUTO";
        public const string ATRIBUTO_NOME = "NOME";
        public const string ATRIBUTO_QUANTIDADE_ESTOQUE = "QUANTIDADE_ESTOQUE";
        public const string ATRIBUTO_PRECO = "PRECO";
        public const string ATRIBUTO_UNIDADE = "UNIDADE";
        public const string ATRIBUTO_ID_FORNECEDOR = "ID_FORNECEDOR";

        public int idProduto                                   { get; set; }
        public string nome                                     { get; set; }
        public int qtdEstoque                                  { get; set; }
        public double preco                                    { get; set; }
        public string unidade                                  { get; set; }
        public double idFornecedor                             { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = idProduto;
            comando.Parameters[ATRIBUTO_NOME].Value = nome;
            comando.Parameters[ATRIBUTO_QUANTIDADE_ESTOQUE].Value = qtdEstoque;
            comando.Parameters[ATRIBUTO_PRECO].Value = preco;
            comando.Parameters[ATRIBUTO_UNIDADE].Value = unidade;
            comando.Parameters[ATRIBUTO_ID_FORNECEDOR].Value = idFornecedor;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = idProduto;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idProduto = int.Parse(leitorDados[ATRIBUTO_ID_PRODUTO].ToString());
            nome = leitorDados[ATRIBUTO_NOME].ToString();
            qtdEstoque = int.Parse(leitorDados[ATRIBUTO_QUANTIDADE_ESTOQUE].ToString());
            preco = double.Parse(leitorDados[ATRIBUTO_PRECO].ToString());
            unidade = leitorDados[ATRIBUTO_UNIDADE].ToString();
            idFornecedor = int.Parse(leitorDados[ATRIBUTO_ID_FORNECEDOR].ToString());
        }
    }

}

