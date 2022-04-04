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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.txbId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbCidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbBairro = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbEndereco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbCnpj = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTelefone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbNumero = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BorderRadius = 20;
            this.btnExcluir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcluir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcluir.FillColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(433, 395);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 45);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BorderRadius = 20;
            this.btnAlterar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAlterar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAlterar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAlterar.FillColor = System.Drawing.Color.IndianRed;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(260, 395);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(150, 45);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientes.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientes.Location = new System.Drawing.Point(39, 207);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(787, 169);
            this.dgvClientes.TabIndex = 27;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClientes.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvClientes.ThemeStyle.ReadOnly = false;
            this.dgvClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClientes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BorderRadius = 20;
            this.btnCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrar.FillColor = System.Drawing.Color.Teal;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(77, 395);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(150, 45);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbId
            // 
            this.txbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbId.DefaultText = "";
            this.txbId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbId.Location = new System.Drawing.Point(45, 56);
            this.txbId.Name = "txbId";
            this.txbId.PasswordChar = '\0';
            this.txbId.PlaceholderText = "ID";
            this.txbId.ReadOnly = true;
            this.txbId.SelectedText = "";
            this.txbId.Size = new System.Drawing.Size(69, 36);
            this.txbId.TabIndex = 25;
            // 
            // txbNome
            // 
            this.txbNome.Animated = true;
            this.txbNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNome.DefaultText = "";
            this.txbNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNome.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txbNome.Location = new System.Drawing.Point(45, 98);
            this.txbNome.Name = "txbNome";
            this.txbNome.PasswordChar = '\0';
            this.txbNome.PlaceholderText = "Nome";
            this.txbNome.SelectedText = "";
            this.txbNome.Size = new System.Drawing.Size(180, 36);
            this.txbNome.TabIndex = 21;
            // 
            // txbCidade
            // 
            this.txbCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCidade.DefaultText = "";
            this.txbCidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbCidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCidade.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txbCidade.Location = new System.Drawing.Point(679, 149);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.PasswordChar = '\0';
            this.txbCidade.PlaceholderText = "Cidade";
            this.txbCidade.SelectedText = "";
            this.txbCidade.Size = new System.Drawing.Size(147, 36);
            this.txbCidade.TabIndex = 33;
            // 
            // txbBairro
            // 
            this.txbBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbBairro.DefaultText = "";
            this.txbBairro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbBairro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbBairro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBairro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbBairro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBairro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbBairro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbBairro.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txbBairro.Location = new System.Drawing.Point(464, 149);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.PasswordChar = '\0';
            this.txbBairro.PlaceholderText = "Bairro";
            this.txbBairro.SelectedText = "";
            this.txbBairro.Size = new System.Drawing.Size(180, 36);
            this.txbBairro.TabIndex = 32;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEndereco.DefaultText = "";
            this.txbEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEndereco.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbEndereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEndereco.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txbEndereco.Location = new System.Drawing.Point(464, 98);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.PasswordChar = '\0';
            this.txbEndereco.PlaceholderText = "Endereço";
            this.txbEndereco.SelectedText = "";
            this.txbEndereco.Size = new System.Drawing.Size(180, 36);
            this.txbEndereco.TabIndex = 31;
            // 
            // txbCnpj
            // 
            this.txbCnpj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCnpj.DefaultText = "";
            this.txbCnpj.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCnpj.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCnpj.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCnpj.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCnpj.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCnpj.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbCnpj.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCnpj.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txbCnpj.Location = new System.Drawing.Point(45, 149);
            this.txbCnpj.Name = "txbCnpj";
            this.txbCnpj.PasswordChar = '\0';
            this.txbCnpj.PlaceholderText = "CNPJ";
            this.txbCnpj.SelectedText = "";
            this.txbCnpj.Size = new System.Drawing.Size(170, 36);
            this.txbCnpj.TabIndex = 30;
            // 
            // txbEmail
            // 
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "";
            this.txbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txbEmail.Location = new System.Drawing.Point(260, 98);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "Email";
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(180, 36);
            this.txbEmail.TabIndex = 22;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTelefone.DefaultText = "";
            this.txbTelefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTelefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTelefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTelefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTelefone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTelefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTelefone.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txbTelefone.Location = new System.Drawing.Point(260, 149);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.PasswordChar = '\0';
            this.txbTelefone.PlaceholderText = "Telefone";
            this.txbTelefone.SelectedText = "";
            this.txbTelefone.Size = new System.Drawing.Size(180, 36);
            this.txbTelefone.TabIndex = 34;
            // 
            // txbNumero
            // 
            this.txbNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNumero.DefaultText = "";
            this.txbNumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNumero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbNumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNumero.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txbNumero.Location = new System.Drawing.Point(679, 98);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.PasswordChar = '\0';
            this.txbNumero.PlaceholderText = "Número";
            this.txbNumero.SelectedText = "";
            this.txbNumero.Size = new System.Drawing.Size(104, 36);
            this.txbNumero.TabIndex = 35;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 483);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbCnpj);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnAlterar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientes;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Guna.UI2.WinForms.Guna2TextBox txbId;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private Guna.UI2.WinForms.Guna2TextBox txbNome;
        private Guna.UI2.WinForms.Guna2TextBox txbCnpj;
        private Guna.UI2.WinForms.Guna2TextBox txbEndereco;
        private Guna.UI2.WinForms.Guna2TextBox txbBairro;
        private Guna.UI2.WinForms.Guna2TextBox txbCidade;
        private Guna.UI2.WinForms.Guna2TextBox txbTelefone;
        private Guna.UI2.WinForms.Guna2TextBox txbNumero;
    }
}