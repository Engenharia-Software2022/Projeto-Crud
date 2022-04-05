using ProjetoDS.dao;
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
    public partial class frmConsultaClientes : Form
    {
        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            string nome = txbPesquisarNome.Text;
            dgvClientes.DataSource = dao.BuscarClientePorNome(nome);

            if (dgvClientes.Rows.Count == 0) 
            {
                MessageBox.Show("Nenhum Cliente encontrado! ");

                //listar todos os clientes caso nao encontre cliente com o nome buscado
                dgvClientes.DataSource = dao.ListarTodosClientes ();
            }


        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dgvClientes.DataSource = dao.ListarTodosClientes();
        }
    }
}
