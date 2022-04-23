using AV1_PAV.Entidades;
using AV1_PAV.SQL;
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
        private bool selecionado;
        public NovaVenda()
        {
            InitializeComponent();
            LimparTexto();
        }

        public void SetProduto(Produto produto)
        {
            p = produto;
        }

        public void Selecionado(bool v)
        {
            selecionado = v;
        }

        private void SetTexto()
        {
            LbNome.Text = p.nome.ToString();
            BxPreco.Text = p.preco.ToString();
            AtualizarTotal();           
        }

        private void LimparTexto()
        {
            LbNome.Text = "";
            BxPreco.Text = "";
            BxQuantidade.Text = "1";
            BxTotal.Text = "";
        }

        private void AtualizarTotal()
        {
            BxTotal.Text = (Double.Parse(BxQuantidade.Text) * Double.Parse(BxPreco.Text)).ToString();
        }

        private void AtualizaTabela()
        {
            String[] row = { p.idProduto.ToString(), p.nome, iv.quantidade.ToString(),
                             iv.valorUnitario.ToString(), iv.totalItem.ToString() };
            DataGridItemVenda.Rows.Add(row);
        }

        private void BtProcurar_Click(object sender, EventArgs e)
        {
            selecionado = false;
            ProcurarClienteProduto janela = new(this, BxProcurar.Text);
            janela.ShowDialog();
            if(selecionado)
                SetTexto();
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            p = ProdutoSQL.BuscarPorCodigo(BxCodigo.Text);
            SetTexto();
        }

        private void BtAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            iv.idVenda = 1;
            iv.idProduto = p.idProduto;
            iv.numeroItem = numeroItem;
            iv.quantidade = int.Parse(BxQuantidade.Text);
            iv.valorUnitario = Double.Parse(BxPreco.Text);
            iv.totalItem = Double.Parse(BxTotal.Text);

            AtualizaTabela();
            Lista.Add(iv);

            subtotal += Double.Parse(BxTotal.Text);
            LbSubTotal.Text = "Sub - Total: R$ " + subtotal;

            LimparTexto();
            numeroItem++;
            p = new();
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

        private void AtualizarTotal(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void BtSelecionarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
