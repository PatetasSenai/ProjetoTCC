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

        public void atualiza(int codigo, string nomeP, double valor)
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
            if (radioButton6.Checked == true)
            {
                FormPagdin frm = new FormPagdin(mktotaldin.Text);
                frm.Show();
            }
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
            gridEstoque.Columns.Add("ID", "ID");
            gridEstoque.Columns.Add("Item", "Item");
            gridEstoque.Columns.Add("Quantidade", "Quantidade");

            string estoque = "select id, nome, quantidade from ItensCardapio";
            SqlConnection estoquecon = Conexao.obterConexao();
            SqlCommand estoquecmd = new SqlCommand(estoque, estoquecon);
            estoquecmd.CommandType = CommandType.Text;


            gridPedido.Columns.Add("Código", "Código");
            gridPedido.Columns.Add("Descrição", "Descrição");
            gridPedido.Columns.Add("Valor Unit", "Valor Unit");
            gridPedido.Columns.Add("Quantidade", "Quantidade");
            gridPedido.Columns.Add("Valor Total", "Valor Total");



            txtNomeItem.Enabled = false;
            txtValorItem.Enabled = false;
            if (funcCaixa.Ocupacao != "ADM")
            {
                tabCadProduto.TabPages.Remove(tabCadastro);
                tabCadProduto.TabPages.Remove(tabEstoque);
                tabCadProduto.TabPages.Remove(tabMetricas);



            }
            else
            {
                dgAtualizaMesas.Columns.Add("ID", "ID");
                dgAtualizaMesas.Columns.Add("Descrição", "Descrição");

                dgAtualizaItens.Columns.Add("ID", "ID");
                dgAtualizaItens.Columns.Add("Nome", "Nome");
                dgAtualizaItens.Columns.Add("Valor de Venda", "Valor de Venda");

                dgAtualizaPratos.Columns.Add("ID", "ID");
                dgAtualizaPratos.Columns.Add("Nome", "Nome");
                dgAtualizaPratos.Columns.Add("Valor de Venda", "Valor de Venda");

                dgAtualizaFuncionarios.Columns.Add("ID", "ID");
                dgAtualizaFuncionarios.Columns.Add("Nome", "Nome");
                dgAtualizaFuncionarios.Columns.Add("Login", "Login");

                string gridFuncionarios = "select id, nome, login from Funcionario";
                SqlConnection conn = Conexao.obterConexao();
                SqlCommand cmdFuncionario = new SqlCommand(gridFuncionarios, conn);
                cmdFuncionario.CommandType = CommandType.Text;
                SqlDataReader drFuncionario = cmdFuncionario.ExecuteReader();
                int colunasFuncionarios = drFuncionario.FieldCount;
                string[] linhaFuncionarios = new string[colunasFuncionarios];
                while (drFuncionario.Read())
                {
                    //MessageBox.Show(conn.State.ToString());
                    //percorre cada uma das colunas

                    for (int a = 0; a < colunasFuncionarios; a++)
                    {

                        //verifica o tipo de dados da coluna

                        if (drFuncionario.GetFieldType(a).ToString() == "System.Int32")
                        {

                            linhaFuncionarios[a] = drFuncionario.GetInt32(a).ToString();

                        }


                        if (drFuncionario.GetFieldType(a).ToString() == "System.String")
                        {

                            linhaFuncionarios[a] = drFuncionario.GetString(a).ToString();

                        }

                        if (drFuncionario.GetFieldType(a).ToString() == "System.String")
                        {

                            linhaFuncionarios[a] = drFuncionario.GetString(a).ToString();

                        }

                    }

                    dgAtualizaFuncionarios.Rows.Add(linhaFuncionarios);

                }
                drFuncionario.Close();

                string gridItens = "select id, nome, valorvenda from ItensCardapio where categoria = 'Itens'";
                //conn = Conexao.obterConexao();
                SqlCommand cmdItens = new SqlCommand(gridItens, conn);
                cmdItens.CommandType = CommandType.Text;
                SqlDataReader drItens = cmdItens.ExecuteReader();
                int colunasItens = drItens.FieldCount;
                string[] linhaItens = new string[colunasItens];
                while (drItens.Read())
                {

                    //percorre cada uma das colunas

                    for (int a = 0; a < colunasItens; a++)
                    {

                        //verifica o tipo de dados da coluna

                        if (drItens.GetFieldType(a).ToString() == "System.Int32")
                        {

                            linhaItens[a] = drItens.GetInt32(a).ToString();

                        }


                        if (drItens.GetFieldType(a).ToString() == "System.String")
                        {

                            linhaItens[a] = drItens.GetString(a).ToString();

                        }

                        if (drItens.GetFieldType(a).ToString() == "System.Decimal")
                        {

                            linhaItens[a] = drItens.GetDecimal(a).ToString();

                        }

                    }
                    dgAtualizaItens.Rows.Add(linhaItens);
                }
                //conn.Close();
                drItens.Close();


                string gridPratos = "select id, nome, valorvenda from ItensCardapio where categoria = 'Pratos'";
                //conn = Conexao.obterConexao();
                SqlCommand cmdPratos = new SqlCommand(gridPratos, conn);
                cmdPratos.CommandType = CommandType.Text;
                SqlDataReader drPratos = cmdPratos.ExecuteReader();
                int colunasPratos = drPratos.FieldCount;
                string[] linhaPratos = new string[colunasPratos];
                while (drPratos.Read())
                {

                    //percorre cada uma das colunas

                    for (int a = 0; a < colunasPratos; a++)
                    {

                        //verifica o tipo de dados da coluna

                        if (drPratos.GetFieldType(a).ToString() == "System.Int32")
                        {

                            linhaPratos[a] = drPratos.GetInt32(a).ToString();

                        }


                        if (drPratos.GetFieldType(a).ToString() == "System.String")
                        {

                            linhaPratos[a] = drPratos.GetString(a).ToString();

                        }

                        if (drPratos.GetFieldType(a).ToString() == "System.Decimal")
                        {

                            linhaPratos[a] = drPratos.GetDecimal(a).ToString();

                        }

                    }
                    dgAtualizaPratos.Rows.Add(linhaPratos);
                }

                string gridMesas = "select * from Mesa";
                conn = Conexao.obterConexao();
                SqlCommand cmdMesas = new SqlCommand(gridMesas, conn);
                cmdMesas.CommandType = CommandType.Text;
                SqlDataReader drMesas = cmdMesas.ExecuteReader();
                int colunasMesas = drMesas.FieldCount;
                string[] linhaMesas = new string[colunasMesas];
                while (drMesas.Read())
                {

                    //percorre cada uma das colunas

                    for (int a = 0; a < colunasMesas; a++)
                    {

                        //verifica o tipo de dados da coluna

                        if (drMesas.GetFieldType(a).ToString() == "System.Int32")
                        {

                            linhaMesas[a] = drMesas.GetInt32(a).ToString();

                        }


                        if (drMesas.GetFieldType(a).ToString() == "System.String")
                        {

                            linhaMesas[a] = drMesas.GetString(a).ToString();

                        }

                    }


                    // select id, nome, valorvenda from ItensCardapio where categoria = Pratos
                    // select id, nome, valorvenda from ItensCardapio where categoria = Itens
                    dgAtualizaMesas.Rows.Add(linhaMesas);

                }
                conn.Close();


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
            PesquisaItens Pesquisaitens = new PesquisaItens(txtBusca.Text, this);
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

                gridPedido.Rows.Add(txtCodigoItem.Text, txtNomeItem.Text, txtValorItem.Text, txtQuantidade.Text, valorTotal.ToString());
                totalPedido = valorTotal;
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
            if (rbCartao.Checked)
            {
                FormPagCard cartao = new FormPagCard(Double.Parse(txtTotalPedido.Text));
                cartao.Show();
            }
            else if (rbCheque.Checked)
            {
                FormPagCheque cheque = new FormPagCheque(Double.Parse(txtTotalPedido.Text));
                cheque.Show();
            }
            else if (rbDinheiro.Checked)
            {
                FormPagdin dinheiro = new FormPagdin(txtTotalPedido.Text);
                dinheiro.Show();
            }
            else
            {
                MessageBox.Show("Escolha uma Forma de Pagamento!");
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

        private void btnLimpapesquisa_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            txtCodigoItem.Clear();
            txtNomeItem.Clear();
            txtQuantidade.Clear();
            txtValorItem.Clear();
        }

        private void btnDeletarItem_Click(object sender, EventArgs e)
        {
            //string itemExcluido = gridPedido.SelectedCells[4].ToString();

            //double itemExcluido = Convert.ToDouble(gridPedido.SelectedCells[4].ToString());
            //gridPedido.Rows.Remove(gridPedido.Rows[gridPedido.CurrentRow.Index]);
            //txtTotalPedido.Text = (Convert.ToDouble(txtTotalPedido.ToString()) - itemExcluido).ToString();

            if (gridPedido.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = gridPedido.SelectedRows[0];
                double valorExcluido = Double.Parse(linha.Cells[4].Value.ToString());
                valorExcluido = Double.Parse(txtTotalPedido.Text) - valorExcluido;
                txtTotalPedido.Text = valorExcluido.ToString();
                gridPedido.Rows.Remove(gridPedido.Rows[gridPedido.CurrentRow.Index]);


            }


        }

        private void gridPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAtualizaPrato_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_Leave(object sender, EventArgs e)
        {
            FormPagdin pagdim = new FormPagdin();
            pagdim.ShowDialog();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
