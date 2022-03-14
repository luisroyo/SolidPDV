using SolidPDV.db.daos;
using System;
using System.Windows.Forms;

namespace SolidPDV
{
    public partial class FrmCategoria : Form
    {
        private static string idCategoria = "";

        CategoriaDAO categoriaDAO = new CategoriaDAO();
        public FrmCategoria()
        {
            InitializeComponent();
            dgv_categoria.DataSource = categoriaDAO.buscarCategoria();
            dgv_categoria.Columns["descricao"].ReadOnly = false;
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria(txb_categoria.Text);

            if (categoriaDAO.inserirCategoria(categoria))
            {
                MessageBox.Show("Categoria Inserido Com Sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel inserir categoria!");
            }
            txb_categoria.Clear();
            dgv_categoria.DataSource = categoriaDAO.buscarCategoria();

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dgv_categoria.DataSource = categoriaDAO.buscarCategoria();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir a Categoria?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                MessageBox.Show("Exclusão concluida com sucesso!", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                categoriaDAO.deletarCategoria(idCategoria);
                dgv_categoria.DataSource = categoriaDAO.buscarCategoria();
            }            
        }

        private void dgv_categoria_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgv_categoria.CurrentRow.Cells[0].Value.ToString();
            string categoria = dgv_categoria.CurrentRow.Cells[1].Value.ToString();

            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar a Categoria?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                MessageBox.Show("Categoria alterada com sucesso!", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                categoriaDAO.atualizarCategoria(id, categoria);
            }         
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            string id = dgv_categoria.CurrentRow.Cells[0].Value.ToString();
            string categoria = dgv_categoria.CurrentRow.Cells[1].Value.ToString();

            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar a Categoria?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                MessageBox.Show("Categoria alterada com sucesso!", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                categoriaDAO.atualizarCategoria(id, categoria);
            }
        }

        private void dgv_categoria_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idCategoria = dgv_categoria.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
