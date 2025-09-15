using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string status = "Ativo";
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Preencha os campos Nome e Email.");
                return;
            }

            dgvUsers.Rows.Add(nome, email, status);
            txtName.Clear();
            txtEmail.Clear();

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvUsers.Columns[e.ColumnIndex].Name != "columnAtividade") return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
            DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["columnAtividade"];
            string statusAtual = btnCell.Value?.ToString();

            if (statusAtual == "Ativo")
            {
                var resposta = MessageBox.Show(
                    "Deseja realmente inativar este Usuário?",
                    "Confirmar Inativação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    btnCell.Value = "Inativo";
                }

            }
            else
            {
                var resposta = MessageBox.Show(
                    "Deseja realmente ativar este Usuário?",
                    "Confirmar Ativação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    btnCell.Value = "Ativo";
                }
            }
        }

        private void txtData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrarCausaRaiz_Click(object sender, EventArgs e)
        {
            string causa = txtNomeCausaRaiz.Text.Trim();
            string prioridade = cboPrioridade.Text.Trim();
            string status = "Ativo";
            if (string.IsNullOrEmpty(causa) || string.IsNullOrEmpty(prioridade))
            {
                MessageBox.Show("Preencha os campos Nome causa raíz e prioridade.");
                return;
            }

            dgvCausaRaiz.Rows.Add(causa, prioridade, status);
            txtNomeCausaRaiz.Clear();

        }

        private void dgvCausaRaiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0) return;
            if (dgvCausaRaiz.Columns[e.ColumnIndex].Name != "columnStatus") return;

            DataGridViewRow row = dgvCausaRaiz.Rows[e.RowIndex];
            DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["columnStatus"];
            string statusAtual = btnCell.Value?.ToString();

            if (statusAtual == "Ativo")
            {
                var resposta = MessageBox.Show(
                    "Deseja realmente inativar esta causa-raiz?",
                    "Confirmar Inativação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    btnCell.Value = "Inativo";
                }
                
            }
            else
            {
                var resposta = MessageBox.Show(
                    "Deseja realmente ativar esta causa-raiz?",
                    "Confirmar Ativação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    btnCell.Value = "Ativo";
                }
            }
        }
    }
}

    

