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
    class ControladorCadastroCompra
    {
        public void selecionar(Compra compra)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlCommand comandoSelecao = new MySqlCommand("SELECT * FROM compra WHERE ID_compra = " +
                     compra.idCompra, BancoDados.obterInstancia().obterConexao());
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                while (leitorDados.Read())
                {
                    compra.lerDados(leitorDados);
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

        public void incluir(Compra compra)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            ControladorCadastroItemCompra controlador = new();
            try
            {
                MySqlCommand comandoInclusao = new MySqlCommand("INSERT INTO compra VALUES ("+ compra.idCompra + 
                    ",\"" + compra.data + "\",\"" + compra.hora + "\"," + compra.idFornecedor + "," + compra.totalCompra.ToString().Replace(',','.') + 
                    ",\"" + compra.situacaoCompra + "\")", BancoDados.obterInstancia().obterConexao());
                comandoInclusao.ExecuteNonQuery();
                foreach(ItemCompra item in compra.itens)
                {
                    try
                    {
                        controlador.incluir(item);
                    } catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }

                MySqlCommand comandoInclusaoContaReceber = new MySqlCommand("INSERT INTO contapagar (id_conta_pagar, id_fornecedor, data_lancamento, data_vencimento, valor, pago)" +
                                                                            "VALUES (" + compra.contaPagar.idContaPagar + "," + compra.contaPagar.idFornecedor + ",\"" + compra.contaPagar.dataLancamento + "\"" + ",\"" + compra.contaPagar.dataVencimento + "\"," + 
                                                                                compra.contaPagar.valor.ToString().Replace(',', '.') + ",\"" + compra.contaPagar.pago + "\")", BancoDados.obterInstancia().obterConexao());
                comandoInclusaoContaReceber.ExecuteNonQuery();
                
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
                MySqlCommand comandoAtualizacao = new MySqlCommand("UPDATE compra SET situacao_compra = \"" + situacao + "\"" +
                    " WHERE id_compra = " + id, BancoDados.obterInstancia().obterConexao());
                comandoAtualizacao.ExecuteNonQuery();

                List<ItemCompra> itens = new();
                ControladorCadastroItemCompra controladorItem = new();
                itens = controladorItem.selecionarVarios(id);

                foreach(ItemCompra item in itens)
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
