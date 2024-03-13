using Microsoft.VisualBasic.ApplicationServices;
using SecureSoftware.Classes;
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
    public partial class SecureNotePage : UserControl
    {
        private readonly MasterAccount User;
        private readonly PasswordVault Vault;
        public SecureNotePage(MasterAccount User, PasswordVault Vault)
        {
            InitializeComponent();
            this.User = User;
            this.Vault = Vault;
            _ = this.CreatePanels();
        }

        async public Task CreatePanels()
        {
            Note[]? notes = await User.GetNotesAsync();
            if (notes is not null)
            {
                MainPanel.Controls.Clear();
                int i = 1;
                foreach (var note in notes)
                {
                    SecureNoteListItem panel = new(MainPanel)
                    {
                        ID = note._id,
                        NameProp = note.name,
                        CreatedAtProp = note.created_at,
                        Number = i
                    };
                    MainPanel.Controls.Add(panel);
                    i++;
                }
                SetActionRowEnabled(true);
            }
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
