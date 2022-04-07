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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }


        #region Método Cadastrar Cliente

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            //receber os dados dos campos
            obj.nome = txbNome.Text;
            obj.email = txbEmail.Text;
            obj.senha = txbSenha.Text;
            obj.sexo = cbSexo.Text;
            obj.nivel_acesso = cbNivel_Acesso.Text;

            // criar o objeto da classe clienteDAO

            ClienteDAO dao = new ClienteDAO();
            dao.Cadastrar(obj);

            //atualiza o datagridview
            dgvCliente.DataSource = dao.ListarTodosClientes();
        }

        #endregion

       
        #region Listar todos os clientes
        private void frmClientes_Load(object sender, EventArgs e)
        {
            //implementando método listartodosclientes
            ClienteDAO dao = new ClienteDAO();
            dgvCliente.DataSource = dao.ListarTodosClientes();


        }

        #endregion


        #region Carregando dados do datagridview para os combobox
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Carregando os dados do datagridview para os textbox clicando no item do datagridview
            txbId.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txbNome.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txbEmail.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txbSenha.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            cbSexo.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            cbNivel_Acesso.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
        }

        #endregion


        #region Método excluir Cliente
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.id = int.Parse(txbId.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.excluir(obj);
            dgvCliente.DataSource = dao.ListarTodosClientes();
        }
        #endregion


        #region Método Alterar Cliente
        private void BtnAlterarCliente_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            //receber os dados dos campos
            obj.nome = txbNome.Text;
            obj.email = txbEmail.Text;
            obj.senha = txbSenha.Text;
            obj.sexo = cbSexo.Text;
            obj.nivel_acesso = cbNivel_Acesso.Text;

            obj.id = int.Parse(txbId.Text);

            // criar o objeto da classe clienteDAO

            ClienteDAO dao = new ClienteDAO();
            dao.alterar(obj);

            //atualiza o datagridview
            dgvCliente.DataSource = dao.ListarTodosClientes();
        }
        #endregion

        #region Método buscar cliente por nome


        #endregion

        private void btnConsultarClienteNome_Click(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            string nome = txbPesquisa.Text;

            dgvConsultaCliente.DataSource = dao.ConsultarClientePorNome(nome);

            if (dgvConsultaCliente.Rows.Count <= 0) 
            {
                MessageBox.Show("Nenhum Cliente encontrado!");
                dgvConsultaCliente.DataSource = dao.ListarTodosClientes();
            }
        }
    }
}
