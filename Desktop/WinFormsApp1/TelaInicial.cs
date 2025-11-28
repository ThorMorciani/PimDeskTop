using IAssist;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WinFormsApp1
{


    public partial class TelaInicial : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private List<string> _nomeUsuario;
        private List<string> _cargoUsuario;
        private List<string> _idUsuario;


        public TelaInicial(List<string> nome, List<string> cargo, List<string> id)
        {
            InitializeComponent();
            _nomeUsuario = nome;
            _cargoUsuario = cargo;
            _idUsuario = id;

            txtNomeUser.Text = _nomeUsuario[0];
            txtCargoUser.Text = _cargoUsuario[0];
            txtIdUser.Text = _idUsuario[0];
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
            if (cboPerfis.Text.Trim() == "Gerente")
            {
                perfil = 5;
            }
            else if (cboPerfis.Text.Trim() == "Funcionario")
            {
                perfil = 6;
            }
            else if (cboPerfis.Text.Trim() == "Tecnico")
            {
                perfil = 7;
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
                    txtName.Clear();
                    txtUser.Clear();
                    txtEmail.Clear();
                    cboPerfis.SelectedIndex = -1;
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

        private async void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            //clique da coluna de status
            if (dgvUsers.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvUsers.Columns[e.ColumnIndex].Name == "columnAtividade")
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["columnAtividade"];
                object userId = dgvUsers.Rows[e.RowIndex].Cells["columnID"].Value;
                object userPerfil = dgvUsers.Rows[e.RowIndex].Cells["columnPerfil"].Value;
                object nameProfile = dgvUsers.Rows[e.RowIndex].Cells["columnPerfil"].Value;
                string statusAtual = btnCell.Value?.ToString();
                var userIdString = userId.ToString();
                if (statusAtual == "Ativo")
                {
                    if (userIdString == txtIdUser.Text || nameProfile.ToString() == "Admin")
                    {
                        MessageBox.Show("Você não tem permissão para alterar este usuário");

                    }
                    else
                    {
                        var resposta = MessageBox.Show(
                        "Deseja realmente inativar este Usuário?",
                        "Confirmar Inativação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (resposta == DialogResult.Yes)
                    {
                        
                            btnCell.Value = "Inativo";
                            try
                            {
                                using (var client = new HttpClient())
                                {
                                    client.BaseAddress = new Uri("https://localhost:7158/");
                                    var response = await client.DeleteAsync($"User/{userId}");
                                    if (response.IsSuccessStatusCode)
                                    {
                                        MessageBox.Show("Usuário inativado com sucesso!");

                                    }
                                    else
                                    {
                                        string msg = await response.Content.ReadAsStringAsync();
                                        MessageBox.Show($"Erro ao inativar: {msg}");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Erro interno: {ex.Message}");
                            }
                        }

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
                        try
                        {
                            using (var client = new HttpClient())
                            {
                                client.BaseAddress = new Uri("https://localhost:7158/");
                                var response = await client.DeleteAsync($"User/{userId}");
                                if (response.IsSuccessStatusCode)
                                {
                                    MessageBox.Show("Usuário ativado com sucesso!");

                                }
                                else
                                {
                                    string msg = await response.Content.ReadAsStringAsync();
                                    MessageBox.Show($"Erro ao ativar: {msg}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro interno: {ex.Message}");
                        }
                    }
                }
            }



            //clique da coluna de editar
            if (dgvUsers.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
      dgvUsers.Columns[e.ColumnIndex].Name == "columnEditar")
            {
                object idUser = dgvUsers.Rows[e.RowIndex].Cells["columnID"].Value;
                object nameProfile = dgvUsers.Rows[e.RowIndex].Cells["columnPerfil"].Value;
                var idUsuario = _idUsuario[0].ToString();
                var idUserStr = idUser.ToString();
                if (idUsuario == idUserStr || (nameProfile.ToString() == "Admin"))
                {
                    MessageBox.Show("Você não tem permissão para alterar este usuário");

                }
                else
                {
                    btnEditar.Visible = true;
                    btnRegister.Visible = false;
                    txtPassword.Visible = false;
                    txtConfirmPassword.Visible = false;
                    lblConfirmPassword.Visible = false;
                    lblPassword.Visible = false;
                    lblId.Visible = true;
                    txtID.Visible = true;
                    btnCancel.Visible = true;

                    object value = dgvUsers.Rows[e.RowIndex].Cells["columnID"].Value;
                    if (value != null && long.TryParse(value.ToString(), out long userId))
                    {
                        try
                        {
                            using (var client = new HttpClient())
                            {
                                client.BaseAddress = new Uri("https://localhost:7158/");
                                client.DefaultRequestHeaders.Accept.Clear();
                                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                                HttpResponseMessage response = await client.GetAsync($"User/{userId}");
                                if (response.IsSuccessStatusCode)
                                {
                                    var json = await response.Content.ReadAsStringAsync();
                                    var user = JsonConvert.DeserializeObject<UserResponse>(json);

                                    if (user != null)
                                    {

                                        txtID.Text = user.Id.ToString();
                                        txtName.Text = user.Name;
                                        txtUser.Text = user.Username;
                                        txtEmail.Text = user.Email;
                                        cboPerfis.Text = user.Profile.ProfileName;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Usuário não encontrado.");
                                    }
                                }
                                else
                                {
                                    string msg = await response.Content.ReadAsStringAsync();
                                    MessageBox.Show($"Erro ao buscar usuário: {msg}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro interno: {ex.Message}");
                        }
                    }
                
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

        private async void dgvCausaRaiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            if (dgvCausaRaiz.Columns[e.ColumnIndex].Name != "columnStatus") return;

            DataGridViewRow row = dgvCausaRaiz.Rows[e.RowIndex];
            DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["columnStatus"];
            string statusAtual = btnCell.Value?.ToString();
            object rootId = dgvCausaRaiz.Rows[e.RowIndex].Cells["columnIdCausaRaiz"].Value;
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
                    try
                    {
                        using (var client = new HttpClient())
                        {
                            client.BaseAddress = new Uri("https://localhost:7158/");
                            var response = await client.DeleteAsync($"RootCause/{rootId}");
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Causa Raíz inativado com sucesso!");

                            }
                            else
                            {
                                string msg = await response.Content.ReadAsStringAsync();
                                MessageBox.Show($"Erro ao inativar a Causa Raíz: {msg}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro interno: {ex.Message}");
                    }
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
                    try
                    {
                        using (var client = new HttpClient())
                        {
                            client.BaseAddress = new Uri("https://localhost:7158/");
                            var response = await client.DeleteAsync($"RootCause/{rootId}");
                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Causa Raíz inativado com sucesso!");

                            }
                            else
                            {
                                string msg = await response.Content.ReadAsStringAsync();
                                MessageBox.Show($"Erro ao inativar a Causa Raíz: {msg}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro interno: {ex.Message}");
                    }
                }
            }
        }

        private void tabPageCadastro_Click(object sender, EventArgs e)
        {

        }

        private async void btnCarregar_Click(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtID.Text, out long userId))
            {
                MessageBox.Show("ID de usuário inválido.");
                return;
            }

            // Lê os valores dos campos
            string name = txtName.Text;
            string username = txtUser.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string profile = cboPerfis.Text;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7158/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    long perfil = 0;

                    if (cboPerfis.Text == "Gerente")
                    {
                        perfil = 5;
                    }
                    else if (cboPerfis.Text == "Funcionario")
                    {
                        perfil = 6;
                    }
                    var userRequest = new UserPutRequest
                    {
                        Id = userId,
                        Name = name,
                        Username = username,
                        Password = password,
                        Email = email,
                        ProfileId = perfil,
                    };


                    var jsonContent = JsonConvert.SerializeObject(userRequest);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");


                    HttpResponseMessage response = await client.PutAsync("User", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Usuário atualizado com sucesso!");
                        txtID.Visible = false;
                        lblId.Visible = false;
                        btnEditar.Visible = false;
                        btnRegister.Visible = true;
                        txtPassword.Visible = true;
                        txtConfirmPassword.Visible = true;
                        lblConfirmPassword.Visible = true;
                        lblPassword.Visible = true;
                        btnCancel.Visible = false;
                        txtName.Clear();
                        txtUser.Clear();
                        txtEmail.Clear();
                        cboPerfis.SelectedIndex = -1;

                    }
                    else
                    {
                        string msg = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro ao atualizar usuário: {msg}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro interno na atualização: {ex.Message}");
            }

        }

        private async void TelaInicial_Load(object sender, EventArgs e)
        {
            cboPerfis.DropDownStyle = ComboBoxStyle.DropDownList;
            var tabComGrid = tbcMenu.TabPages["tbpCausasRaiz"];
            if (tbcMenu.TabPages.Contains(tabComGrid) && _cargoUsuario[0] == "Gerente")
            {
                tbcMenu.TabPages.Remove(tabComGrid);
            } else if (!tbcMenu.TabPages.Contains(tabComGrid))
            {
                tbcMenu.TabPages.Add(tabComGrid);
            }

            try
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://localhost:7158/");
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(
                            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage response = await client.GetAsync("user");

                        if (response.IsSuccessStatusCode)
                        {
                            string jsonResponse = await response.Content.ReadAsStringAsync();
                            var users = JsonConvert.DeserializeObject<List<UserResponse>>(jsonResponse);

                            dgvUsers.Rows.Clear();

                            foreach (var user in users)
                            {
                                int rowIndex = dgvUsers.Rows.Add();
                                dgvUsers.Rows[rowIndex].Cells["columnID"].Value = user.Id;
                                dgvUsers.Rows[rowIndex].Cells["columnPerfil"].Value = user.Profile.ProfileName;
                                dgvUsers.Rows[rowIndex].Cells["columnName"].Value = user.Name;
                                dgvUsers.Rows[rowIndex].Cells["columnEmail"].Value = user.Email;
                                dgvUsers.Rows[rowIndex].Cells["columnAtividade"].Value = user.Active ? "Ativo" : "Inativo";
                                dgvUsers.Rows[rowIndex].Cells["columnEditar"].Value = "Editar";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao acessar a API: " + response.StatusCode);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7158/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync("ticket");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        var tickets = JsonConvert.DeserializeObject<List<TicketResponse>>(jsonResponse);

                        dgvTickets.Rows.Clear();

                        foreach (var ticket in tickets)
                        {
                            int rowIndex = dgvTickets.Rows.Add();
                            dgvTickets.Rows[rowIndex].Cells["columnIdTicket"].Value = ticket.TicketNumber;
                            dgvTickets.Rows[rowIndex].Cells["columnTicketStatus"].Value = ticket.Status;
                            dgvTickets.Rows[rowIndex].Cells["columnCriticidade"].Value = ticket.RootCause.Criticality;
                            dgvTickets.Rows[rowIndex].Cells["columnTecnico"].Value = ticket.Reporter.Name;
                            dgvTickets.Rows[rowIndex].Cells["columnCause"].Value = ticket.RootCause.RootCauseName;
                            dgvTickets.Rows[rowIndex].Cells["columnVisualizar"].Value = "Visualizar";


                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao acessar a API: " + response.StatusCode);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7158/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync("RootCause");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        var roots = JsonConvert.DeserializeObject<List<RootCauseResponse>>(jsonResponse);

                        dgvCausaRaiz.Rows.Clear();

                        foreach (var root in roots)
                        {
                            int rowIndex = dgvCausaRaiz.Rows.Add();
                            dgvCausaRaiz.Rows[rowIndex].Cells["columnIdCausaRaiz"].Value = root.Id;
                            dgvCausaRaiz.Rows[rowIndex].Cells["columnCausaRaiz"].Value = root.RootCauseName;
                            dgvCausaRaiz.Rows[rowIndex].Cells["columnPrioridade"].Value = root.Criticality;
                            dgvCausaRaiz.Rows[rowIndex].Cells["columnStatus"].Value = root.Active ? "Ativo" : "Inativo";



                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao acessar a API: " + response.StatusCode);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }








        }

        private void lblNomeUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {

            var resposta = MessageBox.Show(
                   "Deseja realmente Deslogar?",
                   "Quer mesmo sair?",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                var telaLogin = new TelaLogin();
                telaLogin.ButtonLogar.Enabled = true;
                this.Close();
                telaLogin.Show();
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7158/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync("user");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        var users = JsonConvert.DeserializeObject<List<UserResponse>>(jsonResponse);

                        dgvUsers.Rows.Clear();

                        foreach (var user in users)
                        {
                            int rowIndex = dgvUsers.Rows.Add();
                            dgvUsers.Rows[rowIndex].Cells["columnID"].Value = user.Id;
                            dgvUsers.Rows[rowIndex].Cells["columnPerfil"].Value = user.Profile.ProfileName;
                            dgvUsers.Rows[rowIndex].Cells["columnName"].Value = user.Name;
                            dgvUsers.Rows[rowIndex].Cells["columnEmail"].Value = user.Email;
                            dgvUsers.Rows[rowIndex].Cells["columnAtividade"].Value = user.Active ? "Ativo" : "Inativo";
                            dgvUsers.Rows[rowIndex].Cells["columnEditar"].Value = "Editar";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao acessar a API: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void tabPerfil_Click(object sender, EventArgs e)
        {

        }

        private async void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTickets.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
      dgvTickets.Columns[e.ColumnIndex].Name == "columnVisualizar")
            {
                object value = dgvTickets.Rows[e.RowIndex].Cells["columnIdTicket"].Value;
                if (value != null)
                {
                    try
                    {
                        using (var client = new HttpClient())
                        {
                            client.BaseAddress = new Uri("https://localhost:7158/");
                            client.DefaultRequestHeaders.Accept.Clear();
                            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                            HttpResponseMessage response = await client.GetAsync($"Ticket/{value.ToString()}");
                            if (response.IsSuccessStatusCode)
                            {
                                var json = await response.Content.ReadAsStringAsync();
                                var ticket = JsonConvert.DeserializeObject<TicketResponse>(json);

                                if (ticket != null)
                                {

                                    txtIdTicket.Text = ticket.Id.ToString();
                                    txtStatus.Text = ticket.Status;
                                    txtDescription.Text = ticket.Description;
                                    txtCriticidade.Text = ticket.RootCause.Criticality.ToString();
                                    txtCausaRaiz.Text = ticket.RootCause.RootCauseName.ToString();
                                    txtTecnico.Text = ticket.Assignee.Name;
                                    txtAbertoPor.Text = ticket.Reporter.Name;
                                    txtCriadoEm.Text = ticket.CreatedAt.ToString();
                                    txtAtualizadoEm.Text = ticket.UpdatedAt.ToString();
                                    txtSolucao.Text = ticket.Solution;

                                }
                                else
                                {
                                    MessageBox.Show("Ticket não encontrado.");
                                }
                            }
                            else
                            {
                                string msg = await response.Content.ReadAsStringAsync();
                                MessageBox.Show($"Erro ao buscar ticket: {msg}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro interno: {ex.Message}");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtID.Visible = false;
            lblId.Visible = false;
            btnEditar.Visible = false;
            btnRegister.Visible = true;
            txtPassword.Visible = true;
            txtConfirmPassword.Visible = true;
            lblConfirmPassword.Visible = true;
            lblPassword.Visible = true;
            btnCancel.Visible = false;
            txtName.Clear();
            txtUser.Clear();
            cboPerfis.SelectedIndex = -1;
            txtEmail.Clear();
        }

        private void tbpCausasRaiz_Click(object sender, EventArgs e)
        {

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            


        }
    }
}

    

