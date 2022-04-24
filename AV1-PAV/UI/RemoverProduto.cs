﻿using System;
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

        public RemoverProduto()
        {
            InitializeComponent();
            preencherGrid();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Quantidade em estoque";
            dataGridView1.Columns[3].HeaderText = "Preço";
            dataGridView1.Columns[4].HeaderText = "Unidade";
            dataGridView1.Columns[5].HeaderText = "Fornecedor";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter dataAdapter = new(criarComando("SELECT * FROM produto WHERE nome LIKE \"%" + tbxBusca.Text + "%\""));
            criarTabela(dataAdapter);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int selecionado = dataGridView1.CurrentCell.RowIndex;
            int id_selecionado;
            if (selecionado > -1)
            {
                Produto produto = new();
                ControladorCadastroProduto controlador = new();
                BancoDados.obterInstancia().conectar();
                id_selecionado = int.Parse(dataGridView1.Rows[selecionado].Cells["id_produto"].Value.ToString());
                produto.idProduto = id_selecionado;
                controlador.excluir(produto);
                dataGridView1.Rows.RemoveAt(selecionado);
                BancoDados.obterInstancia().desconectar();
            }
        }
    }
}
