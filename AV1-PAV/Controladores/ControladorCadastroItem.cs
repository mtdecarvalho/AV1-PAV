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
    public abstract class ControladorCadastroItem
    {
        public void retirarDoEstoque(Item item)
        {
            int qtdEstoque = 0;
            int novaQtd = 0;

            MySqlCommand getQtdEstoque = new MySqlCommand("SELECT quantidade_estoque FROM produto WHERE id_produto = " +
                item.idProduto, BancoDados.obterInstancia().obterConexao());
            MySqlDataReader leitorDados = getQtdEstoque.ExecuteReader();
            while (leitorDados.Read())
                qtdEstoque = int.Parse(leitorDados["quantidade_estoque"].ToString());
            leitorDados.Close();

            novaQtd = qtdEstoque - item.quantidade;

            MySqlCommand comandoRetirarEstoque = new MySqlCommand("UPDATE produto SET quantidade_estoque = "
                                                + novaQtd + " WHERE id_produto = " + item.idProduto, BancoDados.obterInstancia().obterConexao());
            comandoRetirarEstoque.ExecuteNonQuery();
        }

        public void reestocar(Item item)
        {
            int qtdEstoque = 0;
            int novaQtd = 0;

            MySqlCommand getQtdEstoque = new MySqlCommand("SELECT quantidade_estoque FROM produto WHERE id_produto = " +
                item.idProduto, BancoDados.obterInstancia().obterConexao());
            MySqlDataReader leitorDados = getQtdEstoque.ExecuteReader();
            while (leitorDados.Read())
                qtdEstoque = int.Parse(leitorDados["quantidade_estoque"].ToString());
            leitorDados.Close();

            novaQtd = item.quantidade + qtdEstoque;
            MySqlCommand comandoReestoque = new MySqlCommand("UPDATE produto SET quantidade_estoque = " 
                                                + novaQtd + " WHERE id_produto = " + item.idProduto, BancoDados.obterInstancia().obterConexao());
            comandoReestoque.ExecuteNonQuery();
        }
    }
}
