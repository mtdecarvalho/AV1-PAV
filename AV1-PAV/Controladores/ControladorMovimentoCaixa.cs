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
            movimentoCaixa.descricao = "VENDA DE ID " + venda.idVenda + " E VALOR " + venda.totalVenda + " RECEBIDA À VISTA.";
            movimentoCaixa.tipoMovimento = "ENTRADA";
            movimentoCaixa.valor = venda.totalVenda;

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
            movimentoCaixa.descricao = "COMPRA DE ID " + compra.idCompra + " E VALOR " + compra.totalCompra + " PAGA À VISTA.";
            movimentoCaixa.tipoMovimento = "SAIDA";
            movimentoCaixa.valor = compra.totalCompra;

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
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void incluir(ContaReceber contaReceber)
        {
            MovimentoCaixa movimentoCaixa = new();
            movimentoCaixa.idCaixa = 0;
            movimentoCaixa.numeroMovimento = MovimentoCaixaSQL.BuscarMaiorID();
            movimentoCaixa.idReferencia = contaReceber.idContaReceber;
            movimentoCaixa.dataMovimento = contaReceber.dataRecebimento;
            movimentoCaixa.horaMovimento = DateTime.Now.ToString("HH:mm:ss"); // inserir data
            movimentoCaixa.descricao = "CONTA A RECEBER DE ID " + contaReceber.idContaReceber + " E VALOR " + contaReceber.valor + " RECEBIDA.";
            movimentoCaixa.tipoMovimento = "ENTRADA";
            movimentoCaixa.valor = contaReceber.valor;

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
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void incluir(ContaPagar contaPagar, string data)
        {
            MovimentoCaixa movimentoCaixa = new();
            movimentoCaixa.idCaixa = 0;
            movimentoCaixa.numeroMovimento = MovimentoCaixaSQL.BuscarMaiorID();
            movimentoCaixa.idReferencia = contaPagar.idContaPagar;
            movimentoCaixa.dataMovimento = data;
            movimentoCaixa.horaMovimento = DateTime.Now.ToString("HH:mm:ss");
            movimentoCaixa.descricao = "CONTA A PAGAR DE ID " + contaPagar.idContaPagar + " E VALOR " + contaPagar.valor + " PAGA.";
            movimentoCaixa.tipoMovimento = "SAIDA";
            movimentoCaixa.valor = contaPagar.valor;

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
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }
    }
}
