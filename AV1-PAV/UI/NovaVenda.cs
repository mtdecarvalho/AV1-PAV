using AV1_PAV.Entidades;
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
    public partial class NovaVenda : Form
    {
        private List<ItemVenda> Lista = new();
        private ItemVenda iv = new();
        private Produto p;
        private double subtotal = 0;
        private int numeroItem = 0;
        public NovaVenda()
        {
            InitializeComponent();
            LimparTexto();
        }

        public void SetProduto(Produto produto)
        {
            p = produto;
        }

        private void SetTexto()
        {
            LbNome.Text = p.nome.ToString();
            BxPreco.Text = p.preco.ToString();
            BxTotal.Text = (Double.Parse(BxQuantidade.Text) * Double.Parse(BxPreco.Text)).ToString();
        }

        private void LimparTexto()
        {
            LbNome.Text = "";
            BxPreco.Text = "";
            BxQuantidade.Text = "1";
            BxTotal.Text = "";
        }

        private void BtProcurar_Click(object sender, EventArgs e)
        {
            ProcurarProduto janela = new(this, BxProcurar.Text);
            janela.ShowDialog();
            SetTexto();
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            //Falta buscar do banco
            SetTexto();
        }

        private void BtAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            /*public const string ATRIBUTO_ID_VENDA = "ID_VENDA";
            public const string ATRIBUTO_NUMERO_ITEM = "NUMERO_ITEM";
            public const string ATRIBUTO_ID_PRODUTO = "ID_PRODUTO";
            public const string ATRIBUTO_QUANTIDADE = "QUANTIDADE";
            public const string ATRIBUTO_VALOR_UNITARIO = "VALOR_UNITARIO";
            public const string ATRIBUTO_TOTAL_ITEM = "TOTAL_ITEM";
            */
            iv.idVenda = 1;
            iv.idProduto = p.idProduto;
            iv.numeroItem = numeroItem;
            iv.quantidade = int.Parse(BxQuantidade.Text);
            iv.valorUnitario = Double.Parse(BxPreco.Text);
            iv.totalItem = Double.Parse(BxTotal.Text);

            String[] row = { p.idProduto.ToString(), p.nome, iv.quantidade.ToString(),
                             iv.valorUnitario.ToString(), iv.totalItem.ToString() };
            DataGridItemVenda.Rows.Add(row);
            Lista.Add(iv);
            subtotal += Double.Parse(BxTotal.Text);
            LbSubTotal.Text = "Sub - Total: R$ " + subtotal;
            LimparTexto();
            numeroItem++;
        }

        private void BtRemoverCarrinho_Click(object sender, EventArgs e)
        {
            //Falta remover do grid
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            //Janela confirmar o cancelamento
            Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
