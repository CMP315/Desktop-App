using SecureSoftware.Classes;
using SecureSoftware.Forms;
using SecureSoftware.Forms.Dialogs;

namespace SecureSoftware.Components
{
    public partial class SecureNotePage : UserControl
    {
        private readonly MasterAccount User;
        private readonly PasswordVault Vault;
        public SecureNotePage(MasterAccount User, PasswordVault Vault)
        {
            InitializeComponent();
            this.User = User;
            this.Vault = Vault;
            _ = this.CreatePanels();
        }

        async public Task CreatePanels()
        {
            Note[]? notes = await User.GetNotesAsync(this.User.JWT);
            if (notes is not null)
            {
                MainPanel.Controls.Clear();
                int i = 1;
                foreach (var note in notes)
                {
                    SecureNoteListItem panel = new(MainPanel, note, User, this)
                    {
                        ID = note._id,
                        NameProp = note.name,
                        CreatedAtProp = note.created_at,
                        Number = i
                    };
                    MainPanel.Controls.Add(panel);
                    i++;
                }
                SetActionRowEnabled(true);
            }
        }

        private void SecureNotePage_Resize(object sender, EventArgs e)
        {
            foreach (Control control in MainPanel.Controls)
            {
                control.Width = (MainPanel.Width - 40);
            }
        }

        public bool SetActionRowEnabled(bool enabled)
        {
            foreach (var control in SecureActionRowLayoutPanel.Controls)
            {
                Button button = (Button)control;
                button.Enabled = enabled;
            }
            return enabled;
        }

        async private void CreateNoteButton_Click(object sender, EventArgs e)
        {
            SetActionRowEnabled(false);
            CreateNote CreateNoteForm = new(User, Vault, MainPanel, this);
            CreateNoteForm.ShowDialog();
            SetActionRowEnabled(true);
        }

        async private void RefreshNotesButton_Click(object sender, EventArgs e)
        {
            SetActionRowEnabled(false);
            MainPanel.Controls.Clear();
            ProgressPanel progress = new();
            progress.LabelProp = "Loading Secure Notes...";
            MainPanel.Controls.Add(progress);
            await CreatePanels();
            SetActionRowEnabled(true);
        }

        async private void DeleteNotesButton_Click(object sender, EventArgs e)
        {
            SetActionRowEnabled(false);

            PromptDeletion confirmationForm = new("Are you sure you want to delete all of your Secure Notes?", "Yes, delete all of them!", "No, keep them!");
            DialogResult results = confirmationForm.ShowDialog();
            if (results == DialogResult.OK)
            {
                bool isDeleted = await User.DeleteNotesAsync(this.User.JWT);
                if (isDeleted)
                {
                    MainPanel.Controls.Clear();
                }
            }
            else
            {
                confirmationForm.Dispose();
            }
            SetActionRowEnabled(true);
        }
    }
}
