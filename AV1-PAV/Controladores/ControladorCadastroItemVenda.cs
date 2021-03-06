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
    class ControladorCadastroItemVenda : ControladorCadastroItem
    {
        public List<ItemVenda> selecionarVarios(int id)
        {
            List<ItemVenda> itens = new();
            MySqlCommand comandoSelecao = new MySqlCommand("SELECT * FROM itemvenda WHERE id_venda = " + id, BancoDados.obterInstancia().obterConexao());
            MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
            while (leitorDados.Read())
            {
                ItemVenda item = new();
                item.lerDados(leitorDados);
                itens.Add(item);
            }
            leitorDados.Close();

            return itens;
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

        public void incluir(ItemVenda item)
        {
            try
            {
                MySqlCommand comandoInclusao = new MySqlCommand("INSERT INTO itemvenda VALUES (" + item.idVenda + 
                    "," + item.numeroItem + "," + item.idProduto + "," + item.quantidade + 
                    "," + item.valorUnitario.ToString().Replace(',','.') + "," + item.totalItem.ToString().Replace(',','.') + ")", BancoDados.obterInstancia().obterConexao());
                comandoInclusao.ExecuteNonQuery();
                retirarDoEstoque(item);
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void excluir(ItemVenda item)
        {
            MySqlCommand comandoExclusao = new MySqlCommand("DELETE FROM itemvenda WHERE id_venda = " + item.idVenda +
                                " AND numero_item = " + item.numeroItem, BancoDados.obterInstancia().obterConexao());
            comandoExclusao.ExecuteNonQuery();
            reestocar(item);
        }
    }
}
