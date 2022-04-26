
namespace AV1_PAV.UI
{
    partial class ListarRemoverVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarRemoverVenda));
            this.GridLista = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.Filtro = new System.Windows.Forms.GroupBox();
            this.RbSituacao = new System.Windows.Forms.RadioButton();
            this.RbData = new System.Windows.Forms.RadioButton();
            this.BxPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).BeginInit();
            this.Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridLista
            // 
            this.GridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Data,
            this.Hora,
            this.Cliente,
            this.Total,
            this.Situacao});
            this.GridLista.Location = new System.Drawing.Point(12, 43);
            this.GridLista.Name = "GridLista";
            this.GridLista.RowTemplate.Height = 25;
            this.GridLista.Size = new System.Drawing.Size(644, 461);
            this.GridLista.TabIndex = 0;
            this.GridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(25, 25);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // Filtro
            // 
            this.Filtro.Controls.Add(this.RbSituacao);
            this.Filtro.Controls.Add(this.RbData);
            this.Filtro.Location = new System.Drawing.Point(12, 510);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(117, 70);
            this.Filtro.TabIndex = 9;
            this.Filtro.TabStop = false;
            this.Filtro.Text = "Filtrar por:";
            // 
            // RbSituacao
            // 
            this.RbSituacao.AutoSize = true;
            this.RbSituacao.Location = new System.Drawing.Point(6, 47);
            this.RbSituacao.Name = "RbSituacao";
            this.RbSituacao.Size = new System.Drawing.Size(70, 19);
            this.RbSituacao.TabIndex = 2;
            this.RbSituacao.TabStop = true;
            this.RbSituacao.Text = "Situação";
            this.RbSituacao.UseVisualStyleBackColor = true;
            // 
            // RbData
            // 
            this.RbData.AutoSize = true;
            this.RbData.Location = new System.Drawing.Point(6, 22);
            this.RbData.Name = "RbData";
            this.RbData.Size = new System.Drawing.Size(49, 19);
            this.RbData.TabIndex = 0;
            this.RbData.TabStop = true;
            this.RbData.Text = "Data";
            this.RbData.UseVisualStyleBackColor = true;
            // 
            // BxPesquisa
            // 
            this.BxPesquisa.Location = new System.Drawing.Point(135, 557);
            this.BxPesquisa.Name = "BxPesquisa";
            this.BxPesquisa.Size = new System.Drawing.Size(335, 23);
            this.BxPesquisa.TabIndex = 10;
            this.BxPesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ListarRemoverVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 596);
            this.Controls.Add(this.BxPesquisa);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.GridLista);
            this.Name = "ListarRemoverVenda";
            this.Text = "ListaRemoverVenda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListarRemoverVenda_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GridLista)).EndInit();
            this.Filtro.ResumeLayout(false);
            this.Filtro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridLista;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.GroupBox Filtro;
        private System.Windows.Forms.RadioButton RbSituacao;
        private System.Windows.Forms.RadioButton RbData;
        private System.Windows.Forms.TextBox BxPesquisa;
    }
}