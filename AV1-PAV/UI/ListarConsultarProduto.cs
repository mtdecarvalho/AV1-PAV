using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AV1_PAV.Persistencia;

namespace AV1_PAV.UI
{
    public partial class ListarConsultarProduto : Form
    {
        public MySqlCommand criarComando(string stringSql)
        {
            return new MySqlCommand(stringSql, BancoDados.obterInstancia().obterConexao());
        }

        public void criarTabela(MySqlDataAdapter dataAdapter)
        {
            DataTable tabela = new();

            dataAdapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }

        public void preencherGrid()
        {
            MySqlDataAdapter dataAdapter = new(criarComando("SELECT * FROM produto"));
            criarTabela(dataAdapter);
        }
        public ListarConsultarProduto()
        {
            InitializeComponent();
            BancoDados.obterInstancia().conectar();
            preencherGrid();
            BancoDados.obterInstancia().desconectar();
            dataGridView1.Columns[0].HeaderText = "ID";
            //dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Quantidade em estoque";
            dataGridView1.Columns[3].HeaderText = "Preço";
            dataGridView1.Columns[4].HeaderText = "Unidade";
            dataGridView1.Columns[5].HeaderText = "Fornecedor";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
