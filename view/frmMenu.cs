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
            frmConsultaClientes frm = new frmConsultaClientes();
            frm.Show();

        }

        private void _cadastroDeClientes_Click(object sender, EventArgs e)
        {
            Frmclientes frm = new Frmclientes();
            frm.Show();
            this.Hide();
        }
    }
}
