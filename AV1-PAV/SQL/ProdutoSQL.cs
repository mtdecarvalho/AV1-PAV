using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_PAV.SQL
{
    class ProdutoSQL
    {
        public static Produto BuscarPorCodigo(String codigo)
        {
            Produto entidade = new();
            String SQL = "SELECT * FROM PRODUTO WHERE id_produto =" + codigo;

            BancoDados.obterInstancia().conectar();
            MySqlCommand comandoSelecao = new MySqlCommand(SQL, BancoDados.obterInstancia().obterConexao());
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                if (leitorDados.Read())
                {
                    entidade.lerDados(leitorDados);
                }
                else
                {
                    SQL = "SELECT * FROM produto WHERE id_produto = 0";
                    leitorDados.Read();
                    entidade.lerDados(leitorDados);
                }
                leitorDados.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            BancoDados.obterInstancia().desconectar();

            return entidade;
        }

        public static List<Produto> BuscarMultiplosPorNome(String nome)
        {
            List<Produto> Lista = new();
            
            String SQL = "SELECT * FROM produto WHERE nome LIKE \"%" + nome + "%\"";

            BancoDados.obterInstancia().conectar();
            MySqlCommand comandoSelecao = new MySqlCommand(SQL, BancoDados.obterInstancia().obterConexao());
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                while (leitorDados.Read())
                {
                    Produto entidade = new();
                    entidade.lerDados(leitorDados);
                    Lista.Add(entidade);
                }
                leitorDados.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            BancoDados.obterInstancia().desconectar();

            return Lista;
        }
    }
}
