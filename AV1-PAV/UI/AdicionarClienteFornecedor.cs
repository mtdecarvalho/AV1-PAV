using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AV1_PAV.Controladores;
using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
using AV1_PAV.SQL;

namespace AV1_PAV.UI
{
    public partial class AdicionarClienteFornecedor : Form
    {
        public AdicionarClienteFornecedor()
        {
            InitializeComponent();
        }

        public AdicionarClienteFornecedor(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
            if (this.Text == "Adicionar fornecedor")
                this.lblCpfCnpj.Text = "CNPJ:";
            else if (this.Text == "Adicionar cliente")
                this.lblCpfCnpj.Text = "CPF:";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.Text == "Adicionar cliente")
            {
                Cliente cliente = new();
                cliente.idCliente = ClienteSQL.BuscarMaiorID() + 1;
                cliente.nome = tbxNome.Text;
                cliente.cpfCnpj = tbxCpfCnpj.Text;
                cliente.logradouro = tbxLogradouro.Text;
                cliente.numero = int.Parse(tbxNumero.Text);
                cliente.complemento = tbxComplemento.Text;
                cliente.bairro = tbxBairro.Text;
                cliente.cidade = tbxCidade.Text;
                cliente.estado = cbEstado.SelectedItem.ToString();
                cliente.cep = tbxCEP.Text;
                cliente.telefone = tbxTelefone.Text;
                cliente.email = tbxEmail.Text;

                BancoDados.obterInstancia().conectar();
                ControladorCadastroCliente controlador = new();
                controlador.incluir(cliente);
                BancoDados.obterInstancia().desconectar();
            }
            else if (this.Text == "Adicionar fornecedor")
            {
                Fornecedor fornecedor = new();
                fornecedor.idFornecedor = FornecedorSQL.BuscarMaiorID() + 1;
                fornecedor.nome = tbxNome.Text;
                fornecedor.cpfCnpj = tbxCpfCnpj.Text;
                fornecedor.logradouro = tbxLogradouro.Text;
                fornecedor.numero = int.Parse(tbxNumero.Text);
                fornecedor.complemento = tbxComplemento.Text;
                fornecedor.bairro = tbxBairro.Text;
                fornecedor.cidade = tbxCidade.Text;
                fornecedor.estado = cbEstado.SelectedItem.ToString();
                fornecedor.cep = tbxCEP.Text;
                fornecedor.telefone = tbxTelefone.Text;
                fornecedor.email = tbxEmail.Text;

                BancoDados.obterInstancia().conectar();
                ControladorCadastroFornecedor controlador = new();
                controlador.incluir(fornecedor);
                BancoDados.obterInstancia().desconectar();
            }
            this.Close();
        }

        private void tbxCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AdicionarClienteFornecedor_Load(object sender, EventArgs e)
        {
            cbEstado.SelectedIndex = 0;
        }
    }
}
