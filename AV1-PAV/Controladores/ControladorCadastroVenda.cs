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
        private MySqlCommand comandoInclusao;
        private MySqlCommand comandoAtualizacao;
        private MySqlCommand comandoSelecao;
        private ControladorCadastroItemVenda controladorItemVenda;

        public ControladorCadastroVenda()
        {
            comandoInclusao = new MySqlCommand("INSERT INTO VENDA VALUES " +
                                               "(@ID_VENDA, @DATA, @HORA, " +
                                               "@ID_CLIENTE, @TOTAL_VENDA, @SITUACAO_VENDA)", 
                                               BancoDados.obterInstancia().obterConexao());

            comandoAtualizacao = new MySqlCommand("UPDATE venda " +
                                                  "SET situacao = @situacao" +
                                                  "WHERE id_venda = @id_venda",
                                                  BancoDados.obterInstancia().obterConexao());

            comandoSelecao = new MySqlCommand("SELECT * FROM VENDA WHERE ID_VENDA = @ID_VENDA", BancoDados.obterInstancia().obterConexao());

            criarParametrosInclusao(comandoInclusao);
            criarParametrosAtualizacao(comandoAtualizacao);
            criarParametrosSelecao(comandoSelecao);
        }
        protected void criarParametrosInclusao(MySqlCommand comando)
        {
            comando.Parameters.Add(Venda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
            comando.Parameters.Add(Venda.ATRIBUTO_DATA, MySqlDbType.Date);
            comando.Parameters.Add(Venda.ATRIBUTO_HORA, MySqlDbType.Time);
            comando.Parameters.Add(Venda.ATRIBUTO_ID_CLIENTE, MySqlDbType.Int32);
            comando.Parameters.Add(Venda.ATRIBUTO_TOTAL_VENDA, MySqlDbType.Double);
            comando.Parameters.Add(Venda.ATRIBUTO_SITUACAO_VENDA, MySqlDbType.VarChar);
        }
        protected void criarParametrosAtualizacao(MySqlCommand comando)
        {
            comando.Parameters.Add(Venda.ATRIBUTO_SITUACAO_VENDA, MySqlDbType.VarChar);
            comando.Parameters.Add(Venda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
        }
        protected void criarParametrosSelecao(MySqlCommand comando)
        {
            comando.Parameters.Add(Venda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
        }

        public void selecionar(Venda entidade)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                entidade.transferirDadosIdentificador(comandoSelecao);
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                while (leitorDados.Read())
                {
                    entidade.lerDados(leitorDados);
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
                System.Diagnostics.Debug.WriteLine("estou aqui");
                venda.transferirDados(comandoInclusao);
                System.Diagnostics.Debug.WriteLine("estou aqui");
                comandoInclusao.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine("estou aqui");
                /*foreach(ItemVenda item in venda.itens)
                {
                    try
                    {
                        controladorItemVenda.incluir(item);
                    } catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }*/
                BancoDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void atualizar(Entidade entidade)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                BancoDados.obterInstancia().iniciarTransacao();
                comandoAtualizacao.ExecuteNonQuery();
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
