using Microsoft.VisualBasic.ApplicationServices;
using SecureSoftware.Classes;
using SecureSoftware.Forms;
using SecureSoftware.Forms.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SecureSoftware.Components
{
    public partial class SecureNoteListItem : UserControl
    {
        private readonly Panel MainPanel;
        private readonly MasterAccount MasterAccount;
        private readonly Note Note;
        private readonly SecureNotePage Page;
        public SecureNoteListItem(Panel MainPanel, Note note, MasterAccount masterAccount, SecureNotePage page)
        {
            InitializeComponent();
            this.MainPanel = MainPanel;
            this.Width = MainPanel.Width - 40;
            this.Note = note;
            this.MasterAccount = masterAccount;
            this.Page = page;
        }

        #region Properties 
        private string? _id;
        private int? _number;
        private string? _name;
        private string? _createdAt;
        private string? _lastEditedAt;

        [Category("Custom Props")]
        public string? ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public int? Number
        {
            get { return _number; }
            set
            {
                _number = value;
                if (_number.HasValue)
                {
                    NumberLabel.Text = value.ToString();
                }
                else
                {
                    NumberLabel.Text = "";
                }
            }
        }

        [Category("Custom Props")]
        public string? NameProp
        {
            get { return _name; }
            set { _name = value; NameLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string? CreatedAtProp
        {
            get { return _createdAt; }
            set { _createdAt = value; CreatedAtLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string? LastEditedAtProp
        {
            get { return _lastEditedAt; }
            set { _lastEditedAt = value; LastEditedLabel.Text = value; LastEditedLabel.Visible = true; LastEditedTitleLabel.Visible = true; }
        }
        #endregion

        private void ViewNoteButton_Click(object sender, EventArgs e)
        {
            ViewNote viewNote = new(Note);
            viewNote.ShowDialog();
            return;
        }

        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EditNote editNote = new(Note, MasterAccount, MainPanel, Page);
            editNote.ShowDialog();
            return;
        }

        async private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            bool isDeleted = await Note.Delete();
            if (isDeleted)
            {
                this.Dispose();
            }
        }
    }
}
