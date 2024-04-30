using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
using SecureSoftware.Components;
using System.Text;
using System.Text.Json;
using System.Windows.Input;

namespace SecureSoftware.Forms
{
    public partial class CreateNote : Form
    {
        private readonly MasterAccount User;
        private readonly SecureNotePage SecureNote;
        private readonly Panel Panel;
        public CreateNote(MasterAccount user, PasswordVault vault, Panel panel, SecureNotePage secureNote)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.User = user;
            this.SecureNote = secureNote;
            this.Panel = panel;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        async private void CreateButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(NameInput.Text) || string.IsNullOrEmpty(ContentInput.Text))
            {
                MessageBox.Show("The Name and Content should both have some content. They are both required fields.", "Invalid Form Data");
                return;
            }

            string apiUrl = $"{Globals.API_BASE_URL}/notes/{this.User._id}";
            var requestBody = new
            {
                name = NameInput.Text,
                note = ContentInput.Text
            };

            var jsonRequestBody = JsonSerializer.Serialize(requestBody);
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", this.User.JWT);
            try
            {
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    try
                    {
                        Note? note = BsonSerializer.Deserialize<Note>(jsonString);
                        if (note is null)
                        {
                            return;
                        }

                        SecureNoteListItem panel = new(Panel, note, User, SecureNote)
                        {
                            ID = note._id,
                            Number = Panel.Controls.Count + 1,
                            NameProp = NameInput.Text,
                            CreatedAtProp = note.created_at,
                        };

                        Panel.Controls.Add(panel);
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
    }
}
