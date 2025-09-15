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
            tbcMenu = new TabControl();
            tabPageCadastro = new TabPage();
            dgvUsers = new DataGridView();
            ColunaNome = new DataGridViewTextBoxColumn();
            ColunaEmail = new DataGridViewTextBoxColumn();
            columnAtividade = new DataGridViewButtonColumn();
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
            tbpRelatorio = new TabPage();
            btnGerarRelatorio = new Button();
            lblDatafinal = new Label();
            txtDatafinal = new MaskedTextBox();
            lblDatainicial = new Label();
            txtDatainicial = new MaskedTextBox();
            dgvRelatorio = new DataGridView();
            tbpCausasRaiz = new TabPage();
            btnCadastrarCausaRaiz = new Button();
            cboPrioridade = new ComboBox();
            lblPriority = new Label();
            lblRoot = new Label();
            txtNomeCausaRaiz = new TextBox();
            dgvCausaRaiz = new DataGridView();
            columnCausaRaiz = new DataGridViewTextBoxColumn();
            columnPrioridade = new DataGridViewTextBoxColumn();
            columnStatus = new DataGridViewButtonColumn();
            tbcMenu.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tbpRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            tbpCausasRaiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCausaRaiz).BeginInit();
            SuspendLayout();
            // 
            // tbcMenu
            // 
            tbcMenu.Controls.Add(tabPageCadastro);
            tbcMenu.Controls.Add(tbpRelatorio);
            tbcMenu.Controls.Add(tbpCausasRaiz);
            tbcMenu.Location = new Point(1, 0);
            tbcMenu.Name = "tbcMenu";
            tbcMenu.SelectedIndex = 0;
            tbcMenu.Size = new Size(1342, 646);
            tbcMenu.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
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
            tabPageCadastro.Location = new Point(4, 24);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(1334, 618);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro de Usuários";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { ColunaNome, ColunaEmail, columnAtividade });
            dgvUsers.Location = new Point(566, 16);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(741, 492);
            dgvUsers.TabIndex = 11;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // ColunaNome
            // 
            ColunaNome.HeaderText = "Nome";
            ColunaNome.Name = "ColunaNome";
            // 
            // ColunaEmail
            // 
            ColunaEmail.HeaderText = "Email";
            ColunaEmail.Name = "ColunaEmail";
            // 
            // columnAtividade
            // 
            columnAtividade.HeaderText = "Status";
            columnAtividade.Name = "columnAtividade";
            columnAtividade.Text = "Status";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(25, 364);
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
            lblConfirmPassword.Location = new Point(25, 290);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(95, 15);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "Confirmar senha";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(25, 226);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(39, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Senha";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(25, 159);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Nome";
            lblName.Click += label2_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(25, 39);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(99, 15);
            lblUser.TabIndex = 5;
            lblUser.Text = "Nome de Usuário";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(25, 308);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(300, 23);
            txtConfirmPassword.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(25, 244);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(25, 57);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(300, 23);
            txtUser.TabIndex = 0;
            // 
            // tbpRelatorio
            // 
            tbpRelatorio.Controls.Add(btnGerarRelatorio);
            tbpRelatorio.Controls.Add(lblDatafinal);
            tbpRelatorio.Controls.Add(txtDatafinal);
            tbpRelatorio.Controls.Add(lblDatainicial);
            tbpRelatorio.Controls.Add(txtDatainicial);
            tbpRelatorio.Controls.Add(dgvRelatorio);
            tbpRelatorio.Location = new Point(4, 24);
            tbpRelatorio.Name = "tbpRelatorio";
            tbpRelatorio.Padding = new Padding(3);
            tbpRelatorio.Size = new Size(1334, 618);
            tbpRelatorio.TabIndex = 1;
            tbpRelatorio.Text = "Relatórios";
            tbpRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(22, 179);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(138, 23);
            btnGerarRelatorio.TabIndex = 5;
            btnGerarRelatorio.Text = "Gerar Relatório";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // lblDatafinal
            // 
            lblDatafinal.AutoSize = true;
            lblDatafinal.Location = new Point(22, 102);
            lblDatafinal.Name = "lblDatafinal";
            lblDatafinal.Size = new Size(57, 15);
            lblDatafinal.TabIndex = 4;
            lblDatafinal.Text = "Data final";
            // 
            // txtDatafinal
            // 
            txtDatafinal.Location = new Point(22, 120);
            txtDatafinal.Mask = "00/00/0000";
            txtDatafinal.Name = "txtDatafinal";
            txtDatafinal.Size = new Size(138, 23);
            txtDatafinal.TabIndex = 3;
            txtDatafinal.ValidatingType = typeof(DateTime);
            // 
            // lblDatainicial
            // 
            lblDatainicial.AutoSize = true;
            lblDatainicial.Location = new Point(22, 30);
            lblDatainicial.Name = "lblDatainicial";
            lblDatainicial.Size = new Size(65, 15);
            lblDatainicial.TabIndex = 2;
            lblDatainicial.Text = "Data inicial";
            // 
            // txtDatainicial
            // 
            txtDatainicial.Location = new Point(22, 53);
            txtDatainicial.Mask = "00/00/0000";
            txtDatainicial.Name = "txtDatainicial";
            txtDatainicial.Size = new Size(138, 23);
            txtDatainicial.TabIndex = 1;
            txtDatainicial.ValidatingType = typeof(DateTime);
            txtDatainicial.MaskInputRejected += txtData_MaskInputRejected;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRelatorio.Location = new Point(290, 30);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.Size = new Size(995, 511);
            dgvRelatorio.TabIndex = 0;
            // 
            // tbpCausasRaiz
            // 
            tbpCausasRaiz.Controls.Add(btnCadastrarCausaRaiz);
            tbpCausasRaiz.Controls.Add(cboPrioridade);
            tbpCausasRaiz.Controls.Add(lblPriority);
            tbpCausasRaiz.Controls.Add(lblRoot);
            tbpCausasRaiz.Controls.Add(txtNomeCausaRaiz);
            tbpCausasRaiz.Controls.Add(dgvCausaRaiz);
            tbpCausasRaiz.Location = new Point(4, 24);
            tbpCausasRaiz.Name = "tbpCausasRaiz";
            tbpCausasRaiz.Size = new Size(1334, 618);
            tbpCausasRaiz.TabIndex = 2;
            tbpCausasRaiz.Text = "Cadastro de Causas Raíz";
            tbpCausasRaiz.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarCausaRaiz
            // 
            btnCadastrarCausaRaiz.Location = new Point(19, 172);
            btnCadastrarCausaRaiz.Name = "btnCadastrarCausaRaiz";
            btnCadastrarCausaRaiz.Size = new Size(191, 23);
            btnCadastrarCausaRaiz.TabIndex = 5;
            btnCadastrarCausaRaiz.Text = "Cadastrar Causa Raíz";
            btnCadastrarCausaRaiz.UseVisualStyleBackColor = true;
            btnCadastrarCausaRaiz.Click += btnCadastrarCausaRaiz_Click;
            // 
            // cboPrioridade
            // 
            cboPrioridade.FormattingEnabled = true;
            cboPrioridade.Items.AddRange(new object[] { "Alto", "Médio", "Baixo" });
            cboPrioridade.Location = new Point(19, 114);
            cboPrioridade.Name = "cboPrioridade";
            cboPrioridade.Size = new Size(191, 23);
            cboPrioridade.TabIndex = 4;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(19, 85);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(107, 15);
            lblPriority.TabIndex = 3;
            lblPriority.Text = "Nível de Prioridade";
            // 
            // lblRoot
            // 
            lblRoot.AutoSize = true;
            lblRoot.Location = new Point(19, 26);
            lblRoot.Name = "lblRoot";
            lblRoot.Size = new Size(99, 15);
            lblRoot.TabIndex = 2;
            lblRoot.Text = "Nome Causa Raíz";
            // 
            // txtNomeCausaRaiz
            // 
            txtNomeCausaRaiz.Location = new Point(19, 49);
            txtNomeCausaRaiz.Name = "txtNomeCausaRaiz";
            txtNomeCausaRaiz.Size = new Size(191, 23);
            txtNomeCausaRaiz.TabIndex = 1;
            // 
            // dgvCausaRaiz
            // 
            dgvCausaRaiz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCausaRaiz.Columns.AddRange(new DataGridViewColumn[] { columnCausaRaiz, columnPrioridade, columnStatus });
            dgvCausaRaiz.Location = new Point(397, 26);
            dgvCausaRaiz.Name = "dgvCausaRaiz";
            dgvCausaRaiz.Size = new Size(903, 510);
            dgvCausaRaiz.TabIndex = 0;
            dgvCausaRaiz.CellContentClick += dgvCausaRaiz_CellContentClick;
            // 
            // columnCausaRaiz
            // 
            columnCausaRaiz.HeaderText = "Nome Causa Raíz";
            columnCausaRaiz.Name = "columnCausaRaiz";
            // 
            // columnPrioridade
            // 
            columnPrioridade.HeaderText = "Prioridade";
            columnPrioridade.Name = "columnPrioridade";
            // 
            // columnStatus
            // 
            columnStatus.HeaderText = "Status";
            columnStatus.Name = "columnStatus";
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 640);
            Controls.Add(tbcMenu);
            Name = "TelaInicial";
            Text = "TelaInicial";
            tbcMenu.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tbpRelatorio.ResumeLayout(false);
            tbpRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            tbpCausasRaiz.ResumeLayout(false);
            tbpCausasRaiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCausaRaiz).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcMenu;
        private TabPage tabPageCadastro;
        private TabPage tbpRelatorio;
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
        private DataGridView dgvRelatorio;
        private MaskedTextBox txtDatainicial;
        private MaskedTextBox txtDatafinal;
        private Label lblDatainicial;
        private Label lblDatafinal;
        private Button btnGerarRelatorio;
        private TabPage tbpCausasRaiz;
        private Label lblPriority;
        private Label lblRoot;
        private TextBox txtNomeCausaRaiz;
        private DataGridView dgvCausaRaiz;
        private Button btnCadastrarCausaRaiz;
        private ComboBox cboPrioridade;
        private DataGridViewTextBoxColumn columnCausaRaiz;
        private DataGridViewTextBoxColumn columnPrioridade;
        private DataGridViewButtonColumn columnStatus;
        private DataGridViewTextBoxColumn ColunaNome;
        private DataGridViewTextBoxColumn ColunaEmail;
        private DataGridViewButtonColumn columnAtividade;
    }
}