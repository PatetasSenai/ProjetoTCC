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
    public partial class FormPagCard : Form
    {
        public FormPagCard()
        {
            InitializeComponent();
        }

        public FormPagCard(double totalPedido)
        {
            InitializeComponent();
            txtValorCard.Text = totalPedido.ToString();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormPagCard_Load(object sender, EventArgs e)
        {

        }
    }
}
