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
    class ControladorCadastroItemCompra : ControladorCadastroItem
    {
        public List<ItemCompra> selecionarVarios(int id)
        {
            List<ItemCompra> itens = new();
            MySqlCommand comandoSelecao = new MySqlCommand("SELECT * FROM itemcompra WHERE id_compra = " + id, BancoDados.obterInstancia().obterConexao());
            MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
            while (leitorDados.Read())
            {
                ItemCompra item = new();
                item.lerDados(leitorDados);
                itens.Add(item);
            }
            leitorDados.Close();

            return itens;
        }

        public void selecionar(ItemCompra item)
        {
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlCommand comandoSelecao = new MySqlCommand("SELECT * FROM itemcompra WHERE id_compra = " + item.idCompra + 
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

        public void incluir(ItemCompra item)
        {
            try
            {
                MySqlCommand comandoInclusao = new MySqlCommand("INSERT INTO itemcompra VALUES (" + item.idCompra + 
                    "," + item.numeroItem + "," + item.idProduto + "," + item.quantidade + 
                    "," + item.valorUnitario.ToString().Replace(',','.') + "," + item.totalItem.ToString().Replace(',','.') + ")", BancoDados.obterInstancia().obterConexao());
                comandoInclusao.ExecuteNonQuery();
                reestocar(item);
            }
            catch (Exception ex)
            {
                BancoDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }
        
        public void excluir(ItemCompra item)
        {
            MySqlCommand comandoExclusao = new MySqlCommand("DELETE FROM itemcompra WHERE id_compra = " + item.idCompra +
                                " AND numero_item = " + item.numeroItem, BancoDados.obterInstancia().obterConexao());
            comandoExclusao.ExecuteNonQuery();
            retirarDoEstoque(item);
        }
    }
}
