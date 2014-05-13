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

        public FormPagdin(double totalPedido)
        {
            InitializeComponent();
            txtValorDinTotal.Text = totalPedido.ToString();
        }

        private void FormPagdin_Load(object sender, EventArgs e)
        {
            txtValorDinTotal.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorRecDin_Leave(object sender, EventArgs e)
        {
            double valortotal = Double.Parse(txtValorDinTotal.Text);
            double valorrecebido = Convert.ToDouble(txtValorRecDin.Text);
            double valortroco = valorrecebido - valortotal;
            txtValorTrocoDin.Text = valortroco.ToString();
        }

        private void btnLimppagdin_Click(object sender, EventArgs e)
        {
            txtValorTrocoDin.Clear();
            txtValorRecDin.Clear();
            //txtValorDinTotal.Clear();
        }

        private void btnCancelpagdin_Click(object sender, EventArgs e)
        {
            /*txtValorDinTotal.Clear();
            txtValorRecDin.Clear();
            txtValorTrocoDin.Clear();*/
            this.Close();
        }
    }
}
