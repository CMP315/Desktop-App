using SecureSoftware.Classes;
using System.Windows.Input;

namespace SecureSoftware.Forms
{
    public partial class DeleteAccountConfirmation : Form
    {
        private readonly MasterAccount User;
        public DeleteAccountConfirmation(MasterAccount user)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.User = user;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        async private void ConfirmDelete_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{Globals.API_BASE_URL}/users/{this.User._id}";
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", this.User.JWT);
            try
            {
                var response = await httpClient.DeleteAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        Environment.Exit(0);
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
