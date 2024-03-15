using SecureSoftware.Classes;
using SecureSoftware.Forms.Password_Generator;
using System.ComponentModel;

namespace SecureSoftware.Components
{
    public enum VaultItemType
    {
        PasswordVault,
        SecureNotes,
        GeneratePassword,
        Settings
    }

    public partial class SideBarMenuItem : UserControl
    {
        private readonly new Panel Parent;
        private readonly MasterAccount User;
        private readonly PasswordVault Vault;
        private readonly MasterAccountUserComponent AccountInfo;

        public SideBarMenuItem(Panel panel, MasterAccount user, MasterAccountUserComponent accountInfo)
        {
            this.Parent = panel;
            this.User = user;
            this.AccountInfo = accountInfo;
            InitializeComponent();
            this.MouseClick += SideBarMenuItem_MouseClick;
        }

        #region Properties 
        private VaultItemType _ID;
        private string _label;
        private FontAwesome.Sharp.IconChar _icon;
        private Color _backgroundColor;
        private Color _backgroundColorHover;


        [Category("Custom Props")]
        public VaultItemType ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        [Category("Custom Props")]
        public string Label
        {
            get { return _label; }
            set { _label = value; SideBarLabel.Text = value; }
        }

        [Category("Custom Props")]
        public FontAwesome.Sharp.IconChar Icon
        {
            get { return _icon; }
            set { _icon = value; SideBarIcon.IconChar = value; }
        }

        [Category("Custom Props")]

        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; this.BackColor = value; }
        }

        [Category("Custom Props")]
        public Color BackgroundColorHover
        {
            get { return _backgroundColorHover; }
            set { _backgroundColorHover = value; }
        }
        #endregion

        private void SideBarMenuItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = this.BackgroundColorHover;
        }

        private void SideBarMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.BackgroundColor;
        }
        private void SideBarMenuItem_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = this.BackgroundColor;
            switch(_ID)
            {
                case VaultItemType.PasswordVault:
                    if (!Parent.IsDisposed && Parent.Controls.Count > 0)
                    {
                        Parent.Controls.Clear();
                    }
                    PasswordVaultPage passwordVaultPage = new(User, Vault);
                    Parent.Controls.Add(passwordVaultPage);
                    passwordVaultPage.Dock = DockStyle.Fill;
                    break;
                case VaultItemType.GeneratePassword:
                    SelectType selectType = new();
                    selectType.ShowDialog();
                    selectType.Dispose();
                    break;
                case VaultItemType.SecureNotes:
                    if (!Parent.IsDisposed && Parent.Controls.Count > 0)
                    {
                        Parent.Controls.Clear();
                    }
                    SecureNotePage secureNotesPage = new(User, Vault);
                    Parent.Controls.Add(secureNotesPage);
                    secureNotesPage.Dock = DockStyle.Fill;
                    break;
                case VaultItemType.Settings:
                    if (!Parent.IsDisposed && Parent.Controls.Count > 0)
                    {
                        Parent.Controls.Clear();
                    }
                    UserSettings settingsPage = new(User, Parent);
                    Parent.Controls.Add(settingsPage);
                    settingsPage.Dock = DockStyle.Fill;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void SideBarMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = this.BackgroundColorHover;
        }
    }
}
