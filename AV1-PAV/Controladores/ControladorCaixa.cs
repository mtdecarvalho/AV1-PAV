using AV1_PAV.Entidades;
using AV1_PAV.SQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_PAV.Controladores
{
    class ControladorCaixa
    {
        public const string ENTRADA = "ENTRADA";
        public const string SAIDA = "SAIDA";
        public void atualizar (MovimentoCaixa movimentoCaixa)
        {
            double saldo = MovimentoCaixaSQL.getSaldo(movimentoCaixa.idCaixa);
            double novoSaldo;

            if (movimentoCaixa.tipoMovimento == ENTRADA)
                novoSaldo = saldo + movimentoCaixa.valor;
            else if (movimentoCaixa.tipoMovimento == SAIDA)
                novoSaldo = saldo - movimentoCaixa.valor;

            MySqlCommand comandoAtualizacao = new MySqlCommand("UPDATE conta SET saldo = " + novoSaldo + " WHERE id_caixa = " + movimentoCaixa.idCaixa);
            comandoAtualizacao.ExecuteNonQuery();
        }
    }
}
