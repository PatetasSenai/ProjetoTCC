using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class PesquisaItens : Form
    {
        String busca = null;
        FormCaixa frmAtualizar = null;

        public PesquisaItens()
        {
            InitializeComponent();

        }

       

        public PesquisaItens(String busca, FormCaixa frmRecebido)
        {
            InitializeComponent();
            this.busca = busca;
            this.frmAtualizar = frmRecebido;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PesquisaItens_Load(object sender, EventArgs e)
        {
            string buscaitens = "select id, nome, valorvenda, quantidade from ItensCardapio where nome like @p";
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand cmd = new SqlCommand(buscaitens, conn);
            cmd.Parameters.Add("@p", "%" + this.busca + "%");
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            int colunas = dr.FieldCount;
            for (int i = 0; i < colunas; i++)
            {
                gridItensBusca.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
            }
            string[] linhaDados = new string[colunas];
            while (dr.Read())
            {

                //percorre cada uma das colunas

                for (int a = 0; a < colunas; a++)
                {

                    //verifica o tipo de dados da coluna

                    if (dr.GetFieldType(a).ToString() == "System.Int32")
                    {

                        linhaDados[a] = dr.GetInt32(a).ToString();

                    }


                    if (dr.GetFieldType(a).ToString() == "System.String")
                    {

                        linhaDados[a] = dr.GetString(a).ToString();

                    }

                    if (dr.GetFieldType(a).ToString() == "System.Double")
                    {

                        linhaDados[a] = dr.GetDouble(a).ToString();

                    }
                    if (dr.GetFieldType(a).ToString() == "System.Double")
                    {

                        linhaDados[a] = dr.GetDouble(a).ToString();

                    }

                    if (dr.GetFieldType(a).ToString() == "System.Decimal")
                    {

                        linhaDados[a] = dr.GetDecimal(a).ToString();

                    }
                }

                //atribui a linha ao datagridview

                gridItensBusca.Rows.Add(linhaDados);

            }
        }

        private void gridItensBusca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            string nome;
            double valorvenda;
            string [] valores = new string[3];
            gridItensBusca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (gridItensBusca.SelectedRows.Count >= 0)
            {
                DataGridViewRow row = gridItensBusca.SelectedRows[0];
                valores[0] = row.Cells[0].Value.ToString();
                valores[1] = row.Cells[1].Value.ToString();
                valores[2] = row.Cells[2].Value.ToString();
            }
            id = Convert.ToInt32(valores[0]);
            nome = valores[1];
            valorvenda = Convert.ToDouble(valores[2]);
            frmAtualizar.atualiza(id, nome, valorvenda);
            this.Dispose();

        }
    }
}
