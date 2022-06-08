using AV1_PAV.Controladores;
using AV1_PAV.Entidades;
using AV1_PAV.PDF;
using AV1_PAV.Persistencia;
using AV1_PAV.SQL;
using MySql.Data.MySqlClient;
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
    public partial class ListarCancelarVenda : Form
    {
        private List<Venda> Lista = new();
        private String filtro;
        private string funcao;
        private const string CANCELAR = "Cancelar";
        private const string LISTAR = "Listar";
        public ListarCancelarVenda()
        {
            InitializeComponent();
        }

        public ListarCancelarVenda(String funcao)
        {
            InitializeComponent();
            this.funcao = funcao;
            if (this.funcao == LISTAR)
            {
                btnCancelar.Visible = true;
                btnCancelar.Enabled = true;
                btnCancelar.Text = "Gerar relatório";
                this.Text = "Listar vendas";
            }
            else
            {
                btnCancelar.Visible = true;
                btnCancelar.Enabled = true;
                this.Text = "Cancelar Venda";
            }
            Lista = VendaSQL.BuscarMultiplos("id_cliente","");
            PreencherTabela();
            BancoDados.obterInstancia().conectar();
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

            BancoDados.obterInstancia().finalizarTransacao();
            BancoDados.obterInstancia().desconectar();
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
                BancoDados.obterInstancia().conectar();
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
            BancoDados.obterInstancia().desconectar();
        }

        private void ListarRemoverVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            BancoDados.obterInstancia().finalizarTransacao();
            BancoDados.obterInstancia().desconectar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (funcao == CANCELAR)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja cancelar?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(GridLista.SelectedRows[0].Cells[0].Value.ToString());
                    BancoDados.obterInstancia().conectar();
                    ControladorCadastroVenda controlador = new();
                    controlador.atualizar("CANCELADA", id);
                    BancoDados.obterInstancia().desconectar();
                    Lista = VendaSQL.BuscarMultiplos("id_cliente", "");
                    PreencherTabela();
                }
            }
            else if (funcao == LISTAR)
            {
                GeradorPDF gerador = new(GridLista, "Relatório de Vendas.pdf");
                gerador.GerarPDF();
            }
        }
    }
}
