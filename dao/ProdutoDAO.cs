using MySql.Data.MySqlClient;
using ProjetoDS.conexao;
using ProjetoDS.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDS.dao
{
    public class ProdutoDAO
    {
        MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = ConnectionFactory.getConnection();
        }

        #region Método cadastrar produtos

        public void Cadastrar(Produto obj)
        {
            try
            {
                string sql = @"insert into produto (descricao, quantidade, fk_forid, preco) values (@descricao, @quantidade, @fk_for_id, @preco)";


                //2 passo - organizar o sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@descricao", obj.descricao);
                cmd.Parameters.AddWithValue("@quantidade", obj.quantidade);


                cmd.Parameters.AddWithValue("@fk_for_id", obj.fk_fornecedor);
                cmd.Parameters.AddWithValue("@preco", obj.preco);


                conexao.Open();

                cmd.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion



        #region Método Alterar produto

        public void alterar(Produto obj)
        {
            try
            {
                string sql = @"update produto set descricao = @descricao, quantidade = @quantidade, fk_forid = @fk_for_id, preco = @ preco where id_produto = @id";


                //2 passo - organizar o sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@descricao", obj.descricao);
                cmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                cmd.Parameters.AddWithValue("@fk_for_id", obj.fk_fornecedor);
                cmd.Parameters.AddWithValue("preco", obj.preco);


                cmd.Parameters.AddWithValue("@id", obj.id_produto);

                conexao.Open();

                cmd.ExecuteNonQuery();

                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Produto alterado com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }


        }
        #endregion



        #region Método para excluir produto

        public void excluir(Produto obj)
        {
            try
            {
                string sql = @"delete from produto where id_produto = @id";


                //2 passo - organizar o sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.id_produto);

                conexao.Open();

                cmd.ExecuteNonQuery();

                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Produto excluído com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }


        }
        #endregion



        #region Método Listar Produtos
        public DataTable ListarTodosProdutos()
        {

            //1 passo - comando sql com inner join para alterar visualização dos campos e unir as duas tabelas
            string sql = @"select p.id_produto 'Código', p.descricao 'Descrição', p.quantidade 'Quantidade',p.preco 'Preço', f.nome 'Fornecedor'
                           from produto as p join fornecedor as f
                            on (p.fk_forid = f.id_fornecedor)";

            //2 passo - organizar o sql
            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            //3 passo - abcmdrir a conexao e executar o comando                
            conexao.Open();
            cmd.ExecuteNonQuery();

            //4 passo - criar o MySQLDataAdapter
            DataTable tabelaProduto = new DataTable();

            //5 passo - criar o DataTable
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(tabelaProduto);

            //fechar conexão
            conexao.Close();

            //Retornar o DataTable com os dados
            return tabelaProduto;

        }

        #endregion
    }

}
