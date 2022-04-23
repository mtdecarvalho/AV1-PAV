
namespace AV1_PAV.UI
{
    partial class ProcurarProduto
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
            this.DataGridProdutos = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtSelecionar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridProdutos
            // 
            this.DataGridProdutos.AllowUserToAddRows = false;
            this.DataGridProdutos.AllowUserToDeleteRows = false;
            this.DataGridProdutos.AllowUserToResizeColumns = false;
            this.DataGridProdutos.AllowUserToResizeRows = false;
            this.DataGridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Preco});
            this.DataGridProdutos.Location = new System.Drawing.Point(12, 12);
            this.DataGridProdutos.MultiSelect = false;
            this.DataGridProdutos.Name = "DataGridProdutos";
            this.DataGridProdutos.ReadOnly = true;
            this.DataGridProdutos.RowTemplate.Height = 25;
            this.DataGridProdutos.Size = new System.Drawing.Size(244, 336);
            this.DataGridProdutos.TabIndex = 0;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // BtSelecionar
            // 
            this.BtSelecionar.Location = new System.Drawing.Point(262, 12);
            this.BtSelecionar.Name = "BtSelecionar";
            this.BtSelecionar.Size = new System.Drawing.Size(75, 23);
            this.BtSelecionar.TabIndex = 1;
            this.BtSelecionar.Text = "Selecionar";
            this.BtSelecionar.UseVisualStyleBackColor = true;
            this.BtSelecionar.Click += new System.EventHandler(this.BtSelecionar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(262, 41);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 2;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // ProcurarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSelecionar);
            this.Controls.Add(this.DataGridProdutos);
            this.Name = "ProcurarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcurarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.Button BtSelecionar;
        private System.Windows.Forms.Button BtCancelar;
    }
}