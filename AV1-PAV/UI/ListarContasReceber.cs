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
    class ListarContasReceber : ListarContas
    {
        private List<ContaReceber> Lista = new();
        private string funcao;
        private const string BAIXAR = "Baixar";
        private const string RELATORIO = "Relatorio";

        public ListarContasReceber(string funcao)
        {
            InitializeComponent();
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
            Lista = ContaReceberSQL.BuscarMultiplos("id_conta_receber", "");
            PreencherTabela(funcao);
        }

        private String[] PreencherLinha(ContaReceber conta)
        {
            String[] linha = { conta.idContaReceber.ToString(), conta.descricao,
                        ClienteSQL.BuscarPorCodigo(conta.idCliente.ToString()).nome.ToString(),
                        conta.dataLancamento, conta.dataVencimento, conta.valor.ToString(),
                        conta.recebido, conta.dataRecebimento, conta.valorRecebimento.ToString()};
            return linha;
        }

        public override void PreencherTabela(string funcao)
        {
            GridLista.Rows.Clear();
            BancoDados.obterInstancia().conectar();
            if (funcao == BAIXAR)
            {
                foreach (ContaReceber conta in Lista)
                {
                    if (conta.recebido == "NAO")
                    {
                        String[] row = PreencherLinha(conta);
                        GridLista.Rows.Add(row);
                    }
                }

            }
            else
            {
                foreach (ContaReceber conta in Lista)
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
                    int id = int.Parse(GridLista.SelectedRows[0].Cells[0].Value.ToString());
                    BancoDados.obterInstancia().conectar();
                    ControladorCadastroContaReceber controlador = new();
                    controlador.atualizar("SIM", id);
                    BancoDados.obterInstancia().desconectar();
                    Lista = ContaReceberSQL.BuscarMultiplos("id_conta_receber", "");
                    PreencherTabela(BAIXAR);
                }
            }
            else if (funcao == RELATORIO)
            {
                GeradorPDF gerador = new(GridLista, "Relatório de Contas a Receber.pdf");
                gerador.GerarPDF();
            }
        }

        public override void RbPagas_CheckedChanged(object sender, EventArgs e)
        {
            String busca = "SIM";
            GridLista.Rows.Clear();
            BancoDados.obterInstancia().conectar();
            foreach (ContaReceber conta in Lista)
            {
                if (conta.recebido.Contains(busca))
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
            foreach (ContaReceber conta in Lista)
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
            foreach (ContaReceber conta in Lista)
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
