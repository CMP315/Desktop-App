using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
using System.Text;
using System.Text.Json;

namespace SecureSoftware.Forms
{
    public partial class Login : Form
    {
        public MasterAccount? user;
        public Login()
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private async void LoginButton_ClickAsync(object sender, EventArgs e)
        {
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
                        MasterAccount? user = BsonSerializer.Deserialize<MasterAccount>(jsonString);
                        if (user is null)
                        {
                            return;
                        }
                        this.user = user;
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
