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

        private int idProduto;
        private string nome;
        private int qtdEstoque;
        private double preco;
        private string unidade;
        private int idFornecedor;

        public int getIdProduto()                                   { return idProduto;                 }
        public string getNome()                                     { return nome;                      }
        public int getQtdEstoque()                                  { return qtdEstoque;                }
        public double getPreco()                                    { return preco;                     }
        public string getUnidade()                                  { return unidade;                   }
        public double getIdFornecedor()                             { return idFornecedor;              }

        public void setIdProduto(int idProduto)                     { this.idProduto = idProduto;       }
        public void setNome(string nome)                            { this.nome = nome;                 }
        public void setQtdEstoque(int qtdEstoque)                   { this.qtdEstoque = qtdEstoque;     }
        public void setPreco(double preco)                          { this.preco = preco;               }
        public void setUnidade(string unidade)                      { this.unidade = unidade;           }
        public void setIdFornecedor(int idFornecedor)               { this.idFornecedor = idFornecedor; }


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

