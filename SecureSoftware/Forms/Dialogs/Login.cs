using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
using System.Text;
using System.Text.Json;
using System.Windows.Input;

namespace SecureSoftware.Forms
{
    public partial class Login : Form
    {
        private MasterAccount? UserAccount;
        public Login()
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public MasterAccount? User
        {
            get { return this.UserAccount; }
        }

        private async void LoginButton_ClickAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameBox.Text) || string.IsNullOrWhiteSpace(PasswordInputBox.Text))
            {
                MessageBox.Show("One of the input boxes has an invalid value. Ensure all required values are present.", "Invalid Form Details");
                return;
            }
            LoginButton.Enabled = false;
            CancelButton.Enabled = false;
            string apiUrl = $"{Globals.API_BASE_URL}/login";
            var requestBody = new
            {
                email = UsernameBox.Text,
                password = PasswordInputBox.Text
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
                    try
                    {
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
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
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
                LoginButton.Enabled = true;
                CancelButton.Enabled = true;
            }
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
