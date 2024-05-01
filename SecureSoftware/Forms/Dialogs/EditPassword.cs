using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
using SecureSoftware.Components;
using SecureSoftware.Forms.Password_Generator;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace SecureSoftware.Forms
{
    public partial class EditPassword : Form
    {
        private readonly Panel MainPanel;
        private readonly UserAccount User;
        private readonly string? UserPassword;
        private readonly string key;
        public EditPassword(UserAccount User, Panel MainPanel, string key)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.User = User;
            this.MainPanel = MainPanel;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.key = key;
        }


        async private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameInput.Text) || string.IsNullOrWhiteSpace(PasswordInput.Text) || string.IsNullOrWhiteSpace(SiteNameInput.Text))
            {
                MessageBox.Show("One of the input boxes has an invalid value. Ensure all required values are present.", "Invalid Form Details");
                return;
            }
            CreateButton.Enabled = false;
            CancelButton.Enabled = false;
            string apiUrl = $"{Globals.API_BASE_URL}/passwords/{this.User.user_id}/{this.User._id}";
            var requestBody = new
            {
                username = NameInput.Text,
                password = PasswordInput.Text,
                site_name = SiteNameInput.Text,
                notes = NotesInput.Text
            };

            var jsonRequestBody = JsonSerializer.Serialize(requestBody);
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", this.key);

            try
            {
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");
                var response = await httpClient.PatchAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    try
                    {
                        UserAccount? account = BsonSerializer.Deserialize<UserAccount>(jsonString);
                        if (account is null)
                        {
                            return;
                        }
                        this.Close();
                        this.MainPanel.Controls.Clear();
                        this.MainPanel.Controls.Add(new ProgressPanel());
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
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void EditPassword_Load(object sender, EventArgs e)
        {
            UserAccount? Account = await this.User.Get(this.key)!;
            if (Account is not null)
            {
                NameInput.Text = Account.username;
                NameInput.PlaceholderText = "Enter the account Username or E-Mail";
                NameInput.Enabled = true;

                PasswordInput.Text = Account.password;
                PasswordInput.PlaceholderText = "Enter the Password";
                PasswordInput.Enabled = true;

                SiteNameInput.Text = Account.site_name;
                SiteNameInput.PlaceholderText = "Enter the Site Name";
                SiteNameInput.Enabled = true;

                NotesInput.Text = Account.notes;
                NotesInput.Enabled = true;
            }
        }   

        private void GeneratePassword_Click(object sender, EventArgs e)
        {
            SelectType selectType = new();
            selectType.ShowDialog();
            selectType.Dispose();
        }

        private void QuickGenPassword_Click(object sender, EventArgs e)
        {
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            using RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] sizeBytes = new byte[4];
            rng.GetBytes(sizeBytes);
            int size = Math.Abs(BitConverter.ToInt32(sizeBytes, 0)) % 10 + 50;

            char[] chars = new char[size];
            byte[] bytes = new byte[1];
            for (int i = 0; i < size; i++)
            {
                rng.GetBytes(bytes);
                chars[i] = validChars[bytes[0] % validChars.Length];
            }

            PasswordInput.Text = new string(chars);
        }
    }
}
