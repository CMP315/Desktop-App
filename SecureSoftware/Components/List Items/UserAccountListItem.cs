using SecureSoftware.Classes;
using SecureSoftware.Forms;
using System.ComponentModel;


namespace SecureSoftware.Components
{
    public partial class UserAccountListItem : UserControl
    {
        private readonly UserAccount User;
        private readonly PasswordVault PasswordVault;
        private readonly Panel MainPanel;

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


        public UserAccountListItem(Panel MainPanel, UserAccount User, PasswordVault PasswordVault)
        {
            this.MainPanel = MainPanel;
            this.PasswordVault = PasswordVault;
            InitializeComponent();
            this.Width = MainPanel.Width - 40;
            this.User = User;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewPassword viewPassword = new(User);
            viewPassword.ShowDialog();
            return;
        }

        async private void DeleteButton_Click(object sender, EventArgs e)
        {
            bool isDeleted = await User.Delete();
            if (isDeleted)
            {
                this.Dispose();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditPassword editPassword = new(User, PasswordVault, MainPanel);
            editPassword.ShowDialog();
            return;
        }
    }
}
