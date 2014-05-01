using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormCaixa : Form
    {
        private Funcionario funcCaixa;
        double totalPedido = 0;

        public void atualiza(int codigo, string nomeP, double valor )
        {
            txtCodigoItem.Text = codigo.ToString();
            txtNomeItem.Text = nomeP;
            txtValorItem.Text = valor.ToString();
        }

        public FormCaixa()
        {
            InitializeComponent();
        }

        public FormCaixa(Funcionario f)
        {
            InitializeComponent();
            this.funcCaixa = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCaixa_Load(object sender, EventArgs e)
        {
            txtNomeItem.Enabled = false;
            txtValorItem.Enabled = false;
            if (funcCaixa.Ocupacao != "ADM")
            {
                tabCadProduto.TabPages.Remove(tabCadastro);
                tabCadProduto.TabPages.Remove(tabEstoque);
                tabCadProduto.TabPages.Remove(tabMetricas);



            }
        }

        private void tabCadProduto_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesquisaItens Pesquisaitens = new PesquisaItens(txtBusca.Text,this);
            Pesquisaitens.ShowDialog();
            txtQuantidade.Focus();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string v;
            string v2;
            string consultaId = "select nome, valorvenda from ItensCardapio where id = @id";
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand cmd = new SqlCommand(consultaId, conn);
            //cmd.Parameters.Add("@id", txtCodigoItem.Text);
            cmd.Parameters.AddWithValue("@id", Int32.Parse(txtCodigoItem.Text));
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                v = dr.GetString(0);
                v2 = dr.GetDecimal(1).ToString();
            }
            
            
        }

        private void btnAddproduto_Click(object sender, EventArgs e)
        {
            
            string quantidade = txtQuantidade.Text;
            string valorUnit = txtValorItem.Text;
            double valorTotal = Convert.ToInt32(quantidade) * Convert.ToDouble(valorUnit);

            if (txtCodigoItem.Text == "" || txtNomeItem.Text == "" || txtQuantidade.Text == "" || txtValorItem.Text == "")
            {

                MessageBox.Show("Escolha um Item Válido");
            }
            else 
            {
                int linhasGrid = gridPedido.RowCount;
                if (linhasGrid == 0)
                {
                    gridPedido.Columns.Add("Código", "Código");
                    gridPedido.Columns.Add("Descrição", "Descrição");
                    gridPedido.Columns.Add("Valor Unit", "Valor Unit");
                    gridPedido.Columns.Add("Quantidade", "Quantidade");
                    gridPedido.Columns.Add("Valor Total", "Valor Total");
                    gridPedido.Rows.Add(txtCodigoItem.Text, txtNomeItem.Text, txtValorItem.Text, txtQuantidade.Text, valorTotal.ToString());
                    totalPedido = valorTotal;
                    
                }
                else 
                {
                    gridPedido.Rows.Add(txtCodigoItem.Text, txtNomeItem.Text, txtValorItem.Text, txtQuantidade.Text, valorTotal.ToString());
                    totalPedido += valorTotal;
                }
                txtTotalPedido.Text = totalPedido.ToString();
                txtBusca.Clear();
                txtCodigoItem.Clear();
                txtNomeItem.Clear();
                txtValorItem.Clear();
                txtQuantidade.Clear();
                
            }
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Validar o meio de cobrança 
            
            if (rbCartao.Checked) 
            {
                FormPagCard cartao = new FormPagCard(Double.Parse(txtTotalPedido.Text));
                cartao.Show();
            }
            if (rbCheque.Checked)
            {
                FormPagCheque cheque = new FormPagCheque(Double.Parse(txtTotalPedido.Text));
                cheque.Show();
            }
            if (rbDinheiro.Checked)
            {
                FormPagdin dinheiro = new FormPagdin(Double.Parse(txtTotalPedido.Text));
                dinheiro.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCadPratos novoform1 = new FormCadPratos();
            novoform1.StartPosition = FormStartPosition.CenterScreen;
            novoform1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormCadPratos novoform1 = new FormCadPratos();
            novoform1.StartPosition = FormStartPosition.CenterScreen;
            novoform1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormCadFun novoform1 = new FormCadFun();
            novoform1.StartPosition = FormStartPosition.CenterScreen;
            novoform1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormCadMesa novoform1 = new FormCadMesa();
            novoform1.StartPosition = FormStartPosition.CenterScreen;
            novoform1.Show();
        }
    }
}
