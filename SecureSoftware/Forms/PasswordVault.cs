using Microsoft.VisualBasic;
using SecureSoftware.Classes;
using SecureSoftware.Components;
using System.Drawing.Text;

namespace SecureSoftware
{
    public partial class PasswordVault : Form
    {

        readonly MasterAccount User = new("65df9bdab07bae1fe1adfec4", "TestUser123", "$2b$12$Hqutbzot.cElHf3MQdNiP.5a7naCEYAb5h8oPEBSP1ygU2pP28xeC", "abc@test.com", "b'$2b$12$Hqutbzot.cElHf3MQdNiP.'", "2024-02-28T20:47:22.918+00:00");
        public PasswordVault()
        {
            InitializeComponent();
            CreatePanels();
            //this.Width = 1400;
            //this.Height = 900;

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.MaximizeBox = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginDetail.Text = ("Logged in As : " + User.name);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        async private void CreatePanels()
        {
            UserAccount[]? accounts = await User.GetAccountsAsync();
            if (accounts is not null)
            {
                foreach (var account in accounts)
                {
                    UserAccountListItem panel = new(MainPanel, User._id)
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

        private void sideBarMenuItem2_Load(object sender, EventArgs e)
        {

        }

        private void sideBarMenuItem1_Load(object sender, EventArgs e)
        {

        }
    }
}
