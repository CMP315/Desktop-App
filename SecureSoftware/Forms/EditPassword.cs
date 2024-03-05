using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
using SecureSoftware.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureSoftware.Forms
{
    public partial class EditPassword : Form
    {
        private readonly PasswordVault Vault;
        private readonly FlowLayoutPanel MainPanel;
        private readonly UserAccount User;

        public EditPassword(UserAccount User, PasswordVault Vault, FlowLayoutPanel MainPanel)
        {
            InitializeComponent();
            this.User = User;
            this.Vault = Vault;
            this.MainPanel = MainPanel;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        async private void SaveButton_Click(object sender, EventArgs e)
        {
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

                        this.MainPanel.Controls.Clear();
                        this.MainPanel.Controls.Add(new ProgressPanel());
                        this.Vault.CreatePanels();
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

        async private void EditPassword_Load(object sender, EventArgs e)
        {
            UserAccount? Account = await this.User.Get()!;
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
    }
}
