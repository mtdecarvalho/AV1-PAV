using AV1_PAV.Controladores;
using AV1_PAV.Entidades;
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
    public partial class ProcurarClienteProduto : Form
    {
        private List<Produto> ListaProduto = new ();
        private List<Cliente> ListaCliente = new();
        private Produto p;
        private Cliente c;
        private GerarNovo janela;
        private String funcao;

         public ProcurarClienteProduto()
        {
            InitializeComponent();
        }
        
        public ProcurarClienteProduto(GerarNovo NV, String nome, String funcao)
        {
            InitializeComponent();
            this.funcao = funcao;
            if (funcao == GerarVenda.PRODUTO)
            {
                ListaProduto = ProdutoSQL.BuscarMultiplosPorNome(nome);
                janela = (GerarVenda)NV;
            }    
            else if (funcao == GerarVenda.CLIENTE)
            {
                ListaCliente = ClienteSQL.BuscarMultiplosPorNome(nome);
                janela = (GerarVenda)NV;
            }
            PreencherTabela();
        }

        public void PreencherTabela()
        {
            if(funcao == GerarVenda.PRODUTO)
                foreach (Produto produto in ListaProduto)
                {
                    String[] row = { produto.idProduto.ToString(), produto.nome};
                    DataGrid.Rows.Add(row);
                }
            else if (funcao == GerarVenda.CLIENTE)
                foreach (Cliente cliente in ListaCliente)
                {
                    String[] row = { cliente.idCliente.ToString(), cliente.nome };
                    DataGrid.Rows.Add(row);
                }
            DataGrid.Rows[0].Selected = true;
        }

        private void BtSelecionar_Click(object sender, EventArgs e)
        {

            if (funcao == GerarVenda.PRODUTO)
            {
                p = ListaProduto[DataGrid.CurrentCell.RowIndex];
                janela.SetProduto(p);
            }
            else if (funcao == GerarVenda.CLIENTE)
            {
                c = ListaCliente[DataGrid.CurrentCell.RowIndex];
                janela.SetCliente(c);
            }
            janela.Selecionado(true);
            Dispose();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja cancelar?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Dispose();
        }
    }

}
