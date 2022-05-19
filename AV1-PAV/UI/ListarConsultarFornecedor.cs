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
using AV1_PAV.Entidades;
using AV1_PAV.Controladores;

namespace AV1_PAV.UI
{
    public partial class ListarConsultarFornecedor : Form
    {
        public MySqlCommand criarComando(string stringSql)
        {
            return new MySqlCommand(stringSql, BancoDados.obterInstancia().obterConexao());
        }

        public void atualizarTabela(MySqlDataAdapter dataAdapter)
        {
            DataTable tabela = new();

            dataAdapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
        }

        public void preencherGrid()
        {
            MySqlDataAdapter dataAdapter = new(criarComando("SELECT * FROM fornecedor"));
            atualizarTabela(dataAdapter);
        }
        public ListarConsultarFornecedor()
        {
            InitializeComponent();
            BancoDados.obterInstancia().conectar();
            preencherGrid();
            BancoDados.obterInstancia().desconectar();

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "CNPJ";
            dataGridView1.Columns[3].HeaderText = "Logradouro";
            dataGridView1.Columns[4].HeaderText = "Número";
            dataGridView1.Columns[5].HeaderText = "Complemento";
            dataGridView1.Columns[6].HeaderText = "Bairro";
            dataGridView1.Columns[7].HeaderText = "Cidade";
            dataGridView1.Columns[8].HeaderText = "Estado";
            dataGridView1.Columns[9].HeaderText = "CEP";
            dataGridView1.Columns[10].HeaderText = "Telefone";
            dataGridView1.Columns[11].HeaderText = "E-mail";
            dataGridView1.Columns["id_fornecedor"].Visible = false;
        }

        private void tbxBusca_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new(criarComando("SELECT * FROM fornecedor WHERE nome LIKE \"%" + tbxBusca.Text + "%\""));
            atualizarTabela(dataAdapter);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selecionado = dataGridView1.CurrentCell.RowIndex;
            int id_selecionado;
            if (selecionado > -1)
            {
                BancoDados.obterInstancia().conectar();
                Fornecedor fornecedor = new();
                ControladorCadastroFornecedor controlador = new();

                id_selecionado = int.Parse(dataGridView1.Rows[selecionado].Cells["id_fornecedor"].Value.ToString());
                fornecedor.idFornecedor = id_selecionado;
                controlador.selecionar(fornecedor);
                tbxNome.Text = fornecedor.nome;
                tbxCNPJ.Text = fornecedor.cpfCnpj;
                tbxLogradouro.Text = fornecedor.logradouro;
                tbxNumero.Text = fornecedor.numero.ToString();
                tbxComplemento.Text = fornecedor.complemento;
                tbxBairro.Text = fornecedor.bairro;
                tbxCidade.Text = fornecedor.cidade;
                tbxEstado.Text = fornecedor.estado;
                tbxCEP.Text = fornecedor.cep;
                tbxTelefone.Text = fornecedor.telefone;
                tbxEmail.Text = fornecedor.email;

                BancoDados.obterInstancia().desconectar();

                MySqlDataAdapter dataAdapter = new(criarComando("SELECT * FROM fornecedor WHERE nome LIKE \"%" + tbxBusca.Text + "%\""));
                atualizarTabela(dataAdapter);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int selecionado = dataGridView1.CurrentCell.RowIndex;
            int id_selecionado;
            if (selecionado > -1)
            {
                BancoDados.obterInstancia().conectar();
                Fornecedor fornecedor = new();
                ControladorCadastroFornecedor controlador = new();

                id_selecionado = int.Parse(dataGridView1.Rows[selecionado].Cells["id_fornecedor"].Value.ToString());
                fornecedor.idFornecedor = id_selecionado;
                controlador.selecionar(fornecedor);
                tbxNome.Text = fornecedor.nome;
                tbxCNPJ.Text = fornecedor.cpfCnpj;
                tbxLogradouro.Text = fornecedor.logradouro;
                tbxNumero.Text = fornecedor.numero.ToString();
                tbxComplemento.Text = fornecedor.complemento;
                tbxBairro.Text = fornecedor.bairro;
                tbxCidade.Text = fornecedor.cidade;
                tbxEstado.Text = fornecedor.estado;
                tbxCEP.Text = fornecedor.cep;
                tbxTelefone.Text = fornecedor.telefone;
                tbxEmail.Text = fornecedor.email;

                BancoDados.obterInstancia().desconectar();

                MySqlDataAdapter dataAdapter = new(criarComando("SELECT * FROM fornecedor WHERE nome LIKE \"%" + tbxBusca.Text + "%\""));
                atualizarTabela(dataAdapter);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
