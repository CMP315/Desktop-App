using SecureSoftware.Classes;

namespace SecureSoftware.Forms.Dialogs
{
    public partial class ViewNote : Form
    {
        private readonly Note Note;
        public ViewNote(Note note)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.Note = note;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void CopyUsernameButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NameInput.Text);
        }

        private void CopyContentButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ContentInput.Text);
        }

        private void CopyCreatedAtButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CreatedAtInput.Text);
        }

        private void CopyLastEditedAtButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LastEditedAtInput.Text);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void ViewNote_Load(object sender, EventArgs e)
        {
            Note? note = await Note.Get()!;
            if (note is not null)
            {
                CopyUsernameButton.Enabled = true;
                CopyContentButton.Enabled = true;
                CopyCreatedAtButton.Enabled = true;
                CopyLastEditedAtButton.Enabled = true;

                NameInput.Text = note.name;
                ContentInput.Text = note.note;
                CreatedAtInput.Text = note.created_at;
                if (note.last_edited_at is not null)
                {
                    LastEditedAtInput.Text = note.last_edited_at;
                }
            }
        }

    }
}
