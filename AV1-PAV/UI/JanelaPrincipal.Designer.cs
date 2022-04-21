
namespace AV1_PAV
{
    partial class JanelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.BtVenda = new System.Windows.Forms.Button();
            this.BtEstoque = new System.Windows.Forms.Button();
            this.BtCliente = new System.Windows.Forms.Button();
            this.BtContasPagar = new System.Windows.Forms.Button();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.BtRemover = new System.Windows.Forms.Button();
            this.BtListar = new System.Windows.Forms.Button();
            this.BtFornecedor = new System.Windows.Forms.Button();
            this.LbFuncao = new System.Windows.Forms.Label();
            this.BtContasReceber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Testar conexão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtVenda
            // 
            this.BtVenda.Location = new System.Drawing.Point(0, 0);
            this.BtVenda.Margin = new System.Windows.Forms.Padding(0);
            this.BtVenda.Name = "BtVenda";
            this.BtVenda.Size = new System.Drawing.Size(150, 100);
            this.BtVenda.TabIndex = 1;
            this.BtVenda.Text = "Vendas";
            this.BtVenda.UseVisualStyleBackColor = true;
            // 
            // BtEstoque
            // 
            this.BtEstoque.Location = new System.Drawing.Point(0, 200);
            this.BtEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.BtEstoque.Name = "BtEstoque";
            this.BtEstoque.Size = new System.Drawing.Size(150, 100);
            this.BtEstoque.TabIndex = 2;
            this.BtEstoque.Text = "Estoque";
            this.BtEstoque.UseVisualStyleBackColor = true;
            this.BtEstoque.Click += new System.EventHandler(this.BtEstoque_Click);
            // 
            // BtCliente
            // 
            this.BtCliente.Location = new System.Drawing.Point(0, 100);
            this.BtCliente.Margin = new System.Windows.Forms.Padding(0);
            this.BtCliente.Name = "BtCliente";
            this.BtCliente.Size = new System.Drawing.Size(150, 100);
            this.BtCliente.TabIndex = 3;
            this.BtCliente.Text = "Clientes";
            this.BtCliente.UseVisualStyleBackColor = true;
            // 
            // BtContasPagar
            // 
            this.BtContasPagar.Location = new System.Drawing.Point(0, 400);
            this.BtContasPagar.Margin = new System.Windows.Forms.Padding(0);
            this.BtContasPagar.Name = "BtContasPagar";
            this.BtContasPagar.Size = new System.Drawing.Size(150, 100);
            this.BtContasPagar.TabIndex = 4;
            this.BtContasPagar.Text = "Contas Pagar";
            this.BtContasPagar.UseVisualStyleBackColor = true;
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Location = new System.Drawing.Point(275, 200);
            this.BtAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(100, 100);
            this.BtAdicionar.TabIndex = 5;
            this.BtAdicionar.Text = "Adicionar";
            this.BtAdicionar.UseVisualStyleBackColor = true;
            // 
            // BtRemover
            // 
            this.BtRemover.Location = new System.Drawing.Point(375, 200);
            this.BtRemover.Margin = new System.Windows.Forms.Padding(0);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(100, 100);
            this.BtRemover.TabIndex = 6;
            this.BtRemover.Text = "Remover";
            this.BtRemover.UseVisualStyleBackColor = true;
            // 
            // BtListar
            // 
            this.BtListar.Location = new System.Drawing.Point(275, 300);
            this.BtListar.Margin = new System.Windows.Forms.Padding(0);
            this.BtListar.Name = "BtListar";
            this.BtListar.Size = new System.Drawing.Size(200, 100);
            this.BtListar.TabIndex = 7;
            this.BtListar.Text = "Listar";
            this.BtListar.UseVisualStyleBackColor = true;
            // 
            // BtFornecedor
            // 
            this.BtFornecedor.Location = new System.Drawing.Point(0, 300);
            this.BtFornecedor.Margin = new System.Windows.Forms.Padding(0);
            this.BtFornecedor.Name = "BtFornecedor";
            this.BtFornecedor.Size = new System.Drawing.Size(150, 100);
            this.BtFornecedor.TabIndex = 8;
            this.BtFornecedor.Text = "Fornecedores";
            this.BtFornecedor.UseVisualStyleBackColor = true;
            // 
            // LbFuncao
            // 
            this.LbFuncao.AutoSize = true;
            this.LbFuncao.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFuncao.Location = new System.Drawing.Point(300, 50);
            this.LbFuncao.Name = "LbFuncao";
            this.LbFuncao.Size = new System.Drawing.Size(125, 37);
            this.LbFuncao.TabIndex = 9;
            this.LbFuncao.Text = "Função X";
            // 
            // BtContasReceber
            // 
            this.BtContasReceber.Location = new System.Drawing.Point(0, 500);
            this.BtContasReceber.Margin = new System.Windows.Forms.Padding(0);
            this.BtContasReceber.Name = "BtContasReceber";
            this.BtContasReceber.Size = new System.Drawing.Size(150, 100);
            this.BtContasReceber.TabIndex = 10;
            this.BtContasReceber.Text = "Contas Receber";
            this.BtContasReceber.UseVisualStyleBackColor = true;
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(584, 601);
            this.Controls.Add(this.BtContasReceber);
            this.Controls.Add(this.LbFuncao);
            this.Controls.Add(this.BtFornecedor);
            this.Controls.Add(this.BtListar);
            this.Controls.Add(this.BtRemover);
            this.Controls.Add(this.BtAdicionar);
            this.Controls.Add(this.BtContasPagar);
            this.Controls.Add(this.BtCliente);
            this.Controls.Add(this.BtEstoque);
            this.Controls.Add(this.BtVenda);
            this.Controls.Add(this.button1);
            this.Name = "JanelaPrincipal";
            this.Text = "PDV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtVenda;
        private System.Windows.Forms.Button BtEstoque;
        private System.Windows.Forms.Button BtCliente;
        private System.Windows.Forms.Button BtContasPagar;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.Button BtRemover;
        private System.Windows.Forms.Button BtListar;
        private System.Windows.Forms.Button BtFornecedor;
        private System.Windows.Forms.Label LbFuncao;
        private System.Windows.Forms.Button BtContasReceber;
    }
}

