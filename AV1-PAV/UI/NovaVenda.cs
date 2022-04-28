﻿using AV1_PAV.Controladores;
using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using AV1_PAV.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV1_PAV.UI
{
    public partial class NovaVenda : Form
    {
        private List<ItemVenda> Lista = new();
        private Produto p;
        private Cliente c;
        private double subtotal = 0;
        private int numeroItem = 0;
        private int numeroVenda;
        private int maiorId;
        private String pagamento;
        private bool selecionado;

        public const String CLIENTE = "Cliente";
        public const String PRODUTO = "Produto";

        public NovaVenda()
        {
            InitializeComponent();
            SetCliente("0");
            SetTextoCliente();
            SetNumeroVenda();
            LimparTexto();
            GetMaxIdProduto();
        }

        public void SetProduto(Produto produto)
        {
            p = produto;
        }

        public void SetCliente(Cliente cliente)
        {
            c = cliente;
        }

        public void GetMaxIdProduto()
        {
            maiorId = ProdutoSQL.BuscarMaior("id_produto");
        }

        public void SetCliente(String id)
        {
            BancoDados.obterInstancia().conectar();
            c = ClienteSQL.BuscarPorCodigo(id);
            BancoDados.obterInstancia().desconectar();
        }

        public void Selecionado(bool v)
        {
            selecionado = v;
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
            System.Diagnostics.Debug.WriteLine(qtd);
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
            if (RbDinheiro.Checked) { 
                pagamento = "Dinheiro";
                return true;
            }
            if (RbCredito.Checked)
            {
                pagamento = "Credito";
                return true;
            }
            if (RbDebito.Checked)
            {
                pagamento = "Debito";
                return true;
            }   
            if (RbBoleto.Checked)
            {
                pagamento = "Boleto";
                return true;
            }
            return false;
        }

        public void AbrirJanelaProduto()
        {
            selecionado = false;
            ProcurarClienteProduto janela = new(this, BxProcurar.Text, PRODUTO);
            janela.ShowDialog();
            if (selecionado)
                SetTexto();
        }

        private void BtProcurar_Click(object sender, EventArgs e)
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

        private void BtAdicionar_Click(object sender, EventArgs e)
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

        private void BtAdicionarCarrinho_Click(object sender, EventArgs e)
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

        private void BtRemoverCarrinho_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirmação", "Tem certeza que deseja remover o item?", MessageBoxButtons.YesNo);

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

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirmação", "Deseja cancelar a venda?", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
                Dispose();
        }

        private void AtualizarTotal(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void BtSelecionarCliente_Click(object sender, EventArgs e)
        {
            selecionado = false;
            ProcurarClienteProduto janela = new(this, BxCliente.Text, CLIENTE);
            janela.ShowDialog();
            if (selecionado)
                SetTextoCliente();
        }

        private void BtFinalizar_Click(object sender, EventArgs e)
        {
            if (ChecarPagamento())
            {
                DateTime thisDay = DateTime.Now;
                string data = thisDay.ToString("yyyy-MM-dd");
                string hora = thisDay.ToString("HH:mm:ss");


                Venda venda = new();
                venda.idVenda = numeroVenda;
                venda.data = data;
                venda.hora = hora;
                if (!selecionado)
                    venda.idCliente = 0;
                else
                    venda.idCliente = c.idCliente;
                venda.totalVenda = subtotal;
                venda.situacaoVenda = "ATIVA";
                venda.itens = Lista;

                switch (pagamento)
                {
                    case "Dinheiro":
                        venda.formaDePagamento.idFormaPagamento = 0;
                        break;
                    case "Credito":
                        venda.formaDePagamento.idFormaPagamento = 1;
                        break;
                    case "Debito":
                        venda.formaDePagamento.idFormaPagamento = 2;
                        break;
                    case "Boleto":
                        venda.formaDePagamento.idFormaPagamento = 3;
                        break;
                }
                venda.formaDePagamento.idVenda = numeroVenda;
                venda.formaDePagamento.valor = subtotal;

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }
    }
}
