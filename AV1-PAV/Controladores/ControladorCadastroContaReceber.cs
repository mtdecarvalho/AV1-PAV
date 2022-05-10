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
    class ControladorCadastroContaReceber : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM CONTARECEBER WHERE ID_CONTA_RECEBER = @ID_CONTA_RECEBER";
        }

        override protected string criarComandoInclusao()
        {
            return
                "INSERT INTO CONTARECEBER VALUES" +
                "(@ID_CONTA_RECEBER, @DESCRICAO, @ID_CLIENTE, " +
                " @DATA_LANCAMENTO, @DATA_VENCIMENTO, @VALOR," +
                " @RECEBIDO, @DATA_RECEBIMENTO, @VALOR_RECEBIMENTO)";
        }

        override protected string criarComandoAtualizacao()
        {
            return
                "UPDATE CONTARECEBER " +
                "SET DESCRICAO = @DESCRICAO, " +
                "ID_CLIENTE = @ID_CLIENTE, " +
                "DATA_LANCAMENTO = @DATA_LANCAMENTO, " +
                "DATA_VENCIMENTO = @DATA_VENCIMENTO, " +
                "VALOR = @VALOR, " +
                "RECEBIDO = @RECEBIDO, " +
                "DATA_RECEBIMENTO = @DATA_RECEBIMENTO, " +
                "VALOR_RECEBIMENTO = @VALOR_RECEBIMENTO" +
                "WHERE ID_CONTA_RECEBER = @ID_CONTA_RECEBER";
        }

        override protected string criarComandoExclusao()
        {
            return "DELETE FROM CONTARECEBER WHERE ID_CONTA_RECEBER = @ID_CONTA_RECEBER";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(ContaReceber.ATRIBUTO_ID_CONTA_RECEBER, MySqlDbType.Int32);
            comando.Parameters.Add(ContaReceber.ATRIBUTO_DESCRICAO, MySqlDbType.VarChar);
            comando.Parameters.Add(ContaReceber.ATRIBUTO_ID_CLIENTE, MySqlDbType.Int32);
            comando.Parameters.Add(ContaReceber.ATRIBUTO_DATA_LANCAMENTO, MySqlDbType.Date);
            comando.Parameters.Add(ContaReceber.ATRIBUTO_DATA_VENCIMENTO, MySqlDbType.Date);
            comando.Parameters.Add(ContaReceber.ATRIBUTO_VALOR, MySqlDbType.Double);
            comando.Parameters.Add(ContaReceber.ATRIBUTO_RECEBIDO, MySqlDbType.VarChar);
            comando.Parameters.Add(ContaReceber.ATRIBUTO_DATA_RECEBIMENTO, MySqlDbType.Date);
            comando.Parameters.Add(ContaReceber.ATRIBUTO_VALOR_RECEBIMENTO, MySqlDbType.Double);
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(ContaReceber.ATRIBUTO_ID_CONTA_RECEBER, MySqlDbType.Int32);
        }

        public void atualizar(string situacao, int id)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                DateTime thisDay = DateTime.Now;
                string data = thisDay.ToString("yyyy-MM-dd");
                MySqlCommand comandoAtualizacao = new MySqlCommand("UPDATE contareceber SET recebido = \"" + situacao + "\"," +
                    "data_recebimento = \"" + data + "\"" + " WHERE id_conta_receber = " + id, BancoDados.obterInstancia().obterConexao());
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
