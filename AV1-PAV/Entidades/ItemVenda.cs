using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AV1_PAV.Persistencia;

namespace AV1_PAV.Entidades
{
    class ItemVenda : Entidade
    {
        public const string ATRIBUTO_ID_VENDA = "ID_VENDA";
        public const string ATRIBUTO_NUMERO_ITEM = "NUMERO_ITEM";
        public const string ATRIBUTO_ID_PRODUTO = "ID_PRODUTO";
        public const string ATRIBUTO_QUANTIDADE = "QUANTIDADE";
        public const string ATRIBUTO_VALOR_UNITARIO = "VALOR_UNITARIO";
        public const string ATRIBUTO_TOTAL_ITEM = "TOTAL_ITEM";

        private int idVenda;
        private int numeroItem;
        private int idProduto;
        private int quantidade;
        private double valorUnitario;
        private double totalItem;

        public int getIdVenda()                                             { return idVenda;                       }
        public int getNumeroItem()                                          { return numeroItem;                    }
        public int getIdProduto()                                           { return idProduto;                     }
        public int getQuantidade()                                          { return quantidade;                    }
        public double getValorUnitario()                                    { return valorUnitario;                 }
        public double getTotalItem()                                        { return totalItem;                     }

        public void setIdVenda(int idVenda)                                 { this.idVenda = idVenda;               }
        public void setNumeroItem(int numeroItem)                           { this.numeroItem = numeroItem;         }
        public void setIdProduto(int idProduto)                             { this.idProduto = idProduto;           }
        public void setQuantidade(int quantidade)                           { this.quantidade = quantidade;         }
        public void setValorUnitario(double valorUnitario)                  { this.valorUnitario = valorUnitario;   }
        public void setTotalItem(double totalItem)                          { this.totalItem = totalItem;           }


        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = idVenda;
            comando.Parameters[ATRIBUTO_NUMERO_ITEM].Value = numeroItem;
            comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = idProduto;
            comando.Parameters[ATRIBUTO_QUANTIDADE].Value = quantidade;
            comando.Parameters[ATRIBUTO_VALOR_UNITARIO].Value = valorUnitario;
            comando.Parameters[ATRIBUTO_TOTAL_ITEM].Value = totalItem;

        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = idVenda;
            comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = idProduto;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idVenda = int.Parse(leitorDados[ATRIBUTO_ID_VENDA].ToString());
            numeroItem = int.Parse(leitorDados[ATRIBUTO_NUMERO_ITEM].ToString());
            idProduto = int.Parse(leitorDados[ATRIBUTO_ID_PRODUTO].ToString());
            quantidade = int.Parse(leitorDados[ATRIBUTO_QUANTIDADE].ToString());
            valorUnitario = double.Parse(leitorDados[ATRIBUTO_VALOR_UNITARIO].ToString());
            totalItem= double.Parse(leitorDados[ATRIBUTO_TOTAL_ITEM].ToString());
        }
    }
}
