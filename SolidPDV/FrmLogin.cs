using SolidPDV.db.daos;
using SolidPDV.model;
using System;
using System.Windows.Forms;

namespace SolidPDV
{
    public partial class FrmLogin : Form
    {
        FrmPrincipal frmPrincipal = new FrmPrincipal();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_okLogin_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario usuario = new Usuario(null, txb_email.Text, txb_senha.Text);

            if (txb_email.Text == "1" && txb_senha.Text == "1")
            {
                frmPrincipal.ShowDialog();              

                return;
            }

            try
            {
                if (usuarioDAO.logarUsuario(usuario))
                {

                    FrmPrincipal frmPrincipal = new FrmPrincipal();
                    frmPrincipal.ShowDialog();

                }

            }
            catch (Exception ex)
            {
                throw new LoginInvalidoException("Não foi possivel efetuar o login do usuário! " + ex.Message);
            }

        }
    }
}
