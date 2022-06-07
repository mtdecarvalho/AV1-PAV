
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.BtVenda = new System.Windows.Forms.Button();
            this.BtEstoque = new System.Windows.Forms.Button();
            this.BtCliente = new System.Windows.Forms.Button();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.BtRemover = new System.Windows.Forms.Button();
            this.BtListar = new System.Windows.Forms.Button();
            this.BtFornecedor = new System.Windows.Forms.Button();
            this.BtFinanceiro = new System.Windows.Forms.Button();
            this.GenericBox = new System.Windows.Forms.GroupBox();
            this.FinanceiroBox = new System.Windows.Forms.GroupBox();
            this.BxContasPagar = new System.Windows.Forms.GroupBox();
            this.BtBaixaPagar = new System.Windows.Forms.Button();
            this.BtRelatorioPagar = new System.Windows.Forms.Button();
            this.BxCaixa = new System.Windows.Forms.GroupBox();
            this.BtVisualizarCaixa = new System.Windows.Forms.Button();
            this.BxContasReceber = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.GenericBox.SuspendLayout();
            this.FinanceiroBox.SuspendLayout();
            this.BxContasPagar.SuspendLayout();
            this.BxCaixa.SuspendLayout();
            this.BxContasReceber.SuspendLayout();
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
            this.BtVenda.Image = ((System.Drawing.Image)(resources.GetObject("BtVenda.Image")));
            this.BtVenda.Location = new System.Drawing.Point(0, 0);
            this.BtVenda.Margin = new System.Windows.Forms.Padding(0);
            this.BtVenda.Name = "BtVenda";
            this.BtVenda.Size = new System.Drawing.Size(150, 150);
            this.BtVenda.TabIndex = 1;
            this.BtVenda.Text = "Vendas";
            this.BtVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtVenda.UseVisualStyleBackColor = true;
            this.BtVenda.Click += new System.EventHandler(this.BtVenda_Click);
            // 
            // BtEstoque
            // 
            this.BtEstoque.Image = ((System.Drawing.Image)(resources.GetObject("BtEstoque.Image")));
            this.BtEstoque.Location = new System.Drawing.Point(0, 250);
            this.BtEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.BtEstoque.Name = "BtEstoque";
            this.BtEstoque.Size = new System.Drawing.Size(150, 100);
            this.BtEstoque.TabIndex = 2;
            this.BtEstoque.Text = "Estoque";
            this.BtEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtEstoque.UseVisualStyleBackColor = true;
            this.BtEstoque.Click += new System.EventHandler(this.BtEstoque_Click);
            // 
            // BtCliente
            // 
            this.BtCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtCliente.Image")));
            this.BtCliente.Location = new System.Drawing.Point(0, 150);
            this.BtCliente.Margin = new System.Windows.Forms.Padding(0);
            this.BtCliente.Name = "BtCliente";
            this.BtCliente.Size = new System.Drawing.Size(150, 100);
            this.BtCliente.TabIndex = 3;
            this.BtCliente.Text = "Clientes";
            this.BtCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtCliente.UseVisualStyleBackColor = true;
            this.BtCliente.Click += new System.EventHandler(this.BtCliente_Click);
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("BtAdicionar.Image")));
            this.BtAdicionar.Location = new System.Drawing.Point(3, 16);
            this.BtAdicionar.Margin = new System.Windows.Forms.Padding(0);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(100, 100);
            this.BtAdicionar.TabIndex = 5;
            this.BtAdicionar.Text = "Adicionar";
            this.BtAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtAdicionar.UseVisualStyleBackColor = true;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // BtRemover
            // 
            this.BtRemover.Image = ((System.Drawing.Image)(resources.GetObject("BtRemover.Image")));
            this.BtRemover.Location = new System.Drawing.Point(103, 16);
            this.BtRemover.Margin = new System.Windows.Forms.Padding(0);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(100, 100);
            this.BtRemover.TabIndex = 6;
            this.BtRemover.Text = "Remover";
            this.BtRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtRemover.UseVisualStyleBackColor = true;
            this.BtRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // BtListar
            // 
            this.BtListar.Image = ((System.Drawing.Image)(resources.GetObject("BtListar.Image")));
            this.BtListar.Location = new System.Drawing.Point(3, 116);
            this.BtListar.Margin = new System.Windows.Forms.Padding(0);
            this.BtListar.Name = "BtListar";
            this.BtListar.Size = new System.Drawing.Size(200, 100);
            this.BtListar.TabIndex = 7;
            this.BtListar.Text = "Listar";
            this.BtListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtListar.UseVisualStyleBackColor = true;
            this.BtListar.Click += new System.EventHandler(this.BtListar_Click);
            // 
            // BtFornecedor
            // 
            this.BtFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("BtFornecedor.Image")));
            this.BtFornecedor.Location = new System.Drawing.Point(0, 350);
            this.BtFornecedor.Margin = new System.Windows.Forms.Padding(0);
            this.BtFornecedor.Name = "BtFornecedor";
            this.BtFornecedor.Size = new System.Drawing.Size(150, 100);
            this.BtFornecedor.TabIndex = 8;
            this.BtFornecedor.Text = "Fornecedores";
            this.BtFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtFornecedor.UseVisualStyleBackColor = true;
            this.BtFornecedor.Click += new System.EventHandler(this.BtFornecedor_Click);
            // 
            // BtFinanceiro
            // 
            this.BtFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("BtFinanceiro.Image")));
            this.BtFinanceiro.Location = new System.Drawing.Point(0, 450);
            this.BtFinanceiro.Margin = new System.Windows.Forms.Padding(0);
            this.BtFinanceiro.Name = "BtFinanceiro";
            this.BtFinanceiro.Size = new System.Drawing.Size(150, 150);
            this.BtFinanceiro.TabIndex = 10;
            this.BtFinanceiro.Text = "Financeiro";
            this.BtFinanceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtFinanceiro.UseVisualStyleBackColor = true;
            this.BtFinanceiro.Click += new System.EventHandler(this.BtContasReceber_Click);
            // 
            // GenericBox
            // 
            this.GenericBox.Controls.Add(this.BtListar);
            this.GenericBox.Controls.Add(this.BtRemover);
            this.GenericBox.Controls.Add(this.BtAdicionar);
            this.GenericBox.Location = new System.Drawing.Point(270, 176);
            this.GenericBox.Name = "GenericBox";
            this.GenericBox.Size = new System.Drawing.Size(206, 218);
            this.GenericBox.TabIndex = 11;
            this.GenericBox.TabStop = false;
            this.GenericBox.Text = "groupBox1";
            // 
            // FinanceiroBox
            // 
            this.FinanceiroBox.Controls.Add(this.BxContasPagar);
            this.FinanceiroBox.Controls.Add(this.BxCaixa);
            this.FinanceiroBox.Controls.Add(this.BxContasReceber);
            this.FinanceiroBox.Location = new System.Drawing.Point(195, 150);
            this.FinanceiroBox.Name = "FinanceiroBox";
            this.FinanceiroBox.Size = new System.Drawing.Size(336, 241);
            this.FinanceiroBox.TabIndex = 8;
            this.FinanceiroBox.TabStop = false;
            this.FinanceiroBox.Text = "Financeiro";
            this.FinanceiroBox.Enter += new System.EventHandler(this.FinanceiroBox_Enter);
            // 
            // BxContasPagar
            // 
            this.BxContasPagar.Controls.Add(this.BtBaixaPagar);
            this.BxContasPagar.Controls.Add(this.BtRelatorioPagar);
            this.BxContasPagar.Location = new System.Drawing.Point(15, 26);
            this.BxContasPagar.Name = "BxContasPagar";
            this.BxContasPagar.Size = new System.Drawing.Size(134, 84);
            this.BxContasPagar.TabIndex = 5;
            this.BxContasPagar.TabStop = false;
            this.BxContasPagar.Text = "Contas a pagar";
            // 
            // BtBaixaPagar
            // 
            this.BtBaixaPagar.Location = new System.Drawing.Point(23, 22);
            this.BtBaixaPagar.Name = "BtBaixaPagar";
            this.BtBaixaPagar.Size = new System.Drawing.Size(75, 23);
            this.BtBaixaPagar.TabIndex = 0;
            this.BtBaixaPagar.Text = "Dar baixa";
            this.BtBaixaPagar.UseVisualStyleBackColor = true;
            this.BtBaixaPagar.Click += new System.EventHandler(this.BtBaixaPagar_Click);
            // 
            // BtRelatorioPagar
            // 
            this.BtRelatorioPagar.Location = new System.Drawing.Point(23, 51);
            this.BtRelatorioPagar.Name = "BtRelatorioPagar";
            this.BtRelatorioPagar.Size = new System.Drawing.Size(75, 23);
            this.BtRelatorioPagar.TabIndex = 1;
            this.BtRelatorioPagar.Text = "Relatorio";
            this.BtRelatorioPagar.UseVisualStyleBackColor = true;
            this.BtRelatorioPagar.Click += new System.EventHandler(this.BtRelatorioPagar_Click);
            // 
            // BxCaixa
            // 
            this.BxCaixa.Controls.Add(this.BtVisualizarCaixa);
            this.BxCaixa.Location = new System.Drawing.Point(15, 125);
            this.BxCaixa.Name = "BxCaixa";
            this.BxCaixa.Size = new System.Drawing.Size(311, 108);
            this.BxCaixa.TabIndex = 6;
            this.BxCaixa.TabStop = false;
            this.BxCaixa.Text = "Caixa";
            // 
            // BtVisualizarCaixa
            // 
            this.BtVisualizarCaixa.Location = new System.Drawing.Point(6, 33);
            this.BtVisualizarCaixa.Name = "BtVisualizarCaixa";
            this.BtVisualizarCaixa.Size = new System.Drawing.Size(107, 23);
            this.BtVisualizarCaixa.TabIndex = 2;
            this.BtVisualizarCaixa.Text = "Visualizar caixa";
            this.BtVisualizarCaixa.UseVisualStyleBackColor = true;
            this.BtVisualizarCaixa.Click += new System.EventHandler(this.BtVisualizarCaixa_Click);
            // 
            // BxContasReceber
            // 
            this.BxContasReceber.Controls.Add(this.button4);
            this.BxContasReceber.Controls.Add(this.button5);
            this.BxContasReceber.Location = new System.Drawing.Point(192, 26);
            this.BxContasReceber.Name = "BxContasReceber";
            this.BxContasReceber.Size = new System.Drawing.Size(134, 84);
            this.BxContasReceber.TabIndex = 6;
            this.BxContasReceber.TabStop = false;
            this.BxContasReceber.Text = "Contas a receber";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Dar baixa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Relatorio";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(584, 601);
            this.Controls.Add(this.FinanceiroBox);
            this.Controls.Add(this.GenericBox);
            this.Controls.Add(this.BtFinanceiro);
            this.Controls.Add(this.BtFornecedor);
            this.Controls.Add(this.BtCliente);
            this.Controls.Add(this.BtEstoque);
            this.Controls.Add(this.BtVenda);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "JanelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV";
            this.GenericBox.ResumeLayout(false);
            this.FinanceiroBox.ResumeLayout(false);
            this.BxContasPagar.ResumeLayout(false);
            this.BxCaixa.ResumeLayout(false);
            this.BxContasReceber.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtVenda;
        private System.Windows.Forms.Button BtEstoque;
        private System.Windows.Forms.Button BtCliente;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.Button BtRemover;
        private System.Windows.Forms.Button BtListar;
        private System.Windows.Forms.Button BtFornecedor;
        private System.Windows.Forms.Button BtFinanceiro;
        private System.Windows.Forms.GroupBox GenericBox;
        private System.Windows.Forms.GroupBox FinanceiroBox;
        private System.Windows.Forms.GroupBox BxContasPagar;
        private System.Windows.Forms.Button BtBaixaPagar;
        private System.Windows.Forms.Button BtRelatorioPagar;
        private System.Windows.Forms.GroupBox BxCaixa;
        private System.Windows.Forms.Button BtVisualizarCaixa;
        private System.Windows.Forms.GroupBox BxContasReceber;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

