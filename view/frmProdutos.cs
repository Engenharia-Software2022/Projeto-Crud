using ProjetoDS.dao;
using ProjetoDS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDS.view
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            //Carregar dados da tabela fornecedor
            FornecedorDAO dao = new FornecedorDAO();
            cbFornecedor.DataSource = dao.ListarTodosFornecedores();

            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id_fornecedor";

            //Carrega o datagridvew
            ProdutoDAO produtoDAO = new ProdutoDAO();

            dgvProduto.DataSource = produtoDAO.ListarTodosProdutos();


        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.descricao = txbDescricao.Text;
            obj.quantidade = int.Parse(txbQuantidade.Text);

            //Pegando achave estrangeira do combobox de fornecedor
            obj.fk_fornecedor = int.Parse(cbFornecedor.SelectedValue.ToString());
            obj.preco = double.Parse(txbPreco.Text);


            ProdutoDAO dao = new ProdutoDAO();
            dao.Cadastrar(obj);

            //Carrega o datagridview novamente
            dgvProduto.DataSource = dao.ListarTodosProdutos();

        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.descricao = txbDescricao.Text;
            obj.quantidade = int.Parse(txbQuantidade.Text);

            //Pegando achave estrangeira do combobox de fornecedor
            obj.fk_fornecedor = int.Parse(cbFornecedor.SelectedValue.ToString());
            obj.preco= double.Parse(txbPreco.Text);

            obj.id_produto = int.Parse(txbId.Text);


            ProdutoDAO dao = new ProdutoDAO();
            dao.alterar(obj);

            //Carrega o datagridview novamente
            dgvProduto.DataSource = dao.ListarTodosProdutos();
        }

        private void ExcluirProduto_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.id_produto = int.Parse(txbId.Text);


            ProdutoDAO dao = new ProdutoDAO();
            dao.excluir(obj);

            //Carrega o datagridview novamente
            dgvProduto.DataSource = dao.ListarTodosProdutos();
        }

        
       

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvProduto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //passar o conteúdo das linhas do datagridview para os textbox
            txbId.Text = dgvProduto.CurrentRow.Cells[0].Value.ToString();
            txbDescricao.Text = dgvProduto.CurrentRow.Cells[1].Value.ToString();
            txbQuantidade.Text = dgvProduto.CurrentRow.Cells[2].Value.ToString();
            txbPreco.Text = dgvProduto.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = dgvProduto.CurrentRow.Cells[4].Value.ToString();

            tabProdutos.SelectedTab = tabPageCadastro;
        }
    }
}
