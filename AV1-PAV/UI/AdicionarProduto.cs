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

namespace AV1_PAV.UI
{
    public partial class AdicionarProduto : Form
    {
        public AdicionarProduto()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Produto produto = new();
            ControladorCadastroProduto controladorProduto = new();
            produto.nome = tbxNome.Text;
            produto.qtdEstoque = int.Parse(tbxQtdEstoque.Text);
            produto.preco = double.Parse(tbxPreco.Text);
            produto.unidade = cbUnidade.SelectedItem.ToString();
            // produto.idFornecedor = cbFornecedor.SelectedItem;
            controladorProduto.incluir(produto);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
