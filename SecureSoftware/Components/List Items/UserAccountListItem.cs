using SecureSoftware.Classes;
using SecureSoftware.Forms;
using SecureSoftware.Forms.Dialogs;
using System.ComponentModel;


namespace SecureSoftware.Components
{
    public partial class UserAccountListItem : UserControl
    {
        private readonly UserAccount User;
        private readonly PasswordVault PasswordVault;
        private readonly Panel MainPanel;
        private readonly string jwt;

        #region Properties 
        private string? _id;
        private string? _IDLabel;
        private string? _site_name;
        private string? _username;

        [Category("Custom Props")]
        public string? ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public string? IDLabelProp
        {
            get { return _IDLabel; }
            set { _IDLabel = value; if (value is not null) {
                    NumberLabel.Text = _IDLabel;
                } else {
                    NumberLabel.Text = "";
                }
            }
        }

        [Category("Custom Props")]
        public string? SiteNameProp
        {
            get { return _site_name; }
            set { _site_name = value; SiteName.Text = value; }
        }

        [Category("Custom Props")]
        public string? UsernameProp
        {
            get { return _username; }
            set { _username = value; Username.Text = value; }
        }
        #endregion


        public UserAccountListItem(Panel MainPanel, UserAccount User, PasswordVault PasswordVault, string key)
        {
            this.MainPanel = MainPanel;
            this.PasswordVault = PasswordVault;
            InitializeComponent();
            this.Width = MainPanel.Width - 40;
            this.User = User;
            this.jwt = key;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewPassword viewPassword = new(User, this.jwt);
            viewPassword.ShowDialog();
            return;
        }

        async private void DeleteButton_Click(object sender, EventArgs e)
        {
            string SiteName = "[" + this.SiteNameProp + "] " + this.UsernameProp;
            PromptDeletion confirmationForm = new("Are you sure you want to delete this Password: " + SiteName, "Yes, delete it!", "No, keep it!");
            DialogResult results = confirmationForm.ShowDialog();
            if (results == DialogResult.OK)
            {
                bool isDeleted = await User.Delete(this.jwt);
                if (isDeleted)
                {
                    this.Dispose();
                }
            }
            else
            {
                confirmationForm.Dispose();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditPassword editPassword = new(User, MainPanel, this.jwt);
            editPassword.ShowDialog();
            return;
        }
    }
}
