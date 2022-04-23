using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AV1_PAV.Controladores;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Persistencia
{
    public abstract class ControladorCadastro
    {
        private MySqlCommand comandoInclusao;
        private MySqlCommand comandoAtualizacao;
        private MySqlCommand comandoExclusao;
        private MySqlCommand comandoSelecao;

        protected abstract string criarComandoInclusao();
        protected abstract string criarComandoAtualizacao();
        protected abstract string criarComandoExclusao();
        protected abstract string criarComandoSelecao();
        protected abstract void criarParametros(MySqlCommand comando);
        protected abstract void criarParametrosChavePrimaria(MySqlCommand comando);

        public ControladorCadastro()
        {
            comandoInclusao = new MySqlCommand(criarComandoInclusao(), BancoDados.obterInstancia().obterConexao());
            comandoAtualizacao = new MySqlCommand(criarComandoAtualizacao(), BancoDados.obterInstancia().obterConexao());
            comandoExclusao = new MySqlCommand(criarComandoExclusao(), BancoDados.obterInstancia().obterConexao());
            comandoSelecao = new MySqlCommand(criarComandoSelecao(), BancoDados.obterInstancia().obterConexao());

            criarParametrosInclusao(comandoInclusao);
            criarParametrosAtualizacao(comandoAtualizacao);
            criarParametrosChavePrimaria(comandoExclusao);
            criarParametrosChavePrimaria(comandoSelecao);
        }

        protected virtual void criarParametrosInclusao(MySqlCommand comandoInclusao)
        {
            criarParametros(comandoInclusao);
        }

        protected virtual void criarParametrosAtualizacao(MySqlCommand comandoAtualizacao)
        {
            criarParametros(comandoAtualizacao);
        }

        public void selecionar(Entidade entidade)
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
            } catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void incluir(Entidade entidade)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                entidade.transferirDados(comandoInclusao);
                comandoInclusao.ExecuteNonQuery();
                BancoDados.obterInstancia().confirmarTransacao();
            } catch (Exception ex)
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
            } catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void excluir(Entidade entidade)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                entidade.transferirDadosIdentificador(comandoExclusao);
                comandoExclusao.ExecuteNonQuery();
                BancoDados.obterInstancia().confirmarTransacao();
            } catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

    }
}
