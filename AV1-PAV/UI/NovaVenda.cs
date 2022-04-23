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
        private Produto p;
        private double subtotal;
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
            //Falta Adicionar no grid
            LbSubTotal.Text = "Sub - Total: R$ " + subtotal;
            LimparTexto();
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
    }
}
