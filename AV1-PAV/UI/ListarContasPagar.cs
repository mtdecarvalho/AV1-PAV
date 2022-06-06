using AV1_PAV.Controladores;
using AV1_PAV.Entidades;
using AV1_PAV.PDF;
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
    class ListarContasPagar : ListarContas
    {
        private List<ContaPagar> Lista = new();
        private String funcao;
        private const string BAIXAR = "Baixar";
        private const string RELATORIO = "Relatorio";

        public ListarContasPagar(String funcao)
        {
            InitializeComponent();
            RenomearParaPagamento();
            
            this.funcao = funcao;
            if (this.funcao == BAIXAR)
            {
                RbPagas.Visible = false;
                RbPagas.Enabled = false;
                Botao.Text = "Dar baixa";
                Text = "Listar Contas";
            }
            else if (this.funcao == RELATORIO)
            {
                Botao.Text = "Gerar relatório";
                Text = "Gerar Relatório";
            }
            Lista = ContaPagarSQL.BuscarMultiplos("id_conta_pagar", "");
            PreencherTabela(funcao);
        }

        private String[] PreencherLinha(ContaPagar conta)
        {
            String[] linha = { conta.idContaPagar.ToString(), conta.descricao,
                            FornecedorSQL.BuscarPorCodigo(conta.idFornecedor.ToString()).nome.ToString(),
                            conta.dataLancamento, conta.dataVencimento, conta.valor.ToString(),
                            conta.pago, conta.dataPagamento, conta.valorPagamento.ToString()};
            return linha;
        }

        public override void PreencherTabela(string funcao)
        {
            GridLista.Rows.Clear();
            BancoDados.obterInstancia().conectar();
            if (funcao == BAIXAR)
            {
                foreach (ContaPagar conta in Lista)
                {
                    if (conta.pago == "NAO")
                    {
                        String[] row = PreencherLinha(conta);
                        GridLista.Rows.Add(row);
                    }
                }

            }
            else
            {
                foreach (ContaPagar conta in Lista)
                {
                    String[] row = PreencherLinha(conta);
                    GridLista.Rows.Add(row);
                }
            }

            BancoDados.obterInstancia().finalizarTransacao();
            BancoDados.obterInstancia().desconectar();
        }

        public override void BtVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public override void Botao_Click(object sender, EventArgs e)
        {
            if (funcao == BAIXAR)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja dar baixa nessa conta?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ContaPagar contaPagar = new();
                    contaPagar.idContaPagar = int.Parse(GridLista.SelectedRows[0].Cells[0].Value.ToString());

                    BancoDados.obterInstancia().conectar();
                    ControladorCadastroContaPagar controlador = new();
                    controlador.selecionar(contaPagar);
                    controlador.atualizar("SIM", contaPagar);
                    BancoDados.obterInstancia().desconectar();

                    Lista = ContaPagarSQL.BuscarMultiplos("id_conta_pagar", "");
                    PreencherTabela(BAIXAR);
                }
            }
            else if (funcao == RELATORIO)
            {
                GeradorPDF gerador = new(GridLista, "Relatório de Contas a Pagar.pdf");
                gerador.GerarPDF();
            }
        }

        public override void RbPagas_CheckedChanged(object sender, EventArgs e)
        {
            String busca = "SIM";
            GridLista.Rows.Clear();
            BancoDados.obterInstancia().conectar();
            foreach (ContaPagar conta in Lista)
            {
                if (conta.pago.Contains(busca))
                {
                    String[] row = PreencherLinha(conta);
                    GridLista.Rows.Add(row);
                }
            }
            BancoDados.obterInstancia().desconectar();
        }

        public override void RbVencidas_CheckedChanged(object sender, EventArgs e)
        {
            GridLista.Rows.Clear();
            BancoDados.obterInstancia().conectar();
            foreach (ContaPagar conta in Lista)
            {
                System.Diagnostics.Debug.WriteLine(DateTime.Parse(conta.dataVencimento));
                if (DateTime.Now > DateTime.Parse(conta.dataVencimento))
                {
                    String[] row = PreencherLinha(conta);
                    GridLista.Rows.Add(row);
                }
            }
            BancoDados.obterInstancia().desconectar();
        }

        public override void RbAVencer_CheckedChanged(object sender, EventArgs e)
        {
            GridLista.Rows.Clear();
            BancoDados.obterInstancia().conectar();
            foreach (ContaPagar conta in Lista)
            {
                if (DateTime.Now < DateTime.Parse(conta.dataVencimento))
                {
                    String[] row = PreencherLinha(conta);
                    GridLista.Rows.Add(row);
                }
            }
            BancoDados.obterInstancia().desconectar();
        }
    }
}
