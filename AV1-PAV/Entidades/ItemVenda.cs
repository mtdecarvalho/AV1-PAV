using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Entidades
{
    public class ItemVenda : Entidade
    {
        public const string ATRIBUTO_ID_VENDA = "ID_VENDA";
        public const string ATRIBUTO_NUMERO_ITEM = "NUMERO_ITEM";
        public const string ATRIBUTO_ID_PRODUTO = "ID_PRODUTO";
        public const string ATRIBUTO_QUANTIDADE = "QUANTIDADE";
        public const string ATRIBUTO_VALOR_UNITARIO = "VALOR_UNITARIO";
        public const string ATRIBUTO_TOTAL_ITEM = "TOTAL_ITEM";

        public int idVenda                                             { get; set; }
        public int numeroItem                                          { get; set; }
        public int idProduto                                           { get; set; }
        public int quantidade                                          { get; set; }
        public double valorUnitario                                    { get; set; }
        public double totalItem                                        { get; set; }

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
            comando.Parameters[ATRIBUTO_NUMERO_ITEM].Value = numeroItem;
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
