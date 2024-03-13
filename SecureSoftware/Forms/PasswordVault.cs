using MongoDB.Bson.Serialization;
using SecureSoftware.Classes;
using SecureSoftware.Components;
using System.Text.Json;
using System.Text;
using SecureSoftware.Forms;
using System.Net.Http.Headers;

namespace SecureSoftware
{
    public partial class PasswordVault : Form
    {
        public FlowLayoutPanel Panel;
        private readonly MasterAccount User;
        public PasswordVault(MasterAccount user)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.Panel = MainPanel;
            this.User = user;
            CreatePanels();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void PasswordVault_Load(object sender, EventArgs e)
        {
            GlobalUsername.Text = User.name;
            GlobalEmail.Text = User.email;
            ContextMenuButtonsTable.Controls.Add(new CustomMaximiseButton(this), 1, 0);
        }

        private void PasswordVault_Resize(object sender, EventArgs e)
        {
            foreach (Control control in MainPanel.Controls)
            {
                control.Width = (MainPanel.Width - 40);
            }
        }

        async public Task CreatePanels()
        {
            UserAccount[]? accounts = await User.GetAccountsAsync();
            if (accounts is not null)
            {
                MainPanel.Controls.Clear();
                foreach (var account in accounts)
                {
                    UserAccountListItem panel = new(MainPanel, account, this)
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

        private void CreatePasswordButton_Click(object sender, EventArgs e)
        {
            SetActionRowEnabled(false);
            CreatePassword CreatePasswordForm = new(User, this);
            CreatePasswordForm.ShowDialog();
            SetActionRowEnabled(true);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}