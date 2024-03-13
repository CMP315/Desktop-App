using Microsoft.VisualBasic.ApplicationServices;
using SecureSoftware.Classes;
using SecureSoftware.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            UserAccount[]? accounts = await User.GetAccountsAsync();
            if (accounts is not null)
            {
                MainPanel.Controls.Clear();
                foreach (var account in accounts)
                {
                    UserAccountListItem panel = new(MainPanel, account, Vault)
                    {
                        ID = account._id,
                        SiteNameProp = account.site_name,
                        UsernameProp = account.username,
                        IconProp = FontAwesome.Sharp.IconChar.Github
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
            bool isDeleted = await User.DeleteAccountsAsync();
            if (isDeleted)
            {
                MainPanel.Controls.Clear();
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
