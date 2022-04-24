
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEstoque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(25, 25);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(605, 340);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(272, 389);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(86, 25);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.textBox2);
            this.grpConsulta.Controls.Add(this.label5);
            this.grpConsulta.Controls.Add(this.textBox1);
            this.grpConsulta.Controls.Add(this.label4);
            this.grpConsulta.Controls.Add(this.tbxEstoque);
            this.grpConsulta.Controls.Add(this.label2);
            this.grpConsulta.Controls.Add(this.tbxPreco);
            this.grpConsulta.Controls.Add(this.label3);
            this.grpConsulta.Controls.Add(this.tbxNome);
            this.grpConsulta.Controls.Add(this.label1);
            this.grpConsulta.Location = new System.Drawing.Point(25, 425);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(593, 100);
            this.grpConsulta.TabIndex = 5;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = "Consulta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(159, 23);
            this.textBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fornecedor:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(50, 23);
            this.textBox1.TabIndex = 7;
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
            // ListarConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 561);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoltar);
            this.Name = "ListarConsultarProduto";
            this.Text = "ListarConsultarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEstoque;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}