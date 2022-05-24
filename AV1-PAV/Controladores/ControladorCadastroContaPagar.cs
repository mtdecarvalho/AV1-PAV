using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_PAV.Controladores
{
    class ControladorCadastroContaPagar : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM ContaPagar WHERE id_conta_pagar = @id_conta_pagar";
        }

        override protected string criarComandoInclusao()
        {
            return
                "INSERT INTO ContaPagar VALUES" +
                "(@id_conta_pagar, @DESCRICAO, @ID_FORNECEDOR, " +
                " @DATA_LANCAMENTO, @DATA_VENCIMENTO, @VALOR," +
                " @PAGO, @DATA_PAGAMENTO, @VALOR_PAGAMENTO)";
        }

        override protected string criarComandoAtualizacao()
        {
            return
                "UPDATE ContaPagar " +
                "SET DESCRICAO = @DESCRICAO, " +
                "ID_FORNECEDOR = @ID_FORNECEDOR, " +
                "DATA_LANCAMENTO = @DATA_LANCAMENTO, " +
                "DATA_VENCIMENTO = @DATA_VENCIMENTO, " +
                "VALOR = @VALOR, " +
                "PAGO = @PAGO, " +
                "DATA_PAGAMENTO = @DATA_PAGAMENTO, " +
                "VALOR_PAGAMENTO = @VALOR_PAGAMENTO" +
                "WHERE id_conta_pagar = @id_conta_pagar";
        }

        override protected string criarComandoExclusao()
        {
            return "DELETE FROM ContaPagar WHERE id_conta_pagar = @id_conta_pagar";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(ContaPagar.ATRIBUTO_ID_CONTA_PAGAR, MySqlDbType.Int32);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_DESCRICAO, MySqlDbType.VarChar);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_ID_FORNECEDOR, MySqlDbType.Int32);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_DATA_LANCAMENTO, MySqlDbType.Date);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_DATA_VENCIMENTO, MySqlDbType.Date);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_VALOR, MySqlDbType.Double);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_PAGO, MySqlDbType.VarChar);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_DATA_PAGAMENTO, MySqlDbType.Date);
            comando.Parameters.Add(ContaPagar.ATRIBUTO_VALOR_PAGAMENTO, MySqlDbType.Double);
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(ContaPagar.ATRIBUTO_ID_CONTA_PAGAR, MySqlDbType.Int32);
        }

        public void atualizar(string situacao, int id)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                DateTime thisDay = DateTime.Now;
                string data = thisDay.ToString("yyyy-MM-dd");
                MySqlCommand comandoAtualizacao = new MySqlCommand("UPDATE ContaPagar SET PAGO = \"" + situacao + "\"," +
                    "DATA_PAGAMENTO = \"" + data + "\"" + " WHERE id_conta_pagar = " + id, BancoDados.obterInstancia().obterConexao());
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
