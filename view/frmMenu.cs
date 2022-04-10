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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void _consultaClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void _cadastroDeClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void _cadastroDeFornecedores_Click(object sender, EventArgs e)
        {
            frmFornecedor frm = new frmFornecedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void _cadastroDeProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void trocarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();

            dao.EfetuarLogoff();
            this.Close();

            
        }
    }
}
