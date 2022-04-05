namespace ProjetoDS.view
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_cliente = new System.Windows.Forms.ToolStripMenuItem();
            this._cadastroDeClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_fornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this._cadastroDeFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this._cadastroDeProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this._consultaEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this._consultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cliente,
            this.menu_fornecedor,
            this.menu_produtos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_cliente
            // 
            this.menu_cliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cadastroDeClientes,
            this._consultaClientes});
            this.menu_cliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_cliente.Name = "menu_cliente";
            this.menu_cliente.Size = new System.Drawing.Size(65, 21);
            this.menu_cliente.Text = "Clientes";
            // 
            // _cadastroDeClientes
            // 
            this._cadastroDeClientes.Name = "_cadastroDeClientes";
            this._cadastroDeClientes.Size = new System.Drawing.Size(197, 22);
            this._cadastroDeClientes.Text = "Cadastro de Clientes";
            this._cadastroDeClientes.Click += new System.EventHandler(this._cadastroDeClientes_Click);
            // 
            // menu_fornecedor
            // 
            this.menu_fornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cadastroDeFornecedores});
            this.menu_fornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_fornecedor.Name = "menu_fornecedor";
            this.menu_fornecedor.Size = new System.Drawing.Size(100, 21);
            this.menu_fornecedor.Text = "Fornecedores";
            // 
            // _cadastroDeFornecedores
            // 
            this._cadastroDeFornecedores.Name = "_cadastroDeFornecedores";
            this._cadastroDeFornecedores.Size = new System.Drawing.Size(232, 22);
            this._cadastroDeFornecedores.Text = "Cadastro de Fornecedores";
            // 
            // menu_produtos
            // 
            this.menu_produtos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cadastroDeProdutos,
            this._consultaEstoque});
            this.menu_produtos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_produtos.Name = "menu_produtos";
            this.menu_produtos.Size = new System.Drawing.Size(73, 21);
            this.menu_produtos.Text = "Produtos";
            // 
            // _cadastroDeProdutos
            // 
            this._cadastroDeProdutos.Name = "_cadastroDeProdutos";
            this._cadastroDeProdutos.Size = new System.Drawing.Size(205, 22);
            this._cadastroDeProdutos.Text = "Cadastro de Produtos";
            // 
            // _consultaEstoque
            // 
            this._consultaEstoque.Name = "_consultaEstoque";
            this._consultaEstoque.Size = new System.Drawing.Size(205, 22);
            this._consultaEstoque.Text = "Consulta Estoque";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(747, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(38, 25);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // _consultaClientes
            // 
            this._consultaClientes.Name = "_consultaClientes";
            this._consultaClientes.Size = new System.Drawing.Size(197, 22);
            this._consultaClientes.Text = "Consulta Clientes";
            this._consultaClientes.Click += new System.EventHandler(this._consultaClientes_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem menu_cliente;
        public System.Windows.Forms.ToolStripMenuItem menu_fornecedor;
        public System.Windows.Forms.ToolStripMenuItem menu_produtos;
        public System.Windows.Forms.ToolStripMenuItem _cadastroDeClientes;
        public System.Windows.Forms.ToolStripMenuItem _cadastroDeFornecedores;
        public System.Windows.Forms.ToolStripMenuItem _cadastroDeProdutos;
        public System.Windows.Forms.ToolStripMenuItem _consultaEstoque;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public System.Windows.Forms.ToolStripMenuItem _consultaClientes;
    }
}