
namespace AV1_PAV.UI
{
    partial class NovaVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        private void InitializeComponent()
        {
            this.BxProcurar = new System.Windows.Forms.TextBox();
            this.BtProcurar = new System.Windows.Forms.Button();
            this.LbProduto = new System.Windows.Forms.Label();
            this.BxCodigo = new System.Windows.Forms.TextBox();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbNome = new System.Windows.Forms.Label();
            this.BxPreco = new System.Windows.Forms.TextBox();
            this.BxQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BxTotal = new System.Windows.Forms.TextBox();
            this.LbSubTotal = new System.Windows.Forms.Label();
            this.BtAdicionarCarrinho = new System.Windows.Forms.Button();
            this.BtRemoverCarrinho = new System.Windows.Forms.Button();
            this.BtFinalizar = new System.Windows.Forms.Button();
            this.DataGridItemVenda = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // BxProcurar
            // 
            this.BxProcurar.Location = new System.Drawing.Point(625, 12);
            this.BxProcurar.Name = "BxProcurar";
            this.BxProcurar.Size = new System.Drawing.Size(152, 23);
            this.BxProcurar.TabIndex = 0;
            // 
            // BtProcurar
            // 
            this.BtProcurar.Location = new System.Drawing.Point(797, 12);
            this.BtProcurar.Name = "BtProcurar";
            this.BtProcurar.Size = new System.Drawing.Size(75, 23);
            this.BtProcurar.TabIndex = 1;
            this.BtProcurar.Text = "Procurar";
            this.BtProcurar.UseVisualStyleBackColor = true;
            this.BtProcurar.Click += new System.EventHandler(this.BtProcurar_Click);
            // 
            // LbProduto
            // 
            this.LbProduto.AutoSize = true;
            this.LbProduto.Location = new System.Drawing.Point(507, 16);
            this.LbProduto.Name = "LbProduto";
            this.LbProduto.Size = new System.Drawing.Size(101, 15);
            this.LbProduto.TabIndex = 2;
            this.LbProduto.Text = "Procurar produto:";
            // 
            // BxCodigo
            // 
            this.BxCodigo.Location = new System.Drawing.Point(625, 41);
            this.BxCodigo.Name = "BxCodigo";
            this.BxCodigo.Size = new System.Drawing.Size(152, 23);
            this.BxCodigo.TabIndex = 3;
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Location = new System.Drawing.Point(797, 41);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtAdicionar.TabIndex = 4;
            this.BtAdicionar.Text = "Adicionar";
            this.BtAdicionar.UseVisualStyleBackColor = true;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo produto:";
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Location = new System.Drawing.Point(578, 80);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(118, 15);
            this.LbNome.TabIndex = 6;
            this.LbNome.Text = "NOME DO PRODUTO";
            // 
            // BxPreco
            // 
            this.BxPreco.Location = new System.Drawing.Point(625, 136);
            this.BxPreco.Name = "BxPreco";
            this.BxPreco.ReadOnly = true;
            this.BxPreco.Size = new System.Drawing.Size(152, 23);
            this.BxPreco.TabIndex = 8;
            // 
            // BxQuantidade
            // 
            this.BxQuantidade.Location = new System.Drawing.Point(625, 107);
            this.BxQuantidade.Name = "BxQuantidade";
            this.BxQuantidade.Size = new System.Drawing.Size(152, 23);
            this.BxQuantidade.TabIndex = 7;
            this.BxQuantidade.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Preço Unidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total item";
            // 
            // BxTotal
            // 
            this.BxTotal.Location = new System.Drawing.Point(625, 165);
            this.BxTotal.Name = "BxTotal";
            this.BxTotal.ReadOnly = true;
            this.BxTotal.Size = new System.Drawing.Size(152, 23);
            this.BxTotal.TabIndex = 11;
            // 
            // LbSubTotal
            // 
            this.LbSubTotal.AutoSize = true;
            this.LbSubTotal.Location = new System.Drawing.Point(368, 526);
            this.LbSubTotal.Name = "LbSubTotal";
            this.LbSubTotal.Size = new System.Drawing.Size(100, 15);
            this.LbSubTotal.TabIndex = 13;
            this.LbSubTotal.Text = "Sub-Total: R$ 0,00";
            // 
            // BtAdicionarCarrinho
            // 
            this.BtAdicionarCarrinho.Location = new System.Drawing.Point(625, 194);
            this.BtAdicionarCarrinho.Name = "BtAdicionarCarrinho";
            this.BtAdicionarCarrinho.Size = new System.Drawing.Size(152, 23);
            this.BtAdicionarCarrinho.TabIndex = 14;
            this.BtAdicionarCarrinho.Text = "Adicionar no Carrinho";
            this.BtAdicionarCarrinho.UseVisualStyleBackColor = true;
            this.BtAdicionarCarrinho.Click += new System.EventHandler(this.BtAdicionarCarrinho_Click);
            // 
            // BtRemoverCarrinho
            // 
            this.BtRemoverCarrinho.Location = new System.Drawing.Point(625, 223);
            this.BtRemoverCarrinho.Name = "BtRemoverCarrinho";
            this.BtRemoverCarrinho.Size = new System.Drawing.Size(152, 23);
            this.BtRemoverCarrinho.TabIndex = 15;
            this.BtRemoverCarrinho.Text = "Remover do Carrinho";
            this.BtRemoverCarrinho.UseVisualStyleBackColor = true;
            this.BtRemoverCarrinho.Click += new System.EventHandler(this.BtRemoverCarrinho_Click);
            // 
            // BtFinalizar
            // 
            this.BtFinalizar.Location = new System.Drawing.Point(735, 526);
            this.BtFinalizar.Name = "BtFinalizar";
            this.BtFinalizar.Size = new System.Drawing.Size(137, 23);
            this.BtFinalizar.TabIndex = 16;
            this.BtFinalizar.Text = "Finalizar compra";
            this.BtFinalizar.UseVisualStyleBackColor = true;
            // 
            // DataGridItemVenda
            // 
            this.DataGridItemVenda.AllowUserToAddRows = false;
            this.DataGridItemVenda.AllowUserToDeleteRows = false;
            this.DataGridItemVenda.AllowUserToResizeColumns = false;
            this.DataGridItemVenda.AllowUserToResizeRows = false;
            this.DataGridItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Produto,
            this.Quantidade,
            this.Preco,
            this.Total});
            this.DataGridItemVenda.Location = new System.Drawing.Point(12, 12);
            this.DataGridItemVenda.MultiSelect = false;
            this.DataGridItemVenda.Name = "DataGridItemVenda";
            this.DataGridItemVenda.ReadOnly = true;
            this.DataGridItemVenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridItemVenda.RowTemplate.Height = 25;
            this.DataGridItemVenda.Size = new System.Drawing.Size(489, 500);
            this.DataGridItemVenda.TabIndex = 17;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Cod.";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 50;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 210;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Qtd.";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 50;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 75;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 60;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(578, 526);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(137, 23);
            this.BtCancelar.TabIndex = 18;
            this.BtCancelar.Text = "Cancelar compra";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // NovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.DataGridItemVenda);
            this.Controls.Add(this.BtFinalizar);
            this.Controls.Add(this.BtRemoverCarrinho);
            this.Controls.Add(this.BtAdicionarCarrinho);
            this.Controls.Add(this.LbSubTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BxTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BxPreco);
            this.Controls.Add(this.BxQuantidade);
            this.Controls.Add(this.LbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtAdicionar);
            this.Controls.Add(this.BxCodigo);
            this.Controls.Add(this.LbProduto);
            this.Controls.Add(this.BtProcurar);
            this.Controls.Add(this.BxProcurar);
            this.Name = "NovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JanelaVenda";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItemVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BxProcurar;
        private System.Windows.Forms.Button BtProcurar;
        private System.Windows.Forms.Label LbProduto;
        private System.Windows.Forms.TextBox BxCodigo;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbNome;
        private System.Windows.Forms.TextBox BxQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BxTotal;
        private System.Windows.Forms.Label LbSubTotal;
        private System.Windows.Forms.Button BtAdicionarCarrinho;
        private System.Windows.Forms.Button BtRemoverCarrinho;
        private System.Windows.Forms.Button BtFinalizar;
        private System.Windows.Forms.DataGridView DataGridItemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        protected internal System.Windows.Forms.TextBox BxPreco;
        private System.Windows.Forms.Button BtCancelar;
    }
}