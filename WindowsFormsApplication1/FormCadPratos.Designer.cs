namespace WindowsFormsApplication1
{
    partial class FormCadPratos
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
            System.Windows.Forms.Label imagemLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valorcustoLabel;
            System.Windows.Forms.Label valorvendaLabel;
            System.Windows.Forms.Label dataultimacompraLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            this.btnCancelaPratos = new System.Windows.Forms.Button();
            this.btnSalvaPratos = new System.Windows.Forms.Button();
            this.imgPic = new System.Windows.Forms.PictureBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.valorcustoTextBox = new System.Windows.Forms.TextBox();
            this.valorvendaTextBox = new System.Windows.Forms.TextBox();
            this.dataultimacompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.BtnCarregaImg = new System.Windows.Forms.Button();
            imagemLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valorcustoLabel = new System.Windows.Forms.Label();
            valorvendaLabel = new System.Windows.Forms.Label();
            dataultimacompraLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPic)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemLabel
            // 
            imagemLabel.AutoSize = true;
            imagemLabel.Location = new System.Drawing.Point(97, 236);
            imagemLabel.Name = "imagemLabel";
            imagemLabel.Size = new System.Drawing.Size(46, 13);
            imagemLabel.TabIndex = 37;
            imagemLabel.Text = "imagem:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(97, 31);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 21;
            idLabel.Text = "id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(97, 57);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 23;
            nomeLabel.Text = "nome:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(97, 83);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(56, 13);
            descricaoLabel.TabIndex = 25;
            descricaoLabel.Text = "descricao:";
            // 
            // valorcustoLabel
            // 
            valorcustoLabel.AutoSize = true;
            valorcustoLabel.Location = new System.Drawing.Point(97, 109);
            valorcustoLabel.Name = "valorcustoLabel";
            valorcustoLabel.Size = new System.Drawing.Size(62, 13);
            valorcustoLabel.TabIndex = 27;
            valorcustoLabel.Text = "valor custo:";
            // 
            // valorvendaLabel
            // 
            valorvendaLabel.AutoSize = true;
            valorvendaLabel.Location = new System.Drawing.Point(97, 135);
            valorvendaLabel.Name = "valorvendaLabel";
            valorvendaLabel.Size = new System.Drawing.Size(66, 13);
            valorvendaLabel.TabIndex = 29;
            valorvendaLabel.Text = "valor venda:";
            // 
            // dataultimacompraLabel
            // 
            dataultimacompraLabel.AutoSize = true;
            dataultimacompraLabel.Location = new System.Drawing.Point(97, 162);
            dataultimacompraLabel.Name = "dataultimacompraLabel";
            dataultimacompraLabel.Size = new System.Drawing.Size(99, 13);
            dataultimacompraLabel.TabIndex = 31;
            dataultimacompraLabel.Text = "data ultima compra:";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(97, 187);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(54, 13);
            categoriaLabel.TabIndex = 33;
            categoriaLabel.Text = "categoria:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(97, 213);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(63, 13);
            quantidadeLabel.TabIndex = 35;
            quantidadeLabel.Text = "quantidade:";
            // 
            // btnCancelaPratos
            // 
            this.btnCancelaPratos.Location = new System.Drawing.Point(288, 443);
            this.btnCancelaPratos.Name = "btnCancelaPratos";
            this.btnCancelaPratos.Size = new System.Drawing.Size(108, 43);
            this.btnCancelaPratos.TabIndex = 40;
            this.btnCancelaPratos.Text = "Cancelar";
            this.btnCancelaPratos.UseVisualStyleBackColor = true;
            this.btnCancelaPratos.Click += new System.EventHandler(this.btnCancelaPratos_Click);
            // 
            // btnSalvaPratos
            // 
            this.btnSalvaPratos.Location = new System.Drawing.Point(100, 443);
            this.btnSalvaPratos.Name = "btnSalvaPratos";
            this.btnSalvaPratos.Size = new System.Drawing.Size(108, 43);
            this.btnSalvaPratos.TabIndex = 39;
            this.btnSalvaPratos.Text = "Salvar";
            this.btnSalvaPratos.UseVisualStyleBackColor = true;
            this.btnSalvaPratos.Click += new System.EventHandler(this.btnSalvaPratos_Click);
            // 
            // imgPic
            // 
            this.imgPic.Location = new System.Drawing.Point(196, 236);
            this.imgPic.Name = "imgPic";
            this.imgPic.Size = new System.Drawing.Size(200, 167);
            this.imgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPic.TabIndex = 38;
            this.imgPic.TabStop = false;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(196, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 22;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(196, 54);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 24;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(196, 80);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.descricaoTextBox.TabIndex = 26;
            // 
            // valorcustoTextBox
            // 
            this.valorcustoTextBox.Location = new System.Drawing.Point(196, 106);
            this.valorcustoTextBox.Name = "valorcustoTextBox";
            this.valorcustoTextBox.Size = new System.Drawing.Size(200, 20);
            this.valorcustoTextBox.TabIndex = 28;
            // 
            // valorvendaTextBox
            // 
            this.valorvendaTextBox.Location = new System.Drawing.Point(196, 132);
            this.valorvendaTextBox.Name = "valorvendaTextBox";
            this.valorvendaTextBox.Size = new System.Drawing.Size(200, 20);
            this.valorvendaTextBox.TabIndex = 30;
            // 
            // dataultimacompraDateTimePicker
            // 
            this.dataultimacompraDateTimePicker.Location = new System.Drawing.Point(196, 158);
            this.dataultimacompraDateTimePicker.Name = "dataultimacompraDateTimePicker";
            this.dataultimacompraDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataultimacompraDateTimePicker.TabIndex = 32;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.Location = new System.Drawing.Point(196, 184);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(200, 20);
            this.categoriaTextBox.TabIndex = 34;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Location = new System.Drawing.Point(196, 210);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantidadeTextBox.TabIndex = 36;
            // 
            // BtnCarregaImg
            // 
            this.BtnCarregaImg.Location = new System.Drawing.Point(100, 360);
            this.BtnCarregaImg.Name = "BtnCarregaImg";
            this.BtnCarregaImg.Size = new System.Drawing.Size(75, 43);
            this.BtnCarregaImg.TabIndex = 41;
            this.BtnCarregaImg.Text = "Carregar Imagem";
            this.BtnCarregaImg.UseVisualStyleBackColor = true;
            this.BtnCarregaImg.Click += new System.EventHandler(this.BtnCarregaImg_Click);
            // 
            // FormCadPratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 514);
            this.Controls.Add(this.BtnCarregaImg);
            this.Controls.Add(this.btnCancelaPratos);
            this.Controls.Add(this.btnSalvaPratos);
            this.Controls.Add(imagemLabel);
            this.Controls.Add(this.imgPic);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(valorcustoLabel);
            this.Controls.Add(this.valorcustoTextBox);
            this.Controls.Add(valorvendaLabel);
            this.Controls.Add(this.valorvendaTextBox);
            this.Controls.Add(dataultimacompraLabel);
            this.Controls.Add(this.dataultimacompraDateTimePicker);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Name = "FormCadPratos";
            this.Text = "FormCadPratos";
            ((System.ComponentModel.ISupportInitialize)(this.imgPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelaPratos;
        private System.Windows.Forms.Button btnSalvaPratos;
        private System.Windows.Forms.PictureBox imgPic;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox valorcustoTextBox;
        private System.Windows.Forms.TextBox valorvendaTextBox;
        private System.Windows.Forms.DateTimePicker dataultimacompraDateTimePicker;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.Button BtnCarregaImg;
    }
}