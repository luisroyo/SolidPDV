using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SolidPDV
{
    internal class ProdutoDAO
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSql;
        public bool inserirProduto(Produto produto)
        {
            try
            {
                conexao = new MySqlConnection(Conn.strConn);

                strSql = "INSERT INTO `db_solid_pdv`.`tb_cad_produto` " +
                    "(`cod_barra`, `descricao`, `preco_custo`, `preco_venda`, `qtd_estoque`, `qtd_minima`)"
                    + "VALUES (@cod_barra, @descricao, @preco_custo, @preco_venda, @qtd_estoque, @qtd_minima)";

                comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@cod_barra", produto.getCodBarra());
                comando.Parameters.AddWithValue("@descricao", produto.getDescricao());
                comando.Parameters.AddWithValue("@preco_custo", produto.getPrecoCusto());
                comando.Parameters.AddWithValue("@preco_venda", produto.getPrecoVenda());
                comando.Parameters.AddWithValue("@qtd_estoque", produto.getEstoque());
                comando.Parameters.AddWithValue("@qtd_minima", produto.getQtdMinima());

                conexao.Open();
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir produto " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
        public DataTable buscarProduto()
        {
            DataTable dt = new DataTable();
            List<Produto> produtos = new List<Produto>();

            try
            {
                conexao = new MySqlConnection(Conn.strConn);
                conexao.Open();
                strSql = "select * from db_solid_pdv.tb_cad_produto";

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
        public Produto buscarProdutoPorCodigoBarra(string codigoBarra)
        {
            Produto produto = new Produto();
            DataTable dt = new DataTable();

            try
            {
                conexao = new MySqlConnection(Conn.strConn);

                conexao.Open();

                strSql = "select * from db_solid_pdv.tb_cad_produto where cod_barra = " + codigoBarra;


                using (MySqlDataAdapter ad = new MySqlDataAdapter(strSql, conexao))
                {
                    ad.Fill(dt);
                    produto.setDescricao(dt.Rows[0]["descricao"].ToString());
                    produto.setPrecoVenda((decimal)dt.Rows[0]["preco_venda"]);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Não conseguimos encontrar o produto! " + ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            return produto;
        }
    }
}
