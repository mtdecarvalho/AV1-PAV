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
using AV1_PAV.Controladores;
using MySql.Data.MySqlClient;
using AV1_PAV.Persistencia;

namespace AV1_PAV.UI
{
    public partial class RemoverProduto : Form
    {
        public void preencherGrid()
        {
            DataTable tabela = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM produto", BancoDados.obterInstancia().obterConexao());
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
            dataAdapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }
        public RemoverProduto()
        {
            InitializeComponent();
            preencherGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        { 
            Produto p = new();
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            int id;
            if (selectedIndex > -1)
            {
                ControladorCadastroProduto c = new();
                BancoDados.obterInstancia().conectar();
                id = int.Parse(dataGridView1.Rows[selectedIndex].Cells["id_produto"].Value.ToString());
                p.idProduto = id;
                c.excluir(p);
                dataGridView1.Rows.RemoveAt(selectedIndex);
                BancoDados.obterInstancia().desconectar();

            }
        }
    }
}
