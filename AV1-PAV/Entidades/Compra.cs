using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Entidades
{
    class Compra : Transacao
    {
        public const string ATRIBUTO_ID_COMPRA = "ID_COMPRA";
        public const string ATRIBUTO_ID_FORNECEDOR = "ID_FORNECEDOR";
        public const string ATRIBUTO_TOTAL_COMPRA = "TOTAL_COMPRA";
        public const string ATRIBUTO_SITUACAO_COMPRA = "SITUACAO_COMPRA";

        public int idCompra { get; set; }
        public int idFornecedor { get; set; }
        public double totalCompra { get; set; }
        public string situacaoCompra { get; set; }

        public List<ItemCompra> itens { get; set; }
        public ContaPagar contaPagar { get; set; }

        public Compra()
        {
            itens = new();
        }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_COMPRA].Value = idCompra;
            comando.Parameters[ATRIBUTO_DATA].Value = data;
            comando.Parameters[ATRIBUTO_HORA].Value = hora;
            comando.Parameters[ATRIBUTO_ID_FORNECEDOR].Value = idFornecedor;
            comando.Parameters[ATRIBUTO_TOTAL_COMPRA].Value = totalCompra;
            comando.Parameters[ATRIBUTO_SITUACAO_COMPRA].Value = situacaoCompra;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_COMPRA].Value = idCompra;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idCompra = int.Parse(leitorDados[ATRIBUTO_ID_COMPRA].ToString());
            data = leitorDados[ATRIBUTO_DATA].ToString();
            hora = leitorDados[ATRIBUTO_HORA].ToString();
            idFornecedor = int.Parse(leitorDados[ATRIBUTO_ID_FORNECEDOR].ToString());
            totalCompra = double.Parse(leitorDados[ATRIBUTO_TOTAL_COMPRA].ToString());
            situacaoCompra = leitorDados[ATRIBUTO_SITUACAO_COMPRA].ToString();
        }
    }
}

