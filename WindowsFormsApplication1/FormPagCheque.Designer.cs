namespace WindowsFormsApplication1
{
    partial class FormPagCheque
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
            this.btnConfirmaPagCheque = new System.Windows.Forms.Button();
            this.btnCancelCheque = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataPagCheque = new System.Windows.Forms.TextBox();
            this.txtValidaCpf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeClientCheque = new System.Windows.Forms.TextBox();
            this.txtNumCheque = new System.Windows.Forms.TextBox();
            this.comboBancoCheque = new System.Windows.Forms.ComboBox();
            this.txtValorCheque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirmaPagCheque);
            this.groupBox1.Controls.Add(this.btnCancelCheque);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDataPagCheque);
            this.groupBox1.Controls.Add(this.txtValidaCpf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTelCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNomeClientCheque);
            this.groupBox1.Controls.Add(this.txtNumCheque);
            this.groupBox1.Controls.Add(this.comboBancoCheque);
            this.groupBox1.Controls.Add(this.txtValorCheque);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento em Cheque";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConfirmaPagCheque
            // 
            this.btnConfirmaPagCheque.Location = new System.Drawing.Point(91, 264);
            this.btnConfirmaPagCheque.Name = "btnConfirmaPagCheque";
            this.btnConfirmaPagCheque.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmaPagCheque.TabIndex = 18;
            this.btnConfirmaPagCheque.Text = "Confirmar";
            this.btnConfirmaPagCheque.UseVisualStyleBackColor = true;
            // 
            // btnCancelCheque
            // 
            this.btnCancelCheque.Location = new System.Drawing.Point(10, 264);
            this.btnCancelCheque.Name = "btnCancelCheque";
            this.btnCancelCheque.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCheque.TabIndex = 17;
            this.btnCancelCheque.Text = "Cancelar";
            this.btnCancelCheque.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome ";
            // 
            // txtDataPagCheque
            // 
            this.txtDataPagCheque.Location = new System.Drawing.Point(146, 33);
            this.txtDataPagCheque.Name = "txtDataPagCheque";
            this.txtDataPagCheque.Size = new System.Drawing.Size(90, 20);
            this.txtDataPagCheque.TabIndex = 15;
            // 
            // txtValidaCpf
            // 
            this.txtValidaCpf.Location = new System.Drawing.Point(10, 227);
            this.txtValidaCpf.Name = "txtValidaCpf";
            this.txtValidaCpf.Size = new System.Drawing.Size(191, 20);
            this.txtValidaCpf.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Verifica CPF";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Location = new System.Drawing.Point(9, 187);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(121, 20);
            this.txtTelCliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone de Contato";
            // 
            // txtNomeClientCheque
            // 
            this.txtNomeClientCheque.Location = new System.Drawing.Point(10, 148);
            this.txtNomeClientCheque.Name = "txtNomeClientCheque";
            this.txtNomeClientCheque.Size = new System.Drawing.Size(191, 20);
            this.txtNomeClientCheque.TabIndex = 7;
            // 
            // txtNumCheque
            // 
            this.txtNumCheque.Location = new System.Drawing.Point(10, 109);
            this.txtNumCheque.Name = "txtNumCheque";
            this.txtNumCheque.Size = new System.Drawing.Size(191, 20);
            this.txtNumCheque.TabIndex = 6;
            // 
            // comboBancoCheque
            // 
            this.comboBancoCheque.FormattingEnabled = true;
            this.comboBancoCheque.Location = new System.Drawing.Point(9, 71);
            this.comboBancoCheque.Name = "comboBancoCheque";
            this.comboBancoCheque.Size = new System.Drawing.Size(121, 21);
            this.comboBancoCheque.TabIndex = 5;
            // 
            // txtValorCheque
            // 
            this.txtValorCheque.Location = new System.Drawing.Point(9, 33);
            this.txtValorCheque.Name = "txtValorCheque";
            this.txtValorCheque.Size = new System.Drawing.Size(91, 20);
            this.txtValorCheque.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data do Pagamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº do Cheque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banco";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // FormPagCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 325);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPagCheque";
            this.Text = "Pagamento em Cheque";
            this.Load += new System.EventHandler(this.FormPagCheque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeClientCheque;
        private System.Windows.Forms.TextBox txtNumCheque;
        private System.Windows.Forms.ComboBox comboBancoCheque;
        private System.Windows.Forms.TextBox txtValorCheque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValidaCpf;
        private System.Windows.Forms.TextBox txtDataPagCheque;
        private System.Windows.Forms.Button btnCancelCheque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConfirmaPagCheque;
    }
}