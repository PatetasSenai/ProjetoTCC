namespace WindowsFormsApplication1
{
    partial class FormCadMesa
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label descricaoLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalvarMesa = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(116, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "id:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(116, 63);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(56, 13);
            descricaoLabel.TabIndex = 9;
            descricaoLabel.Text = "descricao:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalvarMesa
            // 
            this.btnSalvarMesa.Location = new System.Drawing.Point(89, 124);
            this.btnSalvarMesa.Name = "btnSalvarMesa";
            this.btnSalvarMesa.Size = new System.Drawing.Size(110, 33);
            this.btnSalvarMesa.TabIndex = 11;
            this.btnSalvarMesa.Text = "Salvar";
            this.btnSalvarMesa.UseVisualStyleBackColor = true;
            this.btnSalvarMesa.Click += new System.EventHandler(this.btnSalvarMesa_Click_1);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(178, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 13;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(178, 63);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 14;
            // 
            // FormCadMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 221);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSalvarMesa);
            this.Controls.Add(idLabel);
            this.Controls.Add(descricaoLabel);
            this.Name = "FormCadMesa";
            this.Text = "FormCadMesa";
            this.Load += new System.EventHandler(this.FormCadMesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalvarMesa;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
    }
}