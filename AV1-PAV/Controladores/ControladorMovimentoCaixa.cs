using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_PAV.Controladores
{
    class ControladorMovimentoCaixa
    {
        
        public void incluir (Venda venda)
        {
            const string DESCRICAO = "VENDA";
            const string TIPO_MOVIMENTO = "ENTRADA";
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                // pegar saldo atual do caixa para depois somar com o novo saldo e incluir no banco
                MySqlCommand comandoSelecaoSaldo = new MySqlCommand("SELECT saldo FROM caixa WHERE id_caixa = " + venda.formaDePagamento.idFormaPagamento);

                MySqlCommand comandoInclusao = new MySqlCommand("INSERT INTO movimentocaixa VALUES (" + venda.formaDePagamento.idFormaPagamento +
                    "," + 0 + "," + venda.idVenda + ",\"" + venda.data + "\",\"" + venda.hora + "\",\"" + DESCRICAO + "\",\"" + TIPO_MOVIMENTO + "\"," 
                    + venda.totalVenda.ToString().Replace(',','.') + ")", BancoDados.obterInstancia().obterConexao());
                System.Diagnostics.Debug.WriteLine(comandoInclusao);
                comandoInclusao.ExecuteNonQuery();
                
                BancoDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }
        public void incluir(Compra compra)
        {
            const string DESCRICAO = "COMPRA";
            const string TIPO_MOVIMENTO = "SAÍDA";
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                // o primeiro valor a ser informado deveria ser o id do caixa, que compartilha dos mesmos ids de forma de pagamento
                // o problem aqui é que compra não tem uma forma de pagamento, então não sei que valor colocar no caso de compra
                // uma solução seria criar um novo registro em caixa exclusivamente para retirar do saldo da empresa.
                MySqlCommand comandoSelecaoSaldo = new MySqlCommand("SELECT saldo FROM caixa WHERE id_caixa = " + compra. );
                MySqlCommand comandoInclusao = new MySqlCommand("INSERT INTO movimentocaixa VALUES (" + compra. +
                    "," + 0 + "," + compra.idCompra + ",\"" + compra.data + "\",\"" + compra.hora + "\",\"" + DESCRICAO + "\",\"" + TIPO_MOVIMENTO + "\","
                    + compra.totalCompra.ToString().Replace(',', '.') + ")", BancoDados.obterInstancia().obterConexao());
                System.Diagnostics.Debug.WriteLine(comandoInclusao);
                comandoInclusao.ExecuteNonQuery();

                BancoDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }
    }

}
