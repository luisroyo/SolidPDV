using System;
using System.Windows.Forms;

namespace SolidPDV
{
    public partial class FrmFormaPagamento : Form
    {

        public FrmFormaPagamento(string valorTotal)
        {
            InitializeComponent();
            lbl_precoTotalPagamento.Text = valorTotal;
        }

        private void btn_concluir_Click(object sender, EventArgs e)
        {
            string formaPagamento = "";
            if (cb_dinheiro.Checked)
            {
                formaPagamento = "Dinheiro";
            }
            else if (cb_cartaoDebito.Checked)
            {
                formaPagamento = "Débito";
            }
            else if (cb_cartaoCredito.Checked)
            {
                formaPagamento = "Crédito";
            }
            else
            {
                MessageBox.Show("Selecione uma forma de pagamento!");
                return;
            }
            MessageBox.Show("Compra no valor de: " + lbl_precoTotalPagamento.Text + "\n " +
                "Forma de Pagamento: " + formaPagamento);

            cb_cartaoCredito.Checked = false;
            cb_cartaoDebito.Checked = false;
            cb_dinheiro.Checked = false;
            formaPagamento = null;
            lbl_precoTotalPagamento.Text = null;

            Close();



        }
    }
}
