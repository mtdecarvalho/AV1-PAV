using AV1_PAV.Controladores;
using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using AV1_PAV.SQL;
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
    public partial class ProcurarClienteProduto : Form
    {
        private List<Produto> Lista = new();
        private Produto p;
        private NovaVenda janela;
        public ProcurarClienteProduto()
        {
            InitializeComponent();
        }

        public ProcurarClienteProduto(NovaVenda NV, String nome)
        {
            InitializeComponent();
            Lista = ProdutoSQL.BuscarMultiplosPorNome(nome);
            janela = NV;
            PreencherTabela();
        }

        public void PreencherTabela()
        {
            foreach (Produto produto in Lista)
            {
                String[] row = { produto.idProduto.ToString(), produto.nome};
                DataGridProdutos.Rows.Add(row);
            }
            DataGridProdutos.Rows[0].Selected = true;
        }

        private void BtSelecionar_Click(object sender, EventArgs e)
        {
            p = Lista[DataGridProdutos.CurrentCell.RowIndex];
            janela.SetProduto(p);
            janela.Selecionado(true);
            Dispose();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }

}
