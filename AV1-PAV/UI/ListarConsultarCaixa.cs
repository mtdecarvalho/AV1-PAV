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
using AV1_PAV.PDF;
using AV1_PAV.Persistencia;
using MySql.Data.MySqlClient;

namespace AV1_PAV.UI
{
    public partial class ListarConsultarCaixa : Form
    {
        private List<Caixa> Lista = new();


        public ListarConsultarCaixa()
        {
            InitializeComponent();

            LerDoBanco();
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            dataGridCaixa.Rows.Clear();

            foreach (Caixa caixa in Lista)
            {
                String[] linha = {
                    caixa.id.ToString(), caixa.nome, caixa.saldo.ToString()
                };
                dataGridCaixa.Rows.Add(linha);
            }
        }

        public void LerDoBanco(String SQL = "SELECT * FROM caixa")
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
                    Caixa entidade = new();
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

        private void btn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridCaixa.CurrentCell.RowIndex;

            GeradorPDF gerador = new(dataGridCaixa, "Relatório de Fechamento de Caixa.pdf");
            gerador.GerarPDF();
        }
    }
}
