using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Controladores
{
    class ControladorCadastroVenda
    {
        public void selecionar(Venda venda)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlCommand comandoSelecao = new MySqlCommand("SELECT * FROM VENDA WHERE ID_VENDA = " +
                     venda.idVenda, BancoDados.obterInstancia().obterConexao());
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                while (leitorDados.Read())
                {
                    venda.lerDados(leitorDados);
                }
                leitorDados.Close();
                BancoDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void incluir(Venda venda)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            ControladorCadastroItemVenda controladorItemVenda = new();
            try
            {
                MySqlCommand comandoInclusao = new MySqlCommand("INSERT INTO venda VALUES ("+ venda.idVenda + 
                    ",\"" + venda.data + "\",\"" + venda.hora + "\"," + venda.idCliente + "," + venda.totalVenda.ToString().Replace(',','.') + 
                    ",\"" + venda.situacaoVenda + "\")", BancoDados.obterInstancia().obterConexao());
                comandoInclusao.ExecuteNonQuery();
                foreach(ItemVenda item in venda.itens)
                {
                    try
                    {
                        controladorItemVenda.incluir(item);
                    } catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                MySqlCommand comandoInclusaoFPV = new MySqlCommand("INSERT INTO formapagamentovenda VALUES (" + venda.formaDePagamento.idVenda + "," + venda.formaDePagamento.idFormaPagamento 
                                                                            + "," + venda.formaDePagamento.valor.ToString().Replace(',','.') + ")", BancoDados.obterInstancia().obterConexao());
                comandoInclusaoFPV.ExecuteNonQuery();

                if (venda.formaDePagamento.idFormaPagamento == 0)
                {
                } else
                {
                    MySqlCommand comandoInclusaoContaReceber = new MySqlCommand("INSERT INTO contareceber (id_conta_receber, id_cliente, data_lancamento, data_vencimento, valor, recebido)" +
                                                                                "VALUES (" + venda.contaReceber.idContaReceber + "," + venda.contaReceber.idCliente + ",\"" + venda.contaReceber.dataLancamento + "\"" + ",\"" + venda.contaReceber.dataVencimento + "\"," + 
                                                                                    venda.contaReceber.valor.ToString().Replace(',', '.') + ",\"" + venda.contaReceber.recebido + "\")", BancoDados.obterInstancia().obterConexao());
                    comandoInclusaoContaReceber.ExecuteNonQuery();
                }

                BancoDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void atualizar(string situacao, int id)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlCommand comandoAtualizacao = new MySqlCommand("UPDATE venda SET situacao_venda = \"" + situacao + "\"" +
                    " WHERE id_venda = " + id, BancoDados.obterInstancia().obterConexao());
                comandoAtualizacao.ExecuteNonQuery();

                List<ItemVenda> itens = new();
                ControladorCadastroItemVenda controladorItem = new();
                itens = controladorItem.selecionarVarios(id);

                foreach(ItemVenda item in itens)
                {
                    controladorItem.excluir(item);
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
