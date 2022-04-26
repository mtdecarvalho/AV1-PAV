﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.Controladores
{
    class ControladorCadastroItemVenda
    {
        public void reestocar(ItemVenda item)
        {
            int qtdEstoque = 0;
            int novaQtd = 0;
            MySqlCommand getQtdEstoque = new MySqlCommand("SELECT quantidade_estoque FROM produto WHERE id_produto = " +
                item.idProduto, BancoDados.obterInstancia().obterConexao());
            MySqlDataReader leitorDados = getQtdEstoque.ExecuteReader();
            while (leitorDados.Read())
                qtdEstoque = int.Parse(leitorDados["quantidade_estoque"].ToString());
            novaQtd = item.quantidade + qtdEstoque;
            MySqlCommand comandoReestoque = new MySqlCommand("UPDATE produto SET quantidade_estoque = " 
                                                + novaQtd + "WHERE id_produto = " + item.idProduto, BancoDados.obterInstancia().obterConexao());
            comandoReestoque.ExecuteNonQuery();
        }
        public void selecionar(ItemVenda item)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlCommand comandoSelecao = new MySqlCommand("SELECT * FROM itemvenda WHERE id_venda = " + item.idVenda + 
                    " AND numero_item = " + item.numeroItem, BancoDados.obterInstancia().obterConexao());
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                while (leitorDados.Read())
                {
                    item.lerDados(leitorDados);
                }
                leitorDados.Close();
                BancoDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public virtual void incluir(ItemVenda item)
        {
            try
            {
                MySqlCommand comandoInclusao = new MySqlCommand("INSERT INTO itemvenda VALUES (" + item.idVenda + 
                    "," + item.numeroItem + "," + item.idProduto + "," + item.quantidade + 
                    "," + item.valorUnitario + "," + item.totalItem + ")", BancoDados.obterInstancia().obterConexao());
                comandoInclusao.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void excluir(ItemVenda item)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlCommand comandoExclusao = new MySqlCommand("DELETE FROM itemvenda WHERE id_venda = " + item.idVenda +
                                    " AND numero_item = " + item.numeroItem, BancoDados.obterInstancia().obterConexao());
                comandoExclusao.ExecuteNonQuery();
                reestocar(item);
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
