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
        private ControladorCadastroItemVenda controladorItemVenda;

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
            controladorItemVenda = new();
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
