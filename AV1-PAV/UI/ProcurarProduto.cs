using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
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
    public partial class ProcurarProduto : Form
    {
        private List<Produto> Lista = new List<Produto>();
        private Produto p;
        private NovaVenda janela;
        public ProcurarProduto()
        {
            InitializeComponent();
        }

        public ProcurarProduto(NovaVenda NV, String nome)
        {
            InitializeComponent();
            janela = NV;
            Lista = p.ObterListaPorNome(nome);
        }

        private void BtSelecionar_Click(object sender, EventArgs e)
        {
            janela.SetProduto(p);
        }
    }

}
