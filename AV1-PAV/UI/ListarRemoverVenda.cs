using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
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
    public partial class ListarRemoverVenda : Form
    {
        private List<Venda> Lista = new();
        private String funcao;
        private String filtro;
        public ListarRemoverVenda()
        {
            InitializeComponent();
        }

        public ListarRemoverVenda(String funcao)
        {
            InitializeComponent();
            this.funcao = funcao;
            Lista = VendaSQL.BuscarMultiplos("id_cliente","");
            PreencherTabela();
        }

        private void PreencherTabela()
        {
            GridLista.Rows.Clear();
            BancoDados.obterInstancia().conectar();
            foreach (Venda venda in Lista)
            {               
                String[] row = { venda.idVenda.ToString(), venda.data, venda.hora, 
                    ClienteSQL.BuscarPorCodigo(venda.idCliente.ToString()).nome.ToString(), 
                    venda.totalVenda.ToString(), venda.situacaoVenda };
                GridLista.Rows.Add(row);
                
            }
            GridLista.Rows[0].Selected = true;

            //BancoDados.obterInstancia().finalizarTransacao();
            //BancoDados.obterInstancia().desconectar();
        }

        private bool ChecarSelecao()
        {
            if (RbData.Checked)
            {
                filtro = "Data";
                return true;
            }
            if (RbSituacao.Checked)
            {
                filtro = "Situacao";
                return true;
            }
            return false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (ChecarSelecao())
            {
                String busca = BxPesquisa.Text;
                GridLista.Rows.Clear();
                foreach (Venda venda in Lista)
                {
                    if (filtro == "data")
                    {
                        if (venda.data.Contains(busca))
                        {
                            String[] row = { venda.idVenda.ToString(), venda.data, venda.hora,
                            ClienteSQL.BuscarPorCodigo(venda.idCliente.ToString()).nome.ToString(),
                            venda.totalVenda.ToString(), venda.situacaoVenda };
                            GridLista.Rows.Add(row);
                        }
                    }
                    if (filtro == "Situacao")
                    {
                        if (venda.situacaoVenda.Contains(busca))
                        {
                            String[] row = { venda.idVenda.ToString(), venda.data, venda.hora,
                            ClienteSQL.BuscarPorCodigo(venda.idCliente.ToString()).nome.ToString(),
                            venda.totalVenda.ToString(), venda.situacaoVenda };
                            GridLista.Rows.Add(row);
                        }
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Favor selecione um filtro", "Erro", MessageBoxButtons.OK);
            }

        }

        private void ListarRemoverVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            BancoDados.obterInstancia().finalizarTransacao();
            BancoDados.obterInstancia().desconectar();
        }
    }
}
