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
    class ControladorCadastroVenda : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM VENDA WHERE ID_VENDA = @ID_VENDA";
        }

        override protected string criarComandoInclusao()
        {
            return
                "INSERT INTO VENDA VALUES " +
                "(@ID_VENDA, @DATA, @HORA, " +
                "@ID_CLIENTE, @TOTAL_VENDA, @SITUACAO_VENDA)";
        }

        override protected string criarComandoAtualizacao()
        {
            return
                "UPDATE VENDA " +
                "SET DATA = @DATA," +
                "HORA = @HORA, " +
                "ID_CLIENTE = @ID_CLIENTE, " +
                "TOTAL_VENDA = @TOTAL_VENDA, " +
                "SITUACAO_VENDA = @SITUACAO_VENDA" +
                "WHERE ID_VENDA = @ID_VENDA";
        }

        override protected string criarComandoExclusao()
        {
            return "DELETE FROM VENDA WHERE ID_VENDA = @ID_VENDA";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(Venda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
            comando.Parameters.Add(Venda.ATRIBUTO_DATA, MySqlDbType.Date);
            comando.Parameters.Add(Venda.ATRIBUTO_HORA, MySqlDbType.Time);
            comando.Parameters.Add(Venda.ATRIBUTO_ID_CLIENTE, MySqlDbType.Int32);
            comando.Parameters.Add(Venda.ATRIBUTO_TOTAL_VENDA, MySqlDbType.Double);
            comando.Parameters.Add(Venda.ATRIBUTO_SITUACAO_VENDA, MySqlDbType.VarChar);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Venda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
        }
    }
}
