using MySql.Data.MySqlClient;
using ProjetoDS.conexao;
using ProjetoDS.model;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoDS.dao
{
    public class ClienteDAO
    {
        MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = ConnectionFactory.getConnection();
        }

        //metodos sql
        public void Cadastrar(Cliente obj)
        {
            try
            {
                string sql = @"insert into cliente (nome, email, senha, sexo) values (@nome,@email,@senha,@sexo)";


                //2 passo - organizar o sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@senha", obj.senha);
                cmd.Parameters.AddWithValue("@sexo", obj.sexo);

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


        //metodos sql
        public void alterar(Cliente obj)
        {
            try
            {
                string sql = @"update cliente set nome = @nome, email=@email, senha=@senha, sexo=@sexo where id_cliente = @id";


                //2 passo - organizar o sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", obj.nome);
                cmd.Parameters.AddWithValue("@email", obj.email);
                cmd.Parameters.AddWithValue("@senha", obj.senha);
                cmd.Parameters.AddWithValue("@sexo", obj.sexo);

                cmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();

                cmd.ExecuteNonQuery();

                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Cliente alterado com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }


        }

        //metodos sql
        public void excluir(Cliente obj)
        {
            try
            {
                string sql = @"delete from cliente where id_cliente = @id";

                //2 passo - organizar o sql
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();



                cmd.ExecuteNonQuery();
                //4 passo - fechar a conexao
                conexao.Close();

                MessageBox.Show("Cliente excluído com sucesso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }

        }


        //Metodo lIstar clientes


        public DataTable ListarTodosClientes()
        {

            //1 passo - comando sql
            string sql = @"select * from cliente";

            //2 passo - organizar o sql
            MySqlCommand cmd = new MySqlCommand(sql, conexao);

            //3 passo - abcmdrir a conexao e executar o comando                
            conexao.Open();
            cmd.ExecuteNonQuery();

            //4 passo - criar o MySQLDataAdapter
            DataTable tabelaCliente = new DataTable();

            //5 passo - criar o DataTable
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(tabelaCliente);

            //fechar conexão
            conexao.Close();

            //Retornar o DataTable com os dados
            return tabelaCliente;

        }
    }
}
