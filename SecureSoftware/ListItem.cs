using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureSoftware
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties 
        private string _name;
        private string _email;

        [Category("Custom Props")]
        public string AccountNameProp
        {
            get { return _name; }
            set { _name = value; AccountName.Text = value; }
        }

        [Category("Custom Props")]

        public string AccountEmailProp
        {
            get { return _email; }
            set { _email = value; AccountEmail.Text = value; }
        }
        #endregion

        private void ListItem_Load(object sender, EventArgs e)
        {

        }
    }
}