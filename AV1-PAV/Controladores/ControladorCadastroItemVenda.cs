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
    class ControladorCadastroItemVenda : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM ITEMVENDA WHERE ID_VENDA = @ID_VENDA, NUMERO_ITEM = @NUMERO_ITEM";
        }

        override protected string criarComandoInclusao()
        {
            return 
                "INSERT INTO ITEMVENDA VALUES " +
                "(@ID_VENDA, @NUMERO_ITEM, @ID_PRODUTO, " +
                " @QUANTIDADE, @VALOR_UNITARIO, @TOTAL_ITEM)";
        }

        override protected string criarComandoAtualizacao()
        {
            return
                "UPDATE ITEMVENDA " +
                "SET ID_PRODUTO = @ID_PRODUTO, " +
                "QUANTIDADE = @QUANTIDADE, " +
                "VALOR_UNITARIO = @VALOR_UNITARIO, " +
                "TOTAL_ITEM = @TOTAL_ITEM" +
                "WHERE ID_VENDA = @ID_VENDA, NUMERO_ITEM = @NUMERO_ITEM";
        }

        override protected string criarComandoExclusao()
        {
            return "DELETE FROM ITEMVENDA WHERE ID_VENDA = @ID_VENDA, NUMERO_ITEM = @NUMERO_ITEM";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(ItemVenda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
            comando.Parameters.Add(ItemVenda.ATRIBUTO_NUMERO_ITEM, MySqlDbType.Int32);
            comando.Parameters.Add(ItemVenda.ATRIBUTO_ID_PRODUTO, MySqlDbType.Int32);
            comando.Parameters.Add(ItemVenda.ATRIBUTO_QUANTIDADE, MySqlDbType.Int32);
            comando.Parameters.Add(ItemVenda.ATRIBUTO_VALOR_UNITARIO, MySqlDbType.Double);
            comando.Parameters.Add(ItemVenda.ATRIBUTO_TOTAL_ITEM, MySqlDbType.Double);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(ItemVenda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
            comando.Parameters.Add(ItemVenda.ATRIBUTO_NUMERO_ITEM, MySqlDbType.Int32);
        }
        override public void incluir(Entidade entidade)
        {
            try
            {
                entidade.transferirDados(comandoInclusao);
                comandoInclusao.ExecuteNonQuery();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
                BancoDados.obterInstancia().cancelarTransacao();
            }
        }
    }
}
