using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SolidPDV.model;

namespace SolidPDV.db.daos
{
    internal class UsuarioDAO
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSql;
        public bool inserirUsuario(Usuario usuario)
        {
            try
            {
                conexao = new MySqlConnection(Conn.strConn);
                strSql = "INSERT INTO `db_solid_pdv`.`tb_usuario` (nome, email, senha) " +
                    "VALUES (@nome, @email, @senha)";

                comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@nome", usuario.Nome);
                comando.Parameters.AddWithValue("@email", usuario.Email);
                comando.Parameters.AddWithValue("@senha", usuario.Senha);

                conexao.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir Usuário " + ex.Message);
                return false;
            }

            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }
        public DataTable ObeterTodosUsuarios()
        {
            DataTable dt = new DataTable();
            List<Usuario> usuarios = new List<Usuario>();

            conexao = new MySqlConnection(Conn.strConn);
            try
            {
                conexao.Open();

                strSql = "select nome, email from db_solid_pdv.tb_usuario";

                using (MySqlDataAdapter ad = new MySqlDataAdapter(strSql, conexao))
                {
                    ad.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            return dt;
        }
        public bool logarUsuario(Usuario usuario)
        {
            bool logado = false;

            conexao = new MySqlConnection(Conn.strConn);
            try
            {
                conexao.Open();

                strSql = String.Format("select count(id_usuario) from tb_usuario " +
                    "where email ='{0}' and senha = '{1}'", usuario.Email, usuario.Senha);

                using (MySqlCommand ad = new MySqlCommand(strSql, conexao))
                {
                    int count = Convert.ToInt32(ad.ExecuteScalar());

                    logado = checkUsuario(count);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            return logado;
        }
        private bool checkUsuario(int count)
        {
            if (count == 1)
            {
                return true;
            }
            else
            {
                throw new Exception("Usuário ou Senha Invalidos!");
            }
        }
    }
}
