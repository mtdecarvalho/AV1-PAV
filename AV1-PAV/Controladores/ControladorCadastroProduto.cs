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
    class ControladorCadastroProduto : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO";
        }

        override protected string criarComandoInclusao()
        {
            return
                "INSERT INTO PRODUTO VALUES " +
                "(@ID_PRODUTO, @NOME, @QUANTIDADE_ESTOQUE, " +
                " @PRECO, @UNIDADE, @ID_FORNECEDOR)";
            // necessário tratamento do caso em que id_fornecedor não for informado
        }

        override protected string criarComandoAtualizacao()
        {
            return
                "UPDATE PRODUTO " +
                "SET NOME = @NOME, " +
                "QUANTIDADE_ESTOQUE = @QUANTIDADE_ESTOQUE, " +
                "PRECO = @PRECO, " +
                "UNIDADE = @UNIDADE, " +
                "ID_FORNECEDOR = @ID_FORNECEDOR" +
                "WHERE ID_PRODUTO = @ID_PRODUTO";
        }

        override protected string criarComandoExclusao()
        {
            return "DELETE FROM PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(Produto.ATRIBUTO_ID_PRODUTO, MySqlDbType.Int32);
            comando.Parameters.Add(Produto.ATRIBUTO_NOME, MySqlDbType.VarChar);
            comando.Parameters.Add(Produto.ATRIBUTO_QUANTIDADE_ESTOQUE, MySqlDbType.Int32);
            comando.Parameters.Add(Produto.ATRIBUTO_PRECO, MySqlDbType.Double);
            comando.Parameters.Add(Produto.ATRIBUTO_UNIDADE, MySqlDbType.VarChar);
            comando.Parameters.Add(Produto.ATRIBUTO_ID_FORNECEDOR, MySqlDbType.Int32);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Produto.ATRIBUTO_ID_PRODUTO, MySqlDbType.Int32);
        }
    }
}
