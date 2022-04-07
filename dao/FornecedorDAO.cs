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
    public class FornecedorDAO
    {
        MySqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = ConnectionFactory.getConnection();
        }

        #region Método Cadastrar Fornecedor

        public void Cadastrar(Fornecedor obj) 
        {
            try
            {
                string sql = @"insert into fornecedor (nome, cnpj, endereco, bairro, cidade, numero, telefone, email) 
                                values (@nome,@cnpj, @endereco, @bairro, @cidade, @numero, @telefone, @email)";


                //2 passo - organizar o sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                cmd.Parameters.AddWithValue("@endereco", obj.endereco);
                cmd.Parameters.AddWithValue("@bairro", obj.bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.cidade);
                cmd.Parameters.AddWithValue("@numero", obj.numero);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@email", obj.email);

                conexao.Open();

                cmd.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Fornecedor cadasrtado com sucesso!");

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu erro" + erro);
            }
        }

        #endregion


        #region Método Alterar Fornecedor

        public void alterar(Fornecedor obj)
        {
            try
            {
                string sql = @"update cliente set nome = @nome, cnpj=@cnpj, endereco=@endereco, bairro=@bairro, cidade=@cidade, 
                                numero=@numero, telefone=@telefone, email=@email where id_fornecedor = @id";

                //2 passo - organizar o sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                cmd.Parameters.AddWithValue("@endereco", obj.endereco);
                cmd.Parameters.AddWithValue("@bairro", obj.bairro);
                cmd.Parameters.AddWithValue("@cidade", obj.cidade);
                cmd.Parameters.AddWithValue("@numero", obj.numero);
                cmd.Parameters.AddWithValue("@telefone", obj.telefone);
                cmd.Parameters.AddWithValue("@email", obj.email);

                cmd.Parameters.AddWithValue("@id_fornecedor", obj.id);

                conexao.Open();

                cmd.ExecuteNonQuery();

                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Fornrcrdor alterado com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion


        #region Método Excluir Fornecedor

        public void excluir( Fornecedor obj)
        { 
            try
            {
                string sql = @"delete from fornecedor where id_fornecedor = @id";

                //2 passo - organizar o sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();

                cmd.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Fornecedor excluído com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }

        #endregion




        //colocar método listartodosfornecedores

        #region Método ListarTodosFornecedores

        public DataTable ListarTodosFornecedores()
        {

            //1 passo - comando sql
            string sql = @"select * from fornecedor";

            //2 passo - organizar o sql
            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            //3 passo - abrir a conexao e executar o comando                
            conexao.Open();
            cmd.ExecuteNonQuery();

            //4 passo - criar o MySQLDataAdapter
            DataTable tabelaFornecedor = new DataTable();

            //5 passo - criar o DataTable
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(tabelaFornecedor);

            //fechar conexão
            conexao.Close();

            //Retornar o DataTable com os dados
            return tabelaFornecedor;

        }

        #endregion

    }
}
