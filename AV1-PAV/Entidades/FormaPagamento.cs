using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Entidades
{
    class FormaPagamento : Entidade
    {
        public const string ATRIBUTO_ID_FORMA_PAGAMENTO = "ID_FORMA_PAGAMENTO";
        public const string ATRIBUTO_NOME = "NOME";

        private int idFormaPagamento;
        private string nome;

        public int getIdFormaPagamento()                                { return idFormaPagamento;                  }
        public string getNome()                                         { return nome;                              }

        public void setIdFormaPagamento(int idFormaPagamento)           { this.idFormaPagamento = idFormaPagamento; }
        public void setNome(string nome)                                { this.nome = nome;                         }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_FORMA_PAGAMENTO].Value = idFormaPagamento;
            comando.Parameters[ATRIBUTO_NOME].Value = nome;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_FORMA_PAGAMENTO].Value = idFormaPagamento;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            idFormaPagamento = int.Parse(leitorDados[ATRIBUTO_ID_FORMA_PAGAMENTO].ToString());
            nome = leitorDados[ATRIBUTO_NOME].ToString();
        }

    }
}
