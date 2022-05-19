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
    class FornecedorSQL
    {
        public static int BuscarMaiorID()
        {
            Fornecedor entidade = new();
            String SQL = "SELECT * FROM fornecedor ORDER BY id_fornecedor DESC LIMIT 0, 1";

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
                    entidade.idFornecedor = 0;
                }
                leitorDados.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            BancoDados.obterInstancia().desconectar();

            return entidade.idFornecedor;
        }

        public static Fornecedor BuscarPorCodigo(String codigo)
        {
            Fornecedor entidade = new();
            String SQL = "SELECT * FROM FORNECEDOR WHERE id_fornecedor =" + codigo;

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
                    SQL = "SELECT * FROM fornecedor WHERE id_fornecedor = 0";
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

        public static List<Fornecedor> BuscarMultiplosPorNome(String nome)
        {
            List<Fornecedor> Lista = new();

            String SQL = "SELECT * FROM Fornecedor WHERE nome LIKE \"%" + nome + "%\"";

            BancoDados.obterInstancia().conectar();
            MySqlCommand comandoSelecao = new MySqlCommand(SQL, BancoDados.obterInstancia().obterConexao());
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                while (leitorDados.Read())
                {
                    Fornecedor entidade = new();
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
