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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                if (txtLogin.Text != "" && txtSenha.Text != "")
                {
                    conn = Conexao.obterConexao(); //Tentando conectr com o banco.
                    String sql = "Select id, nome, ocupacao from Funcionario where login =@login and Senha =@senha";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Funcionario f = new Funcionario();
                        f.Id = int.Parse(dr["id"].ToString());
                        f.Nome = dr["nome"].ToString();
                        f.Ocupacao = dr["ocupacao"].ToString();
                        FormCaixa frmCaixa = new FormCaixa(f);
                        this.Hide();
                        frmCaixa.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha inválidos", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos são de preenchimento obrigatório", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }





        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Deseja Sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
