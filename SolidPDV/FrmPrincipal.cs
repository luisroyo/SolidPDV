using System;
using System.Windows.Forms;

namespace SolidPDV
{
    public partial class FrmPrincipal : Form 
    {
        
        public FrmPrincipal()
        {
            InitializeComponent();           
           
        }

        private void btn_venda_Click(object sender, EventArgs e)
        {
            FrmVendas frmVendas = new FrmVendas();
            
            frmVendas.ShowDialog();
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto frmCadastrar = new FrmCadastrarProduto();
            frmCadastrar.ShowDialog();
        }

        private void btn_cad_categoria_Click(object sender, EventArgs e)
        {            
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.ShowDialog();           
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto frmProduto = new FrmCadastrarProduto();
            frmProduto.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria();
            frmCategoria.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto frmProduto = new FrmCadastrarProduto();
            frmProduto.ShowDialog();
        }

        private void btn_venda_Click_1(object sender, EventArgs e)
        {
            FrmVendas frmVendas = new FrmVendas();
            frmVendas.ShowDialog();
        }

        private void btn_cadastroUsuario_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario frmCadastro = new FrmCadastroUsuario();
            frmCadastro.ShowDialog();
        }
    }
}
