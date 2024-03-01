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

namespace SecureSoftware.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void LoginButton_ClickAsync(object sender, EventArgs e)
        {
            
            string apiUrl = $"{Globals.API_BASE_URL}/login";
            var requestBody = new
            {
               email = UsernameBox.Text,
               password = PasswordBox.Text
        };

            var jsonRequestBody = JsonSerializer.Serialize(requestBody);
            MessageBox.Show(jsonRequestBody.ToString());
            using var httpClient = new HttpClient();
            try
            {
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(apiUrl, content);
                MessageBox.Show(await response.Content.ReadAsStringAsync());
                if (response.IsSuccessStatusCode)
                {


                    string jsonString = await response.Content.ReadAsStringAsync();
                    try
                    {
                        MessageBox.Show(jsonString + response);
                        //turns from json into class
                        MasterAccount[]? jsonObject = JsonSerializer.Deserialize<MasterAccount[]>(jsonString);
                        if (jsonObject is null)
                        {
                            return;
                        }
                        MessageBox.Show(jsonString + response);
                        PasswordVault VaultPage = new PasswordVault();
                        VaultPage.Show();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    Console.WriteLine(await response.Content.ReadAsStringAsync());
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
}
