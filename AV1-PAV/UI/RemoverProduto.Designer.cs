
namespace AV1_PAV.UI
{
    partial class RemoverProduto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxBusca = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.nomeProduto,
            this.qtdEstoque,
            this.preco,
            this.unidade,
            this.idFornecedor});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(643, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "ID";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            // 
            // nomeProduto
            // 
            this.nomeProduto.HeaderText = "Nome";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            // 
            // qtdEstoque
            // 
            this.qtdEstoque.HeaderText = "Quantidade em Estoque";
            this.qtdEstoque.Name = "qtdEstoque";
            this.qtdEstoque.ReadOnly = true;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            // 
            // unidade
            // 
            this.unidade.HeaderText = "Unidade";
            this.unidade.Name = "unidade";
            this.unidade.ReadOnly = true;
            // 
            // idFornecedor
            // 
            this.idFornecedor.HeaderText = "Fornecedor";
            this.idFornecedor.Name = "idFornecedor";
            this.idFornecedor.ReadOnly = true;
            // 
            // tbxBusca
            // 
            this.tbxBusca.Location = new System.Drawing.Point(696, 23);
            this.tbxBusca.Name = "tbxBusca";
            this.tbxBusca.Size = new System.Drawing.Size(140, 23);
            this.tbxBusca.TabIndex = 1;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(852, 22);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Procurar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(696, 78);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // RemoverProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 452);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.tbxBusca);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RemoverProduto";
            this.Text = "RemoverProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedor;
        private System.Windows.Forms.TextBox tbxBusca;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnRemover;
    }
}