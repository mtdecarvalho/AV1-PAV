using AV1_PAV.Controladores;
using AV1_PAV.Entidades;
using AV1_PAV.PDF;
using AV1_PAV.Persistencia;
using AV1_PAV.SQL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV1_PAV.UI
{
    public class ListarContas : Form
    {
        public System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarContas));
            this.Botao = new System.Windows.Forms.Button();
            this.Filtro = new System.Windows.Forms.GroupBox();
            this.RbPagas = new System.Windows.Forms.RadioButton();
            this.RbVencidas = new System.Windows.Forms.RadioButton();
            this.RbAVencer = new System.Windows.Forms.RadioButton();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.GridLista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_recebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // Botao
            // 
            this.Botao.Location = new System.Drawing.Point(826, 424);
            this.Botao.Name = "Botao";
            this.Botao.Size = new System.Drawing.Size(96, 50);
            this.Botao.TabIndex = 16;
            this.Botao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Botao.UseVisualStyleBackColor = true;
            this.Botao.Click += new System.EventHandler(this.Botao_Click);
            // 
            // Filtro
            // 
            this.Filtro.Controls.Add(this.RbPagas);
            this.Filtro.Controls.Add(this.RbVencidas);
            this.Filtro.Controls.Add(this.RbAVencer);
            this.Filtro.Location = new System.Drawing.Point(826, 46);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(96, 99);
            this.Filtro.TabIndex = 14;
            this.Filtro.TabStop = false;
            this.Filtro.Text = "Filtrar por:";
            // 
            // RbPagas
            // 
            this.RbPagas.AutoSize = true;
            this.RbPagas.Location = new System.Drawing.Point(6, 72);
            this.RbPagas.Name = "RbPagas";
            this.RbPagas.Size = new System.Drawing.Size(56, 19);
            this.RbPagas.TabIndex = 3;
            this.RbPagas.TabStop = true;
            this.RbPagas.Text = "Pagas";
            this.RbPagas.UseVisualStyleBackColor = true;
            this.RbPagas.CheckedChanged += new System.EventHandler(this.RbPagas_CheckedChanged);
            // 
            // RbVencidas
            // 
            this.RbVencidas.AutoSize = true;
            this.RbVencidas.Location = new System.Drawing.Point(6, 47);
            this.RbVencidas.Name = "RbVencidas";
            this.RbVencidas.Size = new System.Drawing.Size(71, 19);
            this.RbVencidas.TabIndex = 2;
            this.RbVencidas.TabStop = true;
            this.RbVencidas.Text = "Vencidas";
            this.RbVencidas.UseVisualStyleBackColor = true;
            this.RbVencidas.CheckedChanged += new System.EventHandler(this.RbVencidas_CheckedChanged);
            // 
            // RbAVencer
            // 
            this.RbAVencer.AutoSize = true;
            this.RbAVencer.Location = new System.Drawing.Point(6, 22);
            this.RbAVencer.Name = "RbAVencer";
            this.RbAVencer.Size = new System.Drawing.Size(71, 19);
            this.RbAVencer.TabIndex = 0;
            this.RbAVencer.TabStop = true;
            this.RbAVencer.Text = "A vencer";
            this.RbAVencer.UseVisualStyleBackColor = true;
            this.RbAVencer.CheckedChanged += new System.EventHandler(this.RbAVencer_CheckedChanged);
            // 
            // BtVoltar
            // 
            this.BtVoltar.Image = ((System.Drawing.Image)(resources.GetObject("BtVoltar.Image")));
            this.BtVoltar.Location = new System.Drawing.Point(12, 15);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(25, 25);
            this.BtVoltar.TabIndex = 13;
            this.BtVoltar.UseVisualStyleBackColor = true;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // GridLista
            // 
            this.GridLista.AllowUserToAddRows = false;
            this.GridLista.AllowUserToDeleteRows = false;
            this.GridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descricao,
            this.Cliente,
            this.data_lancamento,
            this.data_vencimento,
            this.valor,
            this.recebido,
            this.dataGridViewTextBoxColumn1,
            this.valor_recebimento});
            this.GridLista.Location = new System.Drawing.Point(12, 46);
            this.GridLista.MultiSelect = false;
            this.GridLista.Name = "GridLista";
            this.GridLista.ReadOnly = true;
            this.GridLista.RowHeadersVisible = false;
            this.GridLista.RowTemplate.Height = 25;
            this.GridLista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridLista.Size = new System.Drawing.Size(805, 428);
            this.GridLista.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.HeaderText = "Numero";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // data_lancamento
            // 
            this.data_lancamento.HeaderText = "Data Lançamento";
            this.data_lancamento.Name = "data_lancamento";
            this.data_lancamento.ReadOnly = true;
            // 
            // data_vencimento
            // 
            this.data_vencimento.HeaderText = "Data Vencimento";
            this.data_vencimento.Name = "data_vencimento";
            this.data_vencimento.ReadOnly = true;
            this.data_vencimento.Width = 75;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 50;
            // 
            // recebido
            // 
            this.recebido.HeaderText = "Recebido";
            this.recebido.Name = "recebido";
            this.recebido.ReadOnly = true;
            this.recebido.Width = 75;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Data Recebimento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // valor_recebimento
            // 
            this.valor_recebimento.HeaderText = "Valor Recebimento";
            this.valor_recebimento.Name = "valor_recebimento";
            this.valor_recebimento.ReadOnly = true;
            // 
            // ListarContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 491);
            this.Controls.Add(this.Botao);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.BtVoltar);
            this.Controls.Add(this.GridLista);
            this.Name = "ListarContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarContasReceber";
            this.Filtro.ResumeLayout(false);
            this.Filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Botao;
        public System.Windows.Forms.GroupBox Filtro;
        public System.Windows.Forms.RadioButton RbVencidas;
        public System.Windows.Forms.RadioButton RbAVencer;
        public System.Windows.Forms.Button BtVoltar;
        public System.Windows.Forms.DataGridView GridLista;
        public System.Windows.Forms.DataGridViewTextBoxColumn data_recebimento;
        public System.Windows.Forms.DataGridViewTextBoxColumn ID;
        public System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        public System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        public System.Windows.Forms.DataGridViewTextBoxColumn data_lancamento;
        public System.Windows.Forms.DataGridViewTextBoxColumn data_vencimento;
        public System.Windows.Forms.DataGridViewTextBoxColumn valor;
        public System.Windows.Forms.DataGridViewTextBoxColumn recebido;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn valor_recebimento;
        public System.Windows.Forms.RadioButton RbPagas;
 
        public virtual void BtVoltar_Click(object sender, EventArgs e) { }
        public virtual void Botao_Click(object sender, EventArgs e) { }
        public virtual void RbPagas_CheckedChanged(object sender, EventArgs e) { }
        public virtual void RbVencidas_CheckedChanged(object sender, EventArgs e) { }
        public virtual void RbAVencer_CheckedChanged(object sender, EventArgs e) { }
        public virtual void PreencherTabela(string funcao) { }

        public void RenomearParaPagamento()
        {
            recebido.HeaderText = "Pago";
            dataGridViewTextBoxColumn1.HeaderText = "Data Pagamento";
            valor_recebimento.HeaderText = "Valor Pagamento";
        }
    }
}
