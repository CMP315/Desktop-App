using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
using SecureSoftware.Components;
using SecureSoftware.Forms.Password_Generator;
using System.Text;
using System.Text.Json;

namespace SecureSoftware.Forms
{
    public partial class CreatePassword : Form
    {
        private readonly MasterAccount User;
        private readonly PasswordVault Vault;
        private readonly Panel MainPanel;
        public CreatePassword(MasterAccount user, PasswordVault vault, Panel panel)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.User = user;
            this.Vault = vault;
            this.MainPanel = panel;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        async private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateButton.Enabled = false;
            CancelButton.Enabled = false;
            string apiUrl = $"{Globals.API_BASE_URL}/passwords/{this.User._id}";
            var requestBody = new
            {
                username = NameInput.Text,
                password = PasswordInput.Text,
                site_name = SiteNameInput.Text,
                notes = NotesInput.Text
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
                        UserAccount? account = BsonSerializer.Deserialize<UserAccount>(jsonString);
                        if (account is null)
                        {
                            return;
                        }

                        UserAccountListItem panel = new(MainPanel, account, Vault)
                        {
                            ID = account._id,
                            SiteNameProp = account.site_name,
                            UsernameProp = account.username,
                            IDLabelProp = (MainPanel.Controls.Count + 1).ToString()
                        };

                        MainPanel.Controls.Add(panel);
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
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Random random = new();
            int size = random.Next(50, 59);

            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }

            PasswordInput.Text = new string(chars);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
