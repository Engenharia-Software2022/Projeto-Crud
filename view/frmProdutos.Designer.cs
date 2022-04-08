namespace ProjetoDS.view
{
    partial class frmProdutos
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
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageConsultaProduto = new System.Windows.Forms.TabPage();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txPesquisaProduto = new System.Windows.Forms.TextBox();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.cbFiltroProduto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.ExcluirProduto = new System.Windows.Forms.Button();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabProdutos.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageConsultaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabPageCadastro);
            this.tabProdutos.Controls.Add(this.tabPageConsultaProduto);
            this.tabProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProdutos.Location = new System.Drawing.Point(12, 50);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(851, 341);
            this.tabProdutos.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.groupBox1);
            this.tabPageCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 29);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(843, 308);
            this.tabPageCadastro.TabIndex = 0;
            this.tabPageCadastro.Text = "Cadastro Produtos";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbPreco);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbDescricao);
            this.groupBox1.Controls.Add(this.txbQuantidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbFornecedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 125);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // txbPreco
            // 
            this.txbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPreco.Location = new System.Drawing.Point(621, 93);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(78, 26);
            this.txbPreco.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "Preço(R$):";
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(111, 25);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(65, 26);
            this.txbId.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 85;
            this.label4.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 83;
            this.label2.Text = "Descrição";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricao.Location = new System.Drawing.Point(111, 59);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(407, 26);
            this.txbDescricao.TabIndex = 80;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(621, 59);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(78, 26);
            this.txbQuantidade.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Quantidade";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(111, 91);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(282, 28);
            this.cbFornecedor.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "Fornecedor";
            // 
            // tabPageConsultaProduto
            // 
            this.tabPageConsultaProduto.Controls.Add(this.dgvProduto);
            this.tabPageConsultaProduto.Controls.Add(this.groupBox2);
            this.tabPageConsultaProduto.Location = new System.Drawing.Point(4, 29);
            this.tabPageConsultaProduto.Name = "tabPageConsultaProduto";
            this.tabPageConsultaProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultaProduto.Size = new System.Drawing.Size(843, 332);
            this.tabPageConsultaProduto.TabIndex = 1;
            this.tabPageConsultaProduto.Text = "Consulta Produtos";
            this.tabPageConsultaProduto.UseVisualStyleBackColor = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(16, 158);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(811, 150);
            this.dgvProduto.TabIndex = 92;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txPesquisaProduto);
            this.groupBox2.Controls.Add(this.btnBuscarProduto);
            this.groupBox2.Controls.Add(this.cbFiltroProduto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Nome);
            this.groupBox2.Location = new System.Drawing.Point(14, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 116);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // txPesquisaProduto
            // 
            this.txPesquisaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPesquisaProduto.Location = new System.Drawing.Point(104, 53);
            this.txPesquisaProduto.Name = "txPesquisaProduto";
            this.txPesquisaProduto.Size = new System.Drawing.Size(317, 26);
            this.txPesquisaProduto.TabIndex = 81;
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBuscarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProduto.Location = new System.Drawing.Point(690, 48);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(110, 40);
            this.btnBuscarProduto.TabIndex = 4;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.UseVisualStyleBackColor = false;
            // 
            // cbFiltroProduto
            // 
            this.cbFiltroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltroProduto.FormattingEnabled = true;
            this.cbFiltroProduto.Location = new System.Drawing.Point(496, 54);
            this.cbFiltroProduto.Name = "cbFiltroProduto";
            this.cbFiltroProduto.Size = new System.Drawing.Size(182, 28);
            this.cbFiltroProduto.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label8.Location = new System.Drawing.Point(444, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 90;
            this.label8.Text = "Filtro:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.SlateGray;
            this.Nome.Location = new System.Drawing.Point(22, 56);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(78, 20);
            this.Nome.TabIndex = 87;
            this.Nome.Text = "Pesquisa:";
            // 
            // ExcluirProduto
            // 
            this.ExcluirProduto.BackColor = System.Drawing.Color.LightSlateGray;
            this.ExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcluirProduto.ForeColor = System.Drawing.Color.White;
            this.ExcluirProduto.Location = new System.Drawing.Point(495, 397);
            this.ExcluirProduto.Name = "ExcluirProduto";
            this.ExcluirProduto.Size = new System.Drawing.Size(120, 50);
            this.ExcluirProduto.TabIndex = 3;
            this.ExcluirProduto.Text = "Excluir";
            this.ExcluirProduto.UseVisualStyleBackColor = false;
            this.ExcluirProduto.Click += new System.EventHandler(this.ExcluirProduto_Click);
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAlterarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarProduto.ForeColor = System.Drawing.Color.White;
            this.btnAlterarProduto.Location = new System.Drawing.Point(332, 397);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(120, 50);
            this.btnAlterarProduto.TabIndex = 2;
            this.btnAlterarProduto.Text = "Alterar";
            this.btnAlterarProduto.UseVisualStyleBackColor = false;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(166, 397);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(120, 50);
            this.btnCadastrarProduto.TabIndex = 1;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 33);
            this.panel1.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 16);
            this.label6.TabIndex = 88;
            this.label6.Text = "Sistema: Produtos | Consulta";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(855, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(42, 25);
            this.guna2ControlBox1.TabIndex = 89;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(807, 4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(42, 25);
            this.guna2ControlBox2.TabIndex = 90;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.ExcluirProduto);
            this.Controls.Add(this.btnAlterarProduto);
            this.Controls.Add(this.btnCadastrarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.tabProdutos.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageConsultaProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabPageCadastro;
        private System.Windows.Forms.TabPage tabPageConsultaProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.Button ExcluirProduto;
        private System.Windows.Forms.TextBox txPesquisaProduto;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.ComboBox cbFiltroProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}