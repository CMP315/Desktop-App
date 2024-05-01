using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
using System.Text;
using System.Text.Json;

namespace SecureSoftware.Forms
{
    public partial class VerifyPassword : Form
    {
        private readonly MasterAccount User;
        private new readonly Form ParentForm;
        public VerifyPassword(MasterAccount user, Form parent)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.User = user;
            this.ParentForm = parent;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        async private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(CurrentPasswordInput.Text) || string.IsNullOrEmpty(NewPasswordInput.Text))
            {
                MessageBox.Show("The current and new password are required to change the password. Please check your inputs and try again.");
                return;
            }

            string apiUrl = $"{Globals.API_BASE_URL}/login";
            var requestBody = new
            {
                User.email,
                password = CurrentPasswordInput.Text
            };

            var jsonRequestBody = JsonSerializer.Serialize(requestBody);
            using var httpClient = new HttpClient();
            try
            {
                ConfirmButton.Enabled = false;
                CancelButton.Enabled = false;
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
                        string apiUrl2 = $"{Globals.API_BASE_URL}/users/{this.User._id}";
                        var requestBody2 = new
                        {
                            password = NewPasswordInput.Text
                        };
                        var jsonRequestBody2 = JsonSerializer.Serialize(requestBody2);

                        try
                        {
                            var content2 = new StringContent(jsonRequestBody2, Encoding.UTF8, "application/json");
                            var response2 = await httpClient.PatchAsync(apiUrl2, content2);
                            if (response2.IsSuccessStatusCode)
                            {
                                await response.Content.ReadAsStringAsync();
                                ParentForm.Close();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show($"Error: {response2.StatusCode}");
                                Console.WriteLine($"Error: {response2.StatusCode}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exception: {ex.Message}");
                        }
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
                ConfirmButton.Enabled = true;
                CancelButton.Enabled = true;
            }
    }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
