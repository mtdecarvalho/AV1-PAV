﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace AV1_PAV.Persistencia
{
    class BancoDados
    {
        private int porta = 3306;
        private string servidor = "localhost";
        private string nomeBancoDados = "pav_av1";
        private MySqlConnection conexao;
        private MySqlTransaction transacao;
        private static BancoDados instancia = null; // para o singleton

        private bool iniciado = false;

        private string criarStringConexao(string usuario, string senha)
        {
            return "server = " + servidor +
                   ";port = " + porta.ToString() +
                   ";database = " + nomeBancoDados +
                   ";user id = " + usuario +
                   ";password = " + senha;
        }

        public void conectar(string usuario, string senha)
        {
            try
            {
                conexao = new MySqlConnection(criarStringConexao(usuario, senha));
                conexao.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void conectar()
        {
            conectar("root", "y62fSiko&Q50");
        }

        public void testar()
        {
            try
            {
                conectar("root", "y62fSiko&Q50");
                MessageBox.Show("Conexão realizada com sucesso");
                desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void desconectar()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                conexao.Dispose();
            }
        }

        public MySqlConnection obterConexao()
        {
            return conexao;
        }

        public static BancoDados obterInstancia()
        {
            if (instancia == null)
            {
                instancia = new BancoDados();
            }
            return instancia;
        }

        public void iniciarTransacao()
        {
                transacao = conexao.BeginTransaction();
        }

        public void iniciarTransacaoOtimizado()
        {
            if (!iniciado)
            {
                transacao = conexao.BeginTransaction();
                iniciado = true;
            }
        }
        public void finalizarTransacao()
        {
            iniciado = false;
        }

        public void confirmarTransacao()
        {
            if (transacao != null)
            {
                transacao.Commit();
                transacao.Dispose();
            }
        }

        public void cancelarTransacao()
        {
            if (transacao != null)
            {
                transacao.Rollback();
                transacao.Dispose();
            }
        }
    }
}
