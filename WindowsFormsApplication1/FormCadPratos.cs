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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class FormCadPratos : Form
    {
        public FormCadPratos()
        {
            InitializeComponent();
        }

        private void btnSalvaPratos_Click(object sender, EventArgs e)
        {

            if
              (idTextBox.Text == "" ||
               nomeTextBox.Text == "" ||
               descricaoTextBox.Text == "" ||
               valorcustoTextBox.Text == "" ||
               valorvendaTextBox.Text == "" ||
               categoriaTextBox.Text == "" ||
               quantidadeTextBox.Text == "")
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
                        string sql = "insert into ItensCardapio(id,nome, descricao, valorcusto, valorvenda, categoria, quantidade, imagem)values (@id,@nome, @descricao, @valorcusto, @valorvenda, @categoria, @quantidade, @imagem)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", idTextBox.Text);
                        cmd.Parameters.AddWithValue("@nome", nomeTextBox.Text);
                        cmd.Parameters.AddWithValue("@descricao", descricaoTextBox.Text);
                        cmd.Parameters.AddWithValue("@valorcusto", valorcustoTextBox.Text);
                        cmd.Parameters.AddWithValue("@valorvenda", valorvendaTextBox.Text);
                        cmd.Parameters.AddWithValue("@categoria", categoriaTextBox.Text);
                        cmd.Parameters.AddWithValue("@quantidade", quantidadeTextBox.Text);
                        cmd.Parameters.AddWithValue("@imagem", ImageData);
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
                
                    finally
                    {
                        idTextBox.Clear();
                        nomeTextBox.Clear();
                        descricaoTextBox.Clear();
                        valorcustoTextBox.Clear();
                        valorvendaTextBox.Clear();
                        categoriaTextBox.Clear();
                        quantidadeTextBox.Clear();
                        imgPic.Image = null;
                        imgPic.Invalidate();
                    }
                
            }
        }

        private void btnCancelaPratos_Click(object sender, EventArgs e)
        {


            DialogResult Resultado = MessageBox.Show(" Deseja Cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private string fotoPath = null;
        private byte[] ImageData = null;


        private void BtnCarregaImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Arquivos (*.png)|*.png|Arquivos (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imgPic.Image = new Bitmap(openFileDialog1.FileName);
                    fotoPath = openFileDialog1.FileName;

                    ImageData = ReadImage(fotoPath);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar a imagem." + ex.Message);
                }
            }
        }
                
                byte[] ReadImage(string ImagePath)
                {
                    byte[] ImageData = null;
                    FileInfo fi = new FileInfo(ImagePath);
                    long NumberOfBytes = fi.Length;
                    FileStream fs = new FileStream(ImagePath, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)NumberOfBytes);
                    return ImageData;
                }
            }
        
}



    