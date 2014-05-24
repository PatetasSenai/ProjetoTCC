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
        FormCaixa frmAtualizar = null;

        public FormPagdin(String busca, FormCaixa frm)
        {
            InitializeComponent();
            maskvltotaldin.Text = busca.ToString();
            this.frmAtualizar = frm;
            MessageBox.Show(busca.ToString());
        }

        private void FormPagdin_Load(object sender, EventArgs e)
        {
            maskvltotaldin.Enabled = false;
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

            maskvltrocodin.Clear();
            maskvlrecdin.Clear();
        }


        public string valortotal { get; set; }

        private void maskvltotaldin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void maskvltrocodin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCancelpagdin_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskvlrecdin_Leave(object sender, EventArgs e)
        {
            double valortotal = Double.Parse(maskvltotaldin.Text);
            double valorrecebido = Convert.ToDouble(maskvlrecdin.Text);
            double valortroco = valorrecebido - valortotal;
            maskvltrocodin.Text = valortroco.ToString();
        }

        private void btnConcPagdin_Click(object sender, EventArgs e)
        {
            Conta c = frmAtualizar.novaConta();            
            GravaConta conta = new GravaConta();
            if (conta.novo(c) != 0)
            {
                MessageBox.Show(c.IdConta.ToString());
                List<Comanda> lista = frmAtualizar.getGridItens(c);
                gravaComanda grava = new gravaComanda();

                if (grava.salvar(lista) > 0 )
                {
                    MessageBox.Show("Pagamento finalizado");
                }
                else
                {
                    MessageBox.Show("Erro no pagamento.");
                }
            }
            
        }
    }
}
