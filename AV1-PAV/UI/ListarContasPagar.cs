using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AV1_PAV.Entidades;

namespace AV1_PAV.UI
{
    partial class ListarContasPagar : ListarContasReceber
    {
        private List<ContaPagar> Lista = new();
        private String funcao;
        private const string BAIXAR = "Baixar";
        private const string RELATORIO = "Relatorio";
        public ListarContasPagar()
        {
            InitializeComponent();
        }

        public ListarContasPagar(String funcao)
        {
            InitializeComponent();
            this.funcao = funcao;
            if (this.funcao == BAIXAR)
            {
                RbPagas.Visible = false;
                RbPagas.Enabled = false;
                Botao.Text = "Dar baixa";
                this.Text = "Listar Contas";
            }
            else if (this.funcao == RELATORIO)
            {
                Botao.Text = "Gerar relatório";
                this.Text = "Gerar Relatório";
            }
            //Lista = ContaReceberSQL.BuscarMultiplos("id_conta_receber", "");
            //PreencherTabela(funcao);
        }

        private void ListarContasPagar_Load(object sender, EventArgs e)
        {

        }
    }
}
