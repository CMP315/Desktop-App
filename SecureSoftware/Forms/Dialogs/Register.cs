using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
using SecureSoftware.Components;
using System.Text;
using System.Text.Json;

namespace SecureSoftware.Forms
{
    public partial class Register : Form
    {
        private MasterAccount? UserAccount;
        public Register()
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public MasterAccount? User
        {
            get { return this.UserAccount; }
        }

        private async void RegisterButton_ClickAsync(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(NameInputBox.Text) || string.IsNullOrWhiteSpace(EMailInputBox.Text) || string.IsNullOrWhiteSpace(PasswordInputBox.Text)) {
                MessageBox.Show("One of the input boxes has an invalid value. Ensure all required values are present.", "Invalid Form Details");
                return;
            }
            
            RegisterButton.Enabled = false;
            CancelButton.Enabled = false;
            string apiUrl = $"{Globals.API_BASE_URL}/users";
            var requestBody = new
            {
                name = NameInputBox.Text,
                email = EMailInputBox.Text,
                password = PasswordInputBox.Text,
                image = "https://i.imgur.com/dESNvHe.png"
            };

            if(!IsValidEmail(EMailInputBox.Text))
            {
                MessageBox.Show("This is not a valid EMail address.");
                RegisterButton.Enabled = true;
                CancelButton.Enabled = true;
                return;
            };

            var jsonRequestBody = JsonSerializer.Serialize(requestBody);
            using var httpClient = new HttpClient();
            try
            {
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    LoginRequest? request = BsonSerializer.Deserialize<LoginRequest>(jsonString);
                    if (request.user is null)
                    {
                        return;
                    }
                    httpClient.DefaultRequestHeaders.Add("Authorization", request.jwt);
                    request.user.JWT = request.jwt;
                    this.UserAccount = request.user;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                RegisterButton.Enabled = true;
                CancelButton.Enabled = true;
            }
        }

        static bool IsValidEmail(string email)
        {
            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');

            return atIndex > 0 && dotIndex > atIndex;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordInputBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }
    }
}
