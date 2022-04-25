using AV1_PAV.Controladores;
using AV1_PAV.Entidades;
using AV1_PAV.Persistencia;
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

namespace AV1_PAV
{
    public partial class ListarConsultarCliente : Form
    {
        private List<Cliente> Lista = new();

        public ListarConsultarCliente()
        {
            InitializeComponent();

            LerDoBanco();
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            dataGridClientes.Rows.Clear();

            foreach (Cliente cliente in Lista)
            {
                String[] linha = {
                    cliente.idCliente.ToString(), cliente.nome, cliente.cpfCnpj, cliente.logradouro,
                    cliente.numero.ToString(), cliente.complemento, cliente.bairro, cliente.cidade,
                    cliente.estado, cliente.cep, cliente.telefone, cliente.email
                };
                dataGridClientes.Rows.Add(linha);
            }
        }
        public void LerDoBanco(String SQL = "SELECT * FROM cliente")
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
                    Cliente entidade = new();
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            /*Cliente cliente = new();
            cliente.idCliente = int.Parse(dataGridClientes.SelectedRows[0].Cells[0].Value.ToString());
            BancoDados.obterInstancia().conectar();
            ControladorCadastroCliente controlador = new();
            controlador.selecionar(cliente);
            BancoDados.obterInstancia().desconectar();

            tbxNome.Text = cliente.nome;
            tbxCPF.Text = cliente.cpfCnpj;
            tbxLogradouro.Text = cliente.logradouro;
            tbxNumero.Text = cliente.numero.ToString() ;
            tbxComplemento.Text = cliente.complemento;
            tbxBairro.Text = cliente.bairro;
            tbxCidade.Text = cliente.cidade;
            tbxEstado.Text = cliente.estado;
            tbxCEP.Text = cliente.cep;
            tbxTelefone.Text = cliente.telefone;
            tbxEmail.Text = cliente.email;*/
            string busca = tbxBusca.Text;
            List<Cliente> novaLista = new();

            dataGridClientes.Rows.Clear();
            
            foreach (Cliente cliente in Lista)
            {
                if (cliente.nome.Contains(busca))
                {
                    String[] linha = {
                        cliente.idCliente.ToString(), cliente.nome, cliente.cpfCnpj, cliente.logradouro,
                        cliente.numero.ToString(), cliente.complemento, cliente.bairro, cliente.cidade,
                        cliente.estado, cliente.cep, cliente.telefone, cliente.email
                    };
                    dataGridClientes.Rows.Add(linha);
                }
            }
        }

        private void dataGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridClientes.CurrentCell.RowIndex;

            tbxNome.Text = dataGridClientes.Rows[selectedRow].Cells[1].Value.ToString();
            tbxCPF.Text = dataGridClientes.Rows[selectedRow].Cells[2].Value.ToString();
            tbxLogradouro.Text = dataGridClientes.Rows[selectedRow].Cells[3].Value.ToString();
            tbxNumero.Text = dataGridClientes.Rows[selectedRow].Cells[4].Value.ToString();
            tbxComplemento.Text = dataGridClientes.Rows[selectedRow].Cells[5].Value.ToString();
            tbxBairro.Text = dataGridClientes.Rows[selectedRow].Cells[6].Value.ToString();
            tbxCidade.Text = dataGridClientes.Rows[selectedRow].Cells[7].Value.ToString();
            tbxEstado.Text = dataGridClientes.Rows[selectedRow].Cells[8].Value.ToString();
            tbxCEP.Text = dataGridClientes.Rows[selectedRow].Cells[9].Value.ToString();
            tbxTelefone.Text = dataGridClientes.Rows[selectedRow].Cells[10].Value.ToString();
            tbxEmail.Text = dataGridClientes.Rows[selectedRow].Cells[11].Value.ToString();
        }
    }
}
