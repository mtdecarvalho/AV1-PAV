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
    class MovimentoCaixaSQL
    {
        public static int BuscarMaiorID()
        {
            MovimentoCaixa entidade = new();
            String SQL = "SELECT * FROM movimentocaixa ORDER BY numero_movimento DESC LIMIT 0, 1";

            MySqlCommand comandoSelecao = new MySqlCommand(SQL, BancoDados.obterInstancia().obterConexao());
            try
            {
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                if (leitorDados.Read())
                {
                    entidade.lerDados(leitorDados);
                }
                else
                {
                    entidade.numeroMovimento = 0;
                }
                leitorDados.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return entidade.numeroMovimento + 1;
        }

        public static double getSaldo(int idCaixa)
        {
            string SQL = "SELECT saldo FROM caixa WHERE id_caixa = " + idCaixa;
            double saldo;
            MySqlCommand comandoSelecao = new MySqlCommand(SQL, BancoDados.obterInstancia().obterConexao());
            MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
            leitorDados.Read();
            saldo = Double.Parse(leitorDados.GetValue(0).ToString().Replace('.', ','));
            leitorDados.Close();
            return saldo;
        }
    }
}
