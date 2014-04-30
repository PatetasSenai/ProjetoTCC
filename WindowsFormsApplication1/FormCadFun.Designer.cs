namespace WindowsFormsApplication1
{
    partial class FormCadFun
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label ocupacaoLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label datacadastroLabel;
            System.Windows.Forms.Label ativoLabel;
            this.btnCancelarFun = new System.Windows.Forms.Button();
            this.btnSalvarFun = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.datacadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.cbOcupacao = new System.Windows.Forms.ComboBox();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            ocupacaoLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            datacadastroLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(67, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 23;
            idLabel.Text = "id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(67, 67);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 25;
            nomeLabel.Text = "nome:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(67, 93);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 27;
            enderecoLabel.Text = "endereco:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(67, 119);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(48, 13);
            telefoneLabel.TabIndex = 29;
            telefoneLabel.Text = "telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(67, 145);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(41, 13);
            celularLabel.TabIndex = 31;
            celularLabel.Text = "celular:";
            // 
            // ocupacaoLabel
            // 
            ocupacaoLabel.AutoSize = true;
            ocupacaoLabel.Location = new System.Drawing.Point(67, 171);
            ocupacaoLabel.Name = "ocupacaoLabel";
            ocupacaoLabel.Size = new System.Drawing.Size(58, 13);
            ocupacaoLabel.TabIndex = 33;
            ocupacaoLabel.Text = "ocupacao:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(67, 197);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(32, 13);
            loginLabel.TabIndex = 35;
            loginLabel.Text = "login:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(67, 223);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(39, 13);
            senhaLabel.TabIndex = 37;
            senhaLabel.Text = "senha:";
            // 
            // datacadastroLabel
            // 
            datacadastroLabel.AutoSize = true;
            datacadastroLabel.Location = new System.Drawing.Point(67, 250);
            datacadastroLabel.Name = "datacadastroLabel";
            datacadastroLabel.Size = new System.Drawing.Size(72, 13);
            datacadastroLabel.TabIndex = 39;
            datacadastroLabel.Text = "datacadastro:";
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(67, 277);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(33, 13);
            ativoLabel.TabIndex = 41;
            ativoLabel.Text = "ativo:";
            // 
            // btnCancelarFun
            // 
            this.btnCancelarFun.Location = new System.Drawing.Point(238, 337);
            this.btnCancelarFun.Name = "btnCancelarFun";
            this.btnCancelarFun.Size = new System.Drawing.Size(107, 41);
            this.btnCancelarFun.TabIndex = 44;
            this.btnCancelarFun.Text = "Cancelar";
            this.btnCancelarFun.UseVisualStyleBackColor = true;
            this.btnCancelarFun.Click += new System.EventHandler(this.btnCancelarFun_Click);
            // 
            // btnSalvarFun
            // 
            this.btnSalvarFun.Location = new System.Drawing.Point(70, 337);
            this.btnSalvarFun.Name = "btnSalvarFun";
            this.btnSalvarFun.Size = new System.Drawing.Size(107, 41);
            this.btnSalvarFun.TabIndex = 43;
            this.btnSalvarFun.Text = "Salvar";
            this.btnSalvarFun.UseVisualStyleBackColor = true;
            this.btnSalvarFun.Click += new System.EventHandler(this.btnSalvarFun_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(145, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 24;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(145, 64);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 26;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(145, 90);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(200, 20);
            this.enderecoTextBox.TabIndex = 28;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(145, 194);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(200, 20);
            this.loginTextBox.TabIndex = 36;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(145, 220);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(200, 20);
            this.senhaTextBox.TabIndex = 38;
            // 
            // datacadastroDateTimePicker
            // 
            this.datacadastroDateTimePicker.Location = new System.Drawing.Point(145, 246);
            this.datacadastroDateTimePicker.Name = "datacadastroDateTimePicker";
            this.datacadastroDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datacadastroDateTimePicker.TabIndex = 40;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.Location = new System.Drawing.Point(145, 272);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.ativoCheckBox.TabIndex = 42;
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(145, 117);
            this.mskTel.Mask = "(99) 0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(200, 20);
            this.mskTel.TabIndex = 45;
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(145, 142);
            this.mskCel.Mask = "(99) 00000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(200, 20);
            this.mskCel.TabIndex = 46;
            // 
            // cbOcupacao
            // 
            this.cbOcupacao.FormattingEnabled = true;
            this.cbOcupacao.Items.AddRange(new object[] {
            "",
            "Cosinheiro",
            "Administrador",
            "Caixa"});
            this.cbOcupacao.Location = new System.Drawing.Point(145, 167);
            this.cbOcupacao.Name = "cbOcupacao";
            this.cbOcupacao.Size = new System.Drawing.Size(200, 21);
            this.cbOcupacao.TabIndex = 47;
            // 
            // FormCadFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 435);
            this.Controls.Add(this.cbOcupacao);
            this.Controls.Add(this.mskCel);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.btnCancelarFun);
            this.Controls.Add(this.btnSalvarFun);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(celularLabel);
            this.Controls.Add(ocupacaoLabel);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(datacadastroLabel);
            this.Controls.Add(this.datacadastroDateTimePicker);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoCheckBox);
            this.Name = "FormCadFun";
            this.Text = "FormCadFun";
            this.Load += new System.EventHandler(this.FormCadFun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarFun;
        private System.Windows.Forms.Button btnSalvarFun;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.DateTimePicker datacadastroDateTimePicker;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private System.Windows.Forms.ComboBox cbOcupacao;
    }
}