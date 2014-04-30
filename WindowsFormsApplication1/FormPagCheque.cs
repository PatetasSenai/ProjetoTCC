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
    public partial class FormPagCheque : Form
    {
        public FormPagCheque()
        {
            InitializeComponent();
        }

        public FormPagCheque(double totalPedido)
        {
            InitializeComponent();
            txtValorCheque.Text = totalPedido.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormPagCheque_Load(object sender, EventArgs e)
        {

        }
    }
}
