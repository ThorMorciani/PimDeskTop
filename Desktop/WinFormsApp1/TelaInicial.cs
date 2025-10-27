using IAssist;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{


    public partial class TelaInicial : Form
    {
        private static readonly HttpClient client = new HttpClient();


        public TelaInicial()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string nome = txtName.Text.Trim();
            string user = txtUser.Text.Trim();
            string email = txtEmail.Text.Trim();
            int perfil = 0;
            if(cboPerfis.Text.Trim() == "Gerente")
            {
                perfil = 2;
            }else if(cboPerfis.Text.Trim() == "Funcionário")
            {
                perfil = 3;
            }
            string senha = txtPassword.Text.Trim();
            string confirmSenha = txtConfirmPassword.Text.Trim();
            string status = "Ativo";
            string editar = "Editar";
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmSenha))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            else
            {
                if (confirmSenha != senha)
                {
                    MessageBox.Show("Senhas não coincidem");

                }
                else
                {
                    dgvUsers.Rows.Add(nome, email, status, editar);
                    txtName.Clear();
                    txtEmail.Clear();
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();

                    UserPostRequest usuario = new UserPostRequest
                    {
                        Name = nome,
                        Username = user,
                        Email = email,
                        Password = senha,
                        ProfileId = perfil,
                    };
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:7158/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                            new MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage response = await client.PostAsJsonAsync("User", usuario);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Usuário cadastrado com sucesso!");
                        }
                        else
                        {
                            string msg = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("Erro ao cadastrar: " + msg);
                        }
                    }



                }

            }
            



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

        private void tabPageCadastro_Click(object sender, EventArgs e)
        {

        }

        private async void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                client.BaseAddress = new Uri("https://localhost:7158");

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("user");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    var users = JsonConvert.DeserializeObject<List<UserResponse>>(jsonResponse);

                    foreach (var user in users)
                    {
                        int rowIndex = dgvUsers.Rows.Add();
                        dgvUsers.Rows[rowIndex].Cells["columnID"].Value = user.Id;
                        if (user.Profile == "1")
                        {
                            dgvUsers.Rows[rowIndex].Cells["columnPerfil"].Value = "Administrador";
                        }
                        else if (user.Profile == "2")
                        {
                            dgvUsers.Rows[rowIndex].Cells["columnPerfil"].Value = "Gerente";
                        }

                        dgvUsers.Rows[rowIndex].Cells["columnName"].Value = user.Name;
                        dgvUsers.Rows[rowIndex].Cells["columnEmail"].Value = user.Email;
                        if (user.Active)
                        {
                            dgvUsers.Rows[rowIndex].Cells["columnAtividade"].Value = "Ativo";

                        }
                        else
                        {
                            dgvUsers.Rows[rowIndex].Cells["columnAtividade"].Value = "Inativo";
                        }
                        dgvUsers.Rows[rowIndex].Cells["columnEditar"].Value = "Editar";
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao acessar a API: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    

