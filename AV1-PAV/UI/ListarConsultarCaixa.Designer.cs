
namespace AV1_PAV.UI
{
    partial class ListarConsultarCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarConsultarCaixa));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataGridCaixa = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaixa)).BeginInit();
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
            // dataGridCaixa
            // 
            this.dataGridCaixa.AllowUserToAddRows = false;
            this.dataGridCaixa.AllowUserToDeleteRows = false;
            this.dataGridCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FormaPagamento,
            this.Saldo});
            this.dataGridCaixa.Location = new System.Drawing.Point(12, 43);
            this.dataGridCaixa.MultiSelect = false;
            this.dataGridCaixa.Name = "dataGridCaixa";
            this.dataGridCaixa.ReadOnly = true;
            this.dataGridCaixa.RowHeadersVisible = false;
            this.dataGridCaixa.RowTemplate.Height = 25;
            this.dataGridCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCaixa.Size = new System.Drawing.Size(600, 330);
            this.dataGridCaixa.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.HeaderText = "Forma de Pagamento";
            this.FormaPagamento.Name = "FormaPagamento";
            this.FormaPagamento.ReadOnly = true;
            this.FormaPagamento.Width = 480;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 120;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(237, 379);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(150, 50);
            this.btn.TabIndex = 3;
            this.btn.Text = "Gerar relatório de fechamento de caixa";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // ListarConsultarCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dataGridCaixa);
            this.Controls.Add(this.btnVoltar);
            this.Name = "ListarConsultarCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Button btn;
    }
}