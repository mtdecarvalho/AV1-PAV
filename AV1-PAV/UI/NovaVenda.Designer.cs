
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaVenda));
            this.BxProcurar = new System.Windows.Forms.TextBox();
            this.BtProcurar = new System.Windows.Forms.Button();
            this.LbProduto = new System.Windows.Forms.Label();
            this.BxCodigo = new System.Windows.Forms.TextBox();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbNome = new System.Windows.Forms.Label();
            this.BxPreco = new System.Windows.Forms.TextBox();
            this.BxQuantidade = new System.Windows.Forms.TextBox();
            this.LbPreco = new System.Windows.Forms.Label();
            this.LbQuantidade = new System.Windows.Forms.Label();
            this.LbTotalItem = new System.Windows.Forms.Label();
            this.BxTotal = new System.Windows.Forms.TextBox();
            this.LbSubTotal = new System.Windows.Forms.Label();
            this.BtAdicionarCarrinho = new System.Windows.Forms.Button();
            this.BtRemoverCarrinho = new System.Windows.Forms.Button();
            this.BtFinalizar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtSelecionarCliente = new System.Windows.Forms.Button();
            this.LbVenda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BxCliente = new System.Windows.Forms.TextBox();
            this.LbCliente = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridItemVenda = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridItemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // BxProcurar
            // 
            this.BxProcurar.Location = new System.Drawing.Point(625, 89);
            this.BxProcurar.Name = "BxProcurar";
            this.BxProcurar.Size = new System.Drawing.Size(152, 23);
            this.BxProcurar.TabIndex = 0;
            // 
            // BtProcurar
            // 
            this.BtProcurar.Image = ((System.Drawing.Image)(resources.GetObject("BtProcurar.Image")));
            this.BtProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtProcurar.Location = new System.Drawing.Point(792, 89);
            this.BtProcurar.Name = "BtProcurar";
            this.BtProcurar.Size = new System.Drawing.Size(80, 25);
            this.BtProcurar.TabIndex = 1;
            this.BtProcurar.Text = "Procurar";
            this.BtProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtProcurar.UseVisualStyleBackColor = true;
            this.BtProcurar.Click += new System.EventHandler(this.BtProcurar_Click);
            // 
            // LbProduto
            // 
            this.LbProduto.AutoSize = true;
            this.LbProduto.Location = new System.Drawing.Point(507, 93);
            this.LbProduto.Name = "LbProduto";
            this.LbProduto.Size = new System.Drawing.Size(101, 15);
            this.LbProduto.TabIndex = 2;
            this.LbProduto.Text = "Procurar produto:";
            // 
            // BxCodigo
            // 
            this.BxCodigo.Location = new System.Drawing.Point(625, 118);
            this.BxCodigo.Name = "BxCodigo";
            this.BxCodigo.Size = new System.Drawing.Size(152, 23);
            this.BxCodigo.TabIndex = 3;
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Location = new System.Drawing.Point(797, 118);
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
            this.label1.Location = new System.Drawing.Point(507, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo produto:";
            // 
            // LbNome
            // 
            this.LbNome.AutoSize = true;
            this.LbNome.Location = new System.Drawing.Point(578, 157);
            this.LbNome.Name = "LbNome";
            this.LbNome.Size = new System.Drawing.Size(118, 15);
            this.LbNome.TabIndex = 6;
            this.LbNome.Text = "NOME DO PRODUTO";
            // 
            // BxPreco
            // 
            this.BxPreco.Location = new System.Drawing.Point(625, 213);
            this.BxPreco.Name = "BxPreco";
            this.BxPreco.ReadOnly = true;
            this.BxPreco.Size = new System.Drawing.Size(152, 23);
            this.BxPreco.TabIndex = 8;
            // 
            // BxQuantidade
            // 
            this.BxQuantidade.Location = new System.Drawing.Point(625, 184);
            this.BxQuantidade.Name = "BxQuantidade";
            this.BxQuantidade.Size = new System.Drawing.Size(152, 23);
            this.BxQuantidade.TabIndex = 7;
            this.BxQuantidade.Text = "1";
            this.BxQuantidade.TextChanged += new System.EventHandler(this.AtualizarTotal);
            // 
            // LbPreco
            // 
            this.LbPreco.AutoSize = true;
            this.LbPreco.Location = new System.Drawing.Point(507, 216);
            this.LbPreco.Name = "LbPreco";
            this.LbPreco.Size = new System.Drawing.Size(84, 15);
            this.LbPreco.TabIndex = 10;
            this.LbPreco.Text = "Preço unitario:";
            // 
            // LbQuantidade
            // 
            this.LbQuantidade.AutoSize = true;
            this.LbQuantidade.Location = new System.Drawing.Point(507, 187);
            this.LbQuantidade.Name = "LbQuantidade";
            this.LbQuantidade.Size = new System.Drawing.Size(72, 15);
            this.LbQuantidade.TabIndex = 9;
            this.LbQuantidade.Text = "Quantidade:";
            // 
            // LbTotalItem
            // 
            this.LbTotalItem.AutoSize = true;
            this.LbTotalItem.Location = new System.Drawing.Point(507, 245);
            this.LbTotalItem.Name = "LbTotalItem";
            this.LbTotalItem.Size = new System.Drawing.Size(62, 15);
            this.LbTotalItem.TabIndex = 12;
            this.LbTotalItem.Text = "Total item:";
            // 
            // BxTotal
            // 
            this.BxTotal.Location = new System.Drawing.Point(625, 242);
            this.BxTotal.Name = "BxTotal";
            this.BxTotal.ReadOnly = true;
            this.BxTotal.Size = new System.Drawing.Size(152, 23);
            this.BxTotal.TabIndex = 11;
            // 
            // LbSubTotal
            // 
            this.LbSubTotal.AutoSize = true;
            this.LbSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbSubTotal.Location = new System.Drawing.Point(368, 526);
            this.LbSubTotal.Name = "LbSubTotal";
            this.LbSubTotal.Size = new System.Drawing.Size(108, 15);
            this.LbSubTotal.TabIndex = 13;
            this.LbSubTotal.Text = "Sub-Total: R$ 0,00";
            // 
            // BtAdicionarCarrinho
            // 
            this.BtAdicionarCarrinho.Location = new System.Drawing.Point(625, 271);
            this.BtAdicionarCarrinho.Name = "BtAdicionarCarrinho";
            this.BtAdicionarCarrinho.Size = new System.Drawing.Size(152, 23);
            this.BtAdicionarCarrinho.TabIndex = 14;
            this.BtAdicionarCarrinho.Text = "Adicionar ao Carrinho";
            this.BtAdicionarCarrinho.UseVisualStyleBackColor = true;
            this.BtAdicionarCarrinho.Click += new System.EventHandler(this.BtAdicionarCarrinho_Click);
            // 
            // BtRemoverCarrinho
            // 
            this.BtRemoverCarrinho.Location = new System.Drawing.Point(507, 489);
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
            this.BtFinalizar.Click += new System.EventHandler(this.BtFinalizar_Click);
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
            // BtSelecionarCliente
            // 
            this.BtSelecionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtSelecionarCliente.Image")));
            this.BtSelecionarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtSelecionarCliente.Location = new System.Drawing.Point(792, 6);
            this.BtSelecionarCliente.Name = "BtSelecionarCliente";
            this.BtSelecionarCliente.Size = new System.Drawing.Size(80, 25);
            this.BtSelecionarCliente.TabIndex = 19;
            this.BtSelecionarCliente.Text = "Procurar";
            this.BtSelecionarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtSelecionarCliente.UseVisualStyleBackColor = true;
            this.BtSelecionarCliente.Click += new System.EventHandler(this.BtSelecionarCliente_Click);
            // 
            // LbVenda
            // 
            this.LbVenda.AutoSize = true;
            this.LbVenda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbVenda.Location = new System.Drawing.Point(12, 9);
            this.LbVenda.Name = "LbVenda";
            this.LbVenda.Size = new System.Drawing.Size(64, 15);
            this.LbVenda.TabIndex = 20;
            this.LbVenda.Text = "Venda Nº: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cliente:";
            // 
            // BxCliente
            // 
            this.BxCliente.Location = new System.Drawing.Point(625, 6);
            this.BxCliente.Name = "BxCliente";
            this.BxCliente.Size = new System.Drawing.Size(152, 23);
            this.BxCliente.TabIndex = 22;
            // 
            // LbCliente
            // 
            this.LbCliente.AutoSize = true;
            this.LbCliente.Location = new System.Drawing.Point(578, 47);
            this.LbCliente.Name = "LbCliente";
            this.LbCliente.Size = new System.Drawing.Size(109, 15);
            this.LbCliente.TabIndex = 23;
            this.LbCliente.Text = "NOME DO CLIENTE";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Nº";
            this.Numero.Name = "Numero";
            this.Numero.Width = 10;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Cod.";
            this.Cod.Name = "Cod";
            this.Cod.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nº";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nº";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 30;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Cod.";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 40;
            // 
            // DataGridItemVenda
            // 
            this.DataGridItemVenda.AllowUserToAddRows = false;
            this.DataGridItemVenda.AllowUserToDeleteRows = false;
            this.DataGridItemVenda.AllowUserToResizeColumns = false;
            this.DataGridItemVenda.AllowUserToResizeRows = false;
            this.DataGridItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Produto,
            this.Quantidade,
            this.Unidade,
            this.Total});
            this.DataGridItemVenda.Location = new System.Drawing.Point(12, 27);
            this.DataGridItemVenda.MultiSelect = false;
            this.DataGridItemVenda.Name = "DataGridItemVenda";
            this.DataGridItemVenda.ReadOnly = true;
            this.DataGridItemVenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridItemVenda.RowTemplate.Height = 25;
            this.DataGridItemVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridItemVenda.Size = new System.Drawing.Size(489, 485);
            this.DataGridItemVenda.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nº.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cod.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 235;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Qtd.";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 40;
            // 
            // Unidade
            // 
            this.Unidade.HeaderText = "Unidade";
            this.Unidade.Name = "Unidade";
            this.Unidade.ReadOnly = true;
            this.Unidade.Width = 60;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 40;
            // 
            // NovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.DataGridItemVenda);
            this.Controls.Add(this.LbCliente);
            this.Controls.Add(this.BxCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbVenda);
            this.Controls.Add(this.BtSelecionarCliente);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtFinalizar);
            this.Controls.Add(this.BtRemoverCarrinho);
            this.Controls.Add(this.BtAdicionarCarrinho);
            this.Controls.Add(this.LbSubTotal);
            this.Controls.Add(this.LbTotalItem);
            this.Controls.Add(this.BxTotal);
            this.Controls.Add(this.LbPreco);
            this.Controls.Add(this.LbQuantidade);
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
        private System.Windows.Forms.Label LbPreco;
        private System.Windows.Forms.Label LbQuantidade;
        private System.Windows.Forms.Label LbTotalItem;
        private System.Windows.Forms.TextBox BxTotal;
        private System.Windows.Forms.Label LbSubTotal;
        private System.Windows.Forms.Button BtAdicionarCarrinho;
        private System.Windows.Forms.Button BtRemoverCarrinho;
        private System.Windows.Forms.Button BtFinalizar;
        protected internal System.Windows.Forms.TextBox BxPreco;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtSelecionarCliente;
        private System.Windows.Forms.Label LbVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BxCliente;
        private System.Windows.Forms.Label LbCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridView DataGridItemVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}