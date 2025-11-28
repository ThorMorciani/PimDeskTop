namespace WinFormsApp1
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            tbcMenu = new TabControl();
            tabPerfil = new TabPage();
            txtIdUser = new TextBox();
            lblIdUser = new Label();
            btnDeslogar = new Button();
            txtCargoUser = new TextBox();
            txtNomeUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabPageCadastro = new TabPage();
            btnCancel = new Button();
            button1 = new Button();
            lblId = new Label();
            txtID = new TextBox();
            btnEditar = new Button();
            cboPerfis = new ComboBox();
            lblPerfil = new Label();
            dgvUsers = new DataGridView();
            columnID = new DataGridViewTextBoxColumn();
            columnPerfil = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnEmail = new DataGridViewTextBoxColumn();
            columnAtividade = new DataGridViewButtonColumn();
            columnEditar = new DataGridViewButtonColumn();
            btnRegister = new Button();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            lblName = new Label();
            lblUser = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtUser = new TextBox();
            tbpCausasRaiz = new TabPage();
            dgvCausaRaiz = new DataGridView();
            columnIdCausaRaiz = new DataGridViewTextBoxColumn();
            columnCausaRaiz = new DataGridViewTextBoxColumn();
            columnPrioridade = new DataGridViewTextBoxColumn();
            columnStatus = new DataGridViewButtonColumn();
            tabTicket = new TabPage();
            lblAtualizadoEm = new Label();
            txtAtualizadoEm = new TextBox();
            lblCriadoEm = new Label();
            txtCriadoEm = new TextBox();
            lblAbertoPor = new Label();
            txtAbertoPor = new TextBox();
            txtTecnico = new TextBox();
            lblTecnico = new Label();
            txtCausaRaiz = new TextBox();
            lblCausaRaiz = new Label();
            txtCriticidade = new TextBox();
            lblCriticidade = new Label();
            txtSolucao = new TextBox();
            lblSolucao = new Label();
            lblDescricaoTicket = new Label();
            lblStatusTicket = new Label();
            lblIdTicket = new Label();
            txtStatus = new TextBox();
            txtDescription = new TextBox();
            txtIdTicket = new TextBox();
            dgvTickets = new DataGridView();
            columnIdTicket = new DataGridViewTextBoxColumn();
            columnCause = new DataGridViewTextBoxColumn();
            columnTicketStatus = new DataGridViewTextBoxColumn();
            columnCriticidade = new DataGridViewTextBoxColumn();
            columnTecnico = new DataGridViewTextBoxColumn();
            columnVisualizar = new DataGridViewButtonColumn();
            tbcMenu.SuspendLayout();
            tabPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tbpCausasRaiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCausaRaiz).BeginInit();
            tabTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // tbcMenu
            // 
            tbcMenu.Controls.Add(tabPerfil);
            tbcMenu.Controls.Add(tabPageCadastro);
            tbcMenu.Controls.Add(tbpCausasRaiz);
            tbcMenu.Controls.Add(tabTicket);
            tbcMenu.Location = new Point(1, 0);
            tbcMenu.Name = "tbcMenu";
            tbcMenu.SelectedIndex = 0;
            tbcMenu.Size = new Size(1342, 646);
            tbcMenu.TabIndex = 0;
            // 
            // tabPerfil
            // 
            tabPerfil.Controls.Add(txtIdUser);
            tabPerfil.Controls.Add(lblIdUser);
            tabPerfil.Controls.Add(btnDeslogar);
            tabPerfil.Controls.Add(txtCargoUser);
            tabPerfil.Controls.Add(txtNomeUser);
            tabPerfil.Controls.Add(label2);
            tabPerfil.Controls.Add(label1);
            tabPerfil.Controls.Add(pictureBox1);
            tabPerfil.Location = new Point(4, 24);
            tabPerfil.Name = "tabPerfil";
            tabPerfil.Size = new Size(1334, 618);
            tabPerfil.TabIndex = 3;
            tabPerfil.Text = "Perfil";
            tabPerfil.UseVisualStyleBackColor = true;
            tabPerfil.Click += tabPerfil_Click;
            // 
            // txtIdUser
            // 
            txtIdUser.Enabled = false;
            txtIdUser.Location = new Point(32, 215);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(171, 23);
            txtIdUser.TabIndex = 9;
            // 
            // lblIdUser
            // 
            lblIdUser.AutoSize = true;
            lblIdUser.Location = new Point(32, 197);
            lblIdUser.Name = "lblIdUser";
            lblIdUser.Size = new Size(20, 15);
            lblIdUser.TabIndex = 8;
            lblIdUser.Text = "Id:";
            // 
            // btnDeslogar
            // 
            btnDeslogar.Location = new Point(32, 378);
            btnDeslogar.Name = "btnDeslogar";
            btnDeslogar.Size = new Size(171, 23);
            btnDeslogar.TabIndex = 7;
            btnDeslogar.Text = "Deslogar";
            btnDeslogar.UseVisualStyleBackColor = true;
            btnDeslogar.Click += btnDeslogar_Click;
            // 
            // txtCargoUser
            // 
            txtCargoUser.Enabled = false;
            txtCargoUser.Location = new Point(32, 338);
            txtCargoUser.Name = "txtCargoUser";
            txtCargoUser.Size = new Size(171, 23);
            txtCargoUser.TabIndex = 6;
            // 
            // txtNomeUser
            // 
            txtNomeUser.Enabled = false;
            txtNomeUser.Location = new Point(31, 275);
            txtNomeUser.Name = "txtNomeUser";
            txtNomeUser.Size = new Size(171, 23);
            txtNomeUser.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 257);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 320);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Cargo:";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnCancel);
            tabPageCadastro.Controls.Add(button1);
            tabPageCadastro.Controls.Add(lblId);
            tabPageCadastro.Controls.Add(txtID);
            tabPageCadastro.Controls.Add(btnEditar);
            tabPageCadastro.Controls.Add(cboPerfis);
            tabPageCadastro.Controls.Add(lblPerfil);
            tabPageCadastro.Controls.Add(dgvUsers);
            tabPageCadastro.Controls.Add(btnRegister);
            tabPageCadastro.Controls.Add(lblConfirmPassword);
            tabPageCadastro.Controls.Add(lblPassword);
            tabPageCadastro.Controls.Add(lblEmail);
            tabPageCadastro.Controls.Add(lblName);
            tabPageCadastro.Controls.Add(lblUser);
            tabPageCadastro.Controls.Add(txtConfirmPassword);
            tabPageCadastro.Controls.Add(txtPassword);
            tabPageCadastro.Controls.Add(txtEmail);
            tabPageCadastro.Controls.Add(txtName);
            tabPageCadastro.Controls.Add(txtUser);
            tabPageCadastro.ImeMode = ImeMode.NoControl;
            tabPageCadastro.Location = new Point(4, 24);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(1334, 618);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro de Usuários";
            tabPageCadastro.UseVisualStyleBackColor = true;
            tabPageCadastro.Click += tabPageCadastro_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(194, 373);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 31);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(566, 522);
            button1.Name = "button1";
            button1.Size = new Size(136, 34);
            button1.TabIndex = 19;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(331, 39);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 18;
            lblId.Text = "ID";
            lblId.Visible = false;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(331, 72);
            txtID.Name = "txtID";
            txtID.Size = new Size(154, 23);
            txtID.TabIndex = 17;
            txtID.Visible = false;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(26, 373);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 31);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // cboPerfis
            // 
            cboPerfis.FormattingEnabled = true;
            cboPerfis.Items.AddRange(new object[] { "Gerente", "Funcionario", "Tecnico" });
            cboPerfis.Location = new Point(26, 239);
            cboPerfis.Name = "cboPerfis";
            cboPerfis.Size = new Size(299, 23);
            cboPerfis.TabIndex = 15;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(25, 210);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 14;
            lblPerfil.Text = "Perfil";
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { columnID, columnPerfil, columnName, columnEmail, columnAtividade, columnEditar });
            dgvUsers.Location = new Point(566, 16);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(741, 492);
            dgvUsers.TabIndex = 11;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // columnID
            // 
            columnID.HeaderText = "ID";
            columnID.Name = "columnID";
            // 
            // columnPerfil
            // 
            columnPerfil.HeaderText = "Perfil";
            columnPerfil.Name = "columnPerfil";
            // 
            // columnName
            // 
            columnName.HeaderText = "Nome";
            columnName.Name = "columnName";
            columnName.Resizable = DataGridViewTriState.True;
            // 
            // columnEmail
            // 
            columnEmail.HeaderText = "Email";
            columnEmail.Name = "columnEmail";
            // 
            // columnAtividade
            // 
            columnAtividade.HeaderText = "Status";
            columnAtividade.Name = "columnAtividade";
            columnAtividade.Text = "Status";
            // 
            // columnEditar
            // 
            columnEditar.HeaderText = "Editar";
            columnEditar.Name = "columnEditar";
            columnEditar.Resizable = DataGridViewTriState.True;
            columnEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Location = new Point(26, 514);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 31);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(25, 423);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(95, 15);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "Confirmar senha";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(25, 352);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(39, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Senha";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 278);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Nome";
            lblName.Click += label2_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(25, 126);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(99, 15);
            lblUser.TabIndex = 5;
            lblUser.Text = "Nome de Usuário";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(26, 453);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(300, 23);
            txtConfirmPassword.TabIndex = 4;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(26, 381);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 308);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(25, 158);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(300, 23);
            txtUser.TabIndex = 0;
            // 
            // tbpCausasRaiz
            // 
            tbpCausasRaiz.Controls.Add(dgvCausaRaiz);
            tbpCausasRaiz.Location = new Point(4, 24);
            tbpCausasRaiz.Name = "tbpCausasRaiz";
            tbpCausasRaiz.Size = new Size(1334, 618);
            tbpCausasRaiz.TabIndex = 2;
            tbpCausasRaiz.Text = "Cadastro de Causas Raíz";
            tbpCausasRaiz.UseVisualStyleBackColor = true;
            tbpCausasRaiz.Click += tbpCausasRaiz_Click;
            // 
            // dgvCausaRaiz
            // 
            dgvCausaRaiz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCausaRaiz.Columns.AddRange(new DataGridViewColumn[] { columnIdCausaRaiz, columnCausaRaiz, columnPrioridade, columnStatus });
            dgvCausaRaiz.Location = new Point(127, 37);
            dgvCausaRaiz.Name = "dgvCausaRaiz";
            dgvCausaRaiz.Size = new Size(1003, 510);
            dgvCausaRaiz.TabIndex = 0;
            dgvCausaRaiz.CellContentClick += dgvCausaRaiz_CellContentClick;
            // 
            // columnIdCausaRaiz
            // 
            columnIdCausaRaiz.HeaderText = "ID";
            columnIdCausaRaiz.Name = "columnIdCausaRaiz";
            // 
            // columnCausaRaiz
            // 
            columnCausaRaiz.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnCausaRaiz.HeaderText = "Nome Causa Raíz";
            columnCausaRaiz.Name = "columnCausaRaiz";
            // 
            // columnPrioridade
            // 
            columnPrioridade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnPrioridade.HeaderText = "Prioridade";
            columnPrioridade.Name = "columnPrioridade";
            // 
            // columnStatus
            // 
            columnStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnStatus.HeaderText = "Status";
            columnStatus.Name = "columnStatus";
            // 
            // tabTicket
            // 
            tabTicket.Controls.Add(lblAtualizadoEm);
            tabTicket.Controls.Add(txtAtualizadoEm);
            tabTicket.Controls.Add(lblCriadoEm);
            tabTicket.Controls.Add(txtCriadoEm);
            tabTicket.Controls.Add(lblAbertoPor);
            tabTicket.Controls.Add(txtAbertoPor);
            tabTicket.Controls.Add(txtTecnico);
            tabTicket.Controls.Add(lblTecnico);
            tabTicket.Controls.Add(txtCausaRaiz);
            tabTicket.Controls.Add(lblCausaRaiz);
            tabTicket.Controls.Add(txtCriticidade);
            tabTicket.Controls.Add(lblCriticidade);
            tabTicket.Controls.Add(txtSolucao);
            tabTicket.Controls.Add(lblSolucao);
            tabTicket.Controls.Add(lblDescricaoTicket);
            tabTicket.Controls.Add(lblStatusTicket);
            tabTicket.Controls.Add(lblIdTicket);
            tabTicket.Controls.Add(txtStatus);
            tabTicket.Controls.Add(txtDescription);
            tabTicket.Controls.Add(txtIdTicket);
            tabTicket.Controls.Add(dgvTickets);
            tabTicket.Location = new Point(4, 24);
            tabTicket.Name = "tabTicket";
            tabTicket.Size = new Size(1334, 618);
            tabTicket.TabIndex = 4;
            tabTicket.Text = "Ticket";
            tabTicket.UseVisualStyleBackColor = true;
            // 
            // lblAtualizadoEm
            // 
            lblAtualizadoEm.AutoSize = true;
            lblAtualizadoEm.Location = new Point(150, 136);
            lblAtualizadoEm.Name = "lblAtualizadoEm";
            lblAtualizadoEm.Size = new Size(83, 15);
            lblAtualizadoEm.TabIndex = 20;
            lblAtualizadoEm.Text = "Atualizado em";
            // 
            // txtAtualizadoEm
            // 
            txtAtualizadoEm.Enabled = false;
            txtAtualizadoEm.Location = new Point(150, 154);
            txtAtualizadoEm.Name = "txtAtualizadoEm";
            txtAtualizadoEm.Size = new Size(116, 23);
            txtAtualizadoEm.TabIndex = 19;
            // 
            // lblCriadoEm
            // 
            lblCriadoEm.AutoSize = true;
            lblCriadoEm.Location = new Point(18, 136);
            lblCriadoEm.Name = "lblCriadoEm";
            lblCriadoEm.Size = new Size(62, 15);
            lblCriadoEm.TabIndex = 18;
            lblCriadoEm.Text = "Criado em";
            // 
            // txtCriadoEm
            // 
            txtCriadoEm.Enabled = false;
            txtCriadoEm.Location = new Point(18, 154);
            txtCriadoEm.Name = "txtCriadoEm";
            txtCriadoEm.Size = new Size(116, 23);
            txtCriadoEm.TabIndex = 17;
            // 
            // lblAbertoPor
            // 
            lblAbertoPor.AutoSize = true;
            lblAbertoPor.Location = new Point(284, 136);
            lblAbertoPor.Name = "lblAbertoPor";
            lblAbertoPor.Size = new Size(64, 15);
            lblAbertoPor.TabIndex = 16;
            lblAbertoPor.Text = "Aberto por";
            // 
            // txtAbertoPor
            // 
            txtAbertoPor.Enabled = false;
            txtAbertoPor.Location = new Point(284, 154);
            txtAbertoPor.Name = "txtAbertoPor";
            txtAbertoPor.Size = new Size(116, 23);
            txtAbertoPor.TabIndex = 15;
            // 
            // txtTecnico
            // 
            txtTecnico.Enabled = false;
            txtTecnico.Location = new Point(410, 154);
            txtTecnico.Name = "txtTecnico";
            txtTecnico.Size = new Size(116, 23);
            txtTecnico.TabIndex = 14;
            // 
            // lblTecnico
            // 
            lblTecnico.AutoSize = true;
            lblTecnico.Location = new Point(410, 136);
            lblTecnico.Name = "lblTecnico";
            lblTecnico.Size = new Size(116, 15);
            lblTecnico.TabIndex = 13;
            lblTecnico.Text = "Técnico Responsável";
            // 
            // txtCausaRaiz
            // 
            txtCausaRaiz.Enabled = false;
            txtCausaRaiz.Location = new Point(284, 93);
            txtCausaRaiz.Name = "txtCausaRaiz";
            txtCausaRaiz.Size = new Size(242, 23);
            txtCausaRaiz.TabIndex = 12;
            // 
            // lblCausaRaiz
            // 
            lblCausaRaiz.AutoSize = true;
            lblCausaRaiz.Location = new Point(284, 75);
            lblCausaRaiz.Name = "lblCausaRaiz";
            lblCausaRaiz.Size = new Size(63, 15);
            lblCausaRaiz.TabIndex = 11;
            lblCausaRaiz.Text = "Causa Raíz";
            // 
            // txtCriticidade
            // 
            txtCriticidade.Enabled = false;
            txtCriticidade.Location = new Point(150, 93);
            txtCriticidade.Name = "txtCriticidade";
            txtCriticidade.Size = new Size(116, 23);
            txtCriticidade.TabIndex = 10;
            // 
            // lblCriticidade
            // 
            lblCriticidade.AutoSize = true;
            lblCriticidade.Location = new Point(150, 75);
            lblCriticidade.Name = "lblCriticidade";
            lblCriticidade.Size = new Size(64, 15);
            lblCriticidade.TabIndex = 9;
            lblCriticidade.Text = "Criticidade";
            // 
            // txtSolucao
            // 
            txtSolucao.Enabled = false;
            txtSolucao.Location = new Point(284, 231);
            txtSolucao.Multiline = true;
            txtSolucao.Name = "txtSolucao";
            txtSolucao.Size = new Size(242, 181);
            txtSolucao.TabIndex = 8;
            // 
            // lblSolucao
            // 
            lblSolucao.AutoSize = true;
            lblSolucao.Location = new Point(284, 213);
            lblSolucao.Name = "lblSolucao";
            lblSolucao.Size = new Size(49, 15);
            lblSolucao.TabIndex = 7;
            lblSolucao.Text = "Solução";
            // 
            // lblDescricaoTicket
            // 
            lblDescricaoTicket.AutoSize = true;
            lblDescricaoTicket.Location = new Point(18, 213);
            lblDescricaoTicket.Name = "lblDescricaoTicket";
            lblDescricaoTicket.Size = new Size(58, 15);
            lblDescricaoTicket.TabIndex = 6;
            lblDescricaoTicket.Text = "Descrição";
            // 
            // lblStatusTicket
            // 
            lblStatusTicket.AutoSize = true;
            lblStatusTicket.Location = new Point(18, 75);
            lblStatusTicket.Name = "lblStatusTicket";
            lblStatusTicket.Size = new Size(39, 15);
            lblStatusTicket.TabIndex = 5;
            lblStatusTicket.Text = "Status";
            // 
            // lblIdTicket
            // 
            lblIdTicket.AutoSize = true;
            lblIdTicket.Location = new Point(18, 16);
            lblIdTicket.Name = "lblIdTicket";
            lblIdTicket.Size = new Size(53, 15);
            lblIdTicket.TabIndex = 4;
            lblIdTicket.Text = "ID Ticket";
            // 
            // txtStatus
            // 
            txtStatus.Enabled = false;
            txtStatus.Location = new Point(18, 93);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(116, 23);
            txtStatus.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Enabled = false;
            txtDescription.Location = new Point(18, 231);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(239, 181);
            txtDescription.TabIndex = 2;
            // 
            // txtIdTicket
            // 
            txtIdTicket.Enabled = false;
            txtIdTicket.Location = new Point(18, 34);
            txtIdTicket.Name = "txtIdTicket";
            txtIdTicket.Size = new Size(116, 23);
            txtIdTicket.TabIndex = 1;
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Columns.AddRange(new DataGridViewColumn[] { columnIdTicket, columnCause, columnTicketStatus, columnCriticidade, columnTecnico, columnVisualizar });
            dgvTickets.Location = new Point(576, 16);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.Size = new Size(707, 509);
            dgvTickets.TabIndex = 0;
            dgvTickets.CellContentClick += dgvTickets_CellContentClick;
            // 
            // columnIdTicket
            // 
            columnIdTicket.HeaderText = "Código Ticket";
            columnIdTicket.Name = "columnIdTicket";
            // 
            // columnCause
            // 
            columnCause.HeaderText = "Causa Raíz";
            columnCause.Name = "columnCause";
            // 
            // columnTicketStatus
            // 
            columnTicketStatus.HeaderText = "Status";
            columnTicketStatus.Name = "columnTicketStatus";
            // 
            // columnCriticidade
            // 
            columnCriticidade.HeaderText = "Criticidade";
            columnCriticidade.Name = "columnCriticidade";
            // 
            // columnTecnico
            // 
            columnTecnico.HeaderText = "Técnico Responsável";
            columnTecnico.Name = "columnTecnico";
            // 
            // columnVisualizar
            // 
            columnVisualizar.HeaderText = "Visualizar";
            columnVisualizar.Name = "columnVisualizar";
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 640);
            Controls.Add(tbcMenu);
            Name = "TelaInicial";
            Text = "TelaInicial";
            Load += TelaInicial_Load;
            tbcMenu.ResumeLayout(false);
            tabPerfil.ResumeLayout(false);
            tabPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tbpCausasRaiz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCausaRaiz).EndInit();
            tabTicket.ResumeLayout(false);
            tabTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcMenu;
        private TabPage tabPageCadastro;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private Label lblEmail;
        private Label lblName;
        private Label lblUser;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtUser;
        private Button btnRegister;
        private DataGridView dgvUsers;
        private TabPage tbpCausasRaiz;
        private Label lblPriority;
        private Label lblRoot;
        private TextBox txtNomeCausaRaiz;
        private DataGridView dgvCausaRaiz;
        private Button btnCadastrarCausaRaiz;
        private ComboBox cboPrioridade;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnPerfil;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnEmail;
        private DataGridViewButtonColumn columnAtividade;
        private DataGridViewButtonColumn columnEditar;
        private ComboBox cboPerfis;
        private Label lblPerfil;
        private Button btnEditar;
        private Label lblId;
        private TextBox txtID;
        private TabPage tabPerfil;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox txtCargoUser;
        private TextBox txtNomeUser;
        private Button btnDeslogar;
        private Button button1;
        private TabPage tabTicket;
        private TextBox txtDescription;
        private TextBox txtIdTicket;
        private DataGridView dgvTickets;
        private TextBox txtStatus;
        private Label lblDescricaoTicket;
        private Label lblStatusTicket;
        private Label lblIdTicket;
        private Button btnCancel;
        private Label lblSolucao;
        private DataGridViewTextBoxColumn columnIdTicket;
        private DataGridViewTextBoxColumn columnCause;
        private DataGridViewTextBoxColumn columnTicketStatus;
        private DataGridViewTextBoxColumn columnCriticidade;
        private DataGridViewTextBoxColumn columnTecnico;
        private DataGridViewButtonColumn columnVisualizar;
        private TextBox txtTecnico;
        private Label lblTecnico;
        private TextBox txtCausaRaiz;
        private Label lblCausaRaiz;
        private TextBox txtCriticidade;
        private Label lblCriticidade;
        private TextBox txtSolucao;
        private Label lblAtualizadoEm;
        private TextBox txtAtualizadoEm;
        private Label lblCriadoEm;
        private TextBox txtCriadoEm;
        private Label lblAbertoPor;
        private TextBox txtAbertoPor;
        private DataGridViewTextBoxColumn columnIdCausaRaiz;
        private DataGridViewTextBoxColumn columnCausaRaiz;
        private DataGridViewTextBoxColumn columnPrioridade;
        private DataGridViewButtonColumn columnStatus;
        private TextBox txtIdUser;
        private Label lblIdUser;
    }
}