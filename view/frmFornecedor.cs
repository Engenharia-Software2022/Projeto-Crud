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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.nome = txbNome.Text;
            obj.cnpj = txbCnpj.Text;
            obj.endereco = txbEndereco.Text;
            obj.bairro = txbBairro.Text;
            obj.cidade = txbCidade.Text;
            obj.numero = int.Parse(txbNumero.Text);
            obj.telefone = txbTelefone.Text;
            obj.email = txbEmail.Text;

            FornecedorDAO dao = new FornecedorDAO();
            dao.Cadastrar(obj);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.nome = txbNome.Text;
            obj.cnpj = txbCnpj.Text;
            obj.endereco = txbEndereco.Text;
            obj.bairro = txbBairro.Text;
            obj.cidade = txbCidade.Text;
            obj.numero = int.Parse(txbNumero.Text);
            obj.telefone = txbTelefone.Text;
            obj.email = txbEmail.Text;

            FornecedorDAO dao = new FornecedorDAO();
            dao.alterar(obj);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();


            obj.id = int.Parse(txbId.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.excluir(obj);
        }
    }
    
}
