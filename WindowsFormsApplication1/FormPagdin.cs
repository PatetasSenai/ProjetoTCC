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

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
