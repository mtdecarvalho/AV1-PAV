using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using AV1_PAV.SQL;
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
            MovimentoCaixa movimentoCaixa = new();
            movimentoCaixa.idCaixa = venda.formaDePagamento.idFormaPagamento;
            movimentoCaixa.numeroMovimento = MovimentoCaixaSQL.BuscarMaiorID();
            movimentoCaixa.idReferencia = venda.idVenda;
            movimentoCaixa.dataMovimento = venda.data;
            movimentoCaixa.horaMovimento = venda.hora;
            movimentoCaixa.descricao = "VENDA";
            movimentoCaixa.tipoMovimento = "ENTRADA";
            movimentoCaixa.valor = venda.totalVenda;

            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlCommand comandoInclusao = new MySqlCommand("INSERT INTO movimentocaixa VALUES (" + movimentoCaixa.idCaixa + "," + movimentoCaixa.numeroMovimento + "," + 
                    movimentoCaixa.idReferencia + ",\"" + movimentoCaixa.dataMovimento + "\",\"" + movimentoCaixa.horaMovimento+ "\",\"" + movimentoCaixa.descricao + "\",\"" + 
                    movimentoCaixa.tipoMovimento + "\"," + movimentoCaixa.valor.ToString().Replace(',','.') + ")", BancoDados.obterInstancia().obterConexao());
                comandoInclusao.ExecuteNonQuery();

                try
                {
                    ControladorCaixa controladorCaixa = new();
                    controladorCaixa.atualizar(movimentoCaixa);
                } catch (Exception ex)
                {
                    BancoDados.obterInstancia().cancelarTransacao();
                    throw new Exception(ex.Message);
                }
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
            MovimentoCaixa movimentoCaixa = new();
            movimentoCaixa.idCaixa = 0;
            movimentoCaixa.numeroMovimento = MovimentoCaixaSQL.BuscarMaiorID();
            movimentoCaixa.idReferencia = compra.idCompra;
            movimentoCaixa.dataMovimento = compra.data;
            movimentoCaixa.horaMovimento = compra.hora;
            movimentoCaixa.descricao = "COMPRA";
            movimentoCaixa.tipoMovimento = "SAIDA";
            movimentoCaixa.valor = compra.totalCompra;

            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlCommand comandoInclusao = new MySqlCommand("INSERT INTO movimentocaixa VALUES (" + movimentoCaixa.idCaixa + "," + movimentoCaixa.numeroMovimento + "," +
                    movimentoCaixa.idReferencia + ",\"" + movimentoCaixa.dataMovimento + "\",\"" + movimentoCaixa.horaMovimento + "\",\"" + movimentoCaixa.descricao + "\",\"" +
                    movimentoCaixa.tipoMovimento + "\"," + movimentoCaixa.valor.ToString().Replace(',', '.') + ")", BancoDados.obterInstancia().obterConexao());
                comandoInclusao.ExecuteNonQuery();

                try
                {
                    ControladorCaixa controladorCaixa = new();
                    controladorCaixa.atualizar(movimentoCaixa);
                }
                catch (Exception ex)
                {
                    BancoDados.obterInstancia().cancelarTransacao();
                    throw new Exception(ex.Message);
                }
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
