using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using AV1_PAV.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV1_PAV.UI
{
    class GerarCompra : GerarNovo
    {
        private List<ItemCompra> Lista = new();
        private Compra compra = new();
        private Produto p;
        private Fornecedor f;
        private double subtotal = 0;
        private int numeroItem = 0;
        private int numeroCompra;
        private int maiorId;
        private enum Pagamento
        {
            Dinheiro,
            Credito,
            Debito,
            Boleto
        }
        private bool selecionado;
        public const String FORNECEDOR = "Fornecedor";
        public const String PRODUTO = "Produto";

        public GerarCompra()
        {
            InitializeComponent();
            SetFornecedor("0");
            SetTextoFornecedor();
            SetNumeroCompra();
            LimparTexto();
            GetMaxIdProduto();
            RenomearParaCompra();
        }

        public override void Selecionado(bool v)
        {
            selecionado = v;
        }

        public override void SetProduto(Produto produto)
        {
            p = produto;
        }

        public override void SetFornecedor(Fornecedor fornecedor)
        {
            f = fornecedor;
        }

        private void SetFornecedor(String id)
        {
            BancoDados.obterInstancia().conectar();
            f = FornecedorSQL.BuscarPorCodigo(id);
            BancoDados.obterInstancia().desconectar();
        }

        private void GetMaxIdProduto()
        {
            maiorId = ProdutoSQL.BuscarMaior("id_produto");
        }

        private void SetTexto()
        {
            LbNome.Text = p.nome.ToString();
            BxPreco.Text = p.preco.ToString();
            BxQuantidade.Value = 1;
            AtualizarTotal();
        }

        private void SetNumeroCompra()
        {
            numeroCompra = CompraSQL.BuscarMaiorID() + 1;
            LbVenda.Text = "Compra Número: " + numeroCompra.ToString();
        }

        private void SetTextoFornecedor()
        {
            LbCliente.Text = f.nome;
        }

        private void LimparTexto()
        {
            LbNome.Text = "";
            BxPreco.Text = "1";
            BxQuantidade.Text = "1";
            BxTotal.Text = "";
        }

        private void AtualizarTotal()
        {
            int qtd = int.Parse(BxQuantidade.Value.ToString());
            double preco = Double.Parse(BxPreco.Text);
            double total = qtd * preco;
            BxTotal.Text = total.ToString();
        }

        private void AtualizaTabela(ItemCompra ic)
        {
            String[] row = { ic.numeroItem.ToString(), p.idProduto.ToString(), p.nome, ic.quantidade.ToString(),
                             ic.valorUnitario.ToString(), ic.totalItem.ToString() };
            DataGridItemVenda.Rows.Add(row);
        }
        
        private bool ChecarPagamento()
        {
            if (RbDinheiro.Checked)
            {
                compra.formaDePagamento.idFormaPagamento = ((int)Pagamento.Dinheiro);
                return true;
            }
            if (RbCredito.Checked)
            {
                compra.formaDePagamento.idFormaPagamento = ((int)Pagamento.Credito);
                return true;
            }
            if (RbDebito.Checked)
            {
                compra.formaDePagamento.idFormaPagamento = ((int)Pagamento.Debito);
                return true;
            }
            if (RbBoleto.Checked)
            {
                compra.formaDePagamento.idFormaPagamento = ((int)Pagamento.Boleto);
                return true;
            }
            return false;
        }
        
        private void AbrirJanelaProduto()
        {
            selecionado = false;
            ProcurarGenerico janela = new(this, BxProcurar.Text, PRODUTO);
            janela.ShowDialog();
            if (selecionado)
                SetTexto();
        }

        private ContaPagar PreencherContaPagar(DateTime thisDay)
        {
            ContaPagar conta = new();
            conta.idContaPagar = compra.idCompra;
            conta.idFornecedor = compra.idFornecedor;
            conta.dataLancamento = thisDay.ToString("yyyy-MM-dd");
            conta.dataVencimento = thisDay.AddDays(7).ToString("yyyy-MM-dd");
            conta.valor = compra.totalCompra;
            conta.pago = "NAO";
            return conta;
        }

        private void PreencherVenda()
        {
            DateTime thisDay = DateTime.Now;
            string data = thisDay.ToString("yyyy-MM-dd");
            string hora = thisDay.ToString("HH:mm:ss");

            compra.idCompra = numeroCompra;
            compra.data = data;
            compra.hora = hora;
            compra.idFornecedor = f.idFornecedor;
            compra.totalCompra = subtotal;
            compra.situacaoCompra = "ATIVA";
            compra.itens = Lista;
            compra.formaDePagamento.idVenda = numeroCompra;
            compra.formaDePagamento.valor = subtotal;
            compra.contaPagar = PreencherContaPagar(thisDay);
        }

        public override void BtProcurar_Click(object sender, EventArgs e)
        {
            if (BxProcurar.Text != "")
            {
                if (int.Parse(BxProcurar.Text) < maiorId && int.Parse(BxProcurar.Text) > 0)
                {
                    AbrirJanelaProduto();
                }
                else
                {
                    MessageBox.Show("Item inexistente", "Erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                AbrirJanelaProduto();
            }

        }

        public override void BtAdicionar_Click(object sender, EventArgs e)
        {
            if (BxCodigo.Text != "" && int.Parse(BxCodigo.Text) < maiorId && int.Parse(BxCodigo.Text) > 0)
            {
                p = ProdutoSQL.BuscarPorCodigo(BxCodigo.Text);
                SetTexto();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Item inexistente", "Erro", MessageBoxButtons.OK);
            }
        }

        public override void BtAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            ItemCompra ic = new();
            ic.idCompra = numeroCompra;
            ic.idProduto = p.idProduto;
            ic.numeroItem = numeroItem;
            ic.quantidade = int.Parse(BxQuantidade.Text);
            ic.valorUnitario = double.Parse(BxPreco.Text);
            ic.totalItem = double.Parse(BxTotal.Text);

            AtualizaTabela(ic);
            Lista.Add(ic);

            subtotal += Double.Parse(BxTotal.Text);
            LbSubTotal.Text = "Sub - Total: R$ " + subtotal;

            LimparTexto();
            numeroItem++;
            p = new();
        }

        public override void BtRemoverCarrinho_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja remover o item?", "Confirmação", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int pos = DataGridItemVenda.CurrentCell.RowIndex;
                String id = DataGridItemVenda.Rows[pos].Cells[0].Value.ToString();
                ItemCompra aux = new();

                aux = Lista.Find(item => item.numeroItem == int.Parse(id));

                subtotal -= aux.totalItem;
                LbSubTotal.Text = "Sub - Total: R$ " + subtotal;

                Lista.Remove(aux);
                DataGridItemVenda.Rows.RemoveAt(pos);
            }
        }

        public override void BtCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja cancelar a venda?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Dispose();
        }

        public override void BtSelecionarCliente_Click(object sender, EventArgs e)
        {
            selecionado = false;
            ProcurarGenerico janela = new(this, BxCliente.Text, FORNECEDOR);
            janela.ShowDialog();
            if (selecionado)
                SetTextoFornecedor();
        }

        public override void BtFinalizar_Click(object sender, EventArgs e)
        {
            if (ChecarPagamento())
            {
                PreencherVenda();

                BancoDados.obterInstancia().conectar();
                ControladorCadastroCompra controlador = new();
                controlador.incluir(compra);
                BancoDados.obterInstancia().desconectar();
                this.Dispose();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Favor selecione uma forma de pagamento", "Erro", MessageBoxButtons.OK);
            }
        }

        public override void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }
    }
}
