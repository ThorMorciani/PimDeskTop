using IAssist;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace WinFormsApp1
{

    public partial class TelaLogin : Form
    {
        private string _baseUrl = "https://localhost:7158/";  
        private string _accessToken = "";
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

                HttpResponseMessage response = await client.PostAsync("login/login", content);
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
        private bool NivelDeAcesso(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadJwtToken(token);
            var roles = jsonToken?.Claims
                .Where(c => c.Type == ClaimTypes.Role)
                .Select(c => c.Value)
                .ToList();

            return roles != null && roles.Contains("Admin") || roles.Contains("Gerente");
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
            var username = txtlogin.Text;
            var password = txtPassword.Text;

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

                if (NivelDeAcesso(_accessToken))
                {
                    MessageBox.Show("Login realizado! Token recebido.");
                    TelaInicial telaInicial = new TelaInicial();
                    telaInicial.Show();
                }
                else
                {
                    MessageBox.Show("acesso insuficiente");
                }
            }
            else
            {
                MessageBox.Show("Falha no login. Verifique usuário e senha.");
            }
        }

        




        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
