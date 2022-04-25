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
    class ClienteSQL
    {
        public static Cliente BuscarPorCodigo(String codigo)
        {
            Cliente entidade = new();
            String SQL = "SELECT * FROM cliente WHERE id_cliente =" + codigo;

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
                    SQL = "SELECT * FROM cliente WHERE id_cliente = 0";
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
        public static List<Cliente> BuscarMultiplosPorNome(String nome)
        {
            List<Cliente> Lista = new();

            String SQL = "SELECT * FROM cliente WHERE nome LIKE \"%" + nome + "%\"";

            BancoDados.obterInstancia().conectar();
            MySqlCommand comandoSelecao = new MySqlCommand(SQL, BancoDados.obterInstancia().obterConexao());
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                while (leitorDados.Read())
                {
                    Cliente entidade = new();
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

        public static int BuscarMaiorID()
        {
            Cliente entidade = new();
            String SQL = "SELECT * FROM cliente ORDER BY id_cliente DESC LIMIT 0, 1";

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
                    entidade.idCliente = 0;
                }
                leitorDados.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            BancoDados.obterInstancia().desconectar();

            return entidade.idCliente;
        }
    }
}
