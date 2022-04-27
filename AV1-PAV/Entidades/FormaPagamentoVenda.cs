using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Entidades
{
    public class FormaPagamentoVenda : Entidade
    {
        public const string ATRIBUTO_ID_VENDA = "ID_VENDA";
        public const string ATRIBUTO_ID_FORMA_PAGAMENTO = "ID_FORMA_PAGAMENTO";
        public const string ATRIBUTO_VALOR = "VALOR";

        public int idVenda                                                 { get; set; }
        public int idFormaPagamento                                        { get; set; }
        public double valor                                                { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = idVenda;
            comando.Parameters[ATRIBUTO_ID_FORMA_PAGAMENTO].Value = idFormaPagamento;
            comando.Parameters[ATRIBUTO_VALOR].Value = valor;

        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = idVenda;
            comando.Parameters[ATRIBUTO_ID_FORMA_PAGAMENTO].Value = idFormaPagamento;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idVenda = int.Parse(leitorDados[ATRIBUTO_ID_VENDA].ToString());
            idFormaPagamento = int.Parse(leitorDados[ATRIBUTO_ID_FORMA_PAGAMENTO].ToString());
            valor = double.Parse(leitorDados[ATRIBUTO_VALOR].ToString());
        }

    }
}
