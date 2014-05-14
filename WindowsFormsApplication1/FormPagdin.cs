using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormPagdin : Form
    {
        public FormPagdin()
        {
            InitializeComponent();
        }

        String busca = null;
        FormPagdin frmAtualizar = null;

        public FormPagdin( String busca)
        {
            InitializeComponent();
            maskvltotaldin.Text = busca.ToString();
            MessageBox.Show(busca.ToString());
        }

        private void FormPagdin_Load(object sender, EventArgs e)
        {
            //txtValorDinTotal.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

//<<<<<<< HEAD
        private void txtValorRecDin_Leave(object sender, EventArgs e)
        {
            //           double valortotal = Double.Parse(txtValorDinTotal.Text);
            //           double valorrecebido = Convert.ToDouble(txtValorRecDin.Text);
            //           double valortroco = valorrecebido - valortotal;
            //           txtValorTrocoDin.Text = valortroco.ToString();
            //=======
        }

        private void btnCancelpagdin_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show(" Deseja Cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
//>>>>>>> 89b25ca155ec3f553b567d8841a83098dc3b9737
        }

        private void btnLimppagdin_Click(object sender, EventArgs e)
        {
//<<<<<<< HEAD
//            txtValorTrocoDin.Clear();
//            txtValorRecDin.Clear();
            //txtValorDinTotal.Clear();
        }

        //private void btnCancelpagdin_Click(object sender, EventArgs e)
        //{
            /*txtValorDinTotal.Clear();
            txtValorRecDin.Clear();
            txtValorTrocoDin.Clear();*/
            //this.Close();
//=======
            //maskvltotaldin.Clear();
            //maskvlrecdin.Clear();
            //maskvltrocodin.Clear();
        //}

        public string valortotal { get; set; }

        private void maskvltotaldin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

//>>>>>>> 89b25ca155ec3f553b567d8841a83098dc3b9737
        }
    }
}
