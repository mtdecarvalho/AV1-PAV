using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AV1_PAV.Persistencia;
using AV1_PAV.UI;

namespace AV1_PAV
{
    public partial class JanelaPrincipal : Form
    {
        GroupBox activePanel;
        public JanelaPrincipal()
        {
            InitializeComponent();
            GenericBox.Visible = false;
            FinanceiroBox.Visible = false;
            activePanel = FinanceiroBox;
        }
        public void mostrarPainel(GroupBox painel, String funcao)
        {
            activePanel.Visible = false;
            activePanel = painel;
            activePanel.Visible = true;
            activePanel.Text = funcao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancoDados.obterInstancia().conectar();
            BancoDados.obterInstancia().desconectar();
        }

        private void BtEstoque_Click(object sender, EventArgs e)
        {
            mostrarPainel(GenericBox,"Estoque");
        }

        private void BtFornecedor_Click(object sender, EventArgs e)
        {
            mostrarPainel(GenericBox, "Fornecedores");
        }

        private void BtCliente_Click(object sender, EventArgs e)
        {
            mostrarPainel(GenericBox, "Clientes");
        }

        private void BtVenda_Click(object sender, EventArgs e)
        {
            mostrarPainel(GenericBox, "Vendas");
        }

        private void BtContasReceber_Click(object sender, EventArgs e)
        {
            mostrarPainel(FinanceiroBox, "Financeiro");
        }

        private void FinanceiroBox_Enter(object sender, EventArgs e)
        {

        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            if (activePanel.Text == "Clientes")
            {
                AdicionarClienteFornecedor adicionarCliente = new("Adicionar cliente");
                adicionarCliente.Show();
            }
            else if (activePanel.Text == "Fornecedores")
            {
                AdicionarClienteFornecedor adicionarFornecedor = new("Adicionar fornecedor");
                adicionarFornecedor.Show();
            }
            else if (activePanel.Text == "Estoque")
            {
                AdicionarProduto adicionarProduto = new();
                adicionarProduto.Show();
            }
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {

        }

        private void BtListar_Click(object sender, EventArgs e)
        {

        }
    }
}
