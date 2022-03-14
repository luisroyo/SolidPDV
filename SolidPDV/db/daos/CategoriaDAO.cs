using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SolidPDV.db.daos
{
    internal class CategoriaDAO
    {
        MySqlConnection conexao;
        MySqlCommand comando;

        string strSql;
        public bool inserirCategoria(Categoria categoria)
        {
            try
            {
                conexao = new MySqlConnection(Conn.strConn);

                strSql = "INSERT INTO `db_solid_pdv`.`tb_categoria` " +
                    "(`descricao`)"
                    + "VALUES (@descricao)";

                comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@descricao", categoria.getNome());

                conexao.Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir Categoria " + ex.Message);
                return false;
            }

            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        public DataTable buscarCategoria()
        {
            DataTable dt = new DataTable();
            List<Categoria> categorias = new List<Categoria>();

            try
            {
                conexao = new MySqlConnection(Conn.strConn);

                conexao.Open();

                strSql = "select * from db_solid_pdv.tb_categoria";

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

        public bool deletarCategoria(string id)
        {
            conexao = new MySqlConnection(Conn.strConn);
            try
            {
                conexao.Open();

                strSql = String.Format("delete from tb_categoria where id_categoria ='{0}'", id);

                using (MySqlCommand ad = new MySqlCommand(strSql, conexao))
                {
                    ad.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir Categoria " + ex.Message);
                return false;
            }

            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        public bool atualizarCategoria(string id, string categoria)
        {
            conexao = new MySqlConnection(Conn.strConn);
            try
            {
                conexao.Open();

                strSql = String.Format("UPDATE `db_solid_pdv`.`tb_categoria` SET `descricao` " +
                    "= '{0}' WHERE (`id_categoria` = '{1}')", categoria, id);

                using (MySqlCommand ad = new MySqlCommand(strSql, conexao))
                {
                    ad.ExecuteNonQuery();
                }
                return true;

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
            return false;
        }
       
    }
}
