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
    public partial class ViewPassword : Form
    {
        private readonly UserAccount User;
        public ViewPassword(UserAccount User)
        {
            this.User = User;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyUsernameButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NameInput.Text);
        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordInput.Text);
        }

        private void CopySiteNameButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SiteNameInput.Text);
        }

        private void CopyNotesButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NotesInput.Text);
        }
        private void CopyCreatedAtButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CreatedAtInput.Text);
        }

        private void CopyLastEditedAtButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LastEditedAtInput.Text);
        }

        async private void ViewPassword_Load(object sender, EventArgs e)
        {
            UserAccount? Account = await User.Get()!;
            if (Account is not null)
            {
                CopyUsernameButton.Enabled = true;
                CopyPasswordButton.Enabled = true;  
                CopySiteNameButton.Enabled = true;
                CopyNotesButton.Enabled = true;
                CopyCreatedAtButton.Enabled = true;
                CopyLastEditedAtButton.Enabled = true;

                NameInput.Text = Account.username;
                PasswordInput.Text = Account.password;
                SiteNameInput.Text = Account.site_name;
                NotesInput.Text = Account.notes;
                CreatedAtInput.Text = Account.created_at.ToString();
                if (Account.last_edited_at is not null)
                {
                    LastEditedAtInput.Text = Account.last_edited_at.ToString();
                }
            }

        }
    }
}
