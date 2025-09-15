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
            tabControl1 = new TabControl();
            tabPageCadastro = new TabPage();
            dgvUsers = new DataGridView();
            ColunaNome = new DataGridViewTextBoxColumn();
            ColunaEmail = new DataGridViewTextBoxColumn();
            ColunaRemover = new DataGridViewButtonColumn();
            btnRegister = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtUser = new TextBox();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            txtDatainicial = new MaskedTextBox();
            lblDatainicial = new Label();
            txtDatafinal = new MaskedTextBox();
            lblDatafinal = new Label();
            btnGerarRelatorio = new Button();
            tabControl1.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCadastro);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1342, 646);
            tabControl1.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(dgvUsers);
            tabPageCadastro.Controls.Add(btnRegister);
            tabPageCadastro.Controls.Add(label5);
            tabPageCadastro.Controls.Add(label4);
            tabPageCadastro.Controls.Add(label3);
            tabPageCadastro.Controls.Add(label2);
            tabPageCadastro.Controls.Add(label1);
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
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { ColunaNome, ColunaEmail, ColunaRemover });
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
            // ColunaRemover
            // 
            ColunaRemover.HeaderText = "";
            ColunaRemover.Name = "ColunaRemover";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 290);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 9;
            label5.Text = "Confirmar senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 226);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 159);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 100);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome de Usuário";
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
            // tabPage2
            // 
            tabPage2.Controls.Add(btnGerarRelatorio);
            tabPage2.Controls.Add(lblDatafinal);
            tabPage2.Controls.Add(txtDatafinal);
            tabPage2.Controls.Add(lblDatainicial);
            tabPage2.Controls.Add(txtDatainicial);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1334, 618);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Relatórios";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(995, 511);
            dataGridView1.TabIndex = 0;
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
            // lblDatainicial
            // 
            lblDatainicial.AutoSize = true;
            lblDatainicial.Location = new Point(22, 30);
            lblDatainicial.Name = "lblDatainicial";
            lblDatainicial.Size = new Size(65, 15);
            lblDatainicial.TabIndex = 2;
            lblDatainicial.Text = "Data inicial";
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
            // lblDatafinal
            // 
            lblDatafinal.AutoSize = true;
            lblDatafinal.Location = new Point(22, 102);
            lblDatafinal.Name = "lblDatafinal";
            lblDatafinal.Size = new Size(57, 15);
            lblDatafinal.TabIndex = 4;
            lblDatafinal.Text = "Data final";
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
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 640);
            Controls.Add(tabControl1);
            Name = "TelaInicial";
            Text = "TelaInicial";
            tabControl1.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageCadastro;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtUser;
        private Button btnRegister;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn ColunaNome;
        private DataGridViewTextBoxColumn ColunaEmail;
        private DataGridViewButtonColumn ColunaRemover;
        private DataGridView dataGridView1;
        private MaskedTextBox txtDatainicial;
        private MaskedTextBox txtDatafinal;
        private Label lblDatainicial;
        private Label lblDatafinal;
        private Button btnGerarRelatorio;
    }
}