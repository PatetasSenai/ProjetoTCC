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
using System.Text.RegularExpressions;
using System.Configuration;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class FormCadMesa : Form
    {
        public FormCadMesa()
        {
            InitializeComponent();
        }

       

        private void btnSalvarMesa_Click_1(object sender, EventArgs e)
        {
            if
              (idTextBox.Text == "" ||
               descricaoTextBox.Text == "")
            {
                MessageBox.Show("Preencha o campo de descrição ", "Campos Vazios ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                descricaoTextBox.Focus();

            }
            else
            {
                SqlConnection conn = null;
                try
                {
                    try
                    {
                        conn = Conexao.obterConexao();
                        string sql = "insert into mesa(id, descricao)values (@id,@descricao)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", idTextBox.Text);
                        cmd.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cadastro concluído com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Não foi possível concluir o cadastro" + erro, "Não cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        descricaoTextBox.Clear();
                    }
                }

                catch (Exception erro)
                {
                    MessageBox.Show("ERRO" + erro);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show(" Deseja Cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormCadMesa_Load(object sender, EventArgs e)
        {

        }
    }
}

        