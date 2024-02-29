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
        private string _id;

        [Category("Custom Props")]
        public string AccountNameProp
        {
            get { return _name; }
            set { _name = value; AccountName.Text = value; }
        }

        [Category("Custom Props")]
        public string IDProp
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]

        public string AccountEmailProp
        {
            get { return _email; }
            set { _email = value; AccountEmail.Text = value; }
        }
        #endregion


        private void ViewPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CaaCaa",_id);

        }

        private void AccountName_Click(object sender, EventArgs e)
        {

        }
    }
}