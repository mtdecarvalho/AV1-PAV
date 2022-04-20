
namespace AV1_PAV
{
    partial class Form1
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
            this.BtFinanceiro = new System.Windows.Forms.Button();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.BtRemover = new System.Windows.Forms.Button();
            this.BtListar = new System.Windows.Forms.Button();
            this.BtFornecedor = new System.Windows.Forms.Button();
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
            this.BtVenda.Size = new System.Drawing.Size(150, 150);
            this.BtVenda.TabIndex = 1;
            this.BtVenda.Text = "Vendas";
            this.BtVenda.UseVisualStyleBackColor = true;
            // 
            // BtEstoque
            // 
            this.BtEstoque.Location = new System.Drawing.Point(0, 300);
            this.BtEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.BtEstoque.Name = "BtEstoque";
            this.BtEstoque.Size = new System.Drawing.Size(150, 100);
            this.BtEstoque.TabIndex = 2;
            this.BtEstoque.Text = "Estoque";
            this.BtEstoque.UseVisualStyleBackColor = true;
            // 
            // BtCliente
            // 
            this.BtCliente.Location = new System.Drawing.Point(0, 150);
            this.BtCliente.Margin = new System.Windows.Forms.Padding(0);
            this.BtCliente.Name = "BtCliente";
            this.BtCliente.Size = new System.Drawing.Size(150, 150);
            this.BtCliente.TabIndex = 3;
            this.BtCliente.Text = "Clientes";
            this.BtCliente.UseVisualStyleBackColor = true;
            // 
            // BtFinanceiro
            // 
            this.BtFinanceiro.Location = new System.Drawing.Point(0, 500);
            this.BtFinanceiro.Margin = new System.Windows.Forms.Padding(0);
            this.BtFinanceiro.Name = "BtFinanceiro";
            this.BtFinanceiro.Size = new System.Drawing.Size(150, 100);
            this.BtFinanceiro.TabIndex = 4;
            this.BtFinanceiro.Text = "Financeiro";
            this.BtFinanceiro.UseVisualStyleBackColor = true;
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
            this.BtFornecedor.Location = new System.Drawing.Point(0, 400);
            this.BtFornecedor.Margin = new System.Windows.Forms.Padding(0);
            this.BtFornecedor.Name = "BtFornecedor";
            this.BtFornecedor.Size = new System.Drawing.Size(150, 100);
            this.BtFornecedor.TabIndex = 8;
            this.BtFornecedor.Text = "Fornecedores";
            this.BtFornecedor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(584, 601);
            this.Controls.Add(this.BtFornecedor);
            this.Controls.Add(this.BtListar);
            this.Controls.Add(this.BtRemover);
            this.Controls.Add(this.BtAdicionar);
            this.Controls.Add(this.BtFinanceiro);
            this.Controls.Add(this.BtCliente);
            this.Controls.Add(this.BtEstoque);
            this.Controls.Add(this.BtVenda);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtVenda;
        private System.Windows.Forms.Button BtEstoque;
        private System.Windows.Forms.Button BtCliente;
        private System.Windows.Forms.Button BtFinanceiro;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.Button BtRemover;
        private System.Windows.Forms.Button BtListar;
        private System.Windows.Forms.Button BtFornecedor;
    }
}

