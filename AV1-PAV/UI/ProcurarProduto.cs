using AV1_PAV.Controladores;
using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV1_PAV.UI
{
    public partial class ProcurarProduto : Form
    {
        private List<Produto> Lista = new();
        private Produto p;
        private NovaVenda janela;
        public ProcurarProduto()
        {
            InitializeComponent();
        }

        public ProcurarProduto(NovaVenda NV, String nome)
        {
            InitializeComponent();
            String SQL = "SELECT * FROM PRODUTO WHERE nome LIKE \"%" + nome + "%\"";
            LerDoBanco(SQL);

            janela = NV;
            //System.Diagnostics.Debug.WriteLine(entidade.nome + entidade.preco);

            foreach (Produto produto in Lista)
            {
                String[] row = { produto.nome, produto.preco.ToString()};
                DataGridProdutos.Rows.Add(row); 
            }
        }

        public void LerDoBanco(String SQL)
        {
            BancoDados.obterInstancia().conectar();
            MySqlCommand comandoSelecao = new MySqlCommand(SQL, BancoDados.obterInstancia().obterConexao());
            BancoDados.obterInstancia().iniciarTransacao();
            try
            {
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                while (leitorDados.Read())
                {
                    Produto entidade = new();
                    entidade.lerDados(leitorDados);
                    Lista.Add(entidade);
                }
                leitorDados.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            BancoDados.obterInstancia().desconectar();
        }

        private void BtSelecionar_Click(object sender, EventArgs e)
        {
            p = Lista[DataGridProdutos.CurrentCell.RowIndex];
            janela.SetProduto(p);
            Dispose();
        }
    }

}
