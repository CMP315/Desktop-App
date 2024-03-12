using SecureSoftware.Forms.Password_Generator;
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
    public enum VaultItemType
    {
        PasswordVault,
        SecureNotes,
        GeneratePassword
    }

    public partial class SideBarMenuItem : UserControl
    {
        public SideBarMenuItem()
        {
            InitializeComponent();
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
                    Console.WriteLine("");
                    break;
                case VaultItemType.GeneratePassword:
                    SelectType selectType = new();
                    selectType.ShowDialog();
                    selectType.Dispose();
                    break;
                case VaultItemType.SecureNotes:
                    Console.WriteLine("");
                    break;
            }

        }

        private void SideBarMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = this.BackgroundColorHover;
        }
    }
}
