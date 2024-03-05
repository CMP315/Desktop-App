using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SecureSoftware.Components
{
    public partial class CustomMaximiseButton : UserControl
    {
        private FontAwesome.Sharp.IconChar Icon;
        private PasswordVault Vault;
        public CustomMaximiseButton(PasswordVault Vault)
        {
            InitializeComponent();
            this.Vault = Vault;
            this.Icon = FontAwesome.Sharp.IconChar.Maximize;
            IconButton.IconChar = Icon;
        }

        private void IconButton_Click(object sender, EventArgs e)
        {
            if(this.Icon == FontAwesome.Sharp.IconChar.Maximize)
            {
                this.Vault.WindowState = FormWindowState.Maximized;
                this.Icon = FontAwesome.Sharp.IconChar.Minimize;
            }
            else
            {
                this.Vault.WindowState = FormWindowState.Normal;
                this.Icon = FontAwesome.Sharp.IconChar.Maximize;
            }
            IconButton.IconChar = this.Icon;
        }
    }
}
