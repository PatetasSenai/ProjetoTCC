namespace WindowsFormsApplication1
{
    partial class FormPagCard
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
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnPagaCard = new System.Windows.Forms.Button();
            this.btnCancelCard = new System.Windows.Forms.Button();
            this.comboBandeiraCard = new System.Windows.Forms.ComboBox();
            this.txtValorCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.btnPagaCard);
            this.groupBox1.Controls.Add(this.btnCancelCard);
            this.groupBox1.Controls.Add(this.comboBandeiraCard);
            this.groupBox1.Controls.Add(this.txtValorCard);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagamento Cartão";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(152, 108);
            this.maskedTextBox2.Mask = "000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBox2.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(10, 109);
            this.maskedTextBox1.Mask = "0000.0000.0000.0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // btnPagaCard
            // 
            this.btnPagaCard.Location = new System.Drawing.Point(127, 145);
            this.btnPagaCard.Name = "btnPagaCard";
            this.btnPagaCard.Size = new System.Drawing.Size(75, 23);
            this.btnPagaCard.TabIndex = 10;
            this.btnPagaCard.Text = "Confirmar";
            this.btnPagaCard.UseVisualStyleBackColor = true;
            this.btnPagaCard.Click += new System.EventHandler(this.btnPagaCard_Click);
            // 
            // btnCancelCard
            // 
            this.btnCancelCard.Location = new System.Drawing.Point(46, 145);
            this.btnCancelCard.Name = "btnCancelCard";
            this.btnCancelCard.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCard.TabIndex = 9;
            this.btnCancelCard.Text = "Cancelar";
            this.btnCancelCard.UseVisualStyleBackColor = true;
            this.btnCancelCard.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBandeiraCard
            // 
            this.comboBandeiraCard.FormattingEnabled = true;
            this.comboBandeiraCard.Items.AddRange(new object[] {
            "American Express",
            "Aura",
            "Elo",
            "HiperCard",
            "MasterCard",
            "Sorocred",
            "Visa",
            "Cartão BNDES",
            "Diners Club"});
            this.comboBandeiraCard.Location = new System.Drawing.Point(9, 71);
            this.comboBandeiraCard.Name = "comboBandeiraCard";
            this.comboBandeiraCard.Size = new System.Drawing.Size(121, 21);
            this.comboBandeiraCard.TabIndex = 5;
            // 
            // txtValorCard
            // 
            this.txtValorCard.Location = new System.Drawing.Point(9, 33);
            this.txtValorCard.Name = "txtValorCard";
            this.txtValorCard.Size = new System.Drawing.Size(91, 20);
            this.txtValorCard.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cod de segurança";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nº do Cartão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bandeira";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "-";
            // 
            // FormPagCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 224);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPagCard";
            this.Text = "Pagamento Cartão";
            this.Load += new System.EventHandler(this.FormPagCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBandeiraCard;
        private System.Windows.Forms.Button btnCancelCard;
        private System.Windows.Forms.Button btnPagaCard;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label5;
    }
}