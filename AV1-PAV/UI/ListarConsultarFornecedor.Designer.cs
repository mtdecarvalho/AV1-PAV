
namespace AV1_PAV.UI
{
    partial class ListarConsultarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarConsultarFornecedor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBusca = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxTelefone = new System.Windows.Forms.TextBox();
            this.tbxCEP = new System.Windows.Forms.TextBox();
            this.tbxEstado = new System.Windows.Forms.TextBox();
            this.tbxCidade = new System.Windows.Forms.TextBox();
            this.tbxBairro = new System.Windows.Forms.TextBox();
            this.tbxComplemento = new System.Windows.Forms.TextBox();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.tbxLogradouro = new System.Windows.Forms.TextBox();
            this.tbxCNPJ = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 294);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(25, 25);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // tbxBusca
            // 
            this.tbxBusca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBusca.Location = new System.Drawing.Point(255, 343);
            this.tbxBusca.Name = "tbxBusca";
            this.tbxBusca.Size = new System.Drawing.Size(334, 25);
            this.tbxBusca.TabIndex = 8;
            this.tbxBusca.TextChanged += new System.EventHandler(this.tbxBusca_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(595, 343);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 25);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.tbxTelefone);
            this.groupBox1.Controls.Add(this.tbxCEP);
            this.groupBox1.Controls.Add(this.tbxEstado);
            this.groupBox1.Controls.Add(this.tbxCidade);
            this.groupBox1.Controls.Add(this.tbxBairro);
            this.groupBox1.Controls.Add(this.tbxComplemento);
            this.groupBox1.Controls.Add(this.tbxNumero);
            this.groupBox1.Controls.Add(this.tbxLogradouro);
            this.groupBox1.Controls.Add(this.tbxCNPJ);
            this.groupBox1.Controls.Add(this.tbxNome);
            this.groupBox1.Location = new System.Drawing.Point(13, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(454, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(439, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "CEP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bairro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Complemento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Logradouro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "CNPJ:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(50, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(499, 132);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(355, 23);
            this.tbxEmail.TabIndex = 10;
            // 
            // tbxTelefone
            // 
            this.tbxTelefone.Location = new System.Drawing.Point(499, 103);
            this.tbxTelefone.Name = "tbxTelefone";
            this.tbxTelefone.ReadOnly = true;
            this.tbxTelefone.Size = new System.Drawing.Size(355, 23);
            this.tbxTelefone.TabIndex = 9;
            // 
            // tbxCEP
            // 
            this.tbxCEP.Location = new System.Drawing.Point(584, 74);
            this.tbxCEP.Name = "tbxCEP";
            this.tbxCEP.ReadOnly = true;
            this.tbxCEP.Size = new System.Drawing.Size(270, 23);
            this.tbxCEP.TabIndex = 8;
            // 
            // tbxEstado
            // 
            this.tbxEstado.Location = new System.Drawing.Point(499, 74);
            this.tbxEstado.Name = "tbxEstado";
            this.tbxEstado.ReadOnly = true;
            this.tbxEstado.Size = new System.Drawing.Size(42, 23);
            this.tbxEstado.TabIndex = 7;
            // 
            // tbxCidade
            // 
            this.tbxCidade.Location = new System.Drawing.Point(499, 45);
            this.tbxCidade.Name = "tbxCidade";
            this.tbxCidade.ReadOnly = true;
            this.tbxCidade.Size = new System.Drawing.Size(355, 23);
            this.tbxCidade.TabIndex = 6;
            // 
            // tbxBairro
            // 
            this.tbxBairro.Location = new System.Drawing.Point(499, 16);
            this.tbxBairro.Name = "tbxBairro";
            this.tbxBairro.ReadOnly = true;
            this.tbxBairro.Size = new System.Drawing.Size(355, 23);
            this.tbxBairro.TabIndex = 5;
            // 
            // tbxComplemento
            // 
            this.tbxComplemento.Location = new System.Drawing.Point(99, 132);
            this.tbxComplemento.Name = "tbxComplemento";
            this.tbxComplemento.ReadOnly = true;
            this.tbxComplemento.Size = new System.Drawing.Size(334, 23);
            this.tbxComplemento.TabIndex = 4;
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(99, 103);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.ReadOnly = true;
            this.tbxNumero.Size = new System.Drawing.Size(334, 23);
            this.tbxNumero.TabIndex = 3;
            // 
            // tbxLogradouro
            // 
            this.tbxLogradouro.Location = new System.Drawing.Point(99, 74);
            this.tbxLogradouro.Name = "tbxLogradouro";
            this.tbxLogradouro.ReadOnly = true;
            this.tbxLogradouro.Size = new System.Drawing.Size(334, 23);
            this.tbxLogradouro.TabIndex = 2;
            // 
            // tbxCNPJ
            // 
            this.tbxCNPJ.Location = new System.Drawing.Point(99, 45);
            this.tbxCNPJ.Name = "tbxCNPJ";
            this.tbxCNPJ.ReadOnly = true;
            this.tbxCNPJ.Size = new System.Drawing.Size(334, 23);
            this.tbxCNPJ.TabIndex = 1;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(99, 16);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.ReadOnly = true;
            this.tbxNome.Size = new System.Drawing.Size(334, 23);
            this.tbxNome.TabIndex = 0;
            // 
            // ListarConsultarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxBusca);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListarConsultarFornecedor";
            this.Text = "ListarConsultarFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBusca;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxTelefone;
        private System.Windows.Forms.TextBox tbxCEP;
        private System.Windows.Forms.TextBox tbxEstado;
        private System.Windows.Forms.TextBox tbxCidade;
        private System.Windows.Forms.TextBox tbxBairro;
        private System.Windows.Forms.TextBox tbxComplemento;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.TextBox tbxCNPJ;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxLogradouro;
    }
}