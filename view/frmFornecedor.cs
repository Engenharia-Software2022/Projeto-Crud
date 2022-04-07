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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            //receber os dados dos campos
            obj.nome = txbNome.Text;
            obj.cnpj = mtbCnpj.Text;
            obj.endereco = txbEndereco.Text;
            obj.bairro = txbBairro.Text;
            obj.cidade = txbCidade.Text;
            obj.numero = int.Parse(txbNumero.Text);
            obj.telefone = mtbTelefone.Text;
            obj.email = txbEmail.Text;
           

            // criar o objeto da classe clienteDAO

            FornecedorDAO dao = new FornecedorDAO();
            dao.Cadastrar(obj);

            //atualiza o datagridview
            dgvFornecedor.DataSource = dao.ListarTodosFornecedores();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            dgvFornecedor.DataSource = dao.ListarTodosFornecedores();
        }

        private void BtnAlterarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            //receber os dados dos campos
            obj.nome = txbNome.Text;
            obj.cnpj = mtbCnpj.Text;
            obj.endereco = txbEndereco.Text;
            obj.bairro = txbBairro.Text;
            obj.cidade = txbCidade.Text;
            obj.numero = int.Parse(txbNumero.Text);
            obj.telefone = mtbTelefone.Text;
            obj.email = txbEmail.Text;

            obj.id = int.Parse(txbId.Text);


            // criar o objeto da classe clienteDAO

            FornecedorDAO dao = new FornecedorDAO();
            dao.alterar(obj);

            //atualiza o datagridview
            dgvFornecedor.DataSource = dao.ListarTodosFornecedores();
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Carregando os dados do datagridview para os textbox clicando no item do datagridview
            txbId.Text = dgvFornecedor.CurrentRow.Cells[0].Value.ToString();
            txbNome.Text = dgvFornecedor.CurrentRow.Cells[1].Value.ToString();
            mtbCnpj.Text = dgvFornecedor.CurrentRow.Cells[2].Value.ToString();
            txbEndereco.Text = dgvFornecedor.CurrentRow.Cells[3].Value.ToString();
            txbBairro.Text = dgvFornecedor.CurrentRow.Cells[4].Value.ToString();
            txbCidade.Text = dgvFornecedor.CurrentRow.Cells[5].Value.ToString();
            txbNumero.Text = dgvFornecedor.CurrentRow.Cells[6].Value.ToString();
            mtbTelefone.Text = dgvFornecedor.CurrentRow.Cells[7].Value.ToString();
            txbEmail.Text = dgvFornecedor.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.id = int.Parse(txbId.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.excluir(obj);
            dgvFornecedor.DataSource = dao.ListarTodosFornecedores();
        }
    }
}
