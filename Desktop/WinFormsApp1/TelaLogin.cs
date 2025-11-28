using IAssist;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace WinFormsApp1
{

    public partial class TelaLogin : Form
    {
        private string _baseUrl = "https://localhost:7158/";
        private string _accessToken = "";
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label lblLogin;
        private Label lblPassword;
        private Button btnLogar;
        private PictureBox pboxLogo;
        private string _refreshToken = "";

        private async Task<LoginResponse> FazerLoginAsync(LoginRequest request)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("Login", content);
                if (response.IsSuccessStatusCode)
                {
                    string responseJson = await response.Content.ReadAsStringAsync();
                    var loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseJson, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return loginResponse;
                }
                else
                {
                    string erro = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Erro ao logar: " + erro);
                    return null;
                }
            }
        }
        public Button ButtonLogar
        {
            get { return this.btnLogar; }
        }
        private bool NivelDeAcesso(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadJwtToken(token);
            var cargoUsuario = jsonToken?.Claims
                .Where(c => c.Type == ClaimTypes.Role)
                .Select(c => c.Value)
                .ToList();

            return cargoUsuario != null && cargoUsuario.Contains("Admin") || cargoUsuario.Contains("Gerente");
        }
        private bool AtivoOuInativo(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsoToken = handler.ReadJwtToken(token);
            var active = jsoToken?.Claims
                .Where(c => c.Type == ClaimTypes.Sid)
                .Select(c => c.Value)
                .ToList();
            return active.Contains("Ativo");
        }
        private List<string> PerfilId(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadJwtToken(token);
            var idUsuario = jsonToken?.Claims
               .Where(c => c.Type == ClaimTypes.NameIdentifier)
               .Select(c => c.Value)
               .ToList();
            return idUsuario;
        }
        private List<string> PerfilCargo(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadJwtToken(token);
            var cargoUsuario = jsonToken?.Claims
               .Where(c => c.Type == ClaimTypes.Role)
               .Select(c => c.Value)
               .ToList();
            return cargoUsuario;
        }
        private List<string> PerfilNome(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadJwtToken(token);
            var nomeUsuario = jsonToken?.Claims
                .Where(c => c.Type == ClaimTypes.GivenName)
                .Select(c => c.Value)
                .ToList();
            return nomeUsuario;
        }
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            lblLogin = new Label();
            lblPassword = new Label();
            btnLogar = new Button();
            pboxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(342, 265);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(170, 23);
            txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(342, 335);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(344, 235);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(344, 317);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(344, 385);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(168, 23);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // pboxLogo
            // 
            pboxLogo.Image = (Image)resources.GetObject("pboxLogo.Image");
            pboxLogo.Location = new Point(344, 94);
            pboxLogo.Name = "pboxLogo";
            pboxLogo.Size = new Size(168, 124);
            pboxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxLogo.TabIndex = 5;
            pboxLogo.TabStop = false;
            // 
            // TelaLogin
            // 
            ClientSize = new Size(913, 600);
            Controls.Add(pboxLogo);
            Controls.Add(btnLogar);
            Controls.Add(lblPassword);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Name = "TelaLogin";
            Load += TelaLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private async void btnLogar_Click(object sender, EventArgs e)
        {
            var username = txtLogin.Text;
            var password = txtPassword.Text;
            btnLogar.Enabled = false;

            var loginRequest = new LoginRequest
            {
                Username = username,
                Password = password
            };

            var loginResponse = await FazerLoginAsync(loginRequest);
            if (loginResponse != null)
            {

                _accessToken = loginResponse.AccessToken;
                _refreshToken = loginResponse.RefreshToken;

                if (NivelDeAcesso(_accessToken) && AtivoOuInativo(_accessToken))
                {
                    MessageBox.Show("Logado com sucesso!");
                    var nomeUsuarioAcesso = PerfilNome(_accessToken);
                    var cargoUsuarioAcesso = PerfilCargo(_accessToken);
                    var idUsuarioAcesso = PerfilId(_accessToken);
                    TelaInicial telaInicial = new TelaInicial(nomeUsuarioAcesso, cargoUsuarioAcesso, idUsuarioAcesso);
                    telaInicial.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Acesso insuficiente ou inativo.");
                    var handler = new JwtSecurityTokenHandler();
                    var jsonToken = handler.ReadJwtToken(_accessToken);
                    btnLogar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Falha no login. Verifique usuário e senha.");
                btnLogar.Enabled = true;
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
