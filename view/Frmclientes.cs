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
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void Frmclientes_Activated(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dgvClientes.DataSource = dao.ListarTodosClientes();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente obj = new Cliente();

                obj.nome = txbNome.Text;
                obj.email = txbEmail.Text;
                obj.senha = txbSenha.Text;
                obj.sexo = cbSexo.Text;

                ClienteDAO dao = new ClienteDAO();

                dao.Cadastrar(obj);

                //atualiza o datagridview
                dgvClientes.DataSource = dao.ListarTodosClientes();

            }
            catch (Exception erro)

            {
                MessageBox.Show("Aconteceu um erro" + erro);
            }

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            //atualiza o datagridview
            dgvClientes.DataSource = dao.ListarTodosClientes();
   
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.nome = txbNome.Text;
            obj.email = txbEmail.Text;
            obj.sexo = cbSexo.Text;
            obj.senha = txbSenha.Text;

            obj.id = int.Parse(txbId.Text);
            

            ClienteDAO dao = new ClienteDAO();

            dao.alterar(obj);

            //atualiza o datagridview
            dgvClientes.DataSource = dao.ListarTodosClientes();


        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbId.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txbNome.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txbEmail.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txbSenha.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            cbSexo.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.id = int.Parse(txbId.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.excluir(obj);
            dgvClientes.DataSource = dao.ListarTodosClientes();
        }
    }
}
