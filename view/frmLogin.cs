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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email, senha;

            email = txbEmail.Text;
            senha = txbSenha.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.EfetuaLogin(email, senha);
        }
    }
}
