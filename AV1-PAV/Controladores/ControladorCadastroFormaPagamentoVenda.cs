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
    class ControladorCadastroFormaPagamentoVenda : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM FORMAPAGAMENTOVENDA WHERE ID_VENDA = @ID_VENDA, ID_FORMA_PAGAMENTO = @ID_FORMA_PAGAMENTO";
        }

        override protected string criarComandoInclusao()
        {
            return
                "INSERT INTO FORMAPAGAMENTOVENDA VALUES " +
                "(@ID_VENDA, @ID_FORMA_PAGAMENTO, @VALOR)";
        }

        override protected string criarComandoAtualizacao()
        {
            return
                "UPDATE FORMAPAGAMENTOVENDA " +
                "SET VALOR = @VALOR" +
                "WHERE ID_VENDA = @ID_VENDA, ID_FORMA_PAGAMENTO = @ID_FORMA_PAGAMENTO";
        }

        override protected string criarComandoExclusao()
        {
            return "DELETE FROM FORMAPAGAMENTOVENDA WHERE ID_FORMA_PAGAMENTO = @ID_FORMA_PAGAMENTO, ID_VENDA = @ID_VENDA";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_ID_FORMA_PAGAMENTO, MySqlDbType.Int32);
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_VALOR, MySqlDbType.Double);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_ID_FORMA_PAGAMENTO, MySqlDbType.Int32);
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
        }
    }
}
