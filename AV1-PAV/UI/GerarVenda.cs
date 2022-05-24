using AV1_PAV.Controladores;
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
    class GerarVenda : GerarNovo
    {
        private List<ItemVenda> Lista = new();
        private Venda venda = new();
        private Produto p;
        private Cliente c;
        private double subtotal = 0;
        private int numeroItem = 0;
        private int numeroVenda;
        private int maiorId;
        private enum Pagamento
        {
            Dinheiro,
            Credito,
            Debito,
            Boleto
        }
        private bool selecionado;
        public const String CLIENTE = "Cliente";
        public const String PRODUTO = "Produtos";

        public GerarVenda()
        {
            InitializeComponent();
            SetCliente("0");
            SetTextoCliente();
            SetNumeroVenda();
            LimparTexto();
            GetMaxIdProduto();
        }

        public override void Selecionado(bool v)
        {
            selecionado = v;
        }

        public override void SetProduto(Produto produto)
        {
            p = produto;
        }

        public override void SetCliente(Cliente cliente)
        {
            c = cliente;
        }

        private void SetCliente(String id)
        {
            BancoDados.obterInstancia().conectar();
            c = ClienteSQL.BuscarPorCodigo(id);
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

        private void SetNumeroVenda()
        {
            numeroVenda = VendaSQL.BuscarMaiorID() + 1;
            LbVenda.Text = "Venda Número: " + numeroVenda.ToString();
        }

        private void SetTextoCliente()
        {
            LbCliente.Text = c.nome;
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

        private void AtualizaTabela(ItemVenda iv)
        {
            String[] row = { iv.numeroItem.ToString(), p.idProduto.ToString(), p.nome, iv.quantidade.ToString(),
                             iv.valorUnitario.ToString(), iv.totalItem.ToString() };
            DataGridItemVenda.Rows.Add(row);
        }

        private bool ChecarPagamento()
        {
            if (RbDinheiro.Checked)
            {
                venda.formaDePagamento.idFormaPagamento = ((int)Pagamento.Dinheiro);
                return true;
            }
            if (RbCredito.Checked)
            {
                venda.formaDePagamento.idFormaPagamento = ((int)Pagamento.Credito);
                return true;
            }
            if (RbDebito.Checked)
            {
                venda.formaDePagamento.idFormaPagamento = ((int)Pagamento.Debito);
                return true;
            }
            if (RbBoleto.Checked)
            {
                venda.formaDePagamento.idFormaPagamento = ((int)Pagamento.Boleto);
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

        private ContaReceber PreencherContaReceber(DateTime thisDay)
        {
            ContaReceber conta = new();
            conta.idContaReceber = venda.idVenda;
            conta.idCliente = venda.idCliente;
            conta.dataLancamento = thisDay.ToString("yyyy-MM-dd");
            conta.dataVencimento = thisDay.AddDays(7).ToString("yyyy-MM-dd");
            conta.valor = venda.totalVenda;
            conta.recebido = "NAO";
            return conta;
        }

        private void PreencherVenda()
        {
            DateTime thisDay = DateTime.Now;
            string data = thisDay.ToString("yyyy-MM-dd");
            string hora = thisDay.ToString("HH:mm:ss");

            venda.idVenda = numeroVenda;
            venda.data = data;
            venda.hora = hora;
            venda.idCliente = c.idCliente;
            venda.totalVenda = subtotal;
            venda.situacaoVenda = "ATIVA";
            venda.itens = Lista;
            venda.formaDePagamento.idVenda = numeroVenda;
            venda.formaDePagamento.valor = subtotal;
            venda.contaReceber = PreencherContaReceber(thisDay);
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
            ItemVenda iv = new();
            iv.idVenda = numeroVenda;
            iv.idProduto = p.idProduto;
            iv.numeroItem = numeroItem;
            iv.quantidade = int.Parse(BxQuantidade.Text);
            iv.valorUnitario = double.Parse(BxPreco.Text);
            iv.totalItem = double.Parse(BxTotal.Text);

            AtualizaTabela(iv);
            Lista.Add(iv);

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
                ItemVenda aux = new();

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
            ProcurarGenerico janela = new(this, BxCliente.Text, CLIENTE);
            janela.ShowDialog();
            if (selecionado)
                SetTextoCliente();
        }

        public override void BtFinalizar_Click(object sender, EventArgs e)
        {
            if (ChecarPagamento())
            {
                PreencherVenda();

                BancoDados.obterInstancia().conectar();
                ControladorCadastroVenda controlador = new();
                controlador.incluir(venda);
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
