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
    public partial class FormCadFun : Form
    {
        public FormCadFun()
        {
            InitializeComponent();
        }

        private void btnSalvarFun_Click(object sender, EventArgs e)
        {
            if
              (idTextBox.Text == "" ||
               nomeTextBox.Text == "" ||
               enderecoTextBox.Text == "" ||
               cbOcupacao.Text == "" ||
               loginTextBox.Text == "" ||
               senhaTextBox.Text == "" ||
                (mskTel.Text.Length < 14 &&
                mskCel.Text.Length < 15))
            {
                MessageBox.Show("Preencha todos os campos ", "Campos Vazios ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idTextBox.Focus();

            }
            else
            {
                SqlConnection conn = null;
                try
                {
                    try
                    {
                        conn = Conexao.obterConexao();
                        string sql = "insert into funcionario( nome, endereco, telefone, celular, ocupacao, login, senha, datacadastro, ativo)values (@nome, @endereco, @telefone, @celular, @ocupacao, @login, @senha, @datacadastro, @ativo)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        
                        cmd.Parameters.AddWithValue("@nome", nomeTextBox.Text);
                        cmd.Parameters.AddWithValue("@endereco", enderecoTextBox.Text);
                        cmd.Parameters.AddWithValue("@telefone", mskTel.Text);
                        cmd.Parameters.AddWithValue("@celular", mskCel.Text);
                        cmd.Parameters.AddWithValue("@ocupacao", cbOcupacao.Text);
                        cmd.Parameters.AddWithValue("@login", loginTextBox.Text);
                        cmd.Parameters.AddWithValue("@senha", senhaTextBox.Text);
                        cmd.Parameters.AddWithValue("@datacadastro", DateTime.Parse(datacadastroDateTimePicker.Text));
                        cmd.Parameters.AddWithValue("@ativo", ativoCheckBox.Checked);
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
                        idTextBox.Clear();
                    }
                }

                catch (Exception erro)
                {
                    MessageBox.Show("ERRO" + erro);
                }
            }
        }

        private void btnCancelarFun_Click(object sender, EventArgs e)
        {

            DialogResult Resultado = MessageBox.Show(" Deseja Cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormCadFun_Load(object sender, EventArgs e)
        {
            int id = 0;
            SqlConnection conn = null;
            try
            {

                conn = Conexao.obterConexao();
                string contid = "SELECT COALESCE(MAX(ID),MAX(ID),0) FROM FUNCIONARIO";
                SqlCommand cmdselect = new SqlCommand(contid, conn);
                SqlDataReader exec = cmdselect.ExecuteReader();

                while (exec.Read())
                {
                    if (exec[0].ToString().Length > 0)
                        id = int.Parse(exec[0].ToString());
                }
                    id = id + 1;
                    idTextBox.Text = id.ToString();
                    exec.Close();
                    conn.Close();

                }
            
            catch
                (Exception erro)
            {
                MessageBox.Show(erro.Message.ToString());
            }


        }
    }
}


