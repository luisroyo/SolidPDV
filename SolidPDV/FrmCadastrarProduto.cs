using MySql.Data.MySqlClient;
using SolidPDV.db.daos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SolidPDV
{
    public partial class FrmCadastrarProduto : Form
    {
        ProdutoDAO produtoDAO = new ProdutoDAO();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        public FrmCadastrarProduto()
        {
            InitializeComponent();
            dgv_ListaProdutos.DataSource = produtoDAO.buscarProduto();
            dgv_ListaProdutos.Columns["id_cad_produto"].ReadOnly = true;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
           
        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            if (verificarDados())
            {
                Produto produto = new Produto(txb_codBarra.Text, txb_descricao.Text,
                   decimal.Parse(txb_precoCusto.Text),
                   decimal.Parse(txb_PrecoVenda.Text),
                   int.Parse(txb_qtd_estoque.Text),
                   int.Parse(txb_qtd_minima.Text));


                if (produtoDAO.inserirProduto(produto))
                {
                    MessageBox.Show("Produto Inserido Com Sucesso!");

                    limparCampo();
                }

                else
                {
                    MessageBox.Show("Não foi possivel fazer o Cadastro!");
                    limparCampo();
                }
            }
            else
            {
                MessageBox.Show("Campo Obrigatórios não preenchidos!");

            }
            dgv_ListaProdutos.DataSource = produtoDAO.buscarProduto();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

            dgv_ListaProdutos.DataSource = produtoDAO.buscarProduto();
            dgv_ListaProdutos.Columns["id_cad_produto"].ReadOnly = true;

        }

        private bool verificarDados()
        {
            List<string> lista = new List<string>() {txb_codBarra.Text,txb_descricao.Text,
                txb_precoCusto.Text, txb_PrecoVenda.Text, txb_qtd_estoque.Text, txb_qtd_minima.Text};

            foreach (string item in lista)
            {
                if (item == "")
                {
                    return false;
                }
            }

            return true;
        }

        private void limparCampo()
        {
            txb_codBarra.Clear();
            txb_descricao.Clear();
            txb_precoCusto.Clear();
            txb_PrecoVenda.Clear();
            txb_qtd_estoque.Clear();
            txb_qtd_minima.Clear();
            txb_codBarra.Focus();
        }

        
        
    }
}
