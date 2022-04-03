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

        private void txbId_TextChanged(object sender, EventArgs e)
        {

        }
        //Lista dados do fornecedor no combobox
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            cbFornecedor.DataSource = dao.ListarTodosFornecedores();

            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id_fornecedor";

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txbDescricao.Text;
            obj.quantidade = int.Parse(txbQuantidade.Text);

            //Pegando a chave estrangeira do combobox fornecedor
            obj.fk_fornecedor = int.Parse(cbFornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();
            dao.Cadastrar(obj);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txbDescricao.Text;
            obj.quantidade = int.Parse(txbQuantidade.Text);

            //Pegando a chave estrangeira do combobox fornecedor
            obj.fk_fornecedor = int.Parse(cbFornecedor.SelectedValue.ToString());

            obj.id_produto = int.Parse(txbId.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.alterar(obj);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            
            obj.id_produto = int.Parse(txbId.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.excluir(obj);
        }
    }
}
