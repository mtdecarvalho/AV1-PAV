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
    class CompraSQL
    {
        public static int BuscarMaiorID()
        {
            Compra entidade = new();
            String SQL = "SELECT * FROM compra ORDER BY id_compra DESC LIMIT 0, 1";

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
                    entidade.idCompra = 0;
                }
                leitorDados.Close();
                BancoDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            BancoDados.obterInstancia().desconectar();

            return entidade.idCompra;
        }
    }
}
