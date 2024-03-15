using System.ComponentModel;

namespace SecureSoftware.Components
{
    public partial class MasterAccountUserComponent : UserControl
    {
        public MasterAccountUserComponent()
        {
            InitializeComponent();
        }

        #region Properties 
        private string _ID;
        private string _Username;
        private string _Email;

        async private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox1.LoadAsync(@"https://i.imgur.com/QFhLe2Q.png");
        }

        [Category("Custom Props")]
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        [Category("Custom Props")]
        public string Username
        {
            get { return _Username; }
            set { _Username = value; GlobalUsername.Text = value; }
        }

        [Category("Custom Props")]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; GlobalEmail.Text = value; }
        }

        #endregion
    }

}
