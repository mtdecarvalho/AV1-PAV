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
using AV1_PAV.SQL;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.UI
{
    public partial class AdicionarProduto : Form
    {
        private List<Fornecedor> Lista = new();
        public AdicionarProduto()
        {
            InitializeComponent();
            LerDoBanco();
            preencherComboBox();
        }

        public void LerDoBanco(String SQL = "SELECT * FROM fornecedor")
        {
            BancoDados.obterInstancia().conectar();
            MySqlCommand comandoSelecao = new MySqlCommand(SQL, BancoDados.obterInstancia().obterConexao());
            BancoDados.obterInstancia().iniciarTransacao();
            Lista.Clear();
            try
            {
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                while (leitorDados.Read())
                {
                    Fornecedor entidade = new();
                    entidade.lerDados(leitorDados);
                    Lista.Add(entidade);
                }
                leitorDados.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            BancoDados.obterInstancia().desconectar();
        }

        public void preencherComboBox()
        {
            foreach (Fornecedor fornecedor in Lista)
            {
                cbFornecedor.Items.Add(fornecedor.nome);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Produto produto = new();
            produto.idProduto = ProdutoSQL.BuscarMaior("id_produto") + 1;
            produto.nome = tbxNome.Text;
            produto.qtdEstoque = int.Parse(tbxQtdEstoque.Text);
            produto.preco = double.Parse(tbxPreco.Text);
            produto.unidade = cbUnidade.SelectedItem.ToString();
            produto.idFornecedor = Lista[cbFornecedor.SelectedIndex].idFornecedor;

            BancoDados.obterInstancia().conectar();
            ControladorCadastroProduto controladorProduto = new();
            controladorProduto.incluir(produto);
            BancoDados.obterInstancia().desconectar();

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show( "Tem certeza que deseja cancelar?","Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                this.Close();
        }

        private void tbxQtdEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
