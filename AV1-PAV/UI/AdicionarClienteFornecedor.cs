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

                /// implementar integração com bd
            }
            else if (this.Text == "Adicionar fornecedor")
            {
                /// implementar integração com bd
            }
            this.Close();
        }
    }
}
