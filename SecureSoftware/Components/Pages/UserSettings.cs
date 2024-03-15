using SecureSoftware.Classes;
using SecureSoftware.Forms;
using System.Text;
using System.Text.Json;
namespace SecureSoftware.Components
{
    public partial class UserSettings : UserControl
    {
        private readonly MasterAccount User;
        private readonly Panel MainPanel;

        public UserSettings(MasterAccount user, Panel panel)
        {
            InitializeComponent();
            this.User = user;
            this.MainPanel = panel;
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            UsernameInput.Text = User.name;
            UsernameInput.Enabled = true;

            EmailInput.Text = User.email;
            EmailInput.Enabled = true;
        }
        
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            VerifyPassword verifyPassword = new(User, this.ParentForm);
            verifyPassword.ShowDialog();
            verifyPassword.Dispose();
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccountConfirmation confirmation = new(User);
            confirmation.ShowDialog();
            confirmation.Dispose();
        }

        async private void Save_Click(object sender, EventArgs e)
        {
            string inputUsername = UsernameInput.Text;
            string inputEmail = EmailInput.Text;

            if(!(inputUsername.Equals(User.name) && inputEmail.Equals(User.email)))
            {
                string apiUrl = $"{Globals.API_BASE_URL}/users/{this.User._id}";
                var requestBody = new
                {
                    name = inputUsername,
                    email = inputEmail
                };
                User.name = inputUsername;
                User.email = inputEmail;
                var jsonRequestBody = JsonSerializer.Serialize(requestBody);
                using var httpClient = new HttpClient();
                try
                {
                    var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");
                    var response = await httpClient.PatchAsync(apiUrl, content);
                    if (response.IsSuccessStatusCode)
                    {
                        this.ParentForm.Close();
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
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
