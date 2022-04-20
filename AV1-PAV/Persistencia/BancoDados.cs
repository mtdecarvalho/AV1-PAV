using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace AV1_PAV.Persistencia
{
    class BancoDados
    {
        private int porta = 3306;
        private string servidor = "localhost";
        private string nomeBancoDados = "pav_av1";
        private MySqlConnection conexao;
        private MySqlTransaction transacao;
        private static BancoDados instancia = null; // para o singleton

        private string criarStringConexao(string usuario, string senha)
        {
            return "server = " + servidor +
                   ";port = " + porta.ToString() +
                   ";database = " + nomeBancoDados +
                   ";user id = " + usuario +
                   ";password = " + senha;
        }

        public void conectar(string usuario, string senha)
        {
            try
            {
                conexao = new MySqlConnection(criarStringConexao(usuario, senha));
                conexao.Open();
                MessageBox.Show("Conexão realizada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void conectar()
        {
            //senha do root do mysql server
            conectar("root", "y62fSiko&Q50");
        }

        public void desconectar()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                conexao.Dispose();
            }
        }

        public MySqlConnection obterConexao()
        {
            return conexao;
        }

        public static BancoDados obterInstancia()
        {
            if (instancia == null)
            {
                instancia = new BancoDados();
            }
            return instancia;
        }

        public void iniciarTransacao()
        {
            transacao = conexao.BeginTransaction();
        }

        public void confirmarTransacao()
        {
            if (transacao != null)
            {
                transacao.Commit();
                transacao.Dispose();
            }
        }

        public void cancelarTransacao()
        {
            if (transacao != null)
            {
                transacao.Rollback();
                transacao.Dispose();
            }
        }
    }
}
