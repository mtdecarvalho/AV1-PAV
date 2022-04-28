
namespace AV1_PAV.UI
{
    partial class ListarConsultarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarConsultarProduto));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.tbxFornecedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxUnidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEstoque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBusca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(25, 25);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(505, 371);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.tbxFornecedor);
            this.grpConsulta.Controls.Add(this.label5);
            this.grpConsulta.Controls.Add(this.tbxUnidade);
            this.grpConsulta.Controls.Add(this.label4);
            this.grpConsulta.Controls.Add(this.tbxEstoque);
            this.grpConsulta.Controls.Add(this.label2);
            this.grpConsulta.Controls.Add(this.tbxPreco);
            this.grpConsulta.Controls.Add(this.label3);
            this.grpConsulta.Controls.Add(this.tbxNome);
            this.grpConsulta.Controls.Add(this.label1);
            this.grpConsulta.Location = new System.Drawing.Point(2, 449);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(527, 100);
            this.grpConsulta.TabIndex = 5;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta";
            // 
            // tbxFornecedor
            // 
            this.tbxFornecedor.Location = new System.Drawing.Point(355, 17);
            this.tbxFornecedor.Name = "tbxFornecedor";
            this.tbxFornecedor.ReadOnly = true;
            this.tbxFornecedor.Size = new System.Drawing.Size(159, 23);
            this.tbxFornecedor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fornecedor:";
            // 
            // tbxUnidade
            // 
            this.tbxUnidade.Location = new System.Drawing.Point(226, 62);
            this.tbxUnidade.Name = "tbxUnidade";
            this.tbxUnidade.ReadOnly = true;
            this.tbxUnidade.Size = new System.Drawing.Size(50, 23);
            this.tbxUnidade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unidade:";
            // 
            // tbxEstoque
            // 
            this.tbxEstoque.Location = new System.Drawing.Point(453, 62);
            this.tbxEstoque.Name = "tbxEstoque";
            this.tbxEstoque.ReadOnly = true;
            this.tbxEstoque.Size = new System.Drawing.Size(50, 23);
            this.tbxEstoque.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade em estoque:";
            // 
            // tbxPreco
            // 
            this.tbxPreco.Location = new System.Drawing.Point(61, 62);
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.ReadOnly = true;
            this.tbxPreco.Size = new System.Drawing.Size(50, 23);
            this.tbxPreco.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(61, 17);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.ReadOnly = true;
            this.tbxNome.Size = new System.Drawing.Size(159, 23);
            this.tbxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tbxBusca
            // 
            this.tbxBusca.Location = new System.Drawing.Point(148, 420);
            this.tbxBusca.Name = "tbxBusca";
            this.tbxBusca.Size = new System.Drawing.Size(211, 23);
            this.tbxBusca.TabIndex = 6;
            this.tbxBusca.TextChanged += new System.EventHandler(this.tbxBusca_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(365, 418);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 25);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ListarConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 561);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxBusca);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ListarConsultarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listar produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEstoque;
        private System.Windows.Forms.TextBox tbxUnidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxBusca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultar;
    }
}