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
            ContextMenuButtonsTable.Controls.Add(new CustomMaximiseButton(this), 0, 0);
        }

        private void PasswordVault_Resize(object sender, EventArgs e)
        {
            foreach (Control control in MainPanel.Controls)
            {
                control.Width = (MainPanel.Width - 40);
            }
        }

        async public void CreatePanels()
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
            }
        }

        private void CreatePasswordButton_Click(object sender, EventArgs e)
        {
            CreatePassword CreatePasswordForm = new(User, this);
            CreatePasswordForm.ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshPasswordsButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ProgressPanel());
            CreatePanels();
        }
    }
}