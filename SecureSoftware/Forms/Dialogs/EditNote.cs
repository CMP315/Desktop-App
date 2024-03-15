using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
using SecureSoftware.Components;
using System.Text;
using System.Text.Json;

namespace SecureSoftware.Forms.Dialogs
{
    public partial class EditNote : Form
    {
        private readonly Note Note;
        private readonly Panel MainPanel;
        private readonly MasterAccount User;
        private readonly SecureNotePage Page;
        public EditNote(Note note, MasterAccount user, Panel MainPanel, SecureNotePage page)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.Note = note;
            this.User = user;
            this.MainPanel = MainPanel;
            this.Page = page;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        async private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateButton.Enabled = false;
            CancelButton.Enabled = false;
            string apiUrl = $"{Globals.API_BASE_URL}/notes/{this.User._id}/{this.Note._id}";
            var requestBody = new
            {
                name = NameInput.Text,
                note = ContentInput.Text
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
                        Note? note = BsonSerializer.Deserialize<Note>(jsonString);
                        if (note is null)
                        {
                            return;
                        }
                        this.Close();
                        this.MainPanel.Controls.Clear();
                        ProgressPanel progress = new()
                        {
                            LabelProp = "Loading Secure Notes..."
                        };
                        this.MainPanel.Controls.Add(progress);
                        await Page.CreatePanels();
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
                //this.Vault.SetActionRowEnabled(true);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void EditNote_Load(object sender, EventArgs e)
        {
            Note? note = await Note.Get()!;
            if(note is not null)
            {
                NameInput.Text = note.name;
                NameInput.Enabled = true;

                ContentInput.Text = note.note;
                ContentInput.Enabled = true;
            }
        }
    }
}
