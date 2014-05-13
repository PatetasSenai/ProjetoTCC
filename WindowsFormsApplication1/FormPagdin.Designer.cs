namespace WindowsFormsApplication1
{
    partial class FormPagdin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskvltrocodin = new System.Windows.Forms.MaskedTextBox();
            this.maskvlrecdin = new System.Windows.Forms.MaskedTextBox();
            this.maskvltotaldin = new System.Windows.Forms.MaskedTextBox();
            this.btnConcPagdin = new System.Windows.Forms.Button();
            this.btnLimppagdin = new System.Windows.Forms.Button();
            this.btnCancelpagdin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskvltrocodin);
            this.groupBox1.Controls.Add(this.maskvlrecdin);
            this.groupBox1.Controls.Add(this.maskvltotaldin);
            this.groupBox1.Controls.Add(this.btnConcPagdin);
            this.groupBox1.Controls.Add(this.btnLimppagdin);
            this.groupBox1.Controls.Add(this.btnCancelpagdin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento em dinheiro";
            // 
            // maskvltrocodin
            // 
            this.maskvltrocodin.Location = new System.Drawing.Point(6, 117);
            this.maskvltrocodin.Mask = "99.999,99";
            this.maskvltrocodin.Name = "maskvltrocodin";
            this.maskvltrocodin.Size = new System.Drawing.Size(100, 20);
            this.maskvltrocodin.TabIndex = 19;
            // 
            // maskvlrecdin
            // 
            this.maskvlrecdin.Location = new System.Drawing.Point(6, 78);
            this.maskvlrecdin.Mask = "99.999,99";
            this.maskvlrecdin.Name = "maskvlrecdin";
            this.maskvlrecdin.Size = new System.Drawing.Size(100, 20);
            this.maskvlrecdin.TabIndex = 18;
            // 
            // maskvltotaldin
            // 
            this.maskvltotaldin.Location = new System.Drawing.Point(6, 39);
            this.maskvltotaldin.Mask = "99.999,99";
            this.maskvltotaldin.Name = "maskvltotaldin";
            this.maskvltotaldin.Size = new System.Drawing.Size(100, 20);
            this.maskvltotaldin.TabIndex = 17;
            this.maskvltotaldin.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskvltotaldin_MaskInputRejected);
            // 
            // btnConcPagdin
            // 
            this.btnConcPagdin.Location = new System.Drawing.Point(168, 147);
            this.btnConcPagdin.Name = "btnConcPagdin";
            this.btnConcPagdin.Size = new System.Drawing.Size(75, 23);
            this.btnConcPagdin.TabIndex = 15;
            this.btnConcPagdin.Text = "Concluir";
            this.btnConcPagdin.UseVisualStyleBackColor = true;
            // 
            // btnLimppagdin
            // 
            this.btnLimppagdin.Location = new System.Drawing.Point(87, 147);
            this.btnLimppagdin.Name = "btnLimppagdin";
            this.btnLimppagdin.Size = new System.Drawing.Size(75, 23);
            this.btnLimppagdin.TabIndex = 14;
            this.btnLimppagdin.Text = "Limpar";
            this.btnLimppagdin.UseVisualStyleBackColor = true;
            this.btnLimppagdin.Click += new System.EventHandler(this.btnLimppagdin_Click);
            // 
            // btnCancelpagdin
            // 
            this.btnCancelpagdin.Location = new System.Drawing.Point(6, 147);
            this.btnCancelpagdin.Name = "btnCancelpagdin";
            this.btnCancelpagdin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelpagdin.TabIndex = 13;
            this.btnCancelpagdin.Text = "Cancelar";
            this.btnCancelpagdin.UseVisualStyleBackColor = true;
            this.btnCancelpagdin.Click += new System.EventHandler(this.btnCancelpagdin_Click);
<<<<<<< HEAD
            // 
            // txtValorTrocoDin
            // 
            this.txtValorTrocoDin.Location = new System.Drawing.Point(6, 117);
            this.txtValorTrocoDin.Name = "txtValorTrocoDin";
            this.txtValorTrocoDin.Size = new System.Drawing.Size(100, 20);
            this.txtValorTrocoDin.TabIndex = 12;
            // 
            // txtValorDinTotal
            // 
            this.txtValorDinTotal.Location = new System.Drawing.Point(6, 39);
            this.txtValorDinTotal.Name = "txtValorDinTotal";
            this.txtValorDinTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorDinTotal.TabIndex = 10;
            // 
            // txtValorRecDin
            // 
            this.txtValorRecDin.Location = new System.Drawing.Point(6, 78);
            this.txtValorRecDin.Name = "txtValorRecDin";
            this.txtValorRecDin.Size = new System.Drawing.Size(100, 20);
            this.txtValorRecDin.TabIndex = 11;
            this.txtValorRecDin.Leave += new System.EventHandler(this.txtValorRecDin_Leave);
=======
>>>>>>> 89b25ca155ec3f553b567d8841a83098dc3b9737
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor recebido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Troco";
            // 
            // FormPagdin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 197);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPagdin";
            this.Text = "Pagamento em dinheiro";
            this.Load += new System.EventHandler(this.FormPagdin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConcPagdin;
        private System.Windows.Forms.Button btnLimppagdin;
        private System.Windows.Forms.Button btnCancelpagdin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskvltrocodin;
        private System.Windows.Forms.MaskedTextBox maskvlrecdin;
        private System.Windows.Forms.MaskedTextBox maskvltotaldin;

    }
}