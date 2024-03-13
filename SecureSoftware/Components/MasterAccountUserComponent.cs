using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
