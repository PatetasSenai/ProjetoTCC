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

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelpagdin_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show(" Deseja Cancelar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLimppagdin_Click(object sender, EventArgs e)
        {
            maskvltotaldin.Clear();
            maskvlrecdin.Clear();
            maskvltrocodin.Clear();
        }

        public string valortotal { get; set; }

        private void maskvltotaldin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
