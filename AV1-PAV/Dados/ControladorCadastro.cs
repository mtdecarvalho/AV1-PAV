using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace AV1_PAV.Dados
{
    public abstract class ControladorCadastro
    {
        private MySqlCommand comandoInclusao;
        private MySqlCommand comandoAtualizacao;
        private MySqlCommand comandoExclusao;

        protected abstract string criarComandoInclusao();
        protected abstract string criarComandoAtualizacao();
        protected abstract string criarComandoExclusao();

        public ControladorCadastro()
        {
            comandoInclusao = new MySqlCommand(criarComandoInclusao(), BancoDados.obterInstancia().obterConexao());
            comandoAtualizacao = new MySqlCommand(criarComandoAtualizacao(), BancoDados.obterInstancia().obterConexao());
            comandoExclusao = new MySqlCommand(criarComandoExclusao(), BancoDados.obterInstancia().obterConexao());
        }
    }
}
