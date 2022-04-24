using AV1_PAV.Controladores;
using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_PAV.SQL
{
    class ItemVendaSQL
    {
        public static void IncluirListaVenda(List<ItemVenda> Lista, Venda venda)
        {
            BancoDados.obterInstancia().conectar();
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                ControladorCadastroVenda controladorVenda = new();
                controladorVenda.incluir(venda);
                try
                {
                    ControladorCadastroItemVenda controladorItemVenda = new();
                    foreach (ItemVenda item in Lista)
                    {
                        controladorItemVenda.incluir(item);
                    }
                }
                catch (Exception ex)
                {
                    BancoDados.obterInstancia().cancelarTransacao();
                    throw new Exception(ex.Message);
                }
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
