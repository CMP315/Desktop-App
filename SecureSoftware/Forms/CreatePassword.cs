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
    public partial class CreatePassword : Form
    {
        private readonly MasterAccount User;
        private readonly PasswordVault Vault;
        private string? UserPassword;
        public CreatePassword(MasterAccount user, PasswordVault vault)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.User = user;
            this.Vault = vault;
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

                        UserAccountListItem panel = new(Vault.Panel, account, Vault)
                        {
                            ID = account._id,
                            SiteNameProp = account.site_name,
                            UsernameProp = account.username,
                            IconProp = FontAwesome.Sharp.IconChar.Github
                        };

                        Vault.Panel.Controls.Add(panel);
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

        private void GenerateSecurePassword_CheckedChanged(object sender, EventArgs e)
        {
            if(this.GenerateSecurePassword.Checked)
            {
                string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
                Random random = new();
                int size = random.Next(50, 59);

                char[] chars = new char[size];
                for (int i = 0; i < size; i++)
                {
                    chars[i] = validChars[random.Next(0, validChars.Length)];
                }

                UserPassword = PasswordInput.Text;
                PasswordInput.Text = new string(chars);
            } else
            {
                PasswordInput.Text = UserPassword;
            }
        }
    }
}
