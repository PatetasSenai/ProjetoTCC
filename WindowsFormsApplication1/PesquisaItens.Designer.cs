namespace WindowsFormsApplication1
{
    partial class PesquisaItens
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
            this.gridItensBusca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridItensBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // gridItensBusca
            // 
            this.gridItensBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItensBusca.Location = new System.Drawing.Point(12, 12);
            this.gridItensBusca.Name = "gridItensBusca";
            this.gridItensBusca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItensBusca.Size = new System.Drawing.Size(566, 237);
            this.gridItensBusca.TabIndex = 0;
            this.gridItensBusca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItensBusca_CellClick);
            this.gridItensBusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PesquisaItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this.gridItensBusca);
            this.Name = "PesquisaItens";
            this.Text = "Pesquisa de Itens";
            this.Load += new System.EventHandler(this.PesquisaItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItensBusca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridItensBusca;
    }
}