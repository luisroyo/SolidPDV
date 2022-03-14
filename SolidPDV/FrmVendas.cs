using System;
using System.Data;
using System.Windows.Forms;

namespace SolidPDV
{
    public partial class FrmVendas : Form
    {
      
        private static string quantidadeAtual = "";
        private static int qtdItens = 0;
        private static decimal valorTotal = 0;
        private static DataTable dt = new DataTable();
        DataRow dr;

        readonly ProdutoDAO produtoDao = new ProdutoDAO();

        public FrmVendas()
        {
            InitializeComponent();
        }

        private void lbl_quantidade_Click(object sender, EventArgs e)
        {
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!verificaValor()) { return; }

            try
            {
                Produto produto = produtoDao.buscarProdutoPorCodigoBarra(txb_codBarra.Text);
                produto.setCodBarra(txb_codBarra.Text);

                if (!verificaProduto(produto)) { return; }

                calcularPrecoTotal(produto.getPrecoVenda().ToString());
                criarTabela(produto);

                dgv_mostrarProduto.DataSource = dt;
                dgv_mostrarProduto.Columns["Cod.Barra"].Width = 96;
                dgv_mostrarProduto.Columns["Descrição"].Width = 400;
                dgv_mostrarProduto.Columns["Preço Unitário"].Width = 130;
                dgv_mostrarProduto.Columns["Quantidade Produto"].Width = 130;

                dgv_mostrarProduto.Columns["Cod.Barra"].ReadOnly = true;
                dgv_mostrarProduto.Columns["Descrição"].ReadOnly = true;
                dgv_mostrarProduto.Columns["Preço Unitário"].ReadOnly = true;
                txb_codBarra.Text = produto.getDescricao();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Tivemos algum problema ao buscar o produto! " + ex.Message);
                throw new Exception(ex.Message);
            }
            
           
        }
        private void calcularPrecoTotal(string precoVenda)
        {
            txb_preco.Text = precoVenda;
            //Multiplicando preço  por quantidade
            decimal calculoValorTotal = decimal.Parse(txb_preco.Text) * int.Parse(txb_quantidade.Text);
            valorTotal += calculoValorTotal;
            // Setando textBox  com o valor  total calculado
            txb_valorTotal.Text = valorTotal.ToString();
            // Calculando valor total de produtos
            qtdItens += int.Parse(txb_quantidade.Text);
            //Setando textBox com a quantidade  total  calculada
            txb_qtdTotalItens.Text = qtdItens.ToString();
        }

        private void criarTabela(Produto produto)
        {
            dr = dt.NewRow();

            if (!dt.Columns.Contains("Cod.Barra"))
            {
                dt.Columns.Add("Cod.Barra", typeof(string));
            }

            if (!dt.Columns.Contains("Descrição"))
            {
                dt.Columns.Add("Descrição", typeof(string));
            }

            if (!dt.Columns.Contains("Preço Unitário"))
            {
                dt.Columns.Add("Preço Unitário", typeof(string));
            }

            if (!dt.Columns.Contains("Quantidade Produto"))
            {
                dt.Columns.Add("Quantidade Produto", typeof(string));
            }

            dr["Cod.Barra"] = produto.getCodBarra();
            dr["Descrição"] = produto.getDescricao();
            dr["Preço Unitário"] = produto.getPrecoVenda();
            dr["Quantidade Produto"] = txb_quantidade.Text;

            dt.Rows.Add(dr);
        }

        private bool verificaValor()
        {
            if (txb_codBarra.Text == "")
            {
                MessageBox.Show("Insira um Código de barra valido! ");
                return false;
            }
            if (txb_quantidade.Text == "0")
            {
                txb_quantidade.Text = "1";
            }
            return true;
        }
        private bool verificaProduto(Produto produto)
        {
            if (produto.getDescricao() == null || produto.getPrecoVenda() == 0)
            {
                MessageBox.Show("Produto não encontrado!");
                return false;
            }
            return true;
        }

        private void dgv_mostrarProduto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string novaQtd = dgv_mostrarProduto.CurrentRow.Cells[3].Value.ToString();
            string precoUnitario = dgv_mostrarProduto.CurrentRow.Cells[2].Value.ToString();
            decimal calcValor = decimal.Parse(precoUnitario) * int.Parse(quantidadeAtual);
            decimal calc = decimal.Parse(txb_valorTotal.Text) - calcValor;
            valorTotal = calc;
            txb_valorTotal.Text = valorTotal.ToString();

            calcValor = decimal.Parse(precoUnitario) * int.Parse(novaQtd);

            calc = decimal.Parse(txb_valorTotal.Text) + calcValor;
            valorTotal = calc;
            txb_valorTotal.Text = valorTotal.ToString();

            int x = int.Parse(txb_qtdTotalItens.Text) - int.Parse(quantidadeAtual);
            qtdItens = x + int.Parse(novaQtd);

            txb_qtdTotalItens.Text = qtdItens.ToString();

            txb_quantidade.Text = "";
        }
        private void dgv_mostrarProduto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            quantidadeAtual = dgv_mostrarProduto.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_concluir_Click(object sender, EventArgs e)
        {
            FrmFormaPagamento formaPagamento = new FrmFormaPagamento(txb_valorTotal.Text);

            if (txb_valorTotal.Text == "0,00")
            {
                MessageBox.Show("Compra vazia!");
                return;
            }

            formaPagamento.ShowDialog();
            txb_preco.Clear();
            txb_qtdTotalItens.Clear();
            txb_quantidade.Clear();
            txb_valorTotal.Clear();
            txb_codBarra.Clear();

            dgv_mostrarProduto.DataSource = null;         

            limparCampo();
            
        }

        private void btn_cancelarVenda_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja cancelar a Compra?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                txb_preco.Clear();
                txb_qtdTotalItens.Clear();
                txb_quantidade.Clear();
                txb_valorTotal.Clear();
                txb_codBarra.Clear();
                dgv_mostrarProduto.DataSource = 0;

                MessageBox.Show("Compra cancelada com sucesso", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.dgv_mostrarProduto.DataSource = null;
                this.dgv_mostrarProduto.Rows.Clear();
                this.dgv_mostrarProduto.Refresh();

               
                limparCampo();
            }
        }
        private void limparCampo()
        {
            dt = new DataTable();
            quantidadeAtual = "";
            qtdItens = 0;
            valorTotal = 0;

            txb_preco.Text = "0,00";
            txb_qtdTotalItens.Text = "0";
            txb_quantidade.Text = "0";
            txb_valorTotal.Text = "0,00";
        }
    }
}
