using SolidPDV.db.daos;
using SolidPDV.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SolidPDV
{
    public partial class FrmCadastroUsuario : Form
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            dgv_todosUsuarios.DataSource = usuarioDAO.ObeterTodosUsuarios();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (verificarDados())
            {
                Usuario usuario = new Usuario(txb_nome.Text, txb_email.Text, txb_senha.Text);


                if (usuarioDAO.inserirUsuario(usuario))
                {
                    MessageBox.Show("Usuário Cadastrado Com Sucesso!");
                }

                else
                {
                    MessageBox.Show("Não foi possivel fazer o Cadastro!");
                }
            }
            else
            {
                MessageBox.Show("Senhas não conferem ou campos vazios!");
            }
            dgv_todosUsuarios.DataSource = usuarioDAO.ObeterTodosUsuarios();

        }

        private bool verificarDados()
        {
            List<string> lista = new List<string>() { txb_nome.Text, txb_email.Text, txb_senha.Text };

            foreach (string item in lista)
            {
                if (item == "" || txb_senha.Text != txb_confirmaSenha.Text)
                {
                    return false;
                }
            }

            return true;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
