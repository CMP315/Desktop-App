namespace SecureSoftware.Forms
{
    public partial class LoginOrRegister : Form
    {
        public string? Selected;
        public LoginOrRegister()
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Selected = "Login";
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Selected = "Register";
            this.Close();
        }

        private void LoginOrRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.ApplicationExitCall)
            {
                Environment.Exit(0);
            }
        }
    }
}
