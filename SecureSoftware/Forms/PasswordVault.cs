using SecureSoftware.Classes;
using SecureSoftware.Components;

namespace SecureSoftware
{
    public partial class PasswordVault : Form
    {
        public Panel Panel;
        private readonly MasterAccount User;
        private Point PreviousLocation;
        private MasterAccountUserComponent AccountInfo;

        public PasswordVault(MasterAccount user)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.Panel = PagePanel;
            this.User = user;
            this.AccountInfo = new()
            {
                ID = User._id,
                Username = User.name,
                Email = User.email,
                Parent = EmptyBar
            };
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void PasswordVault_Load(object sender, EventArgs e)
        {
            ContextMenuButtonsTable.Controls.Add(new CustomMaximiseButton(this), 1, 0);

            Color backColour = Color.FromArgb(100, 48, 122);
            Color backColourHover = Color.FromArgb(155, 89, 182);

            SideBarMenuItem item1 = new(PagePanel, User, AccountInfo)
            {
                Label = "Password Vault",
                BackColor = backColour,
                BackgroundColor = backColour,
                BackgroundColorHover = backColourHover,
                ID = VaultItemType.PasswordVault,
                Icon = FontAwesome.Sharp.IconChar.Vault
            };
            NavbarPanel.Controls.Add(item1);

            SideBarMenuItem item2 = new(PagePanel, User, AccountInfo)
            {
                Label = "Secure Notes",
                BackColor = backColour,
                BackgroundColor = backColour,
                BackgroundColorHover = backColourHover,
                ID = VaultItemType.SecureNotes,
                Icon = FontAwesome.Sharp.IconChar.Newspaper
            };
            NavbarPanel.Controls.Add(item2);

            SideBarMenuItem item3 = new(PagePanel, User, AccountInfo)
            {
                Label = "User Settings",
                BackColor = backColour,
                BackgroundColor = backColour,
                BackgroundColorHover = backColourHover,
                ID = VaultItemType.Settings,
                Icon = FontAwesome.Sharp.IconChar.Link
            };
            NavbarPanel.Controls.Add(item3);

            SideBarMenuItem item4 = new(PagePanel, User, AccountInfo)
            {
                Label = "Generate Password",
                BackColor = backColour,
                BackgroundColor = backColour,
                BackgroundColorHover = backColourHover,
                ID = VaultItemType.GeneratePassword,
                Icon = FontAwesome.Sharp.IconChar.Cog
            };
            NavbarPanel.Controls.Add(item4);

            PasswordVaultPage passwordVaultPage = new(User, this);
            PagePanel.Controls.Add(passwordVaultPage);
            passwordVaultPage.Dock = DockStyle.Fill;
        }
        private void PasswordVault_Resize(object sender, EventArgs e)
        {
            foreach (Control control in PagePanel.Controls)
            {
                control.Width = (PagePanel.Width - 40);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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