using SecureSoftware.Classes;
using SecureSoftware.Forms;
using SecureSoftware.Forms.Dialogs;

namespace SecureSoftware.Components
{
    public partial class PasswordVaultPage : UserControl
    {

        private readonly MasterAccount User;
        private readonly PasswordVault Vault;
        public PasswordVaultPage(MasterAccount user, PasswordVault vault)
        {
            InitializeComponent();
            this.User = user;
            this.Vault = vault;
            _ = this.CreatePanels();
        }

        async public Task CreatePanels()
        {
            UserAccount[]? accounts = await User.GetAccountsAsync(this.User.JWT);
            if (accounts is not null)
            {
                MainPanel.Controls.Clear();
                int i = 0;
                foreach (var account in accounts)
                {
                    i++;
                    UserAccountListItem panel = new(MainPanel, account, Vault, this.User.JWT)
                    {
                        ID = account._id,
                        SiteNameProp = account.site_name,
                        UsernameProp = account.username,
                        IDLabelProp = i.ToString()
                    };
                    MainPanel.Controls.Add(panel);
                }
                SetActionRowEnabled(true);
            }
        }
        private void PasswordVaultPage_Resize(object sender, EventArgs e)
        {
            foreach (Control control in MainPanel.Controls)
            {
                control.Width = (MainPanel.Width - 40);
            }
        }

        async private void CreatePasswordButton_Click(object sender, EventArgs e)
        {
            SetActionRowEnabled(false);
            CreatePassword CreatePasswordForm = new(User, Vault, MainPanel);
            CreatePasswordForm.ShowDialog();
            SetActionRowEnabled(true);

        }

        async private void RefreshPasswordsButton_Click(object sender, EventArgs e)
        {
            SetActionRowEnabled(false);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ProgressPanel());
            await CreatePanels();
            SetActionRowEnabled(true);
        }
        private async void DeletePasswordsButton_Click(object sender, EventArgs e)
        {
            SetActionRowEnabled(false);
            PromptDeletion confirmationForm = new("Are you sure you want to delete all of your passwords?", "Yes, all of them!", "No, keep them!");
            DialogResult results = confirmationForm.ShowDialog();
            if (results == DialogResult.OK)
            {
                bool isDeleted = await User.DeleteAccountsAsync(this.User.JWT);
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

        public bool SetActionRowEnabled(bool enabled)
        {
            foreach (var control in ActionRowLayoutPanel.Controls)
            {
                Button button = (Button)control;
                button.Enabled = enabled;
            }
            return enabled;
        }
    }
}
