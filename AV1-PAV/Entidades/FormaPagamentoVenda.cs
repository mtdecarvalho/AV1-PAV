using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using AV1_PAV.Persistencia;


namespace AV1_PAV.Entidades
{
    class FormaPagamentoVenda : Entidade
    {
        public const string ATRIBUTO_ID_VENDA = "ID_VENDA";
        public const string ATRIBUTO_ID_FORMA_PAGAMENTO = "ID_FORMA_PAGAMENTO";
        public const string ATRIBUTO_VALOR = "VALOR";

        private int idVenda;
        private int idFormaPagamento;
        private double valor;

        public int getIdVenda()                                                 { return idVenda;                           }
        public int getIdFormaPagamento()                                        { return idFormaPagamento;                  }
        public double getValor()                                                { return valor;                             }

        public void setIdVenda(int idVenda)                                     { this.idVenda = idVenda;                   }
        public void setIdFormaPagamento(int idFormaPagamento)                   { this.idFormaPagamento = idFormaPagamento; }
        public void setValor(double valor)                                      { this.valor = valor;                       }

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
