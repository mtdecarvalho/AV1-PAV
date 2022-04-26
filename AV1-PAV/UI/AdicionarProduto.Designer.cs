
namespace AV1_PAV.UI
{
    partial class AdicionarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxQtdEstoque = new System.Windows.Forms.TextBox();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.cbUnidade = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(160, 3);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(180, 23);
            this.tbxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade em estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fornecedor:";
            // 
            // tbxQtdEstoque
            // 
            this.tbxQtdEstoque.Location = new System.Drawing.Point(160, 32);
            this.tbxQtdEstoque.Name = "tbxQtdEstoque";
            this.tbxQtdEstoque.Size = new System.Drawing.Size(180, 23);
            this.tbxQtdEstoque.TabIndex = 6;
            this.tbxQtdEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQtdEstoque_KeyPress);
            // 
            // tbxPreco
            // 
            this.tbxPreco.Location = new System.Drawing.Point(160, 61);
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(180, 23);
            this.tbxPreco.TabIndex = 7;
            this.tbxPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPreco_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(121, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 50);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(202, 169);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 50);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFornecedor);
            this.panel1.Controls.Add(this.cbUnidade);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxPreco);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxQtdEstoque);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 149);
            this.panel1.TabIndex = 12;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(160, 119);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(180, 23);
            this.cbFornecedor.TabIndex = 11;
            // 
            // cbUnidade
            // 
            this.cbUnidade.FormattingEnabled = true;
            this.cbUnidade.Items.AddRange(new object[] {
            "kg",
            "mg",
            "l",
            "ml"});
            this.cbUnidade.Location = new System.Drawing.Point(160, 90);
            this.cbUnidade.Name = "cbUnidade";
            this.cbUnidade.Size = new System.Drawing.Size(53, 23);
            this.cbUnidade.TabIndex = 10;
            // 
            // AdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdicionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxQtdEstoque;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbUnidade;
        private System.Windows.Forms.ComboBox cbFornecedor;
    }
}