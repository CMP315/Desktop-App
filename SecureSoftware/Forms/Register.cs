using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
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
using static System.Windows.Forms.DataFormats;

namespace SecureSoftware.Forms
{
    public partial class Register : Form
    {
        public MasterAccount? user;
        public Register()
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
        }

        private async void RegisterButton_ClickAsync(object sender, EventArgs e)
        {
            RegisterButton.Enabled = false;
            CancelButton.Enabled = false;
            string apiUrl = $"{Globals.API_BASE_URL}/users";
            var requestBody = new
            {
                name = NameInputBox.Text,
                email = EMailInputBox.Text,
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
                        MessageBox.Show(jsonString);
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
                RegisterButton.Enabled = true;
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
