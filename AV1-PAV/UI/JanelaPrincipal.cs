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

        private const String VENDAS       = "Vendas";
        private const String CLIENTES     = "Clientes";
        private const String ESTOQUE      = "Estoque";
        private const String FORNECEDORES = "Fornecedores";
        private const String FINANCEIRO   = "Financeiro";

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
            //BancoDados.obterInstancia().desconectar();
        }

        private void BtVenda_Click(object sender, EventArgs e)
        {
            mostrarPainel(GenericBox, VENDAS);
        }

        private void BtCliente_Click(object sender, EventArgs e)
        {
            mostrarPainel(GenericBox, CLIENTES);
        }

        private void BtEstoque_Click(object sender, EventArgs e)
        {
            mostrarPainel(GenericBox, ESTOQUE);
        }

        private void BtFornecedor_Click(object sender, EventArgs e)
        {
            mostrarPainel(GenericBox, FORNECEDORES);
        }

        private void BtContasReceber_Click(object sender, EventArgs e)
        {
            mostrarPainel(FinanceiroBox, FINANCEIRO);
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            if (activePanel.Text == CLIENTES)
            {
                AdicionarClienteFornecedor adicionarCliente = new("Adicionar cliente");
                adicionarCliente.ShowDialog();
            }
            else if (activePanel.Text == FORNECEDORES)
            {
                AdicionarClienteFornecedor adicionarFornecedor = new("Adicionar fornecedor");
                adicionarFornecedor.ShowDialog();
            }
            else if (activePanel.Text == ESTOQUE)
            {
                AdicionarProduto adicionarProduto = new();
                adicionarProduto.ShowDialog();
            }
            else if (activePanel.Text == VENDAS)
            {
                NovaVenda janela = new();
                janela.ShowDialog();
            }
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
              if (activePanel.Text == ESTOQUE)
            {
                RemoverProduto removerProduto = new();
                removerProduto.ShowDialog();
            } else if (activePanel.Text == CLIENTES)
            {
                RemoverCliente removerCliente = new();
                removerCliente.ShowDialog();
            }
        }

        private void BtListar_Click(object sender, EventArgs e)
        {
            if (activePanel.Text == CLIENTES)
            {
                ListarConsultarCliente listarConsultarCliente = new();
                listarConsultarCliente.ShowDialog();
            } else if (activePanel.Text == ESTOQUE)
            {
                ListarConsultarProduto listarConsultarProduto = new();
                listarConsultarProduto.ShowDialog();
            }
        }

        private void FinanceiroBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
