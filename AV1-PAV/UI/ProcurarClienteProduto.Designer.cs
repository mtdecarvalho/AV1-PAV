
namespace AV1_PAV.UI
{
    partial class ProcurarClienteProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcurarClienteProduto));
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtSelecionar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome});
            this.DataGrid.Location = new System.Drawing.Point(12, 12);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowTemplate.Height = 25;
            this.DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(203, 336);
            this.DataGrid.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Cod.";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // BtSelecionar
            // 
            this.BtSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("BtSelecionar.Image")));
            this.BtSelecionar.Location = new System.Drawing.Point(222, 12);
            this.BtSelecionar.Name = "BtSelecionar";
            this.BtSelecionar.Size = new System.Drawing.Size(75, 50);
            this.BtSelecionar.TabIndex = 1;
            this.BtSelecionar.Text = "Selecionar";
            this.BtSelecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtSelecionar.UseVisualStyleBackColor = true;
            this.BtSelecionar.Click += new System.EventHandler(this.BtSelecionar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtCancelar.Image")));
            this.BtCancelar.Location = new System.Drawing.Point(222, 68);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 50);
            this.BtCancelar.TabIndex = 2;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // ProcurarClienteProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 361);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSelecionar);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProcurarClienteProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Procurar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button BtSelecionar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}