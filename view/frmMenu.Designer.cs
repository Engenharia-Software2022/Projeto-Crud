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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this._menuTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.OliveDrab;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cliente,
            this.menu_fornecedor,
            this.menu_produtos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_cliente
            // 
            this.menu_cliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cadastroDeClientes,
            this._menuTrocarUsuario});
            this.menu_cliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_cliente.ForeColor = System.Drawing.Color.White;
            this.menu_cliente.Name = "menu_cliente";
            this.menu_cliente.Size = new System.Drawing.Size(65, 21);
            this.menu_cliente.Text = "Clientes";
            // 
            // _cadastroDeClientes
            // 
            this._cadastroDeClientes.ForeColor = System.Drawing.Color.Black;
            this._cadastroDeClientes.Name = "_cadastroDeClientes";
            this._cadastroDeClientes.Size = new System.Drawing.Size(184, 22);
            this._cadastroDeClientes.Text = "Cadastro/Consulta";
            this._cadastroDeClientes.Click += new System.EventHandler(this._cadastroDeClientes_Click);
            // 
            // menu_fornecedor
            // 
            this.menu_fornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cadastroDeFornecedores});
            this.menu_fornecedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_fornecedor.ForeColor = System.Drawing.Color.White;
            this.menu_fornecedor.Name = "menu_fornecedor";
            this.menu_fornecedor.Size = new System.Drawing.Size(100, 21);
            this.menu_fornecedor.Text = "Fornecedores";
            // 
            // _cadastroDeFornecedores
            // 
            this._cadastroDeFornecedores.Name = "_cadastroDeFornecedores";
            this._cadastroDeFornecedores.Size = new System.Drawing.Size(184, 22);
            this._cadastroDeFornecedores.Text = "Cadastro/Consulta";
            this._cadastroDeFornecedores.Click += new System.EventHandler(this._cadastroDeFornecedores_Click);
            // 
            // menu_produtos
            // 
            this.menu_produtos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cadastroDeProdutos});
            this.menu_produtos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_produtos.ForeColor = System.Drawing.Color.White;
            this.menu_produtos.Name = "menu_produtos";
            this.menu_produtos.Size = new System.Drawing.Size(73, 21);
            this.menu_produtos.Text = "Produtos";
            // 
            // _cadastroDeProdutos
            // 
            this._cadastroDeProdutos.Name = "_cadastroDeProdutos";
            this._cadastroDeProdutos.Size = new System.Drawing.Size(180, 22);
            this._cadastroDeProdutos.Text = "Cadastro/Colsulta";
            this._cadastroDeProdutos.Click += new System.EventHandler(this._cadastroDeProdutos_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.OliveDrab;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(906, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 22);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 618);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 32);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Administrador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marcos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(856, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Versão: 1.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(763, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "EngeSoftware";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.OliveDrab;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(868, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(32, 22);
            this.guna2ControlBox2.TabIndex = 4;
            // 
            // _menuTrocarUsuario
            // 
            this._menuTrocarUsuario.Name = "_menuTrocarUsuario";
            this._menuTrocarUsuario.Size = new System.Drawing.Size(184, 22);
            this._menuTrocarUsuario.Text = "Trocar Usuario";
            this._menuTrocarUsuario.Click += new System.EventHandler(this.trocarUsuarioToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ToolStripMenuItem _menuTrocarUsuario;
    }
}