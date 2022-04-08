namespace ProjetoDS.view
{
    partial class frmFornecedor
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
            this.tabFornecedor = new System.Windows.Forms.TabControl();
            this.tabPageCadastroFornecedor = new System.Windows.Forms.TabPage();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnExcluirFornecedor = new System.Windows.Forms.Button();
            this.BtnAlterarFornecedor = new System.Windows.Forms.Button();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvConsultaFornecedor = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabFornecedor.SuspendLayout();
            this.tabPageCadastroFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFornecedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFornecedor
            // 
            this.tabFornecedor.Controls.Add(this.tabPageCadastroFornecedor);
            this.tabFornecedor.Controls.Add(this.tabPage2);
            this.tabFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFornecedor.Location = new System.Drawing.Point(12, 46);
            this.tabFornecedor.Name = "tabFornecedor";
            this.tabFornecedor.SelectedIndex = 0;
            this.tabFornecedor.Size = new System.Drawing.Size(865, 434);
            this.tabFornecedor.TabIndex = 0;
            // 
            // tabPageCadastroFornecedor
            // 
            this.tabPageCadastroFornecedor.Controls.Add(this.mtbTelefone);
            this.tabPageCadastroFornecedor.Controls.Add(this.mtbCnpj);
            this.tabPageCadastroFornecedor.Controls.Add(this.label2);
            this.tabPageCadastroFornecedor.Controls.Add(this.label10);
            this.tabPageCadastroFornecedor.Controls.Add(this.label9);
            this.tabPageCadastroFornecedor.Controls.Add(this.txbNumero);
            this.tabPageCadastroFornecedor.Controls.Add(this.label8);
            this.tabPageCadastroFornecedor.Controls.Add(this.txbCidade);
            this.tabPageCadastroFornecedor.Controls.Add(this.label7);
            this.tabPageCadastroFornecedor.Controls.Add(this.txbBairro);
            this.tabPageCadastroFornecedor.Controls.Add(this.label6);
            this.tabPageCadastroFornecedor.Controls.Add(this.txbEndereco);
            this.tabPageCadastroFornecedor.Controls.Add(this.label5);
            this.tabPageCadastroFornecedor.Controls.Add(this.label1);
            this.tabPageCadastroFornecedor.Controls.Add(this.Nome);
            this.tabPageCadastroFornecedor.Controls.Add(this.txbId);
            this.tabPageCadastroFornecedor.Controls.Add(this.txbEmail);
            this.tabPageCadastroFornecedor.Controls.Add(this.txbNome);
            this.tabPageCadastroFornecedor.Controls.Add(this.btnExcluirFornecedor);
            this.tabPageCadastroFornecedor.Controls.Add(this.BtnAlterarFornecedor);
            this.tabPageCadastroFornecedor.Controls.Add(this.btnCadastrarFornecedor);
            this.tabPageCadastroFornecedor.Controls.Add(this.dgvFornecedor);
            this.tabPageCadastroFornecedor.Location = new System.Drawing.Point(4, 25);
            this.tabPageCadastroFornecedor.Name = "tabPageCadastroFornecedor";
            this.tabPageCadastroFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastroFornecedor.Size = new System.Drawing.Size(857, 405);
            this.tabPageCadastroFornecedor.TabIndex = 0;
            this.tabPageCadastroFornecedor.Text = "Cadastro Fornecedor";
            this.tabPageCadastroFornecedor.UseVisualStyleBackColor = true;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(436, 139);
            this.mtbTelefone.Mask = "(00)00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(185, 26);
            this.mtbTelefone.TabIndex = 73;
            // 
            // mtbCnpj
            // 
            this.mtbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCnpj.Location = new System.Drawing.Point(419, 61);
            this.mtbCnpj.Mask = "00.000.000/0000-00";
            this.mtbCnpj.Name = "mtbCnpj";
            this.mtbCnpj.Size = new System.Drawing.Size(185, 26);
            this.mtbCnpj.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Código";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 70;
            this.label10.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Numero";
            // 
            // txbNumero
            // 
            this.txbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumero.Location = new System.Drawing.Point(675, 98);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(161, 26);
            this.txbNumero.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "Cidade";
            // 
            // txbCidade
            // 
            this.txbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCidade.Location = new System.Drawing.Point(431, 100);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(173, 26);
            this.txbCidade.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Bairro";
            // 
            // txbBairro
            // 
            this.txbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBairro.Location = new System.Drawing.Point(98, 102);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(275, 26);
            this.txbBairro.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "End";
            // 
            // txbEndereco
            // 
            this.txbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEndereco.Location = new System.Drawing.Point(649, 60);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(187, 26);
            this.txbEndereco.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Cnpj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Email";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(53, 67);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(44, 16);
            this.Nome.TabIndex = 54;
            this.Nome.Text = "Nome";
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(101, 28);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(53, 26);
            this.txbId.TabIndex = 51;
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(99, 139);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(243, 26);
            this.txbEmail.TabIndex = 49;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(99, 60);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(274, 26);
            this.txbNome.TabIndex = 48;
            // 
            // btnExcluirFornecedor
            // 
            this.btnExcluirFornecedor.BackColor = System.Drawing.Color.SlateGray;
            this.btnExcluirFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnExcluirFornecedor.Location = new System.Drawing.Point(464, 347);
            this.btnExcluirFornecedor.Name = "btnExcluirFornecedor";
            this.btnExcluirFornecedor.Size = new System.Drawing.Size(120, 40);
            this.btnExcluirFornecedor.TabIndex = 47;
            this.btnExcluirFornecedor.Text = "Excluir";
            this.btnExcluirFornecedor.UseVisualStyleBackColor = false;
            this.btnExcluirFornecedor.Click += new System.EventHandler(this.btnExcluirFornecedor_Click);
            // 
            // BtnAlterarFornecedor
            // 
            this.BtnAlterarFornecedor.BackColor = System.Drawing.Color.SlateGray;
            this.BtnAlterarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterarFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarFornecedor.Location = new System.Drawing.Point(324, 347);
            this.BtnAlterarFornecedor.Name = "BtnAlterarFornecedor";
            this.BtnAlterarFornecedor.Size = new System.Drawing.Size(120, 40);
            this.BtnAlterarFornecedor.TabIndex = 46;
            this.BtnAlterarFornecedor.Text = "Alterar";
            this.BtnAlterarFornecedor.UseVisualStyleBackColor = false;
            this.BtnAlterarFornecedor.Click += new System.EventHandler(this.BtnAlterarFornecedor_Click);
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.BackColor = System.Drawing.Color.SlateGray;
            this.btnCadastrarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(168, 347);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(120, 40);
            this.btnCadastrarFornecedor.TabIndex = 45;
            this.btnCadastrarFornecedor.Text = "Cadastrar";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.btnCadastrarFornecedor_Click);
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedor.Location = new System.Drawing.Point(8, 176);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(828, 150);
            this.dgvFornecedor.TabIndex = 44;
            this.dgvFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvConsultaFornecedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(857, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta Fornecedor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaFornecedor
            // 
            this.dgvConsultaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaFornecedor.Location = new System.Drawing.Point(47, 154);
            this.dgvConsultaFornecedor.Name = "dgvConsultaFornecedor";
            this.dgvConsultaFornecedor.Size = new System.Drawing.Size(735, 150);
            this.dgvConsultaFornecedor.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 40);
            this.panel1.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(839, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(42, 25);
            this.guna2ControlBox1.TabIndex = 90;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(791, 6);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(42, 25);
            this.guna2ControlBox2.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 16);
            this.label3.TabIndex = 74;
            this.label3.Text = "Sistema: Cadastro Fornecedor | Consulta";
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFornecedor";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            this.tabFornecedor.ResumeLayout(false);
            this.tabPageCadastroFornecedor.ResumeLayout(false);
            this.tabPageCadastroFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFornecedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFornecedor;
        private System.Windows.Forms.TabPage tabPageCadastroFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnExcluirFornecedor;
        private System.Windows.Forms.Button BtnAlterarFornecedor;
        private System.Windows.Forms.Button btnCadastrarFornecedor;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCnpj;
        private System.Windows.Forms.DataGridView dgvConsultaFornecedor;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}